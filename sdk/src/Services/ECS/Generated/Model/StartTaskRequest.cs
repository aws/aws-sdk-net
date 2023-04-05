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
 * Do not modify this file. This file is generated from the ecs-2014-11-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the StartTask operation.
    /// Starts a new task from the specified task definition on the specified container instance
    /// or instances.
    /// 
    ///  <note> 
    /// <para>
    /// Starting April 15, 2023, Amazon Web Services will not onboard new customers to Amazon
    /// Elastic Inference (EI), and will help current customers migrate their workloads to
    /// options that offer better price and performance. After April 15, 2023, new customers
    /// will not be able to launch instances with Amazon EI accelerators in Amazon SageMaker,
    /// Amazon ECS, or Amazon EC2. However, customers who have used Amazon EI at least once
    /// during the past 30-day period are considered current customers and will be able to
    /// continue using the service. 
    /// </para>
    ///  </note> 
    /// <para>
    /// Alternatively, you can use <a>RunTask</a> to place tasks for you. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/scheduling_tasks.html">Scheduling
    /// Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </para>
    /// </summary>
    public partial class StartTaskRequest : AmazonECSRequest
    {
        private string _cluster;
        private List<string> _containerInstances = new List<string>();
        private bool? _enableecsManagedTags;
        private bool? _enableExecuteCommand;
        private string _group;
        private NetworkConfiguration _networkConfiguration;
        private TaskOverride _overrides;
        private PropagateTags _propagateTags;
        private string _referenceId;
        private string _startedBy;
        private List<Tag> _tags = new List<Tag>();
        private string _taskDefinition;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster where to start your
        /// task. If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public string Cluster
        {
            get { return this._cluster; }
            set { this._cluster = value; }
        }

        // Check to see if Cluster property is set
        internal bool IsSetCluster()
        {
            return this._cluster != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerInstances. 
        /// <para>
        /// The container instance IDs or full ARN entries for the container instances where you
        /// would like to place your task. You can specify up to 10 container instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ContainerInstances
        {
            get { return this._containerInstances; }
            set { this._containerInstances = value; }
        }

        // Check to see if ContainerInstances property is set
        internal bool IsSetContainerInstances()
        {
            return this._containerInstances != null && this._containerInstances.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableECSManagedTags. 
        /// <para>
        /// Specifies whether to use Amazon ECS managed tags for the task. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
        /// Your Amazon ECS Resources</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        public bool EnableECSManagedTags
        {
            get { return this._enableecsManagedTags.GetValueOrDefault(); }
            set { this._enableecsManagedTags = value; }
        }

        // Check to see if EnableECSManagedTags property is set
        internal bool IsSetEnableECSManagedTags()
        {
            return this._enableecsManagedTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Whether or not the execute command functionality is enabled for the task. If <code>true</code>,
        /// this enables execute command functionality on all containers in the task.
        /// </para>
        /// </summary>
        public bool EnableExecuteCommand
        {
            get { return this._enableExecuteCommand.GetValueOrDefault(); }
            set { this._enableExecuteCommand = value; }
        }

        // Check to see if EnableExecuteCommand property is set
        internal bool IsSetEnableExecuteCommand()
        {
            return this._enableExecuteCommand.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Group. 
        /// <para>
        /// The name of the task group to associate with the task. The default value is the family
        /// name of the task definition (for example, family:my-family-name).
        /// </para>
        /// </summary>
        public string Group
        {
            get { return this._group; }
            set { this._group = value; }
        }

        // Check to see if Group property is set
        internal bool IsSetGroup()
        {
            return this._group != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// The VPC subnet and security group configuration for tasks that receive their own elastic
        /// network interface by using the <code>awsvpc</code> networking mode.
        /// </para>
        /// </summary>
        public NetworkConfiguration NetworkConfiguration
        {
            get { return this._networkConfiguration; }
            set { this._networkConfiguration = value; }
        }

        // Check to see if NetworkConfiguration property is set
        internal bool IsSetNetworkConfiguration()
        {
            return this._networkConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Overrides. 
        /// <para>
        /// A list of container overrides in JSON format that specify the name of a container
        /// in the specified task definition and the overrides it receives. You can override the
        /// default command for a container (that's specified in the task definition or Docker
        /// image) with a <code>command</code> override. You can also override existing environment
        /// variables (that are specified in the task definition or Docker image) on a container
        /// or add new environment variables to it with an <code>environment</code> override.
        /// </para>
        ///  <note> 
        /// <para>
        /// A total of 8192 characters are allowed for overrides. This limit includes the JSON
        /// formatting characters of the override structure.
        /// </para>
        ///  </note>
        /// </summary>
        public TaskOverride Overrides
        {
            get { return this._overrides; }
            set { this._overrides = value; }
        }

        // Check to see if Overrides property is set
        internal bool IsSetOverrides()
        {
            return this._overrides != null;
        }

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the task definition or the service to
        /// the task. If no value is specified, the tags aren't propagated.
        /// </para>
        /// </summary>
        public PropagateTags PropagateTags
        {
            get { return this._propagateTags; }
            set { this._propagateTags = value; }
        }

        // Check to see if PropagateTags property is set
        internal bool IsSetPropagateTags()
        {
            return this._propagateTags != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceId. 
        /// <para>
        /// The reference ID to use for the task.
        /// </para>
        /// </summary>
        public string ReferenceId
        {
            get { return this._referenceId; }
            set { this._referenceId = value; }
        }

        // Check to see if ReferenceId property is set
        internal bool IsSetReferenceId()
        {
            return this._referenceId != null;
        }

        /// <summary>
        /// Gets and sets the property StartedBy. 
        /// <para>
        /// An optional tag specified when a task is started. For example, if you automatically
        /// trigger a task to run a batch process job, you could apply a unique identifier for
        /// that job to your task with the <code>startedBy</code> parameter. You can then identify
        /// which tasks belong to that job by filtering the results of a <a>ListTasks</a> call
        /// with the <code>startedBy</code> value. Up to 36 letters (uppercase and lowercase),
        /// numbers, hyphens (-), and underscores (_) are allowed.
        /// </para>
        ///  
        /// <para>
        /// If a task is started by an Amazon ECS service, the <code>startedBy</code> parameter
        /// contains the deployment ID of the service that starts it.
        /// </para>
        /// </summary>
        public string StartedBy
        {
            get { return this._startedBy; }
            set { this._startedBy = value; }
        }

        // Check to see if StartedBy property is set
        internal bool IsSetStartedBy()
        {
            return this._startedBy != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the task to help you categorize and organize them.
        /// Each tag consists of a key and an optional value, both of which you define.
        /// </para>
        ///  
        /// <para>
        /// The following basic restrictions apply to tags:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Maximum number of tags per resource - 50
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For each resource, each tag key must be unique, and each tag key can have only one
        /// value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum key length - 128 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Maximum value length - 256 Unicode characters in UTF-8
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If your tagging schema is used across multiple services and resources, remember that
        /// other services may have restrictions on allowed characters. Generally allowed characters
        /// are: letters, numbers, and spaces representable in UTF-8, and the following characters:
        /// + - = . _ : / @.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tag keys and values are case-sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Do not use <code>aws:</code>, <code>AWS:</code>, or any upper or lowercase combination
        /// of such as a prefix for either keys or values as it is reserved for Amazon Web Services
        /// use. You cannot edit or delete tag keys or values with this prefix. Tags with this
        /// prefix do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
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
        /// Gets and sets the property TaskDefinition. 
        /// <para>
        /// The <code>family</code> and <code>revision</code> (<code>family:revision</code>) or
        /// full ARN of the task definition to start. If a <code>revision</code> isn't specified,
        /// the latest <code>ACTIVE</code> revision is used.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TaskDefinition
        {
            get { return this._taskDefinition; }
            set { this._taskDefinition = value; }
        }

        // Check to see if TaskDefinition property is set
        internal bool IsSetTaskDefinition()
        {
            return this._taskDefinition != null;
        }

    }
}