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
    /// Container for the parameters to the SubmitJob operation.
    /// Submits an AWS Batch job from a job definition. Parameters specified during <a>SubmitJob</a>
    /// override parameters defined in the job definition.
    /// 
    ///  <important> 
    /// <para>
    /// Jobs run on Fargate resources don't run for more than 14 days. After 14 days, the
    /// Fargate resources might no longer be available and the job is terminated.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class SubmitJobRequest : AmazonBatchRequest
    {
        private ArrayProperties _arrayProperties;
        private ContainerOverrides _containerOverrides;
        private List<JobDependency> _dependsOn = new List<JobDependency>();
        private string _jobDefinition;
        private string _jobName;
        private string _jobQueue;
        private NodeOverrides _nodeOverrides;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private bool? _propagateTags;
        private RetryStrategy _retryStrategy;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private JobTimeout _timeout;

        /// <summary>
        /// Gets and sets the property ArrayProperties. 
        /// <para>
        /// The array properties for the submitted job, such as the size of the array. The array
        /// size can be between 2 and 10,000. If you specify array properties for a job, it becomes
        /// an array job. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/array_jobs.html">Array
        /// Jobs</a> in the <i>AWS Batch User Guide</i>.
        /// </para>
        /// </summary>
        public ArrayProperties ArrayProperties
        {
            get { return this._arrayProperties; }
            set { this._arrayProperties = value; }
        }

        // Check to see if ArrayProperties property is set
        internal bool IsSetArrayProperties()
        {
            return this._arrayProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerOverrides. 
        /// <para>
        /// A list of container overrides in JSON format that specify the name of a container
        /// in the specified job definition and the overrides it should receive. You can override
        /// the default command for a container (that's specified in the job definition or the
        /// Docker image) with a <code>command</code> override. You can also override existing
        /// environment variables (that are specified in the job definition or Docker image) on
        /// a container or add new environment variables to it with an <code>environment</code>
        /// override.
        /// </para>
        /// </summary>
        public ContainerOverrides ContainerOverrides
        {
            get { return this._containerOverrides; }
            set { this._containerOverrides = value; }
        }

        // Check to see if ContainerOverrides property is set
        internal bool IsSetContainerOverrides()
        {
            return this._containerOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property DependsOn. 
        /// <para>
        /// A list of dependencies for the job. A job can depend upon a maximum of 20 jobs. You
        /// can specify a <code>SEQUENTIAL</code> type dependency without specifying a job ID
        /// for array jobs so that each child array job completes sequentially, starting at index
        /// 0. You can also specify an <code>N_TO_N</code> type dependency with a job ID for array
        /// jobs. In that case, each index child of this job must wait for the corresponding index
        /// child of each dependency to complete before it can begin.
        /// </para>
        /// </summary>
        public List<JobDependency> DependsOn
        {
            get { return this._dependsOn; }
            set { this._dependsOn = value; }
        }

        // Check to see if DependsOn property is set
        internal bool IsSetDependsOn()
        {
            return this._dependsOn != null && this._dependsOn.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobDefinition. 
        /// <para>
        /// The job definition used by this job. This value can be one of <code>name</code>, <code>name:revision</code>,
        /// or the Amazon Resource Name (ARN) for the job definition. If <code>name</code> is
        /// specified without a revision then the latest active revision is used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobDefinition
        {
            get { return this._jobDefinition; }
            set { this._jobDefinition = value; }
        }

        // Check to see if JobDefinition property is set
        internal bool IsSetJobDefinition()
        {
            return this._jobDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job. The first character must be alphanumeric, and up to 128 letters
        /// (uppercase and lowercase), numbers, hyphens, and underscores are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobQueue. 
        /// <para>
        /// The job queue into which the job is submitted. You can specify either the name or
        /// the Amazon Resource Name (ARN) of the queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobQueue
        {
            get { return this._jobQueue; }
            set { this._jobQueue = value; }
        }

        // Check to see if JobQueue property is set
        internal bool IsSetJobQueue()
        {
            return this._jobQueue != null;
        }

        /// <summary>
        /// Gets and sets the property NodeOverrides. 
        /// <para>
        /// A list of node overrides in JSON format that specify the node range to target and
        /// the container overrides for that node range.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter isn't applicable to jobs running on Fargate resources; use <code>containerOverrides</code>
        /// instead.
        /// </para>
        ///  </note>
        /// </summary>
        public NodeOverrides NodeOverrides
        {
            get { return this._nodeOverrides; }
            set { this._nodeOverrides = value; }
        }

        // Check to see if NodeOverrides property is set
        internal bool IsSetNodeOverrides()
        {
            return this._nodeOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Additional parameters passed to the job that replace parameter substitution placeholders
        /// that are set in the job definition. Parameters are specified as a key and value pair
        /// mapping. Parameters in a <code>SubmitJob</code> request override any corresponding
        /// parameter defaults from the job definition.
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
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the job or job definition to the corresponding
        /// Amazon ECS task. If no value is specified, the tags aren't propagated. Tags can only
        /// be propagated to the tasks during task creation. For tags with the same name, job
        /// tags are given priority over job definitions tags. If the total number of combined
        /// tags from the job and job definition is over 50, the job is moved to the <code>FAILED</code>
        /// state. When specified, this overrides the tag propagation setting in the job definition.
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
        /// The retry strategy to use for failed jobs from this <a>SubmitJob</a> operation. When
        /// a retry strategy is specified here, it overrides the retry strategy defined in the
        /// job definition.
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
        /// The tags that you apply to the job request to help you categorize and organize your
        /// resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">Tagging
        /// AWS Resources</a> in <i>AWS General Reference</i>.
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
        /// The timeout configuration for this <a>SubmitJob</a> operation. You can specify a timeout
        /// duration after which AWS Batch terminates your jobs if they haven't finished. If a
        /// job is terminated due to a timeout, it isn't retried. The minimum value for the timeout
        /// is 60 seconds. This configuration overrides any timeout configuration specified in
        /// the job definition. For array jobs, child jobs have the same timeout configuration
        /// as the parent job. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/job_timeouts.html">Job
        /// Timeouts</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
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

    }
}