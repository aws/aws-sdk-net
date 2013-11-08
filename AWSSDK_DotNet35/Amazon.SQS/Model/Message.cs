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

namespace Amazon.SQS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class Message
    {
        
        private string messageId;
        private string receiptHandle;
        private string mD5OfBody;
        private string body;
        private Dictionary<string,string> attributes = new Dictionary<string,string>();


        /// <summary>
        /// 
        ///  
        /// </summary>
        public string MessageId
        {
            get { return this.messageId; }
            set { this.messageId = value; }
        }

        // Check to see if MessageId property is set
        internal bool IsSetMessageId()
        {
            return this.messageId != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string ReceiptHandle
        {
            get { return this.receiptHandle; }
            set { this.receiptHandle = value; }
        }

        // Check to see if ReceiptHandle property is set
        internal bool IsSetReceiptHandle()
        {
            return this.receiptHandle != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string MD5OfBody
        {
            get { return this.mD5OfBody; }
            set { this.mD5OfBody = value; }
        }

        // Check to see if MD5OfBody property is set
        internal bool IsSetMD5OfBody()
        {
            return this.mD5OfBody != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public string Body
        {
            get { return this.body; }
            set { this.body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this.body != null;
        }

        /// <summary>
        /// 
        ///  
        /// </summary>
        public Dictionary<string,string> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this.attributes != null;
        }
    }
}
