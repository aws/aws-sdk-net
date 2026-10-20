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
    /// The details of a daemon task definition. A daemon task definition is a template that
    /// describes the containers that form a daemon. Daemons deploy cross-cutting software
    /// agents independently across your Amazon ECS infrastructure.
    /// </summary>
    public partial class DaemonTaskDefinition
    {
        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// A list of container definitions in JSON format that describe the containers that make
        /// up the daemon task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonContainerDefinition> ContainerDefinitions { get; set; } = AWSConfigs.InitializeCollections ? new List<DaemonContainerDefinition>() : null;

        /// <summary>
        /// Checks to see if the ContainerDefinitions property is set.
        /// </summary>
        internal bool IsSetContainerDefinitions() => this.ContainerDefinitions != null && (this.ContainerDefinitions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units used by the daemon task.
        /// </para>
        /// </summary>
        public string Cpu { get; set; }

        /// <summary>
        /// Checks to see if the Cpu property is set.
        /// </summary>
        internal bool IsSetCpu() => this.Cpu != null;

        /// <summary>
        /// Gets and sets the property DaemonTaskDefinitionArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the daemon task definition.
        /// </para>
        /// </summary>
        public string DaemonTaskDefinitionArn { get; set; }

        /// <summary>
        /// Checks to see if the DaemonTaskDefinitionArn property is set.
        /// </summary>
        internal bool IsSetDaemonTaskDefinitionArn() => this.DaemonTaskDefinitionArn != null;

        /// <summary>
        /// Gets and sets the property DeleteRequestedAt. 
        /// <para>
        /// The Unix timestamp for the time when the daemon task definition delete was requested.
        /// </para>
        /// </summary>
        public DateTime? DeleteRequestedAt { get; set; }

        /// <summary>
        /// Checks to see if the DeleteRequestedAt property is set.
        /// </summary>
        internal bool IsSetDeleteRequestedAt() => this.DeleteRequestedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task execution role that grants the Amazon ECS
        /// container agent permission to make Amazon Web Services API calls on your behalf.
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
        /// The name of a family that this daemon task definition is registered to.
        /// </para>
        /// </summary>
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
        /// The amount of memory (in MiB) used by the daemon task.
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
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The Unix timestamp for the time when the daemon task definition was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisteredAt { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredAt property is set.
        /// </summary>
        internal bool IsSetRegisteredAt() => this.RegisteredAt.HasValue;

        /// <summary>
        /// Gets and sets the property RegisteredBy. 
        /// <para>
        /// The principal that registered the daemon task definition.
        /// </para>
        /// </summary>
        public string RegisteredBy { get; set; }

        /// <summary>
        /// Checks to see if the RegisteredBy property is set.
        /// </summary>
        internal bool IsSetRegisteredBy() => this.RegisteredBy != null;

        /// <summary>
        /// Gets and sets the property Revision. 
        /// <para>
        /// The revision of the daemon task in a particular family. The revision is a version
        /// number of a daemon task definition in a family. When you register a daemon task definition
        /// for the first time, the revision is <c>1</c>. Each time that you register a new revision
        /// of a daemon task definition in the same family, the revision value always increases
        /// by one.
        /// </para>
        /// </summary>
        public int? Revision { get; set; }

        /// <summary>
        /// Checks to see if the Revision property is set.
        /// </summary>
        internal bool IsSetRevision() => this.Revision.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the daemon task definition. The valid values are <c>ACTIVE</c>, <c>DELETE_IN_PROGRESS</c>,
        /// and <c>DELETED</c>.
        /// </para>
        /// </summary>
        public DaemonTaskDefinitionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the IAM role that grants containers
        /// in the daemon task permission to call Amazon Web Services APIs on your behalf.
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
        /// The list of data volume definitions for the daemon task.
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
