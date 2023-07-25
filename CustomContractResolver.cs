using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MSU_JSON_Creator
{
    public class CustomContractResolver : DefaultContractResolver
    {
        public bool UseJsonPropertyName { get; }

        public CustomContractResolver(bool useJsonPropertyName)
        {
            UseJsonPropertyName = useJsonPropertyName;
        }

        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            if (!UseJsonPropertyName)
                property.PropertyName = property.UnderlyingName;

            return property;
        }
    }

    public class ErrorDetails
    {
        public int Id { get; set; }
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }
    }
}
