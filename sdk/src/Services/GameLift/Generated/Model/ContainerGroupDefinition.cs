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
    /// <b>This data type is used with the Amazon GameLift containers feature, which is currently
    /// in public preview.</b> 
    /// 
    ///  
    /// <para>
    /// The properties that describe a container group resource. Container group definition
    /// properties can't be updated. To change a property, create a new container group definition.
    /// </para>
    ///  
    /// <para>
    ///  <b>Used with:</b> <a>CreateContainerGroupDefinition</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Returned by:</b> <a>DescribeContainerGroupDefinition</a>, <a>ListContainerGroupDefinitions</a>
    /// 
    /// </para>
    /// </summary>
    public partial class ContainerGroupDefinition
    {
        private List<ContainerDefinition> _containerDefinitions = AWSConfigs.InitializeCollections ? new List<ContainerDefinition>() : null;
        private string _containerGroupDefinitionArn;
        private DateTime? _creationTime;
        private string _name;
        private ContainerOperatingSystem _operatingSystem;
        private ContainerSchedulingStrategy _schedulingStrategy;
        private ContainerGroupDefinitionStatus _status;
        private string _statusReason;
        private int? _totalCpuLimit;
        private int? _totalMemoryLimit;

        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        ///  The set of container definitions that are included in the container group. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<ContainerDefinition> ContainerDefinitions
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
        /// Gets and sets the property ContainerGroupDefinitionArn. 
        /// <para>
        /// The Amazon Resource Name (<a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/s3-arn-format.html">ARN</a>)
        /// that is assigned to an Amazon GameLift <c>ContainerGroupDefinition</c> resource. It
        /// uniquely identifies the resource across all Amazon Web Services Regions. Format is
        /// <c>arn:aws:gamelift:&lt;region&gt;::containergroupdefinition/[container group definition
        /// name]</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ContainerGroupDefinitionArn
        {
            get { return this._containerGroupDefinitionArn; }
            set { this._containerGroupDefinitionArn = value; }
        }

        // Check to see if ContainerGroupDefinitionArn property is set
        internal bool IsSetContainerGroupDefinitionArn()
        {
            return this._containerGroupDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A time stamp indicating when this data object was created. Format is a number expressed
        /// in Unix time as milliseconds (for example <c>"1469498468.057"</c>).
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive identifier for the container group definition. The name value is unique
        /// in an Amazon Web Services Region.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
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
        /// The platform required for all containers in the container group definition.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Linux 2 (AL2) will reach end of support on 6/30/2025. See more details in the
        /// <a href="https://aws.amazon.com/amazon-linux-2/faqs/">Amazon Linux 2 FAQs</a>. For
        /// game servers that are hosted on AL2 and use Amazon GameLift server SDK 4.x., first
        /// update the game server build to server SDK 5.x, and then deploy to AL2023 instances.
        /// See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-serversdk5-migration.html">
        /// Migrate to Amazon GameLift server SDK version 5.</a> 
        /// </para>
        ///  </note>
        /// </summary>
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
        /// maintains only one copy per fleet instance.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Current status of the container group definition resource. Values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>COPYING</c> -- Amazon GameLift is in the process of making copies of all container
        /// images that are defined in the group. While in this state, the resource can't be used
        /// to create a container fleet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>READY</c> -- Amazon GameLift has copied the registry images for all containers
        /// that are defined in the group. You can use a container group definition in this status
        /// to create a container fleet. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> -- Amazon GameLift failed to create a valid container group definition
        /// resource. For more details on the cause of the failure, see <c>StatusReason</c>. A
        /// container group definition resource in failed status will be deleted within a few
        /// minutes.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ContainerGroupDefinitionStatus Status
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
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// Additional information about a container group definition that's in <c>FAILED</c>
        /// status. Possible reasons include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An internal issue prevented Amazon GameLift from creating the container group definition
        /// resource. Delete the failed resource and call <a>CreateContainerGroupDefinition</a>again.
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An access-denied message means that you don't have permissions to access the container
        /// image on ECR. See <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-iam-policy-examples.html">
        /// IAM permission examples</a> for help setting up required IAM permissions for Amazon
        /// GameLift.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>ImageUri</c> value for at least one of the containers in the container group
        /// definition was invalid or not found in the current Amazon Web Services account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// At least one of the container images referenced in the container group definition
        /// exceeds the allowed size. For size limits, see <a href="https://docs.aws.amazon.com/general/latest/gr/gamelift.html">
        /// Amazon GameLift endpoints and quotas</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// At least one of the container images referenced in the container group definition
        /// uses a different operating system than the one defined for the container group.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

        /// <summary>
        /// Gets and sets the property TotalCpuLimit. 
        /// <para>
        /// The amount of CPU units on a fleet instance to allocate for the container group. All
        /// containers in the group share these resources. This property is an integer value in
        /// CPU units (1 vCPU is equal to 1024 CPU units). 
        /// </para>
        ///  
        /// <para>
        /// You can set additional limits for each <a>ContainerDefinition</a> in the group. If
        /// individual containers have limits, this value must be equal to or greater than the
        /// sum of all container-specific CPU limits in the group.
        /// </para>
        ///  
        /// <para>
        /// For more details on memory allocation, see the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-design-fleet">Container
        /// fleet design guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=128, Max=10240)]
        public int? TotalCpuLimit
        {
            get { return this._totalCpuLimit; }
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
        /// The amount of memory (in MiB) on a fleet instance to allocate for the container group.
        /// All containers in the group share these resources. 
        /// </para>
        ///  
        /// <para>
        /// You can set additional limits for each <a>ContainerDefinition</a> in the group. If
        /// individual containers have limits, this value must meet the following requirements:
        /// 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Equal to or greater than the sum of all container-specific soft memory limits in the
        /// group.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Equal to or greater than any container-specific hard limits in the group.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more details on memory allocation, see the <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/containers-design-fleet">Container
        /// fleet design guide</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4, Max=1024000)]
        public int? TotalMemoryLimit
        {
            get { return this._totalMemoryLimit; }
            set { this._totalMemoryLimit = value; }
        }

        // Check to see if TotalMemoryLimit property is set
        internal bool IsSetTotalMemoryLimit()
        {
            return this._totalMemoryLimit.HasValue; 
        }

    }
}