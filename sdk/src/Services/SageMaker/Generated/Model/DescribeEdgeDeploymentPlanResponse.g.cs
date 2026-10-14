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
    /// This is the response object from the DescribeEdgeDeploymentPlan operation.
    /// </summary>
    public partial class DescribeEdgeDeploymentPlanResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time when the edge deployment plan was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceFleetName. 
        /// <para>
        /// The device fleet used for this edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string DeviceFleetName { get; set; }

        /// <summary>
        /// Checks to see if the DeviceFleetName property is set.
        /// </summary>
        internal bool IsSetDeviceFleetName() => this.DeviceFleetName != null;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentFailed. 
        /// <para>
        /// The number of edge devices that failed the deployment.
        /// </para>
        /// </summary>
        public int? EdgeDeploymentFailed { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentFailed property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentFailed() => this.EdgeDeploymentFailed.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPending. 
        /// <para>
        /// The number of edge devices yet to pick up deployment, or in progress.
        /// </para>
        /// </summary>
        public int? EdgeDeploymentPending { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentPending property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentPending() => this.EdgeDeploymentPending.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanArn. 
        /// <para>
        /// The ARN of edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string EdgeDeploymentPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentPlanArn property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentPlanArn() => this.EdgeDeploymentPlanArn != null;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentPlanName. 
        /// <para>
        /// The name of the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string EdgeDeploymentPlanName { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentPlanName property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentPlanName() => this.EdgeDeploymentPlanName != null;

        /// <summary>
        /// Gets and sets the property EdgeDeploymentSuccess. 
        /// <para>
        /// The number of edge devices with the successful deployment.
        /// </para>
        /// </summary>
        public int? EdgeDeploymentSuccess { get; set; }

        /// <summary>
        /// Checks to see if the EdgeDeploymentSuccess property is set.
        /// </summary>
        internal bool IsSetEdgeDeploymentSuccess() => this.EdgeDeploymentSuccess.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The time when the edge deployment plan was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelConfigs. 
        /// <para>
        /// List of models associated with the edge deployment plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<EdgeDeploymentModelConfig> ModelConfigs { get; set; } = AWSConfigs.InitializeCollections ? new List<EdgeDeploymentModelConfig>() : null;

        /// <summary>
        /// Checks to see if the ModelConfigs property is set.
        /// </summary>
        internal bool IsSetModelConfigs() => this.ModelConfigs != null && (this.ModelConfigs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token to use when calling the next set of stages in the edge deployment plan.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Stages. 
        /// <para>
        /// List of stages in the edge deployment plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<DeploymentStageStatusSummary> Stages { get; set; } = AWSConfigs.InitializeCollections ? new List<DeploymentStageStatusSummary>() : null;

        /// <summary>
        /// Checks to see if the Stages property is set.
        /// </summary>
        internal bool IsSetStages() => this.Stages != null && (this.Stages.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
