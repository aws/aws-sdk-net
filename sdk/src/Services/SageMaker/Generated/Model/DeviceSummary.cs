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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Summary of the device.
    /// </summary>
    public partial class DeviceSummary
    {
        private string _agentVersion;
        private string _description;
        private string _deviceArn;
        private string _deviceFleetName;
        private string _deviceName;
        private string _iotThingName;
        private DateTime? _latestHeartbeat;
        private List<EdgeModelSummary> _models = AWSConfigs.InitializeCollections ? new List<EdgeModelSummary>() : null;
        private DateTime? _registrationTime;

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// Edge Manager agent version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=30)]
        public string AgentVersion
        {
            get { return this._agentVersion; }
            set { this._agentVersion = value; }
        }

        // Check to see if AgentVersion property is set
        internal bool IsSetAgentVersion()
        {
            return this._agentVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
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
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string DeviceArn
        {
            get { return this._deviceArn; }
            set { this._deviceArn = value; }
        }

        // Check to see if DeviceArn property is set
        internal bool IsSetDeviceArn()
        {
            return this._deviceArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet the device belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DeviceFleetName
        {
            get { return this._deviceFleetName; }
            set { this._deviceFleetName = value; }
        }

        // Check to see if DeviceFleetName property is set
        internal bool IsSetDeviceFleetName()
        {
            return this._deviceFleetName != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The unique identifier of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string DeviceName
        {
            get { return this._deviceName; }
            set { this._deviceName = value; }
        }

        // Check to see if DeviceName property is set
        internal bool IsSetDeviceName()
        {
            return this._deviceName != null;
        }

        /// <summary>
        /// Gets and sets the property IotThingName. 
        /// <para>
        /// The Amazon Web Services Internet of Things (IoT) object thing name associated with
        /// the device..
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string IotThingName
        {
            get { return this._iotThingName; }
            set { this._iotThingName = value; }
        }

        // Check to see if IotThingName property is set
        internal bool IsSetIotThingName()
        {
            return this._iotThingName != null;
        }

        /// <summary>
        /// Gets and sets the property LatestHeartbeat. 
        /// <para>
        /// The last heartbeat received from the device.
        /// </para>
        /// </summary>
        public DateTime? LatestHeartbeat
        {
            get { return this._latestHeartbeat; }
            set { this._latestHeartbeat = value; }
        }

        // Check to see if LatestHeartbeat property is set
        internal bool IsSetLatestHeartbeat()
        {
            return this._latestHeartbeat.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// Models on the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeModelSummary> Models
        {
            get { return this._models; }
            set { this._models = value; }
        }

        // Check to see if Models property is set
        internal bool IsSetModels()
        {
            return this._models != null && (this._models.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RegistrationTime. 
        /// <para>
        /// The timestamp of the last registration or de-reregistration.
        /// </para>
        /// </summary>
        public DateTime? RegistrationTime
        {
            get { return this._registrationTime; }
            set { this._registrationTime = value; }
        }

        // Check to see if RegistrationTime property is set
        internal bool IsSetRegistrationTime()
        {
            return this._registrationTime.HasValue; 
        }

    }
}