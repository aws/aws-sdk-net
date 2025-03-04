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
 * Do not modify this file. This file is generated from the codepipeline-2015-07-09.normal.json service model.
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
namespace Amazon.CodePipeline.Model
{
    /// <summary>
    /// Container for the parameters to the PutApprovalResult operation.
    /// Provides the response to a manual approval request to CodePipeline. Valid responses
    /// include Approved and Rejected.
    /// </summary>
    public partial class PutApprovalResultRequest : AmazonCodePipelineRequest
    {
        private string _actionName;
        private string _pipelineName;
        private ApprovalResult _result;
        private string _stageName;
        private string _token;

        /// <summary>
        /// Gets and sets the property ActionName. 
        /// <para>
        /// The name of the action for which approval is requested.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ActionName
        {
            get { return this._actionName; }
            set { this._actionName = value; }
        }

        // Check to see if ActionName property is set
        internal bool IsSetActionName()
        {
            return this._actionName != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineName. 
        /// <para>
        /// The name of the pipeline that contains the action. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
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
        /// Gets and sets the property Result. 
        /// <para>
        /// Represents information about the result of the approval request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApprovalResult Result
        {
            get { return this._result; }
            set { this._result = value; }
        }

        // Check to see if Result property is set
        internal bool IsSetResult()
        {
            return this._result != null;
        }

        /// <summary>
        /// Gets and sets the property StageName. 
        /// <para>
        /// The name of the stage that contains the action.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string StageName
        {
            get { return this._stageName; }
            set { this._stageName = value; }
        }

        // Check to see if StageName property is set
        internal bool IsSetStageName()
        {
            return this._stageName != null;
        }

        /// <summary>
        /// Gets and sets the property Token. 
        /// <para>
        /// The system-generated token used to identify a unique approval request. The token for
        /// each open approval request can be obtained using the <a>GetPipelineState</a> action.
        /// It is used to validate that the approval request corresponding to this token is still
        /// valid.
        /// </para>
        ///  <important> 
        /// <para>
        /// For a pipeline where the execution mode is set to PARALLEL, the token required to
        /// approve/reject an approval request as detailed above is not available. Instead, use
        /// the <c>externalExecutionId</c> in the response output from the <a>ListActionExecutions</a>
        /// action as the token in the approval request.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Token
        {
            get { return this._token; }
            set { this._token = value; }
        }

        // Check to see if Token property is set
        internal bool IsSetToken()
        {
            return this._token != null;
        }

    }
}