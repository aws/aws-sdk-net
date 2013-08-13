/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// Container for the parameters to the DecodeAuthorizationMessage operation.
    /// <para> Decodes additional information about the authorization status of a request from an encoded message returned in response to an AWS
    /// request. </para> <para> For example, if a user is not authorized to perform an action that he or she has requested, the request returns a
    /// <c>Client.UnauthorizedOperation</c> response (an HTTP 403 response). Some AWS actions additionally return an encoded message that can
    /// provide details about this authorization failure. </para> <para><b>NOTE:</b> Only certain AWS actions return an encoded authorization
    /// message. The documentation for an individual action indicates whether that action returns an encoded message in addition to returning an
    /// HTTP code. </para> <para>The message is encoded because the details of the authorization status can constitute privileged information that
    /// the user who requested the action should not see. To decode an authorization status message, a user must be granted permissions via an IAM
    /// policy to request the <c>DecodeAuthorizationMessage</c> (
    /// <c>sts:DecodeAuthorizationMessage</c> ) action. </para> <para> The decoded message includes the following type of
    /// information: </para>
    /// <ul>
    /// <li>Whether the request was denied due to an explicit deny or due to the absence of an explicit allow. For more information, see
    /// Determining Whether a Request is Allowed or Denied in <i>Using IAM</i> .
    /// </li>
    /// <li>The principal who made the request.</li>
    /// <li>The requested action.</li>
    /// <li>The requested resource.</li>
    /// <li>The values of condition keys in the context of the user's request.</li>
    /// 
    /// </ul>
    /// </summary>
    /// <seealso cref="Amazon.SecurityToken.AmazonSecurityTokenService.DecodeAuthorizationMessage"/>
    public class DecodeAuthorizationMessageRequest : AmazonWebServiceRequest
    {
        private string encodedMessage;

        /// <summary>
        /// The encoded message that was returned with the response.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 10240</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string EncodedMessage
        {
            get { return this.encodedMessage; }
            set { this.encodedMessage = value; }
        }

        /// <summary>
        /// Sets the EncodedMessage property
        /// </summary>
        /// <param name="encodedMessage">The value to set for the EncodedMessage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DecodeAuthorizationMessageRequest WithEncodedMessage(string encodedMessage)
        {
            this.encodedMessage = encodedMessage;
            return this;
        }
            

        // Check to see if EncodedMessage property is set
        internal bool IsSetEncodedMessage()
        {
            return this.encodedMessage != null;
        }
    }
}
    
