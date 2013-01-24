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
    /// Removes multiple messages from the specified queue.
    /// </summary>
    /// <remarks>
    /// This operation takes multiple receipt handles and deletes each one of the messages.
    /// The result of the delete operation on each message is reported individually in the response.
    /// </remarks>
    public class DeleteMessageBatchRequest : SQSRequest
    {
        private string queueUrlField;
        private List<DeleteMessageBatchRequestEntry> deleteMessageBatchRequestEntryField;

        /// <summary>
        /// The URL associated with the Amazon SQS queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueUrl")]
        public string QueueUrl
        {
            get { return this.queueUrlField; }
            set { this.queueUrlField = value; }
        }

        /// <summary>
        /// Sets the URL associated with the Amazon SQS queue.
        /// </summary>
        /// <param name="queueUrl">The URL associated with the Amazon SQS queue.</param>
        /// <returns>this instance</returns>
        public DeleteMessageBatchRequest WithQueueUrl(string queueUrl)
        {
            this.queueUrlField = queueUrl;
            return this;
        }

        /// <summary>
        /// Checks if QueueUrl property is set
        /// </summary>
        /// <returns>true if QueueUrl property is set</returns>
        public bool IsSetQueueUrl()
        {
            return this.queueUrlField != null;
        }

        /// <summary>
        /// A list of receipt handles for the messages to be deleted.
        /// </summary>
        public List<DeleteMessageBatchRequestEntry> Entries
        {
            get
            {
                if (this.deleteMessageBatchRequestEntryField == null)
                {
                    this.deleteMessageBatchRequestEntryField = new List<DeleteMessageBatchRequestEntry>();
                }
                return this.deleteMessageBatchRequestEntryField;
            }
            set { this.deleteMessageBatchRequestEntryField = value; }
        }

        /// <summary>
        /// Sets the list of receipt handles for the messages to be deleted.
        /// </summary>
        /// <param name="list">A list of <c>DeleteMessageBatchRequestEntry</c> that will be added to the <c>Entries</c> property.</param>
        /// <returns>this instance</returns>
        public DeleteMessageBatchRequest WithEntries(params DeleteMessageBatchRequestEntry[] list)
        {
            foreach (DeleteMessageBatchRequestEntry item in list)
            {
                Entries.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Entries property is set
        /// </summary>
        /// <returns>true if Entries property is set</returns>
        public bool IsSetEntries()
        {
            return (deleteMessageBatchRequestEntryField.Count > 0);
        }
    }
}
