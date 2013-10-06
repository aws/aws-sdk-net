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

namespace Amazon.SecurityToken.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class DecodeAuthorizationMessageResult
    {
        
        private string decodedMessage;

        /// <summary>
        /// An XML document that contains the decoded message.
        ///  
        /// </summary>
        public string DecodedMessage
        {
            get { return this.decodedMessage; }
            set { this.decodedMessage = value; }
        }

        /// <summary>
        /// Sets the DecodedMessage property
        /// </summary>
        /// <param name="decodedMessage">The value to set for the DecodedMessage property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public DecodeAuthorizationMessageResult WithDecodedMessage(string decodedMessage)
        {
            this.decodedMessage = decodedMessage;
            return this;
        }
            

        // Check to see if DecodedMessage property is set
        internal bool IsSetDecodedMessage()
        {
            return this.decodedMessage != null;
        }
    }
}
