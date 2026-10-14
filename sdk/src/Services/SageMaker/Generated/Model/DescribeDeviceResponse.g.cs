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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeDevice operation.
    /// </summary>
    public partial class DescribeDeviceResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// Edge Manager agent version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 30)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 40)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DeviceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DeviceArn { get; set; }

        /// <summary>
        /// Checks to see if the DeviceArn property is set.
        /// </summary>
        internal bool IsSetDeviceArn() => this.DeviceArn != null;

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet the device belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DeviceFleetName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceFleetName property is set.
        /// </summary>
        internal bool IsSetDeviceFleetName() => this.DeviceFleetName != null;

        /// <summary>
        /// Gets and sets the property DeviceName. 
        /// <para>
        /// The unique identifier of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property IotThingName. 
        /// <para>
        /// The Amazon Web Services Internet of Things (IoT) object thing name associated with
        /// the device.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string IotThingName { get; set; }

        /// <summary>
        /// Checks to see if the IotThingName property is set.
        /// </summary>
        internal bool IsSetIotThingName() => this.IotThingName != null;

        /// <summary>
        /// Gets and sets the property LatestHeartbeat. 
        /// <para>
        /// The last heartbeat received from the device.
        /// </para>
        /// </summary>
        public DateTime? LatestHeartbeat { get; set; }

        /// <summary>
        /// Checks to see if the LatestHeartbeat property is set.
        /// </summary>
        internal bool IsSetLatestHeartbeat() => this.LatestHeartbeat.HasValue;

        /// <summary>
        /// Gets and sets the property MaxModels. 
        /// <para>
        /// The maximum number of models.
        /// </para>
        /// </summary>
        public int? MaxModels { get; set; }

        /// <summary>
        /// Checks to see if the MaxModels property is set.
        /// </summary>
        internal bool IsSetMaxModels() => this.MaxModels.HasValue;

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// Models on the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeModel> Models { get; set; } = AWSConfigs.InitializeCollections ? new List<EdgeModel>() : null;

        /// <summary>
        /// Checks to see if the Models property is set.
        /// </summary>
        internal bool IsSetModels() => this.Models != null && (this.Models.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The response from the last list when returning a list large enough to need tokening.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property RegistrationTime. 
        /// <para>
        /// The timestamp of the last registration or de-reregistration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? RegistrationTime { get; set; }

        /// <summary>
        /// Checks to see if the RegistrationTime property is set.
        /// </summary>
        internal bool IsSetRegistrationTime() => this.RegistrationTime.HasValue;
    }
}
