﻿/*******************************************************************************
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
    /// This is a batch version of <c>ChangeMessageVisibility</c>. It takes
    /// multiple receipt handles and performs the operation on each of the them. The
    /// result of the operation on each message is reported individually in the
    /// response.
    /// </summary>
    public class ChangeMessageVisibilityBatchRequest
    {
        private string queueUrlField;
        private List<ChangeMessageVisibilityBatchRequestEntry> changeMessageVisibilityBatchRequestEntryField;

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
        public ChangeMessageVisibilityBatchRequest WithQueueUrl(string queueUrl)
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
        /// Gets and sets the Entries property.  A list of receipt handles of the messages for which the visibility timeout
        /// must be changed.
        /// </summary>
        public List<ChangeMessageVisibilityBatchRequestEntry> Entries
        {
            get
            {
                if (this.changeMessageVisibilityBatchRequestEntryField == null)
                {
                    this.changeMessageVisibilityBatchRequestEntryField = new List<ChangeMessageVisibilityBatchRequestEntry>();
                }
                return this.changeMessageVisibilityBatchRequestEntryField;
            }
            set { this.changeMessageVisibilityBatchRequestEntryField = value; }
        }

        /// <summary>
        /// Sets the Entries property
        /// </summary>
        /// <param name="list">A list of <c>ChangeMessageVisibilityBatchRequestEntry</c> that will be added to the <c>Entries</c> property.</param>
        /// <returns>this instance</returns>
        public ChangeMessageVisibilityBatchRequest WithEntries(params ChangeMessageVisibilityBatchRequestEntry[] list)
        {
            foreach (ChangeMessageVisibilityBatchRequestEntry item in list)
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
            return (changeMessageVisibilityBatchRequestEntryField.Count > 0);
        }

    }
}
