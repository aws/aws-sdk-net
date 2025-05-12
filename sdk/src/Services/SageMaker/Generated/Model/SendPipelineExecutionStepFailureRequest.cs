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
    /// Container for the parameters to the SendPipelineExecutionStepFailure operation.
    /// Notifies the pipeline that the execution of a callback step failed, along with a message
    /// describing why. When a callback step is run, the pipeline generates a callback token
    /// and includes the token in a message sent to Amazon Simple Queue Service (Amazon SQS).
    /// </summary>
    public partial class SendPipelineExecutionStepFailureRequest : AmazonSageMakerRequest
    {
        private string _callbackToken;
        private string _clientRequestToken;
        private string _failureReason;

        /// <summary>
        /// Gets and sets the property CallbackToken. 
        /// <para>
        /// The pipeline generated token from the Amazon SQS queue.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string CallbackToken
        {
            get { return this._callbackToken; }
            set { this._callbackToken = value; }
        }

        // Check to see if CallbackToken property is set
        internal bool IsSetCallbackToken()
        {
            return this._callbackToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the operation. An idempotent operation completes no more than one time.
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A message describing why the step failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

    }
}