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
    /// An object that represents an Batch job definition.
    /// </summary>
    public partial class JobDefinition
    {
        private OrchestrationType _containerOrchestrationType;
        private ContainerProperties _containerProperties;
        private EksProperties _eksProperties;
        private string _jobDefinitionArn;
        private string _jobDefinitionName;
        private NodeProperties _nodeProperties;
        private Dictionary<string, string> _parameters = new Dictionary<string, string>();
        private List<string> _platformCapabilities = new List<string>();
        private bool? _propagateTags;
        private RetryStrategy _retryStrategy;
        private int? _revision;
        private int? _schedulingPriority;
        private string _status;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private JobTimeout _timeout;
        private string _type;

        /// <summary>
        /// Gets and sets the property ContainerOrchestrationType. 
        /// <para>
        /// The orchestration type of the compute environment. The valid values are <code>ECS</code>
        /// (default) or <code>EKS</code>.
        /// </para>
        /// </summary>
        public OrchestrationType ContainerOrchestrationType
        {
            get { return this._containerOrchestrationType; }
            set { this._containerOrchestrationType = value; }
        }

        // Check to see if ContainerOrchestrationType property is set
        internal bool IsSetContainerOrchestrationType()
        {
            return this._containerOrchestrationType != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerProperties. 
        /// <para>
        /// An object with various properties specific to Amazon ECS based jobs. Valid values
        /// are <code>containerProperties</code>, <code>eksProperties</code>, and <code>nodeProperties</code>.
        /// Only one can be specified.
        /// </para>
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
        /// Gets and sets the property EksProperties. 
        /// <para>
        /// An object with various properties that are specific to Amazon EKS based jobs. Valid
        /// values are <code>containerProperties</code>, <code>eksProperties</code>, and <code>nodeProperties</code>.
        /// Only one can be specified.
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
        /// Gets and sets the property JobDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string JobDefinitionArn
        {
            get { return this._jobDefinitionArn; }
            set { this._jobDefinitionArn = value; }
        }

        // Check to see if JobDefinitionArn property is set
        internal bool IsSetJobDefinitionArn()
        {
            return this._jobDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the job definition.
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
        /// An object with various properties that are specific to multi-node parallel jobs. Valid
        /// values are <code>containerProperties</code>, <code>eksProperties</code>, and <code>nodeProperties</code>.
        /// Only one can be specified.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the job runs on Fargate resources, don't specify <code>nodeProperties</code>. Use
        /// <code>containerProperties</code> instead.
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
        /// Default parameters or parameter substitution placeholders that are set in the job
        /// definition. Parameters are specified as a key-value pair mapping. Parameters in a
        /// <code>SubmitJob</code> request override any corresponding parameter defaults from
        /// the job definition. For more information about specifying parameters, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/job_definition_parameters.html">Job
        /// definition parameters</a> in the <i>Batch User Guide</i>.
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
        /// it defaults to <code>EC2</code>. Jobs run on Fargate resources specify <code>FARGATE</code>.
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
        /// Amazon ECS task. If no value is specified, the tags aren't propagated. Tags can only
        /// be propagated to the tasks when the tasks are created. For tags with the same name,
        /// job tags are given priority over job definitions tags. If the total number of combined
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
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int Revision
        {
            get { return this._revision.GetValueOrDefault(); }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SchedulingPriority. 
        /// <para>
        /// The scheduling priority of the job definition. This only affects jobs in job queues
        /// with a fair share policy. Jobs with a higher scheduling priority are scheduled before
        /// jobs with a lower scheduling priority.
        /// </para>
        /// </summary>
        public int SchedulingPriority
        {
            get { return this._schedulingPriority.GetValueOrDefault(); }
            set { this._schedulingPriority = value; }
        }

        // Check to see if SchedulingPriority property is set
        internal bool IsSetSchedulingPriority()
        {
            return this._schedulingPriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job definition.
        /// </para>
        /// </summary>
        public string Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are applied to the job definition.
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
        /// The timeout time for jobs that are submitted with this job definition. After the amount
        /// of time you specify passes, Batch terminates your jobs if they aren't finished.
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
        /// The type of job definition. It's either <code>container</code> or <code>multinode</code>.
        /// If the job is run on Fargate resources, then <code>multinode</code> isn't supported.
        /// For more information about multi-node parallel jobs, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/multi-node-job-def.html">Creating
        /// a multi-node parallel job definition</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Type
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