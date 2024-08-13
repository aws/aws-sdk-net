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
    /// Contains information summarizing the deployment stage results.
    /// </summary>
    public partial class EdgeDeploymentStatus
    {
        private int? _edgeDeploymentFailedInStage;
        private int? _edgeDeploymentPendingInStage;
        private DateTime? _edgeDeploymentStageStartTime;
        private string _edgeDeploymentStatusMessage;
        private int? _edgeDeploymentSuccessInStage;
        private StageStatus _stageStatus;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentFailedInStage. 
        /// <para>
        /// The number of edge devices that failed the deployment in current stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EdgeDeploymentFailedInStage
        {
            get { return this._edgeDeploymentFailedInStage; }
            set { this._edgeDeploymentFailedInStage = value; }
        }

        // Check to see if EdgeDeploymentFailedInStage property is set
        internal bool IsSetEdgeDeploymentFailedInStage()
        {
            return this._edgeDeploymentFailedInStage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPendingInStage. 
        /// <para>
        /// The number of edge devices yet to pick up the deployment in current stage, or in progress.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EdgeDeploymentPendingInStage
        {
            get { return this._edgeDeploymentPendingInStage; }
            set { this._edgeDeploymentPendingInStage = value; }
        }

        // Check to see if EdgeDeploymentPendingInStage property is set
        internal bool IsSetEdgeDeploymentPendingInStage()
        {
            return this._edgeDeploymentPendingInStage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentStageStartTime. 
        /// <para>
        /// The time when the deployment API started.
        /// </para>
        /// </summary>
        public DateTime? EdgeDeploymentStageStartTime
        {
            get { return this._edgeDeploymentStageStartTime; }
            set { this._edgeDeploymentStageStartTime = value; }
        }

        // Check to see if EdgeDeploymentStageStartTime property is set
        internal bool IsSetEdgeDeploymentStageStartTime()
        {
            return this._edgeDeploymentStageStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentStatusMessage. 
        /// <para>
        /// A detailed message about deployment status in current stage.
        /// </para>
        /// </summary>
        public string EdgeDeploymentStatusMessage
        {
            get { return this._edgeDeploymentStatusMessage; }
            set { this._edgeDeploymentStatusMessage = value; }
        }

        // Check to see if EdgeDeploymentStatusMessage property is set
        internal bool IsSetEdgeDeploymentStatusMessage()
        {
            return this._edgeDeploymentStatusMessage != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentSuccessInStage. 
        /// <para>
        /// The number of edge devices with the successful deployment in the current stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? EdgeDeploymentSuccessInStage
        {
            get { return this._edgeDeploymentSuccessInStage; }
            set { this._edgeDeploymentSuccessInStage = value; }
        }

        // Check to see if EdgeDeploymentSuccessInStage property is set
        internal bool IsSetEdgeDeploymentSuccessInStage()
        {
            return this._edgeDeploymentSuccessInStage.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StageStatus. 
        /// <para>
        /// The general status of the current stage.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StageStatus StageStatus
        {
            get { return this._stageStatus; }
            set { this._stageStatus = value; }
        }

        // Check to see if StageStatus property is set
        internal bool IsSetStageStatus()
        {
            return this._stageStatus != null;
        }

    }
}