/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2011-10-01
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;


namespace Amazon.SQS.Model
{
    /// <summary>
    /// Encloses a receipt handle and an entry id for each message in
    /// <c>ChangeMessageVisibilityBatchRequest</c>.
    /// </summary>
    public class ChangeMessageVisibilityBatchRequestEntry
    {
        private string idField;
        private string receiptHandleField;
        private int? visibilityTimeoutField;

        /// <summary>
        /// Gets and sets the Id property.  An identifier for this particular receipt handle. This is used to communicate
        /// the result. Note that the <c>Id</c>s of a batch request need to be
        /// unique within the request.
        /// </summary>
        public string Id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }


        /// <summary>
        /// Sets the Id property
        /// </summary>
        /// <param name="id">An identifier for this particular receipt handle.</param>
        /// <returns>this instance</returns>
        public ChangeMessageVisibilityBatchRequestEntry WithId(string id)
        {
            this.idField = id;
            return this;
        }

        /// <summary>
        /// Checks if Id property is set
        /// </summary>
        /// <returns>true if Id property is set</returns>
        public bool IsSetId()
        {
            return this.idField != null;
        }

        /// <summary>
        /// Gets and sets the ReceiptHandle property.
        /// </summary>
        public string ReceiptHandle
        {
            get { return this.receiptHandleField; }
            set { this.receiptHandleField = value; }
        }

        /// <summary>
        /// Sets the ReceiptHandle property
        /// </summary>
        /// <param name="receiptHandle">A receipt handle.</param>
        /// <returns>this instance</returns>
        public ChangeMessageVisibilityBatchRequestEntry WithReceiptHandle(string receiptHandle)
        {
            this.receiptHandleField = receiptHandle;
            return this;
        }

        /// <summary>
        /// Checks if ReceiptHandle property is set
        /// </summary>
        /// <returns>true if ReceiptHandle property is set</returns>
        public bool IsSetReceiptHandle()
        {
            return this.receiptHandleField != null;
        }

        /// <summary>
        /// Gets and sets the VisibilityTimeout property.  The new value (in seconds) for the message's visibility timeout.
        /// </summary>
        public int VisibilityTimeout
        {
            get { return this.visibilityTimeoutField.GetValueOrDefault(); }
            set { this.visibilityTimeoutField = value; }
        }

        /// <summary>
        /// Sets the VisibilityTimeout property. The new value (in seconds) for the message's visibility timeout.
        /// </summary>
        /// <param name="visibilityTimeout">The new value (in seconds) for the message's visibility timeout.</param>
        /// <returns>this instance</returns>
        public ChangeMessageVisibilityBatchRequestEntry WithVisibilityTimeout(int visibilityTimeout)
        {
            this.visibilityTimeoutField = visibilityTimeout;
            return this;
        }

        /// <summary>
        /// Checks if VisibilityTimeout property is set
        /// </summary>
        /// <returns>true if VisibilityTimeout property is set</returns>
        public bool IsSetVisibilityTimeout()
        {
            return this.visibilityTimeoutField.HasValue;
        }
    }
}
