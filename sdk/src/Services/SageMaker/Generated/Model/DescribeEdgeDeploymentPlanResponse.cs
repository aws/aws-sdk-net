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
    /// This is the response object from the DescribeEdgeDeploymentPlan operation.
    /// </summary>
    public partial class DescribeEdgeDeploymentPlanResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _deviceFleetName;
        private int? _edgeDeploymentFailed;
        private int? _edgeDeploymentPending;
        private string _edgeDeploymentPlanArn;
        private string _edgeDeploymentPlanName;
        private int? _edgeDeploymentSuccess;
        private DateTime? _lastModifiedTime;
        private List<EdgeDeploymentModelConfig> _modelConfigs = AWSConfigs.InitializeCollections ? new List<EdgeDeploymentModelConfig>() : null;
        private string _nextToken;
        private List<DeploymentStageStatusSummary> _stages = AWSConfigs.InitializeCollections ? new List<DeploymentStageStatusSummary>() : null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the edge deployment plan was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The device fleet used for this edge deployment plan.
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
        /// Gets and sets the property EdgeDeploymentFailed. 
        /// <para>
        /// The number of edge devices that failed the deployment.
        /// </para>
        /// </summary>
        public int? EdgeDeploymentFailed
        {
            get { return this._edgeDeploymentFailed; }
            set { this._edgeDeploymentFailed = value; }
        }

        // Check to see if EdgeDeploymentFailed property is set
        internal bool IsSetEdgeDeploymentFailed()
        {
            return this._edgeDeploymentFailed.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPending. 
        /// <para>
        /// The number of edge devices yet to pick up deployment, or in progress.
        /// </para>
        /// </summary>
        public int? EdgeDeploymentPending
        {
            get { return this._edgeDeploymentPending; }
            set { this._edgeDeploymentPending = value; }
        }

        // Check to see if EdgeDeploymentPending property is set
        internal bool IsSetEdgeDeploymentPending()
        {
            return this._edgeDeploymentPending.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanArn. 
        /// <para>
        /// The ARN of edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string EdgeDeploymentPlanArn
        {
            get { return this._edgeDeploymentPlanArn; }
            set { this._edgeDeploymentPlanArn = value; }
        }

        // Check to see if EdgeDeploymentPlanArn property is set
        internal bool IsSetEdgeDeploymentPlanArn()
        {
            return this._edgeDeploymentPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanName. 
        /// <para>
        /// The name of the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string EdgeDeploymentPlanName
        {
            get { return this._edgeDeploymentPlanName; }
            set { this._edgeDeploymentPlanName = value; }
        }

        // Check to see if EdgeDeploymentPlanName property is set
        internal bool IsSetEdgeDeploymentPlanName()
        {
            return this._edgeDeploymentPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property EdgeDeploymentSuccess. 
        /// <para>
        /// The number of edge devices with the successful deployment.
        /// </para>
        /// </summary>
        public int? EdgeDeploymentSuccess
        {
            get { return this._edgeDeploymentSuccess; }
            set { this._edgeDeploymentSuccess = value; }
        }

        // Check to see if EdgeDeploymentSuccess property is set
        internal bool IsSetEdgeDeploymentSuccess()
        {
            return this._edgeDeploymentSuccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the edge deployment plan was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelConfigs. 
        /// <para>
        /// List of models associated with the edge deployment plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<EdgeDeploymentModelConfig> ModelConfigs
        {
            get { return this._modelConfigs; }
            set { this._modelConfigs = value; }
        }

        // Check to see if ModelConfigs property is set
        internal bool IsSetModelConfigs()
        {
            return this._modelConfigs != null && (this._modelConfigs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token to use when calling the next set of stages in the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// List of stages in the edge deployment plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<DeploymentStageStatusSummary> Stages
        {
            get { return this._stages; }
            set { this._stages = value; }
        }

        // Check to see if Stages property is set
        internal bool IsSetStages()
        {
            return this._stages != null && (this._stages.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}