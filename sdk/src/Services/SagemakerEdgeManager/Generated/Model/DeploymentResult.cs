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
    /// Information about the result of a deployment on an edge device that is registered
    /// with SageMaker Edge Manager.
    /// </summary>
    public partial class DeploymentResult
    {
        private DateTime? _deploymentEndTime;
        private List<DeploymentModel> _deploymentModels = AWSConfigs.InitializeCollections ? new List<DeploymentModel>() : null;
        private string _deploymentName;
        private DateTime? _deploymentStartTime;
        private string _deploymentStatus;
        private string _deploymentStatusMessage;

        /// <summary>
        /// Gets and sets the property DeploymentEndTime. 
        /// <para>
        /// The timestamp of when the deployment was ended, and the agent got the deployment results.
        /// </para>
        /// </summary>
        public DateTime? DeploymentEndTime
        {
            get { return this._deploymentEndTime; }
            set { this._deploymentEndTime = value; }
        }

        // Check to see if DeploymentEndTime property is set
        internal bool IsSetDeploymentEndTime()
        {
            return this._deploymentEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentModels. 
        /// <para>
        /// Returns a list of models deployed on the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeploymentModel> DeploymentModels
        {
            get { return this._deploymentModels; }
            set { this._deploymentModels = value; }
        }

        // Check to see if DeploymentModels property is set
        internal bool IsSetDeploymentModels()
        {
            return this._deploymentModels != null && (this._deploymentModels.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property DeploymentName. 
        /// <para>
        /// The name and unique ID of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DeploymentName
        {
            get { return this._deploymentName; }
            set { this._deploymentName = value; }
        }

        // Check to see if DeploymentName property is set
        internal bool IsSetDeploymentName()
        {
            return this._deploymentName != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStartTime. 
        /// <para>
        /// The timestamp of when the deployment was started on the agent.
        /// </para>
        /// </summary>
        public DateTime? DeploymentStartTime
        {
            get { return this._deploymentStartTime; }
            set { this._deploymentStartTime = value; }
        }

        // Check to see if DeploymentStartTime property is set
        internal bool IsSetDeploymentStartTime()
        {
            return this._deploymentStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// Returns the bucket error code.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string DeploymentStatus
        {
            get { return this._deploymentStatus; }
            set { this._deploymentStatus = value; }
        }

        // Check to see if DeploymentStatus property is set
        internal bool IsSetDeploymentStatus()
        {
            return this._deploymentStatus != null;
        }

        /// <summary>
        /// Gets and sets the property DeploymentStatusMessage. 
        /// <para>
        /// Returns the detailed error message.
        /// </para>
        /// </summary>
        public string DeploymentStatusMessage
        {
            get { return this._deploymentStatusMessage; }
            set { this._deploymentStatusMessage = value; }
        }

        // Check to see if DeploymentStatusMessage property is set
        internal bool IsSetDeploymentStatusMessage()
        {
            return this._deploymentStatusMessage != null;
        }

    }
}