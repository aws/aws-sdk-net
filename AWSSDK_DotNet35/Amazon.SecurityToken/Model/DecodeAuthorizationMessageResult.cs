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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// <para>A document that contains additional information about the authorization status of a request from an encoded message that is returned
    /// in response to an AWS request. </para>
    /// </summary>
    public partial class DecodeAuthorizationMessageResult : AmazonWebServiceResponse
    {
        
        private string decodedMessage;


        /// <summary>
        /// An XML document that contains the decoded message. For more information, see <c>DecodeAuthorizationMessage</c>.
        ///  
        /// </summary>
        public string DecodedMessage
        {
            get { return this.decodedMessage; }
            set { this.decodedMessage = value; }
        }

        // Check to see if DecodedMessage property is set
        internal bool IsSetDecodedMessage()
        {
            return this.decodedMessage != null;
        }
    }
}
