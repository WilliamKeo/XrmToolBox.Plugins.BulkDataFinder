﻿using Microsoft.Xrm.Sdk;
using System;

namespace Keowi.XrmToolBox.Plugins.BulkDataFinder
{
    public class Search
    {
        public AttributeCollection Attributes { get; set; }
        public string Error { get; set; }
        public bool HasDuplicates { get; set; }
        public string InputData { get; set; }
        public bool IsFound { get; set; }
        public bool IsProcessed { get; set; }
        public string PrimaryAttribute { get; set; }
        public Guid RecordId { get; set; }
    }
}