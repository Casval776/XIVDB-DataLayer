﻿//-------------------------------------------------------
//
//      Copyright (c) 2016 All Rights Reserved
//          Daikun Industries LLC
//
//-------------------------------------------------------

using Newtonsoft.Json;
using XIVDB.Interfaces;

namespace XIVDB.Model
{
    /// <summary>
    /// Model class for FATE data types
    /// </summary>
    public class Fate : IXivdbObject
    {
        #region Properties
        [JsonProperty("id")]
        public int? Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("name_ja")]
        public string NameJa { get; set; }
        [JsonProperty("name_en")]
        public string NameEn { get; set; }
        [JsonProperty("name_fr")]
        public string NameFr { get; set; }
        [JsonProperty("name_de")]
        public string NameDe { get; set; }
        [JsonProperty("name_ch")]
        public string NameCh { get; set; }
        [JsonProperty("class_level")]
        public int? ClassLevel { get; set; }
        [JsonProperty("icon")]
        public string Icon { get; set; }
        [JsonProperty("placename")]
        public string Placename { get; set; }
        [JsonProperty("url")]
        public string Url { get; set; }
        [JsonProperty("url_api")]
        public string UrlApi { get; set; }
        [JsonProperty("url_xivdb")]
        public string UrlXivdb { get; set; }
        [JsonProperty("url_xivdb_ja")]
        public string UrlXivdbJa { get; set; }
        [JsonProperty("url_xivdb_fr")]
        public string UrlXivdbFr { get; set; }
        [JsonProperty("url_xivdb_de")]
        public string UrlXivdbDe { get; set; }
        [JsonProperty("url_type")]
        public string UrlType { get; set; }
        [JsonProperty("icon_map")]
        public string IconMap { get; set; }
        [JsonProperty("icon_map_size")]
        public int? IconMapSize { get; set; }
        #endregion
    }
}
