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
 * Do not modify this file. This file is generated from the emr-serverless-2021-07-13.normal.json service model.
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
    /// Container for the parameters to the StartJobRun operation.
    /// Starts a job run.
    /// </summary>
    public partial class StartJobRunRequest : AmazonEMRServerlessRequest
    {
        private string _applicationId;
        private string _clientToken;
        private ConfigurationOverrides _configurationOverrides;
        private JobRunExecutionIamPolicy _executionIamPolicy;
        private string _executionRoleArn;
        private long? _executionTimeoutMinutes;
        private JobDriver _jobDriver;
        private JobRunMode _mode;
        private string _name;
        private RetryPolicy _retryPolicy;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property ApplicationId. 
        /// <para>
        /// The ID of the application on which to run the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string ApplicationId
        {
            get { return this._applicationId; }
            set { this._applicationId = value; }
        }

        // Check to see if ApplicationId property is set
        internal bool IsSetApplicationId()
        {
            return this._applicationId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client idempotency token of the job run to start. Its value must be unique for
        /// each request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        /// The configuration overrides for the job run.
        /// </para>
        /// </summary>
        public ConfigurationOverrides ConfigurationOverrides
        {
            get { return this._configurationOverrides; }
            set { this._configurationOverrides = value; }
        }

        // Check to see if ConfigurationOverrides property is set
        internal bool IsSetConfigurationOverrides()
        {
            return this._configurationOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionIamPolicy. 
        /// <para>
        /// You can pass an optional IAM policy. The resulting job IAM role permissions will be
        /// an intersection of this policy and the policy associated with your job execution role.
        /// </para>
        /// </summary>
        public JobRunExecutionIamPolicy ExecutionIamPolicy
        {
            get { return this._executionIamPolicy; }
            set { this._executionIamPolicy = value; }
        }

        // Check to see if ExecutionIamPolicy property is set
        internal bool IsSetExecutionIamPolicy()
        {
            return this._executionIamPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The execution role ARN for the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTimeoutMinutes. 
        /// <para>
        /// The maximum duration for the job run to run. If the job run runs beyond this duration,
        /// it will be automatically cancelled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000000)]
        public long? ExecutionTimeoutMinutes
        {
            get { return this._executionTimeoutMinutes; }
            set { this._executionTimeoutMinutes = value; }
        }

        // Check to see if ExecutionTimeoutMinutes property is set
        internal bool IsSetExecutionTimeoutMinutes()
        {
            return this._executionTimeoutMinutes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobDriver. 
        /// <para>
        /// The job driver for the job run.
        /// </para>
        /// </summary>
        public JobDriver JobDriver
        {
            get { return this._jobDriver; }
            set { this._jobDriver = value; }
        }

        // Check to see if JobDriver property is set
        internal bool IsSetJobDriver()
        {
            return this._jobDriver != null;
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the job run when it starts.
        /// </para>
        /// </summary>
        public JobRunMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The optional job run name. This doesn't have to be unique.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property RetryPolicy. 
        /// <para>
        /// The retry policy when job run starts.
        /// </para>
        /// </summary>
        public RetryPolicy RetryPolicy
        {
            get { return this._retryPolicy; }
            set { this._retryPolicy = value; }
        }

        // Check to see if RetryPolicy property is set
        internal bool IsSetRetryPolicy()
        {
            return this._retryPolicy != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the job run.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}