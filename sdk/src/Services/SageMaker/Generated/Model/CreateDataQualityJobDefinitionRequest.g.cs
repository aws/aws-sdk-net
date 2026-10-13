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
    /// Container for the parameters to the CreateDataQualityJobDefinition operation. Creates
    /// a definition for a job that monitors data quality and drift. For information about
    /// model monitor, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/model-monitor.html">Amazon
    /// SageMaker AI Model Monitor</a>.
    /// </summary>
    public partial class CreateDataQualityJobDefinitionRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property DataQualityAppSpecification. 
        /// <para>
        /// Specifies the container that runs the monitoring job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataQualityAppSpecification DataQualityAppSpecification { get; set; }

        /// <summary>
        /// Checks to see if the DataQualityAppSpecification property is set.
        /// </summary>
        internal bool IsSetDataQualityAppSpecification() => this.DataQualityAppSpecification != null;

        /// <summary>
        /// Gets and sets the property DataQualityBaselineConfig. 
        /// <para>
        /// Configures the constraints and baselines for the monitoring job.
        /// </para>
        /// </summary>
        public DataQualityBaselineConfig DataQualityBaselineConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataQualityBaselineConfig property is set.
        /// </summary>
        internal bool IsSetDataQualityBaselineConfig() => this.DataQualityBaselineConfig != null;

        /// <summary>
        /// Gets and sets the property DataQualityJobInput. 
        /// <para>
        /// A list of inputs for the monitoring job. Currently endpoints are supported as monitoring
        /// inputs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DataQualityJobInput DataQualityJobInput { get; set; }

        /// <summary>
        /// Checks to see if the DataQualityJobInput property is set.
        /// </summary>
        internal bool IsSetDataQualityJobInput() => this.DataQualityJobInput != null;

        /// <summary>
        /// Gets and sets the property DataQualityJobOutputConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoringOutputConfig DataQualityJobOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the DataQualityJobOutputConfig property is set.
        /// </summary>
        internal bool IsSetDataQualityJobOutputConfig() => this.DataQualityJobOutputConfig != null;

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name for the monitoring job definition.
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
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Specifies networking configuration for the monitoring job.
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
