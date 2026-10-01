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

namespace Amazon.SagemakerEdgeManager.Model
{
    /// <summary>
    /// Container for the parameters to the SendHeartbeat operation. Use to get the current
    /// status of devices registered on SageMaker Edge Manager.
    /// </summary>
    public partial class SendHeartbeatRequest : AmazonSagemakerEdgeManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AgentMetrics. 
        /// <para>
        /// For internal use. Returns a list of SageMaker Edge Manager agent operating metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeMetric> AgentMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<EdgeMetric>() : null;

        /// <summary>
        /// Checks to see if the AgentMetrics property is set.
        /// </summary>
        internal bool IsSetAgentMetrics() => this.AgentMetrics != null && (this.AgentMetrics.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// Returns the version of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string AgentVersion { get; set; }

        /// <summary>
        /// Checks to see if the AgentVersion property is set.
        /// </summary>
        internal bool IsSetAgentVersion() => this.AgentVersion != null;

        /// <summary>
        /// Gets and sets the property DeploymentResult. 
        /// <para>
        /// Returns the result of a deployment on the device.
        /// </para>
        /// </summary>
        public DeploymentResult DeploymentResult { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentResult property is set.
        /// </summary>
        internal bool IsSetDeploymentResult() => this.DeploymentResult != null;

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet that the device belongs to.
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
        /// The unique name of the device.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DeviceName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceName property is set.
        /// </summary>
        internal bool IsSetDeviceName() => this.DeviceName != null;

        /// <summary>
        /// Gets and sets the property Models. 
        /// <para>
        /// Returns a list of models deployed on the the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Model> Models { get; set; } = AWSConfigs.InitializeCollections ? new List<Model>() : null;

        /// <summary>
        /// Checks to see if the Models property is set.
        /// </summary>
        internal bool IsSetModels() => this.Models != null && (this.Models.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
