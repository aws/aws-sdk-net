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
    /// <para>Encloses a receipt handle and an identifier for it.</para>
    /// </summary>
    public class DeleteMessageBatchRequestEntry
    {
        
        private string id;
        private string receiptHandle;


        /// <summary>
        /// An identifier for this particular receipt handle. This is used to communicate the result. Note that the <c>Id</c>s of a batch request need
        /// to be unique within the request.
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
        /// A receipt handle.
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
    }
}
