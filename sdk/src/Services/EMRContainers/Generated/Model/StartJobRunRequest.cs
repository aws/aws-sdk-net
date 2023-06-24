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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the StartJobRun operation.
    /// Starts a job run. A job run is a unit of work, such as a Spark jar, PySpark script,
    /// or SparkSQL query, that you submit to Amazon EMR on EKS.
    /// </summary>
    public partial class StartJobRunRequest : AmazonEMRContainersRequest
    {
        private string _clientToken;
        private ConfigurationOverrides _configurationOverrides;
        private string _executionRoleArn;
        private JobDriver _jobDriver;
        private string _jobTemplateId;
        private Dictionary<string, string> _jobTemplateParameters = new Dictionary<string, string>();
        private string _name;
        private string _releaseLabel;
        private RetryPolicyConfiguration _retryPolicyConfiguration;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _virtualClusterId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client idempotency token of the job run request. 
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
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The execution role ARN for the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property JobTemplateId. 
        /// <para>
        /// The job template ID to be used to start the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string JobTemplateId
        {
            get { return this._jobTemplateId; }
            set { this._jobTemplateId = value; }
        }

        // Check to see if JobTemplateId property is set
        internal bool IsSetJobTemplateId()
        {
            return this._jobTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property JobTemplateParameters. 
        /// <para>
        /// The values of job template parameters to start a job run.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20)]
        public Dictionary<string, string> JobTemplateParameters
        {
            get { return this._jobTemplateParameters; }
            set { this._jobTemplateParameters = value; }
        }

        // Check to see if JobTemplateParameters property is set
        internal bool IsSetJobTemplateParameters()
        {
            return this._jobTemplateParameters != null && this._jobTemplateParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The Amazon EMR release version to use for the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

        /// <summary>
        /// Gets and sets the property RetryPolicyConfiguration. 
        /// <para>
        /// The retry policy configuration for the job run.
        /// </para>
        /// </summary>
        public RetryPolicyConfiguration RetryPolicyConfiguration
        {
            get { return this._retryPolicyConfiguration; }
            set { this._retryPolicyConfiguration = value; }
        }

        // Check to see if RetryPolicyConfiguration property is set
        internal bool IsSetRetryPolicyConfiguration()
        {
            return this._retryPolicyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to job runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VirtualClusterId. 
        /// <para>
        /// The virtual cluster ID for which the job run request is submitted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string VirtualClusterId
        {
            get { return this._virtualClusterId; }
            set { this._virtualClusterId = value; }
        }

        // Check to see if VirtualClusterId property is set
        internal bool IsSetVirtualClusterId()
        {
            return this._virtualClusterId != null;
        }

    }
}