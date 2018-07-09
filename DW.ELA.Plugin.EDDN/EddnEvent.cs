﻿using DW.ELA.Utility.Json;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace DW.ELA.Plugin.EDDN
{
    public class EddnEvent
    {
        [JsonProperty("$schemaRef")]
        public virtual string SchemaRef { get; }

        [JsonProperty("header")]
        public IDictionary<string, string> Header { get; set; }

        public override string ToString() => Serialize.ToJson(this);
    }
}
