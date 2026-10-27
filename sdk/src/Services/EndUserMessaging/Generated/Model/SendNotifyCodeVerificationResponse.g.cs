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

namespace Amazon.EndUserMessaging.Model
{
    /// <summary>
    /// This is the response object from the SendNotifyCodeVerification operation.
    /// </summary>
    public partial class SendNotifyCodeVerificationResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property MessageId. 
        /// <para>
        /// The service-generated identifier for the message that delivers the one-time passcode.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string MessageId { get; set; }

        /// <summary>
        /// Checks to see if the MessageId property is set.
        /// </summary>
        internal bool IsSetMessageId() => this.MessageId != null;

        /// <summary>
        /// Gets and sets the property VerificationId. 
        /// <para>
        /// The service-generated identifier for the verification.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 64)]
        public string VerificationId { get; set; }

        /// <summary>
        /// Checks to see if the VerificationId property is set.
        /// </summary>
        internal bool IsSetVerificationId() => this.VerificationId != null;
    }
}
