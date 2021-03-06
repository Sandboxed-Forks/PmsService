﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace PlexServiceCommon
{
    /// <summary>
    /// Auxilliary application class.
    /// This calss represenets an application that should be run when plex runs
    /// </summary>
    [JsonObject(MemberSerialization.OptIn)]
    public class AuxiliaryApplication
    {
        /// <summary>
        /// Friendly name of the application
        /// </summary>
        [JsonProperty]
        public string Name { get; set; }

        /// <summary>
        /// Path of the executable to run
        /// </summary>
        [JsonProperty]
        public string FilePath { get; set; }

        /// <summary>
        /// any arguments to pass to the executable
        /// </summary>
        [JsonProperty]
        public string Argument { get; set; }

        /// <summary>
        /// A flag to determine if the application should be kept running (service like) or if it can run and stop (like a script)
        /// </summary>
        [JsonProperty]
        public bool KeepAlive { get; set; }

        public AuxiliaryApplication()
        {
            Name = string.Empty;
            FilePath = string.Empty;
            Argument = string.Empty;
            KeepAlive = true;
        }
    }
}
