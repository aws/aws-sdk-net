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
    /// <para>This is used in the responses of batch API to give a detailed description of the result of an operation on each entry in the
    /// request.</para>
    /// </summary>
    public class BatchResultErrorEntry
    {
        
        private string id;
        private bool? senderFault;
        private string code;
        private string message;


        /// <summary>
        /// The id of an entry in a batch request.
        ///  
        /// </summary>
        public string Id
        {
            get { return this.id; }
            set { this.id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this.id != null;
        }

        /// <summary>
        /// Whether the error happened due to the sender's fault.
        ///  
        /// </summary>
        public bool SenderFault
        {
            get { return this.senderFault ?? default(bool); }
            set { this.senderFault = value; }
        }

        // Check to see if SenderFault property is set
        internal bool IsSetSenderFault()
        {
            return this.senderFault.HasValue;
        }

        /// <summary>
        /// An error code representing why the operation failed on this entry.
        ///  
        /// </summary>
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this.code != null;
        }

        /// <summary>
        /// A message explaining why the operation failed on this entry.
        ///  
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;
        }
    }
}
