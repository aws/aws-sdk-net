/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.LicenseManagerLinuxSubscriptions.Model
{
    /// <summary>
    /// This is the response object from the GetServiceSettings operation.
    /// </summary>
    public partial class GetServiceSettingsResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property HomeRegions. 
        /// <para>
        /// The Region in which License Manager displays the aggregated data for Linux subscriptions.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public List<string> HomeRegions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the HomeRegions property is set.
        /// </summary>
        internal bool IsSetHomeRegions() => this.HomeRegions != null && (this.HomeRegions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property LinuxSubscriptionsDiscovery. 
        /// <para>
        /// Lists if discovery has been enabled for Linux subscriptions.
        /// </para>
        /// </summary>
        public LinuxSubscriptionsDiscovery LinuxSubscriptionsDiscovery { get; set; }

        /// <summary>
        /// Checks to see if the LinuxSubscriptionsDiscovery property is set.
        /// </summary>
        internal bool IsSetLinuxSubscriptionsDiscovery() => this.LinuxSubscriptionsDiscovery != null;

        /// <summary>
        /// Gets and sets the property LinuxSubscriptionsDiscoverySettings. 
        /// <para>
        /// Lists the settings defined for Linux subscriptions discovery. The settings include
        /// if Organizations integration has been enabled, and which Regions data will be aggregated
        /// from.
        /// </para>
        /// </summary>
        public LinuxSubscriptionsDiscoverySettings LinuxSubscriptionsDiscoverySettings { get; set; }

        /// <summary>
        /// Checks to see if the LinuxSubscriptionsDiscoverySettings property is set.
        /// </summary>
        internal bool IsSetLinuxSubscriptionsDiscoverySettings() => this.LinuxSubscriptionsDiscoverySettings != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Indicates the status of Linux subscriptions settings being applied.
        /// </para>
        /// </summary>
        public Status Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message which details the Linux subscriptions service settings current status.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> StatusMessage { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null && (this.StatusMessage.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
