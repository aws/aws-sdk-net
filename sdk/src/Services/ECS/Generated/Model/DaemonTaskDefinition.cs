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
        private List<DaemonContainerDefinition> _containerDefinitions = AWSConfigs.InitializeCollections ? new List<DaemonContainerDefinition>() : null;
        private string _cpu;
        private string _daemonTaskDefinitionArn;
        private DateTime? _deleteRequestedAt;
        private string _executionRoleArn;
        private string _family;
        private string _memory;
        private DateTime? _registeredAt;
        private string _registeredBy;
        private int? _revision;
        private DaemonTaskDefinitionStatus _status;
        private string _taskRoleArn;
        private List<DaemonVolume> _volumes = AWSConfigs.InitializeCollections ? new List<DaemonVolume>() : null;

        /// <summary>
        /// Gets and sets the property ContainerDefinitions. 
        /// <para>
        /// A list of container definitions in JSON format that describe the containers that make
        /// up the daemon task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonContainerDefinition> ContainerDefinitions
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
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The number of CPU units used by the daemon task.
        /// </para>
        /// </summary>
        public string Cpu
        {
            get { return this._cpu; }
            set { this._cpu = value; }
        }

        // Check to see if Cpu property is set
        internal bool IsSetCpu()
        {
            return this._cpu != null;
        }

        /// <summary>
        /// Gets and sets the property DaemonTaskDefinitionArn. 
        /// <para>
        /// The full Amazon Resource Name (ARN) of the daemon task definition.
        /// </para>
        /// </summary>
        public string DaemonTaskDefinitionArn
        {
            get { return this._daemonTaskDefinitionArn; }
            set { this._daemonTaskDefinitionArn = value; }
        }

        // Check to see if DaemonTaskDefinitionArn property is set
        internal bool IsSetDaemonTaskDefinitionArn()
        {
            return this._daemonTaskDefinitionArn != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteRequestedAt. 
        /// <para>
        /// The Unix timestamp for the time when the daemon task definition delete was requested.
        /// </para>
        /// </summary>
        public DateTime? DeleteRequestedAt
        {
            get { return this._deleteRequestedAt; }
            set { this._deleteRequestedAt = value; }
        }

        // Check to see if DeleteRequestedAt property is set
        internal bool IsSetDeleteRequestedAt()
        {
            return this._deleteRequestedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task execution role that grants the Amazon ECS
        /// container agent permission to make Amazon Web Services API calls on your behalf.
        /// </para>
        /// </summary>
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Family. 
        /// <para>
        /// The name of a family that this daemon task definition is registered to.
        /// </para>
        /// </summary>
        public string Family
        {
            get { return this._family; }
            set { this._family = value; }
        }

        // Check to see if Family property is set
        internal bool IsSetFamily()
        {
            return this._family != null;
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The amount of memory (in MiB) used by the daemon task.
        /// </para>
        /// </summary>
        public string Memory
        {
            get { return this._memory; }
            set { this._memory = value; }
        }

        // Check to see if Memory property is set
        internal bool IsSetMemory()
        {
            return this._memory != null;
        }

        /// <summary>
        /// Gets and sets the property RegisteredAt. 
        /// <para>
        /// The Unix timestamp for the time when the daemon task definition was registered.
        /// </para>
        /// </summary>
        public DateTime? RegisteredAt
        {
            get { return this._registeredAt; }
            set { this._registeredAt = value; }
        }

        // Check to see if RegisteredAt property is set
        internal bool IsSetRegisteredAt()
        {
            return this._registeredAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegisteredBy. 
        /// <para>
        /// The principal that registered the daemon task definition.
        /// </para>
        /// </summary>
        public string RegisteredBy
        {
            get { return this._registeredBy; }
            set { this._registeredBy = value; }
        }

        // Check to see if RegisteredBy property is set
        internal bool IsSetRegisteredBy()
        {
            return this._registeredBy != null;
        }

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
        public int? Revision
        {
            get { return this._revision; }
            set { this._revision = value; }
        }

        // Check to see if Revision property is set
        internal bool IsSetRevision()
        {
            return this._revision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the daemon task definition. The valid values are <c>ACTIVE</c>, <c>DELETE_IN_PROGRESS</c>,
        /// and <c>DELETED</c>.
        /// </para>
        /// </summary>
        public DaemonTaskDefinitionStatus Status
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
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the IAM role that grants containers
        /// in the daemon task permission to call Amazon Web Services APIs on your behalf.
        /// </para>
        /// </summary>
        public string TaskRoleArn
        {
            get { return this._taskRoleArn; }
            set { this._taskRoleArn = value; }
        }

        // Check to see if TaskRoleArn property is set
        internal bool IsSetTaskRoleArn()
        {
            return this._taskRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Volumes. 
        /// <para>
        /// The list of data volume definitions for the daemon task.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DaemonVolume> Volumes
        {
            get { return this._volumes; }
            set { this._volumes = value; }
        }

        // Check to see if Volumes property is set
        internal bool IsSetVolumes()
        {
            return this._volumes != null && (this._volumes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}