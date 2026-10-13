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
    /// This is the response object from the DescribeModelBiasJobDefinition operation.
    /// </summary>
    public partial class DescribeModelBiasJobDefinitionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the model bias job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property JobDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model bias job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string JobDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the JobDefinitionArn property is set.
        /// </summary>
        internal bool IsSetJobDefinitionArn() => this.JobDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the bias job definition. The name must be unique within an Amazon Web
        /// Services Region in the Amazon Web Services account.
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
        /// Gets and sets the property ModelBiasAppSpecification. 
        /// <para>
        /// Configures the model bias job to run a specified Docker container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelBiasAppSpecification ModelBiasAppSpecification { get; set; }

        /// <summary>
        /// Checks to see if the ModelBiasAppSpecification property is set.
        /// </summary>
        internal bool IsSetModelBiasAppSpecification() => this.ModelBiasAppSpecification != null;

        /// <summary>
        /// Gets and sets the property ModelBiasBaselineConfig. 
        /// <para>
        /// The baseline configuration for a model bias job.
        /// </para>
        /// </summary>
        public ModelBiasBaselineConfig ModelBiasBaselineConfig { get; set; }

        /// <summary>
        /// Checks to see if the ModelBiasBaselineConfig property is set.
        /// </summary>
        internal bool IsSetModelBiasBaselineConfig() => this.ModelBiasBaselineConfig != null;

        /// <summary>
        /// Gets and sets the property ModelBiasJobInput. 
        /// <para>
        /// Inputs for the model bias job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelBiasJobInput ModelBiasJobInput { get; set; }

        /// <summary>
        /// Checks to see if the ModelBiasJobInput property is set.
        /// </summary>
        internal bool IsSetModelBiasJobInput() => this.ModelBiasJobInput != null;

        /// <summary>
        /// Gets and sets the property ModelBiasJobOutputConfig.
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoringOutputConfig ModelBiasJobOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the ModelBiasJobOutputConfig property is set.
        /// </summary>
        internal bool IsSetModelBiasJobOutputConfig() => this.ModelBiasJobOutputConfig != null;

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Networking options for a model bias job.
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
        /// The Amazon Resource Name (ARN) of the IAM role that has read permission to the input
        /// data location and write permission to the output data location in Amazon S3.
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
    }
}
