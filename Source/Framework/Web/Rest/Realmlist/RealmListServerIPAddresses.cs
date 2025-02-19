﻿// Copyright (c) CypherCore <http://github.com/CypherCore> All rights reserved.
// Licensed under the GNU GENERAL PUBLIC LICENSE. See LICENSE file in the project root for full license information.

using Framework.Web.Rest.Realmlist;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Framework.Web
{
    public class RealmListServerIPAddresses
    {
        [JsonPropertyName("families")]
        public IList<AddressFamily> Families { get; set; } = new List<AddressFamily>();
    }
}
