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
 * Do not modify this file. This file is generated from the iotsitewise-2019-12-02.normal.json service model.
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
namespace Amazon.IoTSiteWise.Model
{
    /// <summary>
    /// Container for the parameters to the StartPipelineExecution operation.
    /// Starts execution of a pipeline in the specified workspace. Each compute node runs
    /// according to the DAG dependency order defined in the pipeline. Nodes without dependencies
    /// start immediately, while dependent nodes wait for all upstream nodes to complete successfully.
    /// 
    ///  
    /// <para>
    /// You can provide runtime environment variable overrides that take the highest priority
    /// in the environment variable hierarchy, without modifying the pipeline definition.
    /// </para>
    /// </summary>
    public partial class StartPipelineExecutionRequest : AmazonIoTSiteWiseRequest
    {
        private string _clientToken;
        private ExecutionEnvironmentVariables _executionEnvironmentVariableOverrides;
        private MountOverrides _executionMountOverrides;
        private int? _executionPriority;
        private string _pipelineName;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If you retry a request that completed successfully using the same client
        /// token, the server returns the cached result from the original successful request without
        /// performing the operation again.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=64)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionEnvironmentVariableOverrides. 
        /// <para>
        /// Runtime environment variable overrides for the execution. Includes global variables
        /// that apply to all compute nodes and computeNodes for per-node overrides. These take
        /// the highest priority in the environment variable hierarchy.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public ExecutionEnvironmentVariables ExecutionEnvironmentVariableOverrides
        {
            get { return this._executionEnvironmentVariableOverrides; }
            set { this._executionEnvironmentVariableOverrides = value; }
        }

        // Check to see if ExecutionEnvironmentVariableOverrides property is set
        internal bool IsSetExecutionEnvironmentVariableOverrides()
        {
            return this._executionEnvironmentVariableOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionMountOverrides. 
        /// <para>
        /// Runtime mount overrides for the execution. Overrides are merged by mount name into
        /// each listed compute node's task-defined mounts: a matching name replaces the task-defined
        /// mount, a new name adds a mount, and task-defined mounts not referenced remain unchanged.
        /// Compute nodes not listed use their task-defined mounts as-is.
        /// </para>
        /// </summary>
        public MountOverrides ExecutionMountOverrides
        {
            get { return this._executionMountOverrides; }
            set { this._executionMountOverrides = value; }
        }

        // Check to see if ExecutionMountOverrides property is set
        internal bool IsSetExecutionMountOverrides()
        {
            return this._executionMountOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionPriority. 
        /// <para>
        /// Scheduling priority for the execution. Lower values indicate higher priority. Defaults
        /// to 2 when not specified.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2)]
        public int? ExecutionPriority
        {
            get { return this._executionPriority; }
            set { this._executionPriority = value; }
        }

        // Check to see if ExecutionPriority property is set
        internal bool IsSetExecutionPriority()
        {
            return this._executionPriority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline to execute.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string PipelineName
        {
            get { return this._pipelineName; }
            set { this._pipelineName = value; }
        }

        // Check to see if PipelineName property is set
        internal bool IsSetPipelineName()
        {
            return this._pipelineName != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace containing the pipeline.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string WorkspaceName
        {
            get { return this._workspaceName; }
            set { this._workspaceName = value; }
        }

        // Check to see if WorkspaceName property is set
        internal bool IsSetWorkspaceName()
        {
            return this._workspaceName != null;
        }

    }
}