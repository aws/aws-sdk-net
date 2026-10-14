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
    /// This is the response object from the DescribeDataQualityJobDefinition operation.
    /// </summary>
    public partial class DescribeDataQualityJobDefinitionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time that the data quality monitoring job definition was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DataQualityAppSpecification. 
        /// <para>
        /// Information about the container that runs the data quality monitoring job.
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
        /// The constraints and baselines for the data quality monitoring job definition.
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
        /// The list of inputs for the data quality monitoring job. Currently endpoints are supported.
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
        /// Gets and sets the property JobDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the data quality monitoring job definition.
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
        /// The name of the data quality monitoring job definition.
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
        /// The networking configuration for the data quality monitoring job.
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
    }
}
