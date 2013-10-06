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

namespace Amazon.SimpleEmail.Model
{
    /// <summary>
    /// <para>Represents a unique message ID returned from a successful <c>SendRawEmail</c> request. </para>
    /// </summary>
    public class SendRawEmailResult  
    {
        
        private string messageId;

        /// <summary>
        /// The unique message identifier returned from the <c>SendRawEmail</c> action.
        ///  
        /// </summary>
        public string MessageId
        {
            get { return this.messageId; }
            set { this.messageId = value; }
        }

        /// <summary>
        /// Sets the MessageId property
        /// </summary>
        /// <param name="messageId">The value to set for the MessageId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SendRawEmailResult WithMessageId(string messageId)
        {
            this.messageId = messageId;
            return this;
        }
            

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this.messageId != null;       
        }
    }
}
