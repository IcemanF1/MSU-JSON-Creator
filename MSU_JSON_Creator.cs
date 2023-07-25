using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace MSU_JSON_Creator
{
    public partial class MSU_JSON_Creator : Form
    {
        DataSet dsTracks = new DataSet("Tracks");
        string XMLPath = "";

        public MSU_JSON_Creator()
        {
            InitializeComponent();

            dgMSUTracks.CellEndEdit += new DataGridViewCellEventHandler(dataGridView_CellEndEdit);
            dgSubTracks.CellEndEdit += new DataGridViewCellEventHandler(dataGridView_CellEndEdit);
            dgMSUTracks.CellEnter += new DataGridViewCellEventHandler(dataGridView_CellEnter);

            LoadInitialGrid();

            AddZeldaMSUInitialTracks();

            //LoadFromXML();

            NormalizeGridChecks();
        }
        private void LoadInitialGrid()
        {
            if (dsTracks.Tables.Count == 0)
            {
                dsTracks.Tables.Add("Tracks");

                dsTracks.Tables["Tracks"].Columns.Add("TrackNum");
                dsTracks.Tables["Tracks"].Columns.Add("TrackTitle");
                dsTracks.Tables["Tracks"].Columns.Add("OriginalNotes");
                dsTracks.Tables["Tracks"].Columns.Add("FolderName");
                dsTracks.Tables["Tracks"].Columns.Add("FileName");
                dsTracks.Tables["Tracks"].Columns.Add("TrimStart");
                dsTracks.Tables["Tracks"].Columns.Add("Loop");
                dsTracks.Tables["Tracks"].Columns.Add("TrimEnd");
                dsTracks.Tables["Tracks"].Columns.Add("Crossfade");
                dsTracks.Tables["Tracks"].Columns.Add("FadeIn");
                dsTracks.Tables["Tracks"].Columns.Add("Normalization");
                dsTracks.Tables["Tracks"].Columns.Add("IncludeTrack", System.Type.GetType("System.Boolean"));
                dsTracks.Tables["Tracks"].Columns.Add("IgnoreTrackInfo", System.Type.GetType("System.Boolean"));
                dsTracks.Tables["Tracks"].Columns.Add("HasSubTracks", System.Type.GetType("System.Boolean"));
            }

            if (dsTracks.Tables.Count == 1)
            {
                dsTracks.Tables.Add("MSUInfo");

                dsTracks.Tables["MSUInfo"].Columns.Add("Game");
                dsTracks.Tables["MSUInfo"].Columns.Add("Pack");
                dsTracks.Tables["MSUInfo"].Columns.Add("Artist");
                dsTracks.Tables["MSUInfo"].Columns.Add("Normalization", System.Type.GetType("System.Int32"));
                dsTracks.Tables["MSUInfo"].Columns.Add("OutputPrefix");
            }

            if (dsTracks.Tables.Count == 2)
            {
                dsTracks.Tables.Add("SubTracks");

                dsTracks.Tables["SubTracks"].Columns.Add("TrackNum");
                dsTracks.Tables["SubTracks"].Columns.Add("FolderName");
                dsTracks.Tables["SubTracks"].Columns.Add("FileName");
                dsTracks.Tables["SubTracks"].Columns.Add("TrimStart");
                dsTracks.Tables["SubTracks"].Columns.Add("TrimEnd");
            }
        }
        private void AddZeldaMSUInitialTracks()
        {
            AddRowToTable("1", "Title ~ Link to the Past", "");
            AddRowToTable("2", "Hyrule Field", "");
            AddRowToTable("3", "Time of Falling Rain", "Rain SFX generated in-game automatically.");
            AddRowToTable("4", "The Silly Pink Rabbit", "Bunny Sprite in dark world");
            AddRowToTable("5", "Forest of Mystery", "Light Lost Woods");
            AddRowToTable("6", "Seal of Seven Maidens (Opening Prologue)", "");
            AddRowToTable("7", "Kakariko Village", "");
            AddRowToTable("8", "Mirror Warp", "");
            AddRowToTable("9", "Dark Golden Land", "Darkworld after pearl");
            AddRowToTable("10", "Unsealing the Master Sword", "Ped pull");
            AddRowToTable("11", "Beginning of the Journey", "File Select Screen");
            AddRowToTable("12", "Soldiers of Kakariko Village", "Anger guards in kak.");
            AddRowToTable("13", "Black Mist", "Dark Death Mountain - After pearl pickup");
            AddRowToTable("14", "Guessing Game House", "");
            AddRowToTable("15", "Dark Woods", "Dark Lost Woods.  If not set, uses 9.  Is replaced after 7 crystals.");
            AddRowToTable("16", "Majestic Castle - Hyrule Castle", "");
            AddRowToTable("17", "Lost Ancient Ruins (Pendant Dungeons)", "");
            AddRowToTable("18", "Dank Dungeons", "Caves");
            AddRowToTable("19", "Great Victory!", "");
            AddRowToTable("20", "Safety in the Scantuary", "");
            AddRowToTable("21", "Anger of the Guardians", "Default boss fight if dungeon specific is not set.");
            AddRowToTable("22", "Dungeon of the Shadows (Crystal Dungeons + GT)", "");
            AddRowToTable("23", "Fortune Teller", "");
            AddRowToTable("24", "Dank Dungeons (Copy)", "");
            AddRowToTable("25", "Princess Zelda's Rescue", "");
            AddRowToTable("26", "Meeting the Maidens", "Cuts off after about 1s, happens after 19 in a crystal dungeon");
            AddRowToTable("27", "The Goddess Appears", "Fairy Fountain");
            AddRowToTable("28", "Priest of the Dark Order", "Aga1 monologue");
            AddRowToTable("29", "Release of Ganon", "");
            AddRowToTable("30", "Ganon's Message", "Ganon Monologue");
            AddRowToTable("31", "The Prince of Darkness", "Ganon Fight");
            AddRowToTable("32", "Power of the Gods", "Triforce Room");
            AddRowToTable("33", "Epilogue ~ Beautiful Hyrule", "");
            AddRowToTable("34", "Staff Roll", "");
            AddRowToTable("35", "Eastern Palace", "");
            AddRowToTable("36", "Desert Palace", "");
            AddRowToTable("37", "Agahnim's Tower", "");
            AddRowToTable("38", "Swamp Palace", "");
            AddRowToTable("39", "Palace of Darkness", "");
            AddRowToTable("40", "Misery Mire", "");
            AddRowToTable("41", "Skull Woods", "");
            AddRowToTable("42", "Ice Palace", "");
            AddRowToTable("43", "Tower of Hera", "");
            AddRowToTable("44", "Thieves' Town", "");
            AddRowToTable("45", "Turtle Rock", "");
            AddRowToTable("46", "Ganon's Tower", "");
            AddRowToTable("47", "Eastern Palace Boss", "");
            AddRowToTable("48", "Desert Palace Boss", "");
            AddRowToTable("49", "Agahnim's Tower Boss", "");
            AddRowToTable("50", "Swamp Palace Boss", "");
            AddRowToTable("51", "Palace of Darkness Boss", "");
            AddRowToTable("52", "Misery Mire Boss", "");
            AddRowToTable("53", "Skull Woods Boss", "");
            AddRowToTable("54", "Ice Palace Boss", "");
            AddRowToTable("55", "Tower of Hera Boss", "");
            AddRowToTable("56", "Thieves' Town Boss", "");
            AddRowToTable("57", "Turtle Rock Boss", "");
            AddRowToTable("58", "Ganon's Tower Boss", "");
            AddRowToTable("59", "Ganon's Tower (Upstairs)", "");
            AddRowToTable("60", "Light World OW", "After Ped Pull.  If not set, uses 2.");
            AddRowToTable("61", "Dark World OW", "with 7 Crystals.  If not set, uses 9 even in lost woods with 15 set.");

            dgMSUTracks.DataSource = dsTracks.Tables["Tracks"];
        }
        private void AddRowToTable(string TrackNum, string TrackTitle, string OriginalNotes)
        {
            DataRow dr = dsTracks.Tables["Tracks"].NewRow();
            dr["TrackNum"] = TrackNum;
            dr["TrackTitle"] = TrackTitle;
            dr["OriginalNotes"] = OriginalNotes;
            dsTracks.Tables["Tracks"].Rows.Add(dr);
        }
        private void AddRowToSubTracksTable(string TrackNum)
        {
            DataRow dr = dsTracks.Tables["SubTracks"].NewRow();
            dr["TrackNum"] = TrackNum;
            dsTracks.Tables["SubTracks"].Rows.Add(dr);
        }
        private void SaveInformation()
        {
            if (dsTracks.Tables["MSUInfo"].Rows.Count == 0)
            {
                DataRow dr = dsTracks.Tables["MSUInfo"].NewRow();
                dr["Game"] = txtGame.Text;
                dr["Pack"] = txtPackName.Text;
                dr["Artist"] = txtArtist.Text;
                dr["Normalization"] = numNormalization.Value;
                dr["OutputPrefix"] = txtOutputPrefix.Text;
                dsTracks.Tables["MSUInfo"].Rows.Add(dr);
            }
            else
            {
                dsTracks.Tables["MSUInfo"].Rows[0]["Game"] = txtGame.Text;
                dsTracks.Tables["MSUInfo"].Rows[0]["Pack"] = txtPackName.Text;
                dsTracks.Tables["MSUInfo"].Rows[0]["Artist"] = txtArtist.Text;
                dsTracks.Tables["MSUInfo"].Rows[0]["Normalization"] = numNormalization.Value;
                dsTracks.Tables["MSUInfo"].Rows[0]["OutputPrefix"] = txtOutputPrefix.Text;
            }

            Boolean SaveXML = false;

            if (string.IsNullOrEmpty(XMLPath))
            {
                SetSaveFilePath();

                if (!string.IsNullOrEmpty(XMLPath))
                {
                    SaveXML = true;
                }
            }
            else
            {
                SaveXML = true;
            }

            if (SaveXML == true)
            {
                dsTracks.WriteXml(XMLPath, XmlWriteMode.WriteSchema);
            }
            else
            {
                MessageBox.Show("There is no save file path selected.  Please enter one and try again.", "MSU JSON Creator", MessageBoxButtons.OK);
            }
        }
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            SaveInformation();
        }
        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            ShowSubtrackInfo();
        }
        private void ShowSubtrackInfo()
        {
            int cellRowIndex = dgMSUTracks.CurrentCell.RowIndex;

            string TrackNum = dgMSUTracks.Rows[cellRowIndex].Cells["TrackNum"].Value.ToString();

            dgSubTracks.DataSource = null;

            if (!string.IsNullOrEmpty(dgMSUTracks.Rows[cellRowIndex].Cells["HasSubTracks"].Value.ToString()))
            {
                if ((bool)dgMSUTracks.Rows[cellRowIndex].Cells["HasSubTracks"].Value == true)
                {
                    LoadSubTracks(TrackNum);
                }
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveInformation();
        }
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string isValid = VerifyDataEntered(dsTracks);

            if (isValid == "valid")
            {
                GenerateJSON();
            }
            else
            {
                MessageBox.Show(isValid, "MSU JSON Creator", MessageBoxButtons.OK);
            }
        }
        private void GenerateJSON()
        {
            var msu = new JObject();

            msu.Add("$schema", "https://github.com/qwertymodo/msupcmplusplus/blob/master/configs/schema");
            msu.Add("game", txtGame.Text);
            msu.Add("pack", txtPackName.Text);
            msu.Add("artist", txtArtist.Text);
            msu.Add("normalization", Int32.Parse(numNormalization.Value.ToString()));
            msu.Add("output_prefix", txtOutputPrefix.Text);

            dynamic NewTracks = msu;

            NewTracks.tracks = new JArray() as dynamic;

            for (int x = 0; x < dgMSUTracks.Rows.Count; x++)
            {
                if (!string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["IncludeTrack"].Value.ToString()))
                {
                    if ((bool)dgMSUTracks.Rows[x].Cells["IncludeTrack"].Value == true)
                    {
                        dynamic track = new JObject();

                        string MainTrackNum = dgMSUTracks.Rows[x].Cells["TrackNum"].Value.ToString();

                        track.track_number = Int32.Parse(dgMSUTracks.Rows[x].Cells["TrackNum"].Value.ToString());
                        track.title = dgMSUTracks.Rows[x].Cells["TrackTitle"].Value.ToString();

                        if (!string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["IgnoreTrackInfo"].Value.ToString()))
                        {
                            if ((bool)dgMSUTracks.Rows[x].Cells["IgnoreTrackInfo"].Value == false)
                            {

                                if (!string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["HasSubTracks"].Value.ToString()))
                                {
                                    if ((bool)dgMSUTracks.Rows[x].Cells["HasSubTracks"].Value == false)
                                    {
                                        track.file = dgMSUTracks.Rows[x].Cells["FolderName"].Value.ToString() + "\\" + dgMSUTracks.Rows[x].Cells["FileName"].Value.ToString();

                                        track.trim_start = Int32.Parse(dgMSUTracks.Rows[x].Cells["TrimStart"].Value.ToString());

                                        if (!string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["Loop"].Value.ToString()))
                                        {
                                            track.loop = Int32.Parse(dgMSUTracks.Rows[x].Cells["Loop"].Value.ToString());
                                        }

                                        if (!string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["Crossfade"].Value.ToString()))
                                        {
                                            track.cross_fade = Int32.Parse(dgMSUTracks.Rows[x].Cells["Crossfade"].Value.ToString());
                                        }

                                        if (!string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["FadeIn"].Value.ToString()))
                                        {
                                            track.fade_in = Int32.Parse(dgMSUTracks.Rows[x].Cells["FadeIn"].Value.ToString());
                                        }

                                        track.trim_end = Int32.Parse(dgMSUTracks.Rows[x].Cells["TrimEnd"].Value.ToString());

                                        if (!string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["Normalization"].Value.ToString()))
                                        {
                                            track.normalization = Int32.Parse(dgMSUTracks.Rows[x].Cells["Normalization"].Value.ToString());
                                        }
                                    }
                                    else
                                    {
                                        track.sub_tracks = new JArray() as dynamic;                                     

                                        for (int y = 0; y < dsTracks.Tables["SubTracks"].Rows.Count; y++)
                                        {
                                            

                                            if (dsTracks.Tables["SubTracks"].Rows[y]["TrackNum"].ToString() == MainTrackNum)
                                            {
                                                dynamic subtrack = new JObject();

                                                subtrack.file = dsTracks.Tables["SubTracks"].Rows[y]["FolderName"].ToString() + "\\" + dsTracks.Tables["SubTracks"].Rows[y]["FileName"].ToString();
                                                subtrack.trim_start = Int32.Parse(dsTracks.Tables["SubTracks"].Rows[y]["TrimStart"].ToString());
                                                subtrack.trim_end = Int32.Parse(dsTracks.Tables["SubTracks"].Rows[y]["TrimEnd"].ToString());

                                                track.sub_tracks.Add(subtrack);
                                            }

                                            
                                        }

                                        
                                    }
                                }
                            }
                        }

                        NewTracks.tracks.Add(track);
                    }
                }
            }

            //var jsonResolver = new PropertyRenameAndIgnoreSerializerContractResolver();

            //jsonResolver.RenameProperty(typeof(Root), "schema", "$schema");

            //var serializerSettings = new JsonSerializerSettings();
            //serializerSettings.ContractResolver = jsonResolver;

            //var json2 = JsonConvert.SerializeObject(msu, serializerSettings);

            string json = JsonConvert.SerializeObject(msu, Formatting.Indented);

            if (File.Exists(Application.StartupPath + "\\tracks.json"))
            {
                File.Delete(Application.StartupPath + "\\tracks.json");
            }

            File.WriteAllText(Application.StartupPath + "\\tracks.json", json);
        }
        private void LoadFromXML()
        {
            if (!string.IsNullOrEmpty(XMLPath))
            {
                if (File.Exists(XMLPath))
                {
                    dsTracks.Clear();
                    dsTracks.ReadXml(XMLPath);

                    if (dsTracks.Tables["MSUInfo"].Rows.Count > 0)
                    {
                        txtGame.Text = dsTracks.Tables["MSUInfo"].Rows[0]["Game"].ToString();
                        txtPackName.Text = dsTracks.Tables["MSUInfo"].Rows[0]["Pack"].ToString();
                        txtArtist.Text = dsTracks.Tables["MSUInfo"].Rows[0]["Artist"].ToString();
                        numNormalization.Value = Int32.Parse(dsTracks.Tables["MSUInfo"].Rows[0]["Normalization"].ToString());
                        txtOutputPrefix.Text = dsTracks.Tables["MSUInfo"].Rows[0]["OutputPrefix"].ToString();
                    }
                }
            }

        }
        private void NormalizeGridChecks()
        {
            for (int x = 0; x < dgMSUTracks.Rows.Count; x++)
            {
                if (string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["IncludeTrack"].Value.ToString()))
                {
                    dgMSUTracks.Rows[x].Cells["IncludeTrack"].Value = false;
                }
                if (string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["IgnoreTrackInfo"].Value.ToString()))
                {
                    dgMSUTracks.Rows[x].Cells["IgnoreTrackInfo"].Value = false;
                }
                if (string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["HasSubTracks"].Value.ToString()))
                {
                    dgMSUTracks.Rows[x].Cells["HasSubTracks"].Value = false;
                }
            }
        }
        private void DeselectAll()
        {
            for (int x = 0; x < dgMSUTracks.Rows.Count; x++)
            {
                dgMSUTracks.Rows[x].Cells["IncludeTrack"].Value = false;
                dgMSUTracks.Rows[x].Cells["IgnoreTrackInfo"].Value = false;
            }
        }
        private void btnDeselectAll_Click(object sender, EventArgs e)
        {
            DeselectAll();
        }
        private void SelectTracksWithTrimStart()
        {
            for (int x = 0; x < dgMSUTracks.Rows.Count; x++)
            {
                if (!string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["TrimStart"].Value.ToString()))
                {
                    dgMSUTracks.Rows[x].Cells["IncludeTrack"].Value = true;
                }
            }
        }
        private void btnSelectValids_Click(object sender, EventArgs e)
        {
            SelectTracksWithTrimStart();
        }
        private void btnValidate_Click(object sender, EventArgs e)
        {
            string isValid = VerifyDataEntered(dsTracks);

            MessageBox.Show(isValid, "MSU JSON Creator", MessageBoxButtons.OK);
        }
        static String VerifyDataEntered(DataSet dsTracks)
        {
            string EndString = "Either add one or ignore track info and try again.";
            string EndSubTrackString = "Either add one or delete the sub-track and try again.";

            for (int x = 0; x < dsTracks.Tables["Tracks"].Rows.Count; x++)
            {
                int trimEnd = -1;
                int loop = -1;
                int trimStart = -1;

                string startString = "Track number " + dsTracks.Tables["Tracks"].Rows[x]["TrackNum"].ToString();

                Boolean IncludeTrack = (bool)dsTracks.Tables["Tracks"].Rows[x]["IncludeTrack"];
                Boolean IgnoreTrackInfo = (bool)dsTracks.Tables["Tracks"].Rows[x]["IgnoreTrackInfo"];
                Boolean HasSubTracks = (bool)dsTracks.Tables["Tracks"].Rows[x]["HasSubTracks"];



                if (IncludeTrack == true)
                {
                    if (IgnoreTrackInfo == false)
                    {
                        if (HasSubTracks == false)
                        {
                            if (string.IsNullOrEmpty(dsTracks.Tables["Tracks"].Rows[x]["FolderName"].ToString()))
                            {
                                return startString + " doesn't have a folder set.  " + EndString;
                            }

                            if (string.IsNullOrEmpty(dsTracks.Tables["Tracks"].Rows[x]["FileName"].ToString()))
                            {
                                return startString + " doesn't have a file set.  " + EndString;
                            }

                            if (string.IsNullOrEmpty(dsTracks.Tables["Tracks"].Rows[x]["TrimStart"].ToString()))
                            {
                                return startString + " doesn't have a start trim time set.  " + EndString;
                            }
                            else
                            {
                                if (Int32.TryParse(dsTracks.Tables["Tracks"].Rows[x]["TrimStart"].ToString(), out int numValue))
                                {
                                    trimStart = numValue;
                                }
                                else
                                {
                                    return startString + " doesn't have a valid start trim time as a number.  " + EndString;
                                }
                            }

                            if (string.IsNullOrEmpty(dsTracks.Tables["Tracks"].Rows[x]["TrimEnd"].ToString()))
                            {
                                return startString + " doesn't have a end trim time set.  " + EndString;
                            }
                            else
                            {
                                if (Int32.TryParse(dsTracks.Tables["Tracks"].Rows[x]["TrimEnd"].ToString(), out int numValue))
                                {
                                    trimEnd = numValue;
                                }
                                else
                                {
                                    return startString + " doesn't have a valid end trim time as a number.  " + EndString;
                                }
                            }

                            if (!string.IsNullOrEmpty(dsTracks.Tables["Tracks"].Rows[x]["Loop"].ToString()))
                            {
                                if (Int32.TryParse(dsTracks.Tables["Tracks"].Rows[x]["Loop"].ToString(), out int numValue))
                                {
                                    loop = numValue;
                                }
                                else
                                {
                                    return startString + " doesn't have a valid loop time as a number.  " + EndString;
                                }
                            }

                            if (trimStart > -1)
                            {
                                if (trimEnd > -1)
                                {
                                    if (trimEnd < trimStart)
                                    {
                                        return startString + " the end point is after the trim start.  This will cause a crash in game.  Please fix this before proceeding";
                                    }
                                }
                            }

                            if (loop > -1)
                            {
                                if (trimEnd == -1)
                                {
                                    return startString + " has a loop number set but no trim end.  Please fix this before proceeding.";
                                }
                                else
                                {
                                    if (loop > trimEnd)
                                    {
                                        return startString + " the loop point is after the trim end.  This will cause a crash in game.  Please fix this before proceeding";
                                    }
                                }
                            }

                            if (!string.IsNullOrEmpty(dsTracks.Tables["Tracks"].Rows[x]["Crossfade"].ToString()))
                            {
                                if (Int32.TryParse(dsTracks.Tables["Tracks"].Rows[x]["Crossfade"].ToString(), out int numValue))
                                {

                                }
                                else
                                {
                                    return startString + " doesn't have a valid Crossfade time as a number.  " + EndString;
                                }
                            }

                            if (!string.IsNullOrEmpty(dsTracks.Tables["Tracks"].Rows[x]["FadeIn"].ToString()))
                            {
                                if (Int32.TryParse(dsTracks.Tables["Tracks"].Rows[x]["FadeIn"].ToString(), out int numValue))
                                {

                                }
                                else
                                {
                                    return startString + " doesn't have a valid Fade In time as a number.  " + EndString;
                                }
                            }
                        }
                    }
                }
            }

            for (int y = 0; y < dsTracks.Tables["SubTracks"].Rows.Count; y++)
            {
                string startString = "Track number " + dsTracks.Tables["SubTracks"].Rows[y]["TrackNum"].ToString() + " has a sub-track that";

                int trimEnd = -1;
                int trimStart = -1;

                if (string.IsNullOrEmpty(dsTracks.Tables["SubTracks"].Rows[y]["FolderName"].ToString()))
                {
                    return startString + " doesn't have a folder set.  " + EndSubTrackString;
                }

                if (string.IsNullOrEmpty(dsTracks.Tables["SubTracks"].Rows[y]["FileName"].ToString()))
                {
                    return startString + " doesn't have a file set.  " + EndSubTrackString;
                }

                if (string.IsNullOrEmpty(dsTracks.Tables["SubTracks"].Rows[y]["TrimStart"].ToString()))
                {
                    return startString + " doesn't have a start trim time set.  " + EndSubTrackString;
                }
                else
                {
                    if (Int32.TryParse(dsTracks.Tables["Tracks"].Rows[y]["TrimStart"].ToString(), out int numValue))
                    {
                        trimStart = numValue;
                    }
                    else
                    {
                        return startString + " doesn't have a valid start trim time as a number.  " + EndSubTrackString;
                    }
                }

                if (string.IsNullOrEmpty(dsTracks.Tables["SubTracks"].Rows[y]["TrimEnd"].ToString()))
                {
                    return startString + " doesn't have a end trim time set.  " + EndSubTrackString;
                }
                else
                {
                    if (Int32.TryParse(dsTracks.Tables["SubTracks"].Rows[y]["TrimEnd"].ToString(), out int numValue))
                    {
                        trimEnd = numValue;
                    }
                    else
                    {
                        return startString + " doesn't have a valid end trim time as a number.  " + EndSubTrackString;
                    }
                }

                if (trimStart > -1)
                {
                    if (trimEnd > -1)
                    {
                        if (trimEnd < trimStart)
                        {
                            return startString + " the end point is after the trim start.  This will cause a crash in game.  Please fix this before proceeding";
                        }
                    }
                }
            }

            return "valid";
        }
        private void saveXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetSaveFilePath();
            SaveInformation();
        }
        private void openXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open MSU Track Settings";
            openFileDialog1.CheckFileExists = true;
            openFileDialog1.CheckPathExists = true;
            openFileDialog1.DefaultExt = "xml";
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XMLPath = openFileDialog1.FileName;

                LoadFromXML();
                NormalizeGridChecks();
            }
        }
        private void SetSaveFilePath()
        {
            saveFileDialog1.Title = "Save MSU Track Settings";
            saveFileDialog1.DefaultExt = "xml";
            saveFileDialog1.Filter = "XML Files (*.xml)|*.xml";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                XMLPath = saveFileDialog1.FileName;
            }
        }
        private void hasSubTracksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cellRowIndex = dgMSUTracks.CurrentCell.RowIndex;

            string TrackNum = dgMSUTracks.Rows[cellRowIndex].Cells["TrackNum"].Value.ToString();

            AddRowToSubTracksTable(TrackNum);

            if (string.IsNullOrEmpty(dgMSUTracks.Rows[cellRowIndex].Cells["HasSubTracks"].Value.ToString()))
            {
                dgMSUTracks.Rows[cellRowIndex].Cells["HasSubTracks"].Value = true;
            }
            else
            {
                if ((bool)dgMSUTracks.Rows[cellRowIndex].Cells["HasSubTracks"].Value == false)
                {
                    dgMSUTracks.Rows[cellRowIndex].Cells["HasSubTracks"].Value = true;
                }
            }

            SaveInformation();

            ShowSubtrackInfo();
        }
        private void RemoveAllSubtracks(string TrackNum)
        {
            if (dsTracks.Tables.Count == 3)
            {
                if (dsTracks.Tables["SubTracks"].Rows.Count > 0)
                {
                    for (int x = dsTracks.Tables["SubTracks"].Rows.Count - 1; x > -1; x--)
                    {
                        if (dsTracks.Tables["SubTracks"].Rows[x]["TrackNum"].ToString() == TrackNum)
                        {
                            dsTracks.Tables["SubTracks"].Rows[x].Delete();
                        }
                    }
                }
            }
        }
        private void ClearSubTrackAfterRemove()
        {
            int cellRowIndex = dgMSUTracks.CurrentCell.RowIndex;

            dgMSUTracks.Rows[cellRowIndex].Cells["HasSubTracks"].Value = false;

            SaveInformation();

            dgSubTracks.DataSource = null;
        }
        private void removeSubTracksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cellRowIndex = dgMSUTracks.CurrentCell.RowIndex;

            string TrackNum = dgMSUTracks.Rows[cellRowIndex].Cells["TrackNum"].Value.ToString();

            RemoveAllSubtracks(TrackNum);

            ClearSubTrackAfterRemove();
        }
        private void LoadSubTracks(string TrackNum)
        {
            if (dsTracks.Tables.Count == 3)
            {
                dgSubTracks.DataSource = dsTracks.Tables["SubTracks"];

                (dgSubTracks.DataSource as DataTable).DefaultView.RowFilter = string.Format("TrackNum = '{0}'", TrackNum);
            }
        }
        private void addSubTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cellRowIndex = dgSubTracks.CurrentCell.RowIndex;

            string TrackNum = dgSubTracks.Rows[cellRowIndex].Cells["TrackNum"].Value.ToString();

            AddRowToSubTracksTable(TrackNum);
        }
        private void removeSubTrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int cellRowIndex = dgSubTracks.CurrentCell.RowIndex;

            dgSubTracks.Rows.RemoveAt(cellRowIndex);

            if (dgSubTracks.Rows.Count > 0)
            {

            }
            else
            {
                ClearSubTrackAfterRemove();
            }

        }
        private void btnFillFolder_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < dgMSUTracks.Rows.Count; x++)
            {
                if (!string.IsNullOrEmpty(dgMSUTracks.Rows[x].Cells["FileName"].Value.ToString()))
                {
                    dgMSUTracks.Rows[x].Cells["FolderName"].Value = txtFolder.Text;
                }
            }
        }
    }
}
