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
    /// Defines the monitoring job.
    /// </summary>
    public partial class MonitoringJobDefinition
    {
        /// <summary>
        /// Gets and sets the property BaselineConfig. 
        /// <para>
        /// Baseline configuration used to validate that the data conforms to the specified constraints
        /// and statistics
        /// </para>
        /// </summary>
        public MonitoringBaselineConfig BaselineConfig { get; set; }

        /// <summary>
        /// Checks to see if the BaselineConfig property is set.
        /// </summary>
        internal bool IsSetBaselineConfig() => this.BaselineConfig != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// Sets the environment variables in the Docker container.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Environment { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null && (this.Environment.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MonitoringAppSpecification. 
        /// <para>
        /// Configures the monitoring job to run a specified Docker container image.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoringAppSpecification MonitoringAppSpecification { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringAppSpecification property is set.
        /// </summary>
        internal bool IsSetMonitoringAppSpecification() => this.MonitoringAppSpecification != null;

        /// <summary>
        /// Gets and sets the property MonitoringInputs. 
        /// <para>
        /// The array of inputs for the monitoring job. Currently we support monitoring an Amazon
        /// SageMaker AI Endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1)]
        public List<MonitoringInput> MonitoringInputs { get; set; } = AWSConfigs.InitializeCollections ? new List<MonitoringInput>() : null;

        /// <summary>
        /// Checks to see if the MonitoringInputs property is set.
        /// </summary>
        internal bool IsSetMonitoringInputs() => this.MonitoringInputs != null && (this.MonitoringInputs.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property MonitoringOutputConfig. 
        /// <para>
        /// The array of outputs from the monitoring job to be uploaded to Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoringOutputConfig MonitoringOutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringOutputConfig property is set.
        /// </summary>
        internal bool IsSetMonitoringOutputConfig() => this.MonitoringOutputConfig != null;

        /// <summary>
        /// Gets and sets the property MonitoringResources. 
        /// <para>
        /// Identifies the resources, ML compute instances, and ML storage volumes to deploy for
        /// a monitoring job. In distributed processing, you specify more than one instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public MonitoringResources MonitoringResources { get; set; }

        /// <summary>
        /// Checks to see if the MonitoringResources property is set.
        /// </summary>
        internal bool IsSetMonitoringResources() => this.MonitoringResources != null;

        /// <summary>
        /// Gets and sets the property NetworkConfig. 
        /// <para>
        /// Specifies networking options for an monitoring job.
        /// </para>
        /// </summary>
        public NetworkConfig NetworkConfig { get; set; }

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
        /// <para>
        /// Specifies a time limit for how long the monitoring job is allowed to run.
        /// </para>
        /// </summary>
        public MonitoringStoppingCondition StoppingCondition { get; set; }

        /// <summary>
        /// Checks to see if the StoppingCondition property is set.
        /// </summary>
        internal bool IsSetStoppingCondition() => this.StoppingCondition != null;
    }
}
