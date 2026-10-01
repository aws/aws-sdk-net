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

namespace Amazon.EMRServerless.Model
{
    /// <summary>
    /// Container for the parameters to the StartJobRun operation. Starts a job run.
    /// </summary>
    public partial class StartJobRunRequest : AmazonEMRServerlessRequest
    {
        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application on which to run the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string ApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationId property is set.
        /// </summary>
        internal bool IsSetApplicationId() => this.ApplicationId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client idempotency token of the job run to start. Its value must be unique for
        /// each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        /// The configuration overrides for the job run.
        /// </para>
        /// </summary>
        public ConfigurationOverrides ConfigurationOverrides { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationOverrides property is set.
        /// </summary>
        internal bool IsSetConfigurationOverrides() => this.ConfigurationOverrides != null;

        /// <summary>
        /// Gets and sets the property ExecutionIamPolicy. 
        /// <para>
        /// You can pass an optional IAM policy. The resulting job IAM role permissions will be
        /// an intersection of this policy and the policy associated with your job execution role.
        /// </para>
        /// </summary>
        public JobRunExecutionIamPolicy ExecutionIamPolicy { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionIamPolicy property is set.
        /// </summary>
        internal bool IsSetExecutionIamPolicy() => this.ExecutionIamPolicy != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The execution role ARN for the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property ExecutionTimeoutMinutes. 
        /// <para>
        /// The maximum duration for the job run to run. If the job run runs beyond this duration,
        /// it will be automatically cancelled.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1000000)]
        public long? ExecutionTimeoutMinutes { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionTimeoutMinutes property is set.
        /// </summary>
        internal bool IsSetExecutionTimeoutMinutes() => this.ExecutionTimeoutMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property JobDriver. 
        /// <para>
        /// The job driver for the job run.
        /// </para>
        /// </summary>
        public JobDriver JobDriver { get; set; }

        /// <summary>
        /// Checks to see if the JobDriver property is set.
        /// </summary>
        internal bool IsSetJobDriver() => this.JobDriver != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the job run when it starts.
        /// </para>
        /// </summary>
        public JobRunMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The optional job run name. This doesn't have to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property RetryPolicy. 
        /// <para>
        /// The retry policy when job run starts.
        /// </para>
        /// </summary>
        public RetryPolicy RetryPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RetryPolicy property is set.
        /// </summary>
        internal bool IsSetRetryPolicy() => this.RetryPolicy != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the job run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
