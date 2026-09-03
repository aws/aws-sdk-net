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

namespace Amazon.Batch.Model
{
    /// <summary>
    /// An object that represents an Batch job definition.
    /// </summary>
    public partial class JobDefinition
    {
        /// <summary>
        /// Gets and sets the property ConsumableResourceProperties. 
        /// <para>
        /// Contains a list of consumable resources required by the job.
        /// </para>
        /// </summary>
        public ConsumableResourceProperties ConsumableResourceProperties { get; set; }

        /// <summary>
        /// Checks to see if the ConsumableResourceProperties property is set.
        /// </summary>
        internal bool IsSetConsumableResourceProperties() => this.ConsumableResourceProperties != null;

        /// <summary>
        /// Gets and sets the property ContainerOrchestrationType. 
        /// <para>
        /// The orchestration type of the compute environment. The valid values are <c>ECS</c>
        /// (default) or <c>EKS</c>.
        /// </para>
        /// </summary>
        public OrchestrationType ContainerOrchestrationType { get; set; }

        /// <summary>
        /// Checks to see if the ContainerOrchestrationType property is set.
        /// </summary>
        internal bool IsSetContainerOrchestrationType() => this.ContainerOrchestrationType != null;

        /// <summary>
        /// Gets and sets the property ContainerProperties. 
        /// <para>
        /// An object with properties specific to Amazon ECS-based jobs. When <c>containerProperties</c>
        /// is used in the job definition, it can't be used in addition to <c>eksProperties</c>,
        /// <c>ecsProperties</c>, or <c>nodeProperties</c>.
        /// </para>
        /// </summary>
        public ContainerProperties ContainerProperties { get; set; }

        /// <summary>
        /// Checks to see if the ContainerProperties property is set.
        /// </summary>
        internal bool IsSetContainerProperties() => this.ContainerProperties != null;

        /// <summary>
        /// Gets and sets the property EcsProperties. 
        /// <para>
        /// An object that contains the properties for the Amazon ECS resources of a job.When
        /// <c>ecsProperties</c> is used in the job definition, it can't be used in addition to
        /// <c>containerProperties</c>, <c>eksProperties</c>, or <c>nodeProperties</c>.
        /// </para>
        /// </summary>
        public EcsProperties EcsProperties { get; set; }

        /// <summary>
        /// Checks to see if the EcsProperties property is set.
        /// </summary>
        internal bool IsSetEcsProperties() => this.EcsProperties != null;

        /// <summary>
        /// Gets and sets the property EksProperties. 
        /// <para>
        /// An object with properties that are specific to Amazon EKS-based jobs. When <c>eksProperties</c>
        /// is used in the job definition, it can't be used in addition to <c>containerProperties</c>,
        /// <c>ecsProperties</c>, or <c>nodeProperties</c>.
        /// </para>
        /// </summary>
        public EksProperties EksProperties { get; set; }

        /// <summary>
        /// Checks to see if the EksProperties property is set.
        /// </summary>
        internal bool IsSetEksProperties() => this.EksProperties != null;

        /// <summary>
        /// Gets and sets the property JobDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the JobDefinitionArn property is set.
        /// </summary>
        internal bool IsSetJobDefinitionArn() => this.JobDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property JobDefinitionName. 
        /// <para>
        /// The name of the job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string JobDefinitionName { get; set; }

        /// <summary>
        /// Checks to see if the JobDefinitionName property is set.
        /// </summary>
        internal bool IsSetJobDefinitionName() => this.JobDefinitionName != null;

        /// <summary>
        /// Gets and sets the property NodeProperties. 
        /// <para>
        /// An object with properties that are specific to multi-node parallel jobs. When <c>nodeProperties</c>
        /// is used in the job definition, it can't be used in addition to <c>containerProperties</c>,
        /// <c>ecsProperties</c>, or <c>eksProperties</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If the job runs on Fargate resources, don't specify <c>nodeProperties</c>. Use <c>containerProperties</c>
        /// instead.
        /// </para>
        ///  </note>
        /// </summary>
        public NodeProperties NodeProperties { get; set; }

        /// <summary>
        /// Checks to see if the NodeProperties property is set.
        /// </summary>
        internal bool IsSetNodeProperties() => this.NodeProperties != null;

        /// <summary>
        /// Gets and sets the property Parameters. 
        /// <para>
        /// Default parameters or parameter substitution placeholders that are set in the job
        /// definition. Parameters are specified as a key-value pair mapping. Parameters in a
        /// <c>SubmitJob</c> request override any corresponding parameter defaults from the job
        /// definition. For more information about specifying parameters, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/job_definition_parameters.html">Job
        /// definition parameters</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Parameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Parameters property is set.
        /// </summary>
        internal bool IsSetParameters() => this.Parameters != null && (this.Parameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PlatformCapabilities. 
        /// <para>
        /// The platform capabilities required by the job definition. If no value is specified,
        /// it defaults to <c>EC2</c>. Jobs run on Fargate resources specify <c>FARGATE</c>. Jobs
        /// run on Amazon ECS Managed Instances specify <c>MANAGED_INSTANCES</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PlatformCapabilities { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PlatformCapabilities property is set.
        /// </summary>
        internal bool IsSetPlatformCapabilities() => this.PlatformCapabilities != null && (this.PlatformCapabilities.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the job or job definition to the corresponding
        /// Amazon ECS task. If no value is specified, the tags aren't propagated. Tags can only
        /// be propagated to the tasks when the tasks are created. For tags with the same name,
        /// job tags are given priority over job definitions tags. If the total number of combined
        /// tags from the job and job definition is over 50, the job is moved to the <c>FAILED</c>
        /// state.
        /// </para>
        /// </summary>
        public bool? PropagateTags { get; set; }

        /// <summary>
        /// Checks to see if the PropagateTags property is set.
        /// </summary>
        internal bool IsSetPropagateTags() => this.PropagateTags.HasValue;

        /// <summary>
        /// Gets and sets the property RetryStrategy. 
        /// <para>
        /// The retry strategy to use for failed jobs that are submitted with this job definition.
        /// </para>
        /// </summary>
        public RetryStrategy RetryStrategy { get; set; }

        /// <summary>
        /// Checks to see if the RetryStrategy property is set.
        /// </summary>
        internal bool IsSetRetryStrategy() => this.RetryStrategy != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the job definition.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;

        /// <summary>
        /// Gets and sets the property SchedulingPriority. 
        /// <para>
        /// The scheduling priority of the job definition. This only affects jobs in job queues
        /// with a fair-share policy. Jobs with a higher scheduling priority are scheduled before
        /// jobs with a lower scheduling priority.
        /// </para>
        /// </summary>
        public int? SchedulingPriority { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingPriority property is set.
        /// </summary>
        internal bool IsSetSchedulingPriority() => this.SchedulingPriority.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job definition.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags that are applied to the job definition.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The timeout time for jobs that are submitted with this job definition. After the amount
        /// of time you specify passes, Batch terminates your jobs if they aren't finished.
        /// </para>
        /// </summary>
        public JobTimeout Timeout { get; set; }

        /// <summary>
        /// Checks to see if the Timeout property is set.
        /// </summary>
        internal bool IsSetTimeout() => this.Timeout != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of job definition. It's either <c>container</c> or <c>multinode</c>. If the
        /// job is run on Fargate resources, then <c>multinode</c> isn't supported. For more information
        /// about multi-node parallel jobs, see <a href="https://docs.aws.amazon.com/batch/latest/userguide/multi-node-job-def.html">Creating
        /// a multi-node parallel job definition</a> in the <i>Batch User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
