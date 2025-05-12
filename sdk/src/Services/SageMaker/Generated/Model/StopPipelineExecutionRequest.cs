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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the StopPipelineExecution operation.
    /// Stops a pipeline execution.
    /// 
    ///  
    /// <para>
    ///  <b>Callback Step</b> 
    /// </para>
    ///  
    /// <para>
    /// A pipeline execution won't stop while a callback step is running. When you call <c>StopPipelineExecution</c>
    /// on a pipeline execution with a running callback step, SageMaker Pipelines sends an
    /// additional Amazon SQS message to the specified SQS queue. The body of the SQS message
    /// contains a "Status" field which is set to "Stopping".
    /// </para>
    ///  
    /// <para>
    /// You should add logic to your Amazon SQS message consumer to take any needed action
    /// (for example, resource cleanup) upon receipt of the message followed by a call to
    /// <c>SendPipelineExecutionStepSuccess</c> or <c>SendPipelineExecutionStepFailure</c>.
    /// </para>
    ///  
    /// <para>
    /// Only when SageMaker Pipelines receives one of these calls will it stop the pipeline
    /// execution.
    /// </para>
    ///  
    /// <para>
    ///  <b>Lambda Step</b> 
    /// </para>
    ///  
    /// <para>
    /// A pipeline execution can't be stopped while a lambda step is running because the Lambda
    /// function invoked by the lambda step can't be stopped. If you attempt to stop the execution
    /// while the Lambda function is running, the pipeline waits for the Lambda function to
    /// finish or until the timeout is hit, whichever occurs first, and then stops. If the
    /// Lambda function finishes, the pipeline execution status is <c>Stopped</c>. If the
    /// timeout is hit the pipeline execution status is <c>Failed</c>.
    /// </para>
    /// </summary>
    public partial class StopPipelineExecutionRequest : AmazonSageMakerRequest
    {
        private string _clientRequestToken;
        private string _pipelineExecutionArn;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the operation. An idempotent operation completes no more than once.
        /// </para>
        /// </summary>
        [AWSProperty(Min=32, Max=128)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property PipelineExecutionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the pipeline execution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string PipelineExecutionArn
        {
            get { return this._pipelineExecutionArn; }
            set { this._pipelineExecutionArn = value; }
        }

        // Check to see if PipelineExecutionArn property is set
        internal bool IsSetPipelineExecutionArn()
        {
            return this._pipelineExecutionArn != null;
        }

    }
}