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
 * Do not modify this file. This file is generated from the workmailmessageflow-2019-05-01.normal.json service model.
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
namespace Amazon.WorkMailMessageFlow.Model
{
    /// <summary>
    /// Container for the parameters to the PutRawMessageContent operation.
    /// Updates the raw content of an in-transit email message, in MIME format.
    /// 
    ///  
    /// <para>
    /// This example describes how to update in-transit email message. For more information
    /// and examples for using this API, see <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/update-with-lambda.html">
    /// Updating message content with AWS Lambda</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Updates to an in-transit message only appear when you call <c>PutRawMessageContent</c>
    /// from an AWS Lambda function configured with a synchronous <a href="https://docs.aws.amazon.com/workmail/latest/adminguide/lambda.html#synchronous-rules">
    /// Run Lambda</a> rule. If you call <c>PutRawMessageContent</c> on a delivered or sent
    /// message, the message remains unchanged, even though <a href="https://docs.aws.amazon.com/workmail/latest/APIReference/API_messageflow_GetRawMessageContent.html">GetRawMessageContent</a>
    /// returns an updated message. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class PutRawMessageContentRequest : AmazonWorkMailMessageFlowRequest
    {
        private RawMessageContent _content;
        private string _messageId;

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// Describes the raw message content of the updated email message.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RawMessageContent Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null;
        }

        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The identifier of the email message being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=120)]
        public string MessageId
        {
            get { return this._messageId; }
            set { this._messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this._messageId != null;
        }

    }
}