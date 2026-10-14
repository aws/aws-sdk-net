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
    /// Container for the parameters to the CreateModelQualityJobDefinition operation. Creates
    /// a definition for a job that monitors model quality and drift. For information about
    /// model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
    /// SageMaker AI Model Monitor</a>.
    /// </summary>
    public partial class CreateModelQualityJobDefinitionRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the monitoring job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string JobDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the JobDefinitionName property is set.
        /// </summary>
        internal bool IsSetJobDefinitionName() => this.JobDefinitionName != null;

        /// <summary>
        /// Gets and sets the property JobResources.
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoringResources JobResources { get; set; }

        /// <summary>
        /// Checks to see if the JobResources property is set.
        /// </summary>
        internal bool IsSetJobResources() => this.JobResources != null;

        /// <summary>
        /// Gets and sets the property ModelQualityAppSpecification. 
        /// <para>
        /// The container that runs the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelQualityAppSpecification ModelQualityAppSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ModelQualityAppSpecification property is set.
        /// </summary>
        internal bool IsSetModelQualityAppSpecification() => this.ModelQualityAppSpecification != null;

        /// <summary>
        /// Gets and sets the property ModelQualityBaselineConfig. 
        /// <para>
        /// Specifies the constraints and baselines for the monitoring job.
        /// </para>
        /// </summary>
        public ModelQualityBaselineConfig ModelQualityBaselineConfig { get; set; }

        /// <summary>
        /// Checks to see if the ModelQualityBaselineConfig property is set.
        /// </summary>
        internal bool IsSetModelQualityBaselineConfig() => this.ModelQualityBaselineConfig != null;

        /// <summary>
        /// Gets and sets the property ModelQualityJobInput. 
        /// <para>
        /// A list of the inputs that are monitored. Currently endpoints are supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelQualityJobInput ModelQualityJobInput { get; set; }

        /// <summary>
        /// Checks to see if the ModelQualityJobInput property is set.
        /// </summary>
        internal bool IsSetModelQualityJobInput() => this.ModelQualityJobInput != null;

        /// <summary>
        /// Gets and sets the property ModelQualityJobOutputConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoringOutputConfig ModelQualityJobOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the ModelQualityJobOutputConfig property is set.
        /// </summary>
        internal bool IsSetModelQualityJobOutputConfig() => this.ModelQualityJobOutputConfig != null;

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Specifies the network configuration for the monitoring job.
        /// </para>
        /// </summary>
        public MonitoringNetworkConfig NetworkConfig { get; set; }

        /// <summary>
        /// Checks to see if the NetworkConfig property is set.
        /// </summary>
        internal bool IsSetNetworkConfig() => this.NetworkConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon SageMaker AI can assume
        /// to perform tasks on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property StoppingCondition.
        /// </summary>
        public MonitoringStoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// (Optional) An array of key-value pairs. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html#allocation-whatURL">
        /// Using Cost Allocation Tags</a> in the <i>Amazon Web Services Billing and Cost Management
        /// User Guide</i>.
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
