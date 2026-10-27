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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterDaemonTaskDefinition operation. Registers
    /// a new daemon task definition from the supplied <c>family</c> and <c>containerDefinitions</c>.
    /// Optionally, you can add data volumes to your containers with the <c>volumes</c> parameter.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/daemon-task-definitions.html">Daemon
    /// task definitions</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// <para> A daemon task definition is a template that describes the containers that form
    /// a daemon. Daemons deploy cross-cutting software agents such as security monitoring,
    /// telemetry, and logging across your Amazon ECS infrastructure. </para> <para> Each
    /// time you call <c>RegisterDaemonTaskDefinition</c>, a new revision of the daemon task
    /// definition is created. You can't modify a revision after you register it. </para>
    /// </summary>
    public partial class RegisterDaemonTaskDefinitionRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// A list of container definitions in JSON format that describe the containers that make
        /// up your daemon task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true)]
        public List<DaemonContainerDefinition> ContainerDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<DaemonContainerDefinition>() : null;

        /// <summary>
        /// Checks to see if the ContainerDefinitions property is set.
        /// </summary>
        internal bool IsSetContainerDefinitions() => this.ContainerDefinitions != null && (this.ContainerDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units used by the daemon task. It can be expressed as an integer
        /// using CPU units (for example, <c>1024</c>).
        /// </para>
        /// </summary>
        public string Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu != null;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task execution role that grants the Amazon ECS
        /// container agent permission to make Amazon Web Services API calls on your behalf. The
        /// task execution role is required for daemon tasks that pull container images from Amazon
        /// ECR or send container logs to CloudWatch.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the ExecutionRoleArn property is set.
        /// </summary>
        internal bool IsSetExecutionRoleArn() => this.ExecutionRoleArn != null;

        /// <summary>
        /// Gets and sets the property Family. 
        /// <para>
        /// You must specify a <c>family</c> for a daemon task definition. This family is used
        /// as a name for your daemon task definition. Up to 255 letters (uppercase and lowercase),
        /// numbers, underscores, and hyphens are allowed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Family { get; set; }

        /// <summary>
        /// Checks to see if the Family property is set.
        /// </summary>
        internal bool IsSetFamily() => this.Family != null;

        /// <summary>
        /// Gets and sets the property IpcMode. 
        /// <para>
        /// The IPC namespace mode for the daemon. The valid values are <c>none</c> and <c>shared</c>.
        /// The default is <c>none</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>none</c> is specified or no value is provided, the daemon runs with its own
        /// IPC namespace, isolated from other tasks. If <c>shared</c> is specified, the daemon
        /// joins the host IPC namespace, making it accessible to non-daemon tasks that use <c>ipcMode:
        /// "host"</c> or other daemons that use <c>ipcMode: "shared"</c>.
        /// </para>
        /// </summary>
        public DaemonIpcMode IpcMode { get; set; }

        /// <summary>
        /// Checks to see if the IpcMode property is set.
        /// </summary>
        internal bool IsSetIpcMode() => this.IpcMode != null;

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount of memory (in MiB) used by the daemon task. It can be expressed as an integer
        /// using MiB (for example, <c>1024</c>).
        /// </para>
        /// </summary>
        public string Memory { get; set; }

        /// <summary>
        /// Checks to see if the Memory property is set.
        /// </summary>
        internal bool IsSetMemory() => this.Memory != null;

        /// <summary>
        /// Gets and sets the property PidMode. 
        /// <para>
        /// The PID namespace mode for the daemon. The valid values are <c>none</c> and <c>shared</c>.
        /// The default is <c>none</c>.
        /// </para>
        ///  
        /// <para>
        /// If <c>none</c> is specified or no value is provided, the daemon runs with its own
        /// PID namespace, isolated from other tasks. If <c>shared</c> is specified, the daemon
        /// joins the host PID namespace, making it accessible to non-daemon tasks that use <c>pidMode:
        /// "host"</c> or other daemons that use <c>pidMode: "shared"</c>.
        /// </para>
        /// </summary>
        public DaemonPidMode PidMode { get; set; }

        /// <summary>
        /// Checks to see if the PidMode property is set.
        /// </summary>
        internal bool IsSetPidMode() => this.PidMode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The metadata that you apply to the daemon task definition to help you categorize and
        /// organize them. Each tag consists of a key and an optional value. You define both of
        /// them.
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
        /// Do not use <c>aws:</c>, <c>AWS:</c>, or any upper or lowercase combination of such
        /// as a prefix for either keys or values as it is reserved for Amazon Web Services use.
        /// You cannot edit or delete tag keys or values with this prefix. Tags with this prefix
        /// do not count against your tags per resource limit.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the IAM role that containers
        /// in this daemon task can assume. All containers in this daemon task are granted the
        /// permissions that are specified in this role.
        /// </para>
        /// </summary>
        public string TaskRoleArn { get; set; }

        /// <summary>
        /// Checks to see if the TaskRoleArn property is set.
        /// </summary>
        internal bool IsSetTaskRoleArn() => this.TaskRoleArn != null;

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// A list of volume definitions in JSON format that containers in your daemon task can
        /// use.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonVolume> Volumes { get; set; } = AWSConfigs.InitializeCollections ? new List<DaemonVolume>() : null;

        /// <summary>
        /// Checks to see if the Volumes property is set.
        /// </summary>
        internal bool IsSetVolumes() => this.Volumes != null && (this.Volumes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
