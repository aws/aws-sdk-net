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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateContainerGroupDefinition operation.
    /// <b>This operation is used with the Amazon GameLift containers feature, which is currently
    /// in public preview. </b> 
    /// 
    ///  
    /// <para>
    /// Creates a <c>ContainerGroupDefinition</c> resource that describes a set of containers
    /// for hosting your game server with Amazon GameLift managed EC2 hosting. An Amazon GameLift
    /// container group is similar to a container "task" and "pod". Each container group can
    /// have one or more containers. 
    /// </para>
    ///  
    /// <para>
    /// Use container group definitions when you create a container fleet. Container group
    /// definitions determine how Amazon GameLift deploys your containers to each instance
    /// in a container fleet. 
    /// </para>
    ///  
    /// <para>
    /// You can create two types of container groups, based on scheduling strategy:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A <b>replica container group</b> manages the containers that run your game server
    /// application and supporting software. Replica container groups might be replicated
    /// multiple times on each fleet instance, depending on instance resources. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A <b>daemon container group</b> manages containers that run other software, such as
    /// background services, logging, or test processes. You might use a daemon container
    /// group for processes that need to run only once per fleet instance, or processes that
    /// need to persist independently of the replica container group. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To create a container group definition, specify a group name, a list of container
    /// definitions, and maximum total CPU and memory requirements for the container group.
    /// Specify an operating system and scheduling strategy or use the default values. When
    /// using the Amazon Web Services CLI tool, you can pass in your container definitions
    /// as a JSON file.
    /// </para>
    ///  <note> 
    /// <para>
    /// This operation requires Identity and Access Management (IAM) permissions to access
    /// container images in Amazon ECR repositories. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-iam-policy-examples.html">
    /// IAM permissions for Amazon GameLift</a> for help setting the appropriate permissions.
    /// </para>
    ///  </note> 
    /// <para>
    /// If successful, this operation creates a new <c>ContainerGroupDefinition</c> resource
    /// with an ARN value assigned. You can't change the properties of a container group definition.
    /// Instead, create a new one. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-create-groups.html">Create
    /// a container group definition</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-design-fleet.html">Container
    /// fleet design guide</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-definitions.html#containers-definitions-create">Create
    /// a container definition as a JSON file</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateContainerGroupDefinitionRequest : AmazonGameLiftRequest
    {
        private List<ContainerDefinitionInput> _containerDefinitions = AWSConfigs.InitializeCollections ? new List<ContainerDefinitionInput>() : null;
        private string _name;
        private ContainerOperatingSystem _operatingSystem;
        private ContainerSchedulingStrategy _schedulingStrategy;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _totalCpuLimit;
        private int? _totalMemoryLimit;

        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// Definitions for all containers in this group. Each container definition identifies
        /// the container image and specifies configuration settings for the container. See the
        /// <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-design-fleet.html">
        /// Container fleet design guide</a> for container guidelines.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<ContainerDefinitionInput> ContainerDefinitions
        {
            get { return this._containerDefinitions; }
            set { this._containerDefinitions = value; }
        }

        // Check to see if ContainerDefinitions property is set
        internal bool IsSetContainerDefinitions()
        {
            return this._containerDefinitions != null && (this._containerDefinitions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive identifier for the container group definition. The name value must be
        /// unique in an Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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
        /// Gets and sets the property OperatingSystem. 
        /// <para>
        /// The platform that is used by containers in the container group definition. All containers
        /// in a group must run on the same operating system.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ContainerOperatingSystem OperatingSystem
        {
            get { return this._operatingSystem; }
            set { this._operatingSystem = value; }
        }

        // Check to see if OperatingSystem property is set
        internal bool IsSetOperatingSystem()
        {
            return this._operatingSystem != null;
        }

        /// <summary>
        /// Gets and sets the property SchedulingStrategy. 
        /// <para>
        /// The method for deploying the container group across fleet instances. A replica container
        /// group might have multiple copies on each fleet instance. A daemon container group
        /// has one copy per fleet instance. Default value is <c>REPLICA</c>.
        /// </para>
        /// </summary>
        public ContainerSchedulingStrategy SchedulingStrategy
        {
            get { return this._schedulingStrategy; }
            set { this._schedulingStrategy = value; }
        }

        // Check to see if SchedulingStrategy property is set
        internal bool IsSetSchedulingStrategy()
        {
            return this._schedulingStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of labels to assign to the container group definition resource. Tags are developer-defined
        /// key-value pairs. Tagging Amazon Web Services resources are useful for resource management,
        /// access management and cost allocation. For more information, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws_tagging.html">
        /// Tagging Amazon Web Services Resources</a> in the <i>Amazon Web Services General Reference</i>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
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
        /// Gets and sets the property TotalCpuLimit. 
        /// <para>
        /// The maximum amount of CPU units to allocate to the container group. Set this parameter
        /// to an integer value in CPU units (1 vCPU is equal to 1024 CPU units). All containers
        /// in the group share this memory. If you specify CPU limits for individual containers,
        /// set this parameter based on the following guidelines. The value must be equal to or
        /// greater than the sum of the CPU limits for all containers in the group.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=128, Max=10240)]
        public int TotalCpuLimit
        {
            get { return this._totalCpuLimit.GetValueOrDefault(); }
            set { this._totalCpuLimit = value; }
        }

        // Check to see if TotalCpuLimit property is set
        internal bool IsSetTotalCpuLimit()
        {
            return this._totalCpuLimit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalMemoryLimit. 
        /// <para>
        /// The maximum amount of memory (in MiB) to allocate to the container group. All containers
        /// in the group share this memory. If you specify memory limits for individual containers,
        /// set this parameter based on the following guidelines. The value must be (1) greater
        /// than the sum of the soft memory limits for all containers in the group, and (2) greater
        /// than any individual container's hard memory limit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=4, Max=1024000)]
        public int TotalMemoryLimit
        {
            get { return this._totalMemoryLimit.GetValueOrDefault(); }
            set { this._totalMemoryLimit = value; }
        }

        // Check to see if TotalMemoryLimit property is set
        internal bool IsSetTotalMemoryLimit()
        {
            return this._totalMemoryLimit.HasValue; 
        }

    }
}