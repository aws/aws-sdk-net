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
 * Do not modify this file. This file is generated from the batch-2016-08-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterJobDefinition operation.
    /// Registers an AWS Batch job definition.
    /// </summary>
    public partial class RegisterJobDefinitionRequest : AmazonBatchRequest
    {
        private ContainerProperties _containerProperties;
        private string _jobDefinitionName;
        private NodeProperties _nodeProperties;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private List<string> _platformCapabilities = new List<string>();
        private bool? _propagateTags;
        private RetryStrategy _retryStrategy;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private JobTimeout _timeout;
        private JobDefinitionType _type;

        /// <summary>
        /// Gets and sets the property ContainerProperties. 
        /// <para>
        /// An object with various properties specific to single-node container-based jobs. If
        /// the job definition's <code>type</code> parameter is <code>container</code>, then you
        /// must specify either <code>containerProperties</code> or <code>nodeProperties</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the job runs on Fargate resources, then you must not specify <code>nodeProperties</code>;
        /// use only <code>containerProperties</code>.
        /// </para>
        ///  </note>
        /// </summary>
        public ContainerProperties ContainerProperties
        {
            get { return this._containerProperties; }
            set { this._containerProperties = value; }
        }

        // Check to see if ContainerProperties property is set
        internal bool IsSetContainerProperties()
        {
            return this._containerProperties != null;
        }

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the job definition to register. Up to 128 letters (uppercase and lowercase),
        /// numbers, hyphens, and underscores are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobDefinitionName
        {
            get { return this._jobDefinitionName; }
            set { this._jobDefinitionName = value; }
        }

        // Check to see if JobDefinitionName property is set
        internal bool IsSetJobDefinitionName()
        {
            return this._jobDefinitionName != null;
        }

        /// <summary>
        /// Gets and sets the property NodeProperties. 
        /// <para>
        /// An object with various properties specific to multi-node parallel jobs. If you specify
        /// node properties for a job, it becomes a multi-node parallel job. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/multi-node-parallel-jobs.html">Multi-node
        /// Parallel Jobs</a> in the <i>AWS Batch User Guide</i>. If the job definition's <code>type</code>
        /// parameter is <code>container</code>, then you must specify either <code>containerProperties</code>
        /// or <code>nodeProperties</code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the job runs on Fargate resources, then you must not specify <code>nodeProperties</code>;
        /// use <code>containerProperties</code> instead.
        /// </para>
        ///  </note>
        /// </summary>
        public NodeProperties NodeProperties
        {
            get { return this._nodeProperties; }
            set { this._nodeProperties = value; }
        }

        // Check to see if NodeProperties property is set
        internal bool IsSetNodeProperties()
        {
            return this._nodeProperties != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Default parameter substitution placeholders to set in the job definition. Parameters
        /// are specified as a key-value pair mapping. Parameters in a <code>SubmitJob</code>
        /// request override any corresponding parameter defaults from the job definition.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && this._parameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlatformCapabilities. 
        /// <para>
        /// The platform capabilities required by the job definition. If no value is specified,
        /// it defaults to <code>EC2</code>. To run the job on Fargate resources, specify <code>FARGATE</code>.
        /// </para>
        /// </summary>
        public List<string> PlatformCapabilities
        {
            get { return this._platformCapabilities; }
            set { this._platformCapabilities = value; }
        }

        // Check to see if PlatformCapabilities property is set
        internal bool IsSetPlatformCapabilities()
        {
            return this._platformCapabilities != null && this._platformCapabilities.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the job or job definition to the corresponding
        /// Amazon ECS task. If no value is specified, the tags are not propagated. Tags can only
        /// be propagated to the tasks during task creation. For tags with the same name, job
        /// tags are given priority over job definitions tags. If the total number of combined
        /// tags from the job and job definition is over 50, the job is moved to the <code>FAILED</code>
        /// state.
        /// </para>
        /// </summary>
        public bool PropagateTags
        {
            get { return this._propagateTags.GetValueOrDefault(); }
            set { this._propagateTags = value; }
        }

        // Check to see if PropagateTags property is set
        internal bool IsSetPropagateTags()
        {
            return this._propagateTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for failed jobs that are submitted with this job definition.
        /// Any retry strategy that's specified during a <a>SubmitJob</a> operation overrides
        /// the retry strategy defined here. If a job is terminated due to a timeout, it isn't
        /// retried.
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy
        {
            get { return this._retryStrategy; }
            set { this._retryStrategy = value; }
        }

        // Check to see if RetryStrategy property is set
        internal bool IsSetRetryStrategy()
        {
            return this._retryStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the job definition to help you categorize and organize
        /// your resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// AWS Resources</a> in <i>AWS Batch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout configuration for jobs that are submitted with this job definition, after
        /// which AWS Batch terminates your jobs if they have not finished. If a job is terminated
        /// due to a timeout, it isn't retried. The minimum value for the timeout is 60 seconds.
        /// Any timeout configuration that's specified during a <a>SubmitJob</a> operation overrides
        /// the timeout configuration defined here. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/job_timeouts.html">Job
        /// Timeouts</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        /// </summary>
        public JobTimeout Timeout
        {
            get { return this._timeout; }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of job definition. For more information about multi-node parallel jobs, see
        /// <a href="https://docs.aws.amazon.com/batch/latest/userguide/multi-node-job-def.html">Creating
        /// a multi-node parallel job definition</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the job is run on Fargate resources, then <code>multinode</code> isn't supported.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobDefinitionType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}