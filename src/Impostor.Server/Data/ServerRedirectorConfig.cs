﻿using System.Collections.Generic;

namespace Impostor.Server.Data
{
    internal class ServerRedirectorConfig
    {
        public const string Section = "ServerRedirector";
        
        public bool Enabled { get; set; }
        public bool Master { get; set; }
        public string Redis { get; set; }
        public List<ServerRedirectorNode> Nodes { get; set; }
    }
}