﻿/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;


namespace Amazon.SQS.Model
{
    /// <summary>
    /// This is a batch version of <c>SendMessage</c>. It takes
    /// multiple messages and adds each of them to the queue. The result of each 
    /// add operation is reported individually in the response.
    /// </summary>
    public class SendMessageBatchRequest
    {
        private string queueUrlField;
        private List<SendMessageBatchRequestEntry> sendMessageBatchRequestEntryField;

        /// <summary>
        /// Gets and sets the QueueUrl property.
        /// The URL associated with the Amazon SQS queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueUrl")]
        public string QueueUrl
        {
            get { return this.queueUrlField; }
            set { this.queueUrlField = value; }
        }

        /// <summary>
        /// Sets the QueueUrl property
        /// </summary>
        /// <param name="queueUrl">The URL associated with the Amazon SQS queue.</param>
        /// <returns>this instance</returns>
        public SendMessageBatchRequest WithQueueUrl(string queueUrl)
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
        /// Gets and sets the Entries property.  A list of <c>SendMessageBatchRequestEntries</c>.
        /// </summary>
        public List<SendMessageBatchRequestEntry> Entries
        {
            get
            {
                if (this.sendMessageBatchRequestEntryField == null)
                {
                    this.sendMessageBatchRequestEntryField = new List<SendMessageBatchRequestEntry>();
                }
                return this.sendMessageBatchRequestEntryField;
            }
            set { this.sendMessageBatchRequestEntryField = value; }
        }

        /// <summary>
        /// Sets the Entries property
        /// </summary>
        /// <param name="list">A list of <c>SendMessageBatchRequestEntry</c> that will be added to the <c>Entries</c> property.</param>
        /// <returns>this instance</returns>
        public SendMessageBatchRequest WithEntries(params SendMessageBatchRequestEntry[] list)
        {
            foreach (SendMessageBatchRequestEntry item in list)
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
            return (sendMessageBatchRequestEntryField.Count > 0);
        }

    }
}
