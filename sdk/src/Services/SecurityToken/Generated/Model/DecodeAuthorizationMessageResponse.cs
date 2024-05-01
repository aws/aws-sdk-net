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
 * Do not modify this file. This file is generated from the sts-2011-06-15.normal.json service model.
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
namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// A document that contains additional information about the authorization status of
    /// a request from an encoded message that is returned in response to an Amazon Web Services
    /// request.
    /// </summary>
    public partial class DecodeAuthorizationMessageResponse : AmazonWebServiceResponse
    {
        private string _decodedMessage;

        /// <summary>
        /// Gets and sets the property DecodedMessage. 
        /// <para>
        /// The API returns a response with the decoded message.
        /// </para>
        /// </summary>
        public string DecodedMessage
        {
            get { return this._decodedMessage; }
            set { this._decodedMessage = value; }
        }

        // Check to see if DecodedMessage property is set
        internal bool IsSetDecodedMessage()
        {
            return this._decodedMessage != null;
        }

    }
}