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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The parameters for using an Amazon ECS task as a target.
    /// </summary>
    public partial class PipeTargetEcsTaskParameters
    {
        private List<CapacityProviderStrategyItem> _capacityProviderStrategy = new List<CapacityProviderStrategyItem>();
        private bool? _enableECSManagedTags;
        private bool? _enableExecuteCommand;
        private string _group;
        private LaunchType _launchType;
        private NetworkConfiguration _networkConfiguration;
        private EcsTaskOverride _overrides;
        private List<PlacementConstraint> _placementConstraints = new List<PlacementConstraint>();
        private List<PlacementStrategy> _placementStrategy = new List<PlacementStrategy>();
        private string _platformVersion;
        private PropagateTags _propagateTags;
        private string _referenceId;
        private List<Tag> _tags = new List<Tag>();
        private int? _taskCount;
        private string _taskDefinitionArn;

        /// <summary>
        /// Gets and sets the property CapacityProviderStrategy. 
        /// <para>
        /// The capacity provider strategy to use for the task.
        /// </para>
        ///  
        /// <para>
        /// If a <code>capacityProviderStrategy</code> is specified, the <code>launchType</code>
        /// parameter must be omitted. If no <code>capacityProviderStrategy</code> or launchType
        /// is specified, the <code>defaultCapacityProviderStrategy</code> for the cluster is
        /// used. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=6)]
        public List<CapacityProviderStrategyItem> CapacityProviderStrategy
        {
            get { return this._capacityProviderStrategy; }
            set { this._capacityProviderStrategy = value; }
        }

        // Check to see if CapacityProviderStrategy property is set
        internal bool IsSetCapacityProviderStrategy()
        {
            return this._capacityProviderStrategy != null && this._capacityProviderStrategy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EnableECSManagedTags. 
        /// <para>
        /// Specifies whether to enable Amazon ECS managed tags for the task. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/ecs-using-tags.html">Tagging
        /// Your Amazon ECS Resources</a> in the Amazon Elastic Container Service Developer Guide.
        /// 
        /// </para>
        /// </summary>
        public bool EnableECSManagedTags
        {
            get { return this._enableECSManagedTags.GetValueOrDefault(); }
            set { this._enableECSManagedTags = value; }
        }

        // Check to see if EnableECSManagedTags property is set
        internal bool IsSetEnableECSManagedTags()
        {
            return this._enableECSManagedTags.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EnableExecuteCommand. 
        /// <para>
        /// Whether or not to enable the execute command functionality for the containers in this
        /// task. If true, this enables execute command functionality on all containers in the
        /// task.
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
        /// Specifies an Amazon ECS task group for the task. The maximum length is 255 characters.
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
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// Specifies the launch type on which your task is running. The launch type that you
        /// specify here must match one of the launch type (compatibilities) of the target task.
        /// The <code>FARGATE</code> value is supported only in the Regions where Fargate with
        /// Amazon ECS is supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/AWS-Fargate.html">Fargate
        /// on Amazon ECS</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public LaunchType LaunchType
        {
            get { return this._launchType; }
            set { this._launchType = value; }
        }

        // Check to see if LaunchType property is set
        internal bool IsSetLaunchType()
        {
            return this._launchType != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkConfiguration. 
        /// <para>
        /// Use this structure if the Amazon ECS task uses the <code>awsvpc</code> network mode.
        /// This structure specifies the VPC subnets and security groups associated with the task,
        /// and whether a public IP address is to be used. This structure is required if <code>LaunchType</code>
        /// is <code>FARGATE</code> because the <code>awsvpc</code> mode is required for Fargate
        /// tasks.
        /// </para>
        ///  
        /// <para>
        /// If you specify <code>NetworkConfiguration</code> when the target ECS task does not
        /// use the <code>awsvpc</code> network mode, the task fails.
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
        /// The overrides that are associated with a task.
        /// </para>
        /// </summary>
        public EcsTaskOverride Overrides
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
        /// Gets and sets the property PlacementConstraints. 
        /// <para>
        /// An array of placement constraint objects to use for the task. You can specify up to
        /// 10 constraints per task (including constraints in the task definition and those specified
        /// at runtime).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<PlacementConstraint> PlacementConstraints
        {
            get { return this._placementConstraints; }
            set { this._placementConstraints = value; }
        }

        // Check to see if PlacementConstraints property is set
        internal bool IsSetPlacementConstraints()
        {
            return this._placementConstraints != null && this._placementConstraints.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlacementStrategy. 
        /// <para>
        /// The placement strategy objects to use for the task. You can specify a maximum of five
        /// strategy rules per task. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<PlacementStrategy> PlacementStrategy
        {
            get { return this._placementStrategy; }
            set { this._placementStrategy = value; }
        }

        // Check to see if PlacementStrategy property is set
        internal bool IsSetPlacementStrategy()
        {
            return this._placementStrategy != null && this._placementStrategy.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PlatformVersion. 
        /// <para>
        /// Specifies the platform version for the task. Specify only the numeric portion of the
        /// platform version, such as <code>1.1.0</code>.
        /// </para>
        ///  
        /// <para>
        /// This structure is used only if <code>LaunchType</code> is <code>FARGATE</code>. For
        /// more information about valid platform versions, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/platform_versions.html">Fargate
        /// Platform Versions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        public string PlatformVersion
        {
            get { return this._platformVersion; }
            set { this._platformVersion = value; }
        }

        // Check to see if PlatformVersion property is set
        internal bool IsSetPlatformVersion()
        {
            return this._platformVersion != null;
        }

        /// <summary>
        /// Gets and sets the property PropagateTags. 
        /// <para>
        /// Specifies whether to propagate the tags from the task definition to the task. If no
        /// value is specified, the tags are not propagated. Tags can only be propagated to the
        /// task during task creation. To add tags to a task after task creation, use the <code>TagResource</code>
        /// API action. 
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
        [AWSProperty(Sensitive=true, Min=0, Max=1024)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the task to help you categorize and organize them.
        /// Each tag consists of a key and an optional value, both of which you define. To learn
        /// more, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/APIReference/API_RunTask.html#ECS-RunTask-request-tags">RunTask</a>
        /// in the Amazon ECS API Reference.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TaskCount. 
        /// <para>
        /// The number of tasks to create based on <code>TaskDefinition</code>. The default is
        /// 1.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int TaskCount
        {
            get { return this._taskCount.GetValueOrDefault(); }
            set { this._taskCount = value; }
        }

        // Check to see if TaskCount property is set
        internal bool IsSetTaskCount()
        {
            return this._taskCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TaskDefinitionArn. 
        /// <para>
        /// The ARN of the task definition to use if the event target is an Amazon ECS task. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1600)]
        public string TaskDefinitionArn
        {
            get { return this._taskDefinitionArn; }
            set { this._taskDefinitionArn = value; }
        }

        // Check to see if TaskDefinitionArn property is set
        internal bool IsSetTaskDefinitionArn()
        {
            return this._taskDefinitionArn != null;
        }

    }
}