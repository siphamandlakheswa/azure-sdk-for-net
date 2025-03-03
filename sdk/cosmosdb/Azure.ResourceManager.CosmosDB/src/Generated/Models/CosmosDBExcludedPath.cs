// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.CosmosDB.Models
{
    /// <summary> The CosmosDBExcludedPath. </summary>
    public partial class CosmosDBExcludedPath
    {
        /// <summary> Initializes a new instance of CosmosDBExcludedPath. </summary>
        public CosmosDBExcludedPath()
        {
        }

        /// <summary> Initializes a new instance of CosmosDBExcludedPath. </summary>
        /// <param name="path"> The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard (/path/*). </param>
        internal CosmosDBExcludedPath(string path)
        {
            Path = path;
        }

        /// <summary> The path for which the indexing behavior applies to. Index paths typically start with root and end with wildcard (/path/*). </summary>
        public string Path { get; set; }
    }
}
