// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure;
using Azure.Core;
using Azure.ResourceManager.DataBoxEdge.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataBoxEdge
{
    /// <summary>
    /// A class representing the DataBoxEdgeDevice data model.
    /// The Data Box Edge/Gateway device.
    /// </summary>
    public partial class DataBoxEdgeDeviceData : TrackedResourceData
    {
        /// <summary> Initializes a new instance of DataBoxEdgeDeviceData. </summary>
        /// <param name="location"> The location. </param>
        public DataBoxEdgeDeviceData(AzureLocation location) : base(location)
        {
            ConfiguredRoleTypes = new ChangeTrackingList<DataBoxEdgeRoleType>();
        }

        /// <summary> Initializes a new instance of DataBoxEdgeDeviceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="sku"> The SKU type. </param>
        /// <param name="etag"> The etag for the devices. </param>
        /// <param name="identity"> Msi identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </param>
        /// <param name="kind"> The kind of the device. </param>
        /// <param name="dataBoxEdgeDeviceStatus"> The status of the Data Box Edge/Gateway device. </param>
        /// <param name="serialNumber"> The Serial Number of Data Box Edge/Gateway device. </param>
        /// <param name="description"> The Description of the Data Box Edge/Gateway device. </param>
        /// <param name="modelDescription"> The description of the Data Box Edge/Gateway device model. </param>
        /// <param name="deviceType"> The type of the Data Box Edge/Gateway device. </param>
        /// <param name="friendlyName"> The Data Box Edge/Gateway device name. </param>
        /// <param name="culture"> The Data Box Edge/Gateway device culture. </param>
        /// <param name="deviceModel"> The Data Box Edge/Gateway device model. </param>
        /// <param name="deviceSoftwareVersion"> The Data Box Edge/Gateway device software version. </param>
        /// <param name="deviceLocalCapacity"> The Data Box Edge/Gateway device local capacity in MB. </param>
        /// <param name="timeZone"> The Data Box Edge/Gateway device timezone. </param>
        /// <param name="deviceHcsVersion"> The device software version number of the device (eg: 1.2.18105.6). </param>
        /// <param name="configuredRoleTypes"> Type of compute roles configured. </param>
        /// <param name="nodeCount"> The number of nodes in the cluster. </param>
        /// <param name="resourceMoveDetails"> The details of the move operation on this resource. </param>
        /// <param name="edgeProfile"> The details of Edge Profile for this resource. </param>
        /// <param name="dataResidency"> The details of data-residency related properties for this resource. </param>
        internal DataBoxEdgeDeviceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, IDictionary<string, string> tags, AzureLocation location, DataBoxEdgeSku sku, ETag? etag, ManagedServiceIdentity identity, DataBoxEdgeDeviceKind? kind, DataBoxEdgeDeviceStatus? dataBoxEdgeDeviceStatus, string serialNumber, string description, string modelDescription, DataBoxEdgeDeviceType? deviceType, string friendlyName, string culture, string deviceModel, string deviceSoftwareVersion, long? deviceLocalCapacity, string timeZone, string deviceHcsVersion, IReadOnlyList<DataBoxEdgeRoleType> configuredRoleTypes, int? nodeCount, DataBoxEdgeResourceMoveDetails resourceMoveDetails, EdgeProfile edgeProfile, DataResidency dataResidency) : base(id, name, resourceType, systemData, tags, location)
        {
            Sku = sku;
            ETag = etag;
            Identity = identity;
            Kind = kind;
            DataBoxEdgeDeviceStatus = dataBoxEdgeDeviceStatus;
            SerialNumber = serialNumber;
            Description = description;
            ModelDescription = modelDescription;
            DeviceType = deviceType;
            FriendlyName = friendlyName;
            Culture = culture;
            DeviceModel = deviceModel;
            DeviceSoftwareVersion = deviceSoftwareVersion;
            DeviceLocalCapacity = deviceLocalCapacity;
            TimeZone = timeZone;
            DeviceHcsVersion = deviceHcsVersion;
            ConfiguredRoleTypes = configuredRoleTypes;
            NodeCount = nodeCount;
            ResourceMoveDetails = resourceMoveDetails;
            EdgeProfile = edgeProfile;
            DataResidency = dataResidency;
        }

        /// <summary> The SKU type. </summary>
        public DataBoxEdgeSku Sku { get; set; }
        /// <summary> The etag for the devices. </summary>
        public ETag? ETag { get; set; }
        /// <summary> Msi identity of the resource. Current supported identity types: None, SystemAssigned, UserAssigned. </summary>
        public ManagedServiceIdentity Identity { get; set; }
        /// <summary> The kind of the device. </summary>
        public DataBoxEdgeDeviceKind? Kind { get; }
        /// <summary> The status of the Data Box Edge/Gateway device. </summary>
        public DataBoxEdgeDeviceStatus? DataBoxEdgeDeviceStatus { get; }
        /// <summary> The Serial Number of Data Box Edge/Gateway device. </summary>
        public string SerialNumber { get; }
        /// <summary> The Description of the Data Box Edge/Gateway device. </summary>
        public string Description { get; }
        /// <summary> The description of the Data Box Edge/Gateway device model. </summary>
        public string ModelDescription { get; }
        /// <summary> The type of the Data Box Edge/Gateway device. </summary>
        public DataBoxEdgeDeviceType? DeviceType { get; }
        /// <summary> The Data Box Edge/Gateway device name. </summary>
        public string FriendlyName { get; }
        /// <summary> The Data Box Edge/Gateway device culture. </summary>
        public string Culture { get; }
        /// <summary> The Data Box Edge/Gateway device model. </summary>
        public string DeviceModel { get; }
        /// <summary> The Data Box Edge/Gateway device software version. </summary>
        public string DeviceSoftwareVersion { get; }
        /// <summary> The Data Box Edge/Gateway device local capacity in MB. </summary>
        public long? DeviceLocalCapacity { get; }
        /// <summary> The Data Box Edge/Gateway device timezone. </summary>
        public string TimeZone { get; }
        /// <summary> The device software version number of the device (eg: 1.2.18105.6). </summary>
        public string DeviceHcsVersion { get; }
        /// <summary> Type of compute roles configured. </summary>
        public IReadOnlyList<DataBoxEdgeRoleType> ConfiguredRoleTypes { get; }
        /// <summary> The number of nodes in the cluster. </summary>
        public int? NodeCount { get; }
        /// <summary> The details of the move operation on this resource. </summary>
        public DataBoxEdgeResourceMoveDetails ResourceMoveDetails { get; }
        /// <summary> The details of Edge Profile for this resource. </summary>
        internal EdgeProfile EdgeProfile { get; }
        /// <summary> Edge Profile Subscription. </summary>
        public EdgeProfileSubscription EdgeSubscription
        {
            get => EdgeProfile?.Subscription;
        }

        /// <summary> The details of data-residency related properties for this resource. </summary>
        internal DataResidency DataResidency { get; set; }
        /// <summary> DataResidencyType enum. </summary>
        public DataBoxEdgeDataResidencyType? ResidencyType
        {
            get => DataResidency is null ? default : DataResidency.ResidencyType;
            set
            {
                if (DataResidency is null)
                    DataResidency = new DataResidency();
                DataResidency.ResidencyType = value;
            }
        }
    }
}
