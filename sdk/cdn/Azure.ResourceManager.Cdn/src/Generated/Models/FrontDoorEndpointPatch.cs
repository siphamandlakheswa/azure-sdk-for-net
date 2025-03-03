// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Cdn.Models
{
    /// <summary> Properties required to create or update an endpoint. </summary>
    public partial class FrontDoorEndpointPatch
    {
        /// <summary> Initializes a new instance of FrontDoorEndpointPatch. </summary>
        public FrontDoorEndpointPatch()
        {
            Tags = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Endpoint tags. </summary>
        public IDictionary<string, string> Tags { get; }
        /// <summary> The name of the profile which holds the endpoint. </summary>
        public string ProfileName { get; }
        /// <summary> Whether to enable use of this rule. Permitted values are 'Enabled' or 'Disabled'. </summary>
        public EnabledState? EnabledState { get; set; }
    }
}
