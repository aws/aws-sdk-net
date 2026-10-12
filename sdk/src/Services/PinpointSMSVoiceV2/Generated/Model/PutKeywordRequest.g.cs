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

namespace Amazon.PinpointSMSVoiceV2.Model
{
    /// <summary>
    /// Container for the parameters to the PutKeyword operation. Creates or updates a keyword
    /// configuration on an origination phone number or pool. <para> A keyword is a word that
    /// you can search for on a particular phone number or pool. It is also a specific word
    /// or phrase that an end user can send to your number to elicit a response, such as an
    /// informational message or a special offer. When your number receives a message that
    /// begins with a keyword, End User Messaging SMS responds with a customizable message.
    /// </para> <para> If you specify a keyword that isn't valid, an error is returned. </para>
    /// </summary>
    public partial class PutKeywordRequest : AmazonPinpointSMSVoiceV2Request
    {
        /// <summary>
        /// Gets and sets the property Keyword. 
        /// <para>
        /// The new keyword to add.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 30)]
        public string Keyword { get; set; }

        /// <summary>
        /// Checks to see if the Keyword property is set.
        /// </summary>
        internal bool IsSetKeyword() => this.Keyword != null;

        /// <summary>
        /// Gets and sets the property KeywordAction. 
        /// <para>
        /// The action to perform for the new keyword when it is received.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// AUTOMATIC_RESPONSE: A message is sent to the recipient.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPT_OUT: Keeps the recipient from receiving future messages.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// OPT_IN: The recipient wants to receive future messages.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public KeywordAction KeywordAction { get; set; }

        /// <summary>
        /// Checks to see if the KeywordAction property is set.
        /// </summary>
        internal bool IsSetKeywordAction() => this.KeywordAction != null;

        /// <summary>
        /// Gets and sets the property KeywordMessage. 
        /// <para>
        /// The message associated with the keyword.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1600)]
        public string KeywordMessage { get; set; }

        /// <summary>
        /// Checks to see if the KeywordMessage property is set.
        /// </summary>
        internal bool IsSetKeywordMessage() => this.KeywordMessage != null;

        /// <summary>
        /// Gets and sets the property OriginationIdentity. 
        /// <para>
        /// The origination identity to use such as a PhoneNumberId, PhoneNumberArn, SenderId
        /// or SenderIdArn. You can use <a>DescribePhoneNumbers</a> get the values for PhoneNumberId
        /// and PhoneNumberArn while <a>DescribeSenderIds</a> can be used to get the values for
        /// SenderId and SenderIdArn.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you are using a shared End User Messaging SMS resource then you must use the full
        /// Amazon Resource Name(ARN).
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string OriginationIdentity { get; set; }

        /// <summary>
        /// Checks to see if the OriginationIdentity property is set.
        /// </summary>
        internal bool IsSetOriginationIdentity() => this.OriginationIdentity != null;
    }
}
