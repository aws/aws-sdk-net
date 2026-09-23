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

namespace Amazon.ChimeSDKVoice.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateSipMediaApplicationCall operation. Invokes
    /// the AWS Lambda function associated with the SIP media application and transaction
    /// ID in an update request. The Lambda function can then return a new set of actions.
    /// </summary>
    public partial class UpdateSipMediaApplicationCallRequest : AmazonChimeSDKVoiceRequest
    {
        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// Arguments made available to the Lambda function as part of the <c>CALL_UPDATE_REQUESTED</c>
        /// event. Can contain 0-20 key-value pairs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 20)]
        public Dictionary<string, string> Arguments { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Arguments property is set.
        /// </summary>
        internal bool IsSetArguments() => this.Arguments != null && (this.Arguments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SipMediaApplicationId. 
        /// <para>
        /// The ID of the SIP media application handling the call.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SipMediaApplicationId { get; set; }

        /// <summary>
        /// Checks to see if the SipMediaApplicationId property is set.
        /// </summary>
        internal bool IsSetSipMediaApplicationId() => this.SipMediaApplicationId != null;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The ID of the call transaction.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;
    }
}
