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
    /// Container for the parameters to the CreateEdgeDeploymentPlan operation. Creates an
    /// edge deployment plan, consisting of multiple stages. Each stage may have a different
    /// deployment configuration and devices.
    /// </summary>
    public partial class CreateEdgeDeploymentPlanRequest : AmazonSageMakerRequest
    {
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
        /// Gets and sets the property Stages. 
        /// <para>
        /// List of stages of the edge deployment plan. The number of stages is limited to 10
        /// per deployment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DeploymentStage> Stages { get; set; } = AWSConfigs.InitializeCollections ? new List<DeploymentStage>() : null;

        /// <summary>
        /// Checks to see if the Stages property is set.
        /// </summary>
        internal bool IsSetStages() => this.Stages != null && (this.Stages.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// List of tags with which to tag the edge deployment plan.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
