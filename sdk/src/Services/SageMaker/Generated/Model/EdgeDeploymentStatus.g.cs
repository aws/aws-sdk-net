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
    /// Contains information summarizing the deployment stage results.
    /// </summary>
    public partial class EdgeDeploymentStatus
    {
        /// <summary>
        /// Gets and sets the property EdgeDeploymentFailedInStage. 
        /// <para>
        /// The number of edge devices that failed the deployment in current stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EdgeDeploymentFailedInStage { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentFailedInStage property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentFailedInStage() => this.EdgeDeploymentFailedInStage.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPendingInStage. 
        /// <para>
        /// The number of edge devices yet to pick up the deployment in current stage, or in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EdgeDeploymentPendingInStage { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentPendingInStage property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentPendingInStage() => this.EdgeDeploymentPendingInStage.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentStageStartTime. 
        /// <para>
        /// The time when the deployment API started.
        /// </para>
        /// </summary>
        public DateTime? EdgeDeploymentStageStartTime { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentStageStartTime property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentStageStartTime() => this.EdgeDeploymentStageStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentStatusMessage. 
        /// <para>
        /// A detailed message about deployment status in current stage.
        /// </para>
        /// </summary>
        public string EdgeDeploymentStatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentStatusMessage property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentStatusMessage() => this.EdgeDeploymentStatusMessage != null;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentSuccessInStage. 
        /// <para>
        /// The number of edge devices with the successful deployment in the current stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? EdgeDeploymentSuccessInStage { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentSuccessInStage property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentSuccessInStage() => this.EdgeDeploymentSuccessInStage.HasValue;

        /// <summary>
        /// Gets and sets the property StageStatus. 
        /// <para>
        /// The general status of the current stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public StageStatus StageStatus { get; set; }

        /// <summary>
        /// Checks to see if the StageStatus property is set.
        /// </summary>
        internal bool IsSetStageStatus() => this.StageStatus != null;
    }
}
