﻿// Copyright (c) CypherCore <http://github.com/CypherCore> All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Framework.Web.Rest.Login
{
    public class FormInputs
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("inputs")]
        public List<FormInput> Inputs { get; set; } = new List<FormInput>();

        [JsonPropertyName("srp_url")]
        public string SrpUrl { get; set; }

        [JsonPropertyName("srp_js")]
        public string SrpJs { get; set; }
    }
}
