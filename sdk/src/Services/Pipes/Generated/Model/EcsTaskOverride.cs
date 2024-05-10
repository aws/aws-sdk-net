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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The overrides that are associated with a task.
    /// </summary>
    public partial class EcsTaskOverride
    {
        private List<EcsContainerOverride> _containerOverrides = AWSConfigs.InitializeCollections ? new List<EcsContainerOverride>() : null;
        private string _cpu;
        private EcsEphemeralStorage _ephemeralStorage;
        private string _executionRoleArn;
        private List<EcsInferenceAcceleratorOverride> _inferenceAcceleratorOverrides = AWSConfigs.InitializeCollections ? new List<EcsInferenceAcceleratorOverride>() : null;
        private string _memory;
        private string _taskRoleArn;

        /// <summary>
        /// Gets and sets the property ContainerOverrides. 
        /// <para>
        /// One or more container overrides that are sent to a task.
        /// </para>
        /// </summary>
        public List<EcsContainerOverride> ContainerOverrides
        {
            get { return this._containerOverrides; }
            set { this._containerOverrides = value; }
        }

        // Check to see if ContainerOverrides property is set
        internal bool IsSetContainerOverrides()
        {
            return this._containerOverrides != null && (this._containerOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Cpu. 
        /// <para>
        /// The cpu override for the task.
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
        /// Gets and sets the property EphemeralStorage. 
        /// <para>
        /// The ephemeral storage setting override for the task.
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is only supported for tasks hosted on Fargate that use the following
        /// platform versions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Linux platform version <c>1.4.0</c> or later.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Windows platform version <c>1.0.0</c> or later.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public EcsEphemeralStorage EphemeralStorage
        {
            get { return this._ephemeralStorage; }
            set { this._ephemeralStorage = value; }
        }

        // Check to see if EphemeralStorage property is set
        internal bool IsSetEphemeralStorage()
        {
            return this._ephemeralStorage != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the task execution IAM role override for the task.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task_execution_IAM_role.html">Amazon
        /// ECS task execution IAM role</a> in the <i>Amazon Elastic Container Service Developer
        /// Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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
        /// Gets and sets the property InferenceAcceleratorOverrides. 
        /// <para>
        /// The Elastic Inference accelerator override for the task.
        /// </para>
        /// </summary>
        public List<EcsInferenceAcceleratorOverride> InferenceAcceleratorOverrides
        {
            get { return this._inferenceAcceleratorOverrides; }
            set { this._inferenceAcceleratorOverrides = value; }
        }

        // Check to see if InferenceAcceleratorOverrides property is set
        internal bool IsSetInferenceAcceleratorOverrides()
        {
            return this._inferenceAcceleratorOverrides != null && (this._inferenceAcceleratorOverrides.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Memory. 
        /// <para>
        /// The memory override for the task.
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
        /// Gets and sets the property TaskRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that containers in this task can assume.
        /// All containers in this task are granted the permissions that are specified in this
        /// role. For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/task-iam-roles.html">IAM
        /// Role for Tasks</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
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

    }
}