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
 * Do not modify this file. This file is generated from the iotwireless-2020-11-22.normal.json service model.
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
        private string _configurationName;
        private string _description;
        private List<string> _multicastGroupsToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _multicastGroupsToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private TraceContent _traceContent;
        private List<string> _wirelessDevicesToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _wirelessDevicesToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _wirelessGatewaysToAdd = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _wirelessGatewaysToRemove = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property ConfigurationName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string ConfigurationName
        {
            get { return this._configurationName; }
            set { this._configurationName = value; }
        }

        // Check to see if ConfigurationName property is set
        internal bool IsSetConfigurationName()
        {
            return this._configurationName != null;
        }

        /// <summary>
        /// Gets and sets the property Description.
        /// </summary>
        [AWSProperty(Max=2048)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property MulticastGroupsToAdd. 
        /// <para>
        /// Multicast group resources to add to the network analyzer configuration. Provide the
        /// <c>MulticastGroupId</c> of the resource to add in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> MulticastGroupsToAdd
        {
            get { return this._multicastGroupsToAdd; }
            set { this._multicastGroupsToAdd = value; }
        }

        // Check to see if MulticastGroupsToAdd property is set
        internal bool IsSetMulticastGroupsToAdd()
        {
            return this._multicastGroupsToAdd != null && (this._multicastGroupsToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MulticastGroupsToRemove. 
        /// <para>
        /// Multicast group resources to remove from the network analyzer configuration. Provide
        /// the <c>MulticastGroupId</c> of the resources to remove in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> MulticastGroupsToRemove
        {
            get { return this._multicastGroupsToRemove; }
            set { this._multicastGroupsToRemove = value; }
        }

        // Check to see if MulticastGroupsToRemove property is set
        internal bool IsSetMulticastGroupsToRemove()
        {
            return this._multicastGroupsToRemove != null && (this._multicastGroupsToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TraceContent.
        /// </summary>
        public TraceContent TraceContent
        {
            get { return this._traceContent; }
            set { this._traceContent = value; }
        }

        // Check to see if TraceContent property is set
        internal bool IsSetTraceContent()
        {
            return this._traceContent != null;
        }

        /// <summary>
        /// Gets and sets the property WirelessDevicesToAdd. 
        /// <para>
        /// Wireless device resources to add to the network analyzer configuration. Provide the
        /// <c>WirelessDeviceId</c> of the resource to add in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> WirelessDevicesToAdd
        {
            get { return this._wirelessDevicesToAdd; }
            set { this._wirelessDevicesToAdd = value; }
        }

        // Check to see if WirelessDevicesToAdd property is set
        internal bool IsSetWirelessDevicesToAdd()
        {
            return this._wirelessDevicesToAdd != null && (this._wirelessDevicesToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WirelessDevicesToRemove. 
        /// <para>
        /// Wireless device resources to remove from the network analyzer configuration. Provide
        /// the <c>WirelessDeviceId</c> of the resources to remove in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> WirelessDevicesToRemove
        {
            get { return this._wirelessDevicesToRemove; }
            set { this._wirelessDevicesToRemove = value; }
        }

        // Check to see if WirelessDevicesToRemove property is set
        internal bool IsSetWirelessDevicesToRemove()
        {
            return this._wirelessDevicesToRemove != null && (this._wirelessDevicesToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WirelessGatewaysToAdd. 
        /// <para>
        /// Wireless gateway resources to add to the network analyzer configuration. Provide the
        /// <c>WirelessGatewayId</c> of the resource to add in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WirelessGatewaysToAdd
        {
            get { return this._wirelessGatewaysToAdd; }
            set { this._wirelessGatewaysToAdd = value; }
        }

        // Check to see if WirelessGatewaysToAdd property is set
        internal bool IsSetWirelessGatewaysToAdd()
        {
            return this._wirelessGatewaysToAdd != null && (this._wirelessGatewaysToAdd.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WirelessGatewaysToRemove. 
        /// <para>
        /// Wireless gateway resources to remove from the network analyzer configuration. Provide
        /// the <c>WirelessGatewayId</c> of the resources to remove in the input array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WirelessGatewaysToRemove
        {
            get { return this._wirelessGatewaysToRemove; }
            set { this._wirelessGatewaysToRemove = value; }
        }

        // Check to see if WirelessGatewaysToRemove property is set
        internal bool IsSetWirelessGatewaysToRemove()
        {
            return this._wirelessGatewaysToRemove != null && (this._wirelessGatewaysToRemove.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}