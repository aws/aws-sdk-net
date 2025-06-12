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
 * Do not modify this file. This file is generated from the sagemaker-edge-2020-09-23.normal.json service model.
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
    /// Container for the parameters to the SendHeartbeat operation.
    /// Use to get the current status of devices registered on SageMaker Edge Manager.
    /// </summary>
    public partial class SendHeartbeatRequest : AmazonSagemakerEdgeManagerRequest
    {
        private List<EdgeMetric> _agentMetrics = AWSConfigs.InitializeCollections ? new List<EdgeMetric>() : null;
        private string _agentVersion;
        private DeploymentResult _deploymentResult;
        private string _deviceFleetName;
        private string _deviceName;
        private List<Model> _models = AWSConfigs.InitializeCollections ? new List<Model>() : null;

        /// <summary>
        /// Gets and sets the property AgentMetrics. 
        /// <para>
        /// For internal use. Returns a list of SageMaker Edge Manager agent operating metrics.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EdgeMetric> AgentMetrics
        {
            get { return this._agentMetrics; }
            set { this._agentMetrics = value; }
        }

        // Check to see if AgentMetrics property is set
        internal bool IsSetAgentMetrics()
        {
            return this._agentMetrics != null && (this._agentMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AgentVersion. 
        /// <para>
        /// Returns the version of the agent.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
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
        /// Gets and sets the property DeploymentResult. 
        /// <para>
        /// Returns the result of a deployment on the device.
        /// </para>
        /// </summary>
        public DeploymentResult DeploymentResult
        {
            get { return this._deploymentResult; }
            set { this._deploymentResult = value; }
        }

        // Check to see if DeploymentResult property is set
        internal bool IsSetDeploymentResult()
        {
            return this._deploymentResult != null;
        }

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The name of the fleet that the device belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// The unique name of the device.
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
        /// Gets and sets the property Models. 
        /// <para>
        /// Returns a list of models deployed on the the device.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Model> Models
        {
            get { return this._models; }
            set { this._models = value; }
        }

        // Check to see if Models property is set
        internal bool IsSetModels()
        {
            return this._models != null && (this._models.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}