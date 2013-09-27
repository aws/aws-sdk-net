/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2012-11-05
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Text;


namespace Amazon.SQS.Model
{
    /// <summary>
    /// A receipt handle and an entry id for each message.
    /// </summary>
    public class ChangeMessageVisibilityBatchRequestEntry
    {
        private string idField;
        private string receiptHandleField;
        private int? visibilityTimeoutField;

        /// <summary>
        /// An identifier for this particular receipt handle.
        /// This value is used to identify the message in the result.
        /// </summary>
        /// <remarks>
        /// The <c>Id</c>s of a batch request need to be unique within the request.
        /// </remarks>
        public string Id
        {
            get { return this.idField; }
            set { this.idField = value; }
        }


        /// <summary>
        /// Sets an identifier for this particular receipt handle.
        /// </summary>
        /// <param name="id">An identifier for this particular receipt handle.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The receipt handle associated with the message whose visibility timeout you want to change.
        /// </summary>
        /// <remarks>
        /// This parameter is returned by the ReceiveMessage action.
        /// </remarks>
        public string ReceiptHandle
        {
            get { return this.receiptHandleField; }
            set { this.receiptHandleField = value; }
        }

        /// <summary>
        /// Sets the receipt handle associated with the message whose visibility timeout you want to change.
        /// </summary>
        /// <param name="receiptHandle">A receipt handle.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
        /// The new value (in seconds) for the message's visibility timeout.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
