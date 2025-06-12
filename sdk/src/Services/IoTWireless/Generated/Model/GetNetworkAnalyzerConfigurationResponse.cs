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
    /// This is the response object from the GetNetworkAnalyzerConfiguration operation.
    /// </summary>
    public partial class GetNetworkAnalyzerConfigurationResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _description;
        private List<string> _multicastGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _name;
        private TraceContent _traceContent;
        private List<string> _wirelessDevices = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _wirelessGateways = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name of the new resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1124)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
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
        /// Gets and sets the property MulticastGroups. 
        /// <para>
        /// List of multicast group resources that have been added to the network analyzer configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<string> MulticastGroups
        {
            get { return this._multicastGroups; }
            set { this._multicastGroups = value; }
        }

        // Check to see if MulticastGroups property is set
        internal bool IsSetMulticastGroups()
        {
            return this._multicastGroups != null && (this._multicastGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name.
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
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
        /// Gets and sets the property WirelessDevices. 
        /// <para>
        /// List of wireless device resources that have been added to the network analyzer configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=250)]
        public List<string> WirelessDevices
        {
            get { return this._wirelessDevices; }
            set { this._wirelessDevices = value; }
        }

        // Check to see if WirelessDevices property is set
        internal bool IsSetWirelessDevices()
        {
            return this._wirelessDevices != null && (this._wirelessDevices.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WirelessGateways. 
        /// <para>
        /// List of wireless gateway resources that have been added to the network analyzer configuration.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> WirelessGateways
        {
            get { return this._wirelessGateways; }
            set { this._wirelessGateways = value; }
        }

        // Check to see if WirelessGateways property is set
        internal bool IsSetWirelessGateways()
        {
            return this._wirelessGateways != null && (this._wirelessGateways.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}