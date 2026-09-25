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

namespace Amazon.IoTWireless.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateNetworkAnalyzerConfiguration operation.
    /// Update network analyzer configuration.
    /// </summary>
    public partial class UpdateNetworkAnalyzerConfigurationRequest : AmazonIoTWirelessRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationName.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string ConfigurationName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationName property is set.
        /// </summary>
        internal bool IsSetConfigurationName() => this.ConfigurationName != null;

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MulticastGroupsToAdd. 
        /// <para>
        /// Multicast group resources to add to the network analyzer configuration. Provide the
        /// <c>MulticastGroupId</c> of the resource to add in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> MulticastGroupsToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MulticastGroupsToAdd property is set.
        /// </summary>
        internal bool IsSetMulticastGroupsToAdd() => this.MulticastGroupsToAdd != null && (this.MulticastGroupsToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MulticastGroupsToRemove. 
        /// <para>
        /// Multicast group resources to remove from the network analyzer configuration. Provide
        /// the <c>MulticastGroupId</c> of the resources to remove in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> MulticastGroupsToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the MulticastGroupsToRemove property is set.
        /// </summary>
        internal bool IsSetMulticastGroupsToRemove() => this.MulticastGroupsToRemove != null && (this.MulticastGroupsToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TraceContent.
        /// </summary>
        public TraceContent TraceContent { get; set; }

        /// <summary>
        /// Checks to see if the TraceContent property is set.
        /// </summary>
        internal bool IsSetTraceContent() => this.TraceContent != null;

        /// <summary>
        /// Gets and sets the property WirelessDevicesToAdd. 
        /// <para>
        /// Wireless device resources to add to the network analyzer configuration. Provide the
        /// <c>WirelessDeviceId</c> of the resource to add in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> WirelessDevicesToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the WirelessDevicesToAdd property is set.
        /// </summary>
        internal bool IsSetWirelessDevicesToAdd() => this.WirelessDevicesToAdd != null && (this.WirelessDevicesToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WirelessDevicesToRemove. 
        /// <para>
        /// Wireless device resources to remove from the network analyzer configuration. Provide
        /// the <c>WirelessDeviceId</c> of the resources to remove in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 250)]
        public List<string> WirelessDevicesToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the WirelessDevicesToRemove property is set.
        /// </summary>
        internal bool IsSetWirelessDevicesToRemove() => this.WirelessDevicesToRemove != null && (this.WirelessDevicesToRemove.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WirelessGatewaysToAdd. 
        /// <para>
        /// Wireless gateway resources to add to the network analyzer configuration. Provide the
        /// <c>WirelessGatewayId</c> of the resource to add in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WirelessGatewaysToAdd { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the WirelessGatewaysToAdd property is set.
        /// </summary>
        internal bool IsSetWirelessGatewaysToAdd() => this.WirelessGatewaysToAdd != null && (this.WirelessGatewaysToAdd.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property WirelessGatewaysToRemove. 
        /// <para>
        /// Wireless gateway resources to remove from the network analyzer configuration. Provide
        /// the <c>WirelessGatewayId</c> of the resources to remove in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WirelessGatewaysToRemove { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the WirelessGatewaysToRemove property is set.
        /// </summary>
        internal bool IsSetWirelessGatewaysToRemove() => this.WirelessGatewaysToRemove != null && (this.WirelessGatewaysToRemove.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
