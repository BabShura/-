﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace RiotApi.Net.RestClient.Dto.LolStaticData.Realm
{
    /// <summary>
    /// This object contains realm data.
    /// </summary>
    [DataContract]
    public class RealmDto : RiotDto
    {
        /// <summary>
        /// The base CDN url.
        /// </summary>
        [DataMember(Name = "cdn")]
        public string Cdn { get; set; }

        /// <summary>
        /// Latest changed version of Dragon Magic's css file.
        /// </summary>
        [DataMember(Name = "css")]
        public string Css { get; set; }

        /// <summary>
        /// Latest changed version of Dragon Magic.
        /// </summary>
        [DataMember(Name = "dd")]
        public string Dd { get; set; }

        /// <summary>
        /// Default language for this realm.
        /// </summary>
        [DataMember(Name = "l")]
        public string L { get; set; }

        /// <summary>
        /// Legacy script mode for IE6 or older.
        /// </summary>
        [DataMember(Name = "lg")]
        public string Lg { get; set; }

        /// <summary>
        /// Latest changed version for each data type listed.
        /// </summary>
        [DataMember(Name = "n")]
        public Dictionary<string, string> N { get; set; }

        /// <summary>
        /// Special behavior number identifying the largest profileicon id that can be used under 500. 
        /// Any profileicon that is requested between this number and 500 should be mapped to 0.
        /// </summary>
        [DataMember(Name = "profileiconmax")]
        public int Profileiconmax { get; set; }

        /// <summary>
        /// Additional api data drawn from other sources that may be related to data dragon functionality.
        /// </summary>
        [DataMember(Name = "store")]
        public string Store { get; set; }

        /// <summary>
        /// Current version of this file for this realm.
        /// </summary>
        [DataMember(Name = "v")]
        public string V { get; set; }
    }
}
