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
 * Do not modify this file. This file is generated from the chime-sdk-voice-2022-08-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSipMediaApplicationCall operation.
    /// Invokes the AWS Lambda function associated with the SIP media application and transaction
    /// ID in an update request. The Lambda function can then return a new set of actions.
    /// </summary>
    public partial class UpdateSipMediaApplicationCallRequest : AmazonChimeSDKVoiceRequest
    {
        private Dictionary<string, string> _arguments = new Dictionary<string, string>();
        private string _sipMediaApplicationId;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// Arguments made available to the Lambda function as part of the <code>CALL_UPDATE_REQUESTED</code>
        /// event. Can contain 0-20 key-value pairs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=20)]
        public Dictionary<string, string> Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null && this._arguments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SipMediaApplicationId. 
        /// <para>
        /// The ID of the SIP media application handling the call.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SipMediaApplicationId
        {
            get { return this._sipMediaApplicationId; }
            set { this._sipMediaApplicationId = value; }
        }

        // Check to see if SipMediaApplicationId property is set
        internal bool IsSetSipMediaApplicationId()
        {
            return this._sipMediaApplicationId != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The ID of the call transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

    }
}