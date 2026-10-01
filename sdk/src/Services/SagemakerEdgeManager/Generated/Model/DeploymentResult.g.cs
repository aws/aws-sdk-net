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
    /// Information about the result of a deployment on an edge device that is registered
    /// with SageMaker Edge Manager.
    /// </summary>
    public partial class DeploymentResult
    {
        /// <summary>
        /// Gets and sets the property DeploymentEndTime. 
        /// <para>
        /// The timestamp of when the deployment was ended, and the agent got the deployment results.
        /// </para>
        /// </summary>
        public DateTime? DeploymentEndTime { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentEndTime property is set.
        /// </summary>
        internal bool IsSetDeploymentEndTime() => this.DeploymentEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentModels. 
        /// <para>
        /// Returns a list of models deployed on the agent.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeploymentModel> DeploymentModels { get; set; } = AWSConfigs.InitializeCollections ? new List<DeploymentModel>() : null;

        /// <summary>
        /// Checks to see if the DeploymentModels property is set.
        /// </summary>
        internal bool IsSetDeploymentModels() => this.DeploymentModels != null && (this.DeploymentModels.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DeploymentName. 
        /// <para>
        /// The name and unique ID of the deployment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DeploymentName { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentName property is set.
        /// </summary>
        internal bool IsSetDeploymentName() => this.DeploymentName != null;

        /// <summary>
        /// Gets and sets the property DeploymentStartTime. 
        /// <para>
        /// The timestamp of when the deployment was started on the agent.
        /// </para>
        /// </summary>
        public DateTime? DeploymentStartTime { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStartTime property is set.
        /// </summary>
        internal bool IsSetDeploymentStartTime() => this.DeploymentStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeploymentStatus. 
        /// <para>
        /// Returns the bucket error code.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string DeploymentStatus { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatus property is set.
        /// </summary>
        internal bool IsSetDeploymentStatus() => this.DeploymentStatus != null;

        /// <summary>
        /// Gets and sets the property DeploymentStatusMessage. 
        /// <para>
        /// Returns the detailed error message.
        /// </para>
        /// </summary>
        public string DeploymentStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentStatusMessage property is set.
        /// </summary>
        internal bool IsSetDeploymentStatusMessage() => this.DeploymentStatusMessage != null;
    }
}
