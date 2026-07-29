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
    /// Container for the parameters to the CancelPipelineExecution operation.
    /// Cancels a pipeline execution in the specified workspace. If the execution is not in
    /// a terminal state (such as NOT_STARTED or RUNNING), it transitions to CANCELLING and
    /// asynchronously to CANCELLED. This operation is idempotent: calling it on an execution
    /// that is already CANCELLING or CANCELLED returns success with the current state. Calling
    /// it on a terminal execution (SUCCEEDED or FAILED) returns a conflict error. You can
    /// optionally provide a reason; it is returned in the stateDetails field when you describe
    /// the execution.
    /// </summary>
    public partial class CancelPipelineExecutionRequest : AmazonIoTSiteWiseRequest
    {
        private string _pipelineExecutionId;
        private string _pipelineName;
        private string _reason;
        private string _workspaceName;

        /// <summary>
        /// Gets and sets the property PipelineExecutionId. 
        /// <para>
        /// The unique identifier of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string PipelineExecutionId
        {
            get { return this._pipelineExecutionId; }
            set { this._pipelineExecutionId = value; }
        }

        // Check to see if PipelineExecutionId property is set
        internal bool IsSetPipelineExecutionId()
        {
            return this._pipelineExecutionId != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline.
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
        /// Gets and sets the property Reason. 
        /// <para>
        /// A message describing why the pipeline execution is being cancelled.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Reason
        {
            get { return this._reason; }
            set { this._reason = value; }
        }

        // Check to see if Reason property is set
        internal bool IsSetReason()
        {
            return this._reason != null;
        }

        /// <summary>
        /// Gets and sets the property WorkspaceName. 
        /// <para>
        /// The name of the workspace.
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