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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Batch.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterJobDefinition operation.
    /// Registers an Batch job definition.
    /// </summary>
    public partial class RegisterJobDefinitionRequest : AmazonBatchRequest
    {
        private ConsumableResourceProperties _consumableResourceProperties;
        private ContainerProperties _containerProperties;
        private EcsProperties _ecsProperties;
        private EksProperties _eksProperties;
        private string _jobDefinitionName;
        private NodeProperties _nodeProperties;
        private Dictionary<string, string> _parameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<string> _platformCapabilities = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private bool? _propagateTags;
        private RetryStrategy _retryStrategy;
        private int? _schedulingPriority;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private JobTimeout _timeout;
        private JobDefinitionType _type;

        /// <summary>
        /// Gets and sets the property ConsumableResourceProperties. 
        /// <para>
        /// Contains a list of consumable resources required by the job.
        /// </para>
        /// </summary>
        public ConsumableResourceProperties ConsumableResourceProperties
        {
            get { return this._consumableResourceProperties; }
            set { this._consumableResourceProperties = value; }
        }

        // Check to see if ConsumableResourceProperties property is set
        internal bool IsSetConsumableResourceProperties()
        {
            return this._consumableResourceProperties != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerProperties. 
        /// <para>
        /// An object with properties specific to Amazon ECS-based single-node container-based
        /// jobs. If the job definition's <c>type</c> parameter is <c>container</c>, then you
        /// must specify either <c>containerProperties</c> or <c>nodeProperties</c>. This must
        /// not be specified for Amazon EKS-based job definitions.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the job runs on Fargate resources, then you must not specify <c>nodeProperties</c>;
        /// use only <c>containerProperties</c>.
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
        /// Gets and sets the property EcsProperties. 
        /// <para>
        /// An object with properties that are specific to Amazon ECS-based jobs. This must not
        /// be specified for Amazon EKS-based job definitions.
        /// </para>
        /// </summary>
        public EcsProperties EcsProperties
        {
            get { return this._ecsProperties; }
            set { this._ecsProperties = value; }
        }

        // Check to see if EcsProperties property is set
        internal bool IsSetEcsProperties()
        {
            return this._ecsProperties != null;
        }

        /// <summary>
        /// Gets and sets the property EksProperties. 
        /// <para>
        /// An object with properties that are specific to Amazon EKS-based jobs. This must not
        /// be specified for Amazon ECS based job definitions.
        /// </para>
        /// </summary>
        public EksProperties EksProperties
        {
            get { return this._eksProperties; }
            set { this._eksProperties = value; }
        }

        // Check to see if EksProperties property is set
        internal bool IsSetEksProperties()
        {
            return this._eksProperties != null;
        }

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the job definition to register. It can be up to 128 letters long. It can
        /// contain uppercase and lowercase letters, numbers, hyphens (-), and underscores (_).
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
        /// An object with properties specific to multi-node parallel jobs. If you specify node
        /// properties for a job, it becomes a multi-node parallel job. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/multi-node-parallel-jobs.html">Multi-node
        /// Parallel Jobs</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the job runs on Fargate resources, then you must not specify <c>nodeProperties</c>;
        /// use <c>containerProperties</c> instead.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// If the job runs on Amazon EKS resources, then you must not specify <c>nodeProperties</c>.
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
        /// are specified as a key-value pair mapping. Parameters in a <c>SubmitJob</c> request
        /// override any corresponding parameter defaults from the job definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters
        {
            get { return this._parameters; }
            set { this._parameters = value; }
        }

        // Check to see if Parameters property is set
        internal bool IsSetParameters()
        {
            return this._parameters != null && (this._parameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PlatformCapabilities. 
        /// <para>
        /// The platform capabilities required by the job definition. If no value is specified,
        /// it defaults to <c>EC2</c>. To run the job on Fargate resources, specify <c>FARGATE</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the job runs on Amazon EKS resources, then you must not specify <c>platformCapabilities</c>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PlatformCapabilities
        {
            get { return this._platformCapabilities; }
            set { this._platformCapabilities = value; }
        }

        // Check to see if PlatformCapabilities property is set
        internal bool IsSetPlatformCapabilities()
        {
            return this._platformCapabilities != null && (this._platformCapabilities.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the job or job definition to the corresponding
        /// Amazon ECS task. If no value is specified, the tags are not propagated. Tags can only
        /// be propagated to the tasks during task creation. For tags with the same name, job
        /// tags are given priority over job definitions tags. If the total number of combined
        /// tags from the job and job definition is over 50, the job is moved to the <c>FAILED</c>
        /// state.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the job runs on Amazon EKS resources, then you must not specify <c>propagateTags</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? PropagateTags
        {
            get { return this._propagateTags; }
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
        /// Gets and sets the property SchedulingPriority. 
        /// <para>
        /// The scheduling priority for jobs that are submitted with this job definition. This
        /// only affects jobs in job queues with a fair-share policy. Jobs with a higher scheduling
        /// priority are scheduled before jobs with a lower scheduling priority.
        /// </para>
        ///  
        /// <para>
        /// The minimum supported value is 0 and the maximum supported value is 9999.
        /// </para>
        /// </summary>
        public int? SchedulingPriority
        {
            get { return this._schedulingPriority; }
            set { this._schedulingPriority = value; }
        }

        // Check to see if SchedulingPriority property is set
        internal bool IsSetSchedulingPriority()
        {
            return this._schedulingPriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that you apply to the job definition to help you categorize and organize
        /// your resources. Each tag consists of a key and an optional value. For more information,
        /// see <a href="https://docs.aws.amazon.com/batch/latest/userguide/using-tags.html">Tagging
        /// Amazon Web Services Resources</a> in <i>Batch User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout configuration for jobs that are submitted with this job definition, after
        /// which Batch terminates your jobs if they have not finished. If a job is terminated
        /// due to a timeout, it isn't retried. The minimum value for the timeout is 60 seconds.
        /// Any timeout configuration that's specified during a <a>SubmitJob</a> operation overrides
        /// the timeout configuration defined here. For more information, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/job_timeouts.html">Job
        /// Timeouts</a> in the <i>Batch User Guide</i>.
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
        /// a multi-node parallel job definition</a> in the <i>Batch User Guide</i>.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If the value is <c>container</c>, then one of the following is required: <c>containerProperties</c>,
        /// <c>ecsProperties</c>, or <c>eksProperties</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If the value is <c>multinode</c>, then <c>nodeProperties</c> is required.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If the job is run on Fargate resources, then <c>multinode</c> isn't supported.
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