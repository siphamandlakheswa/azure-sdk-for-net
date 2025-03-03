// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The MonitoringAlertNotificationSettingsBase.
    /// Please note <see cref="MonitoringAlertNotificationSettingsBase"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
    /// The available derived classes include <see cref="AzMonMonitoringAlertNotificationSettings"/> and <see cref="EmailMonitoringAlertNotificationSettings"/>.
    /// </summary>
    public abstract partial class MonitoringAlertNotificationSettingsBase
    {
        /// <summary> Initializes a new instance of MonitoringAlertNotificationSettingsBase. </summary>
        protected MonitoringAlertNotificationSettingsBase()
        {
        }

        /// <summary> Initializes a new instance of MonitoringAlertNotificationSettingsBase. </summary>
        /// <param name="alertNotificationType"> [Required] Specifies the type of signal to monitor. </param>
        internal MonitoringAlertNotificationSettingsBase(MonitoringAlertNotificationType alertNotificationType)
        {
            AlertNotificationType = alertNotificationType;
        }

        /// <summary> [Required] Specifies the type of signal to monitor. </summary>
        internal MonitoringAlertNotificationType AlertNotificationType { get; set; }
    }
}
