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
    /// <summary>List Dead Letter Source Queues Result
    /// </summary>
    [XmlRootAttribute(Namespace = "http://queue.amazonaws.com/doc/2012-11-05/", IsNullable = false)]
    public class ListDeadLetterSourceQueuesResult
    {
        private List<string> queueUrlField;

        /// <summary>
        /// For a given a queue, the queues that are configured to use
        /// that queue as a Dead Letter Queue.
        /// </summary>
        [XmlElementAttribute(ElementName = "QueueUrl")]
        public List<string> QueueUrl
        {
            get
            {
                if (this.queueUrlField == null)
                    this.queueUrlField = new List<string>();
                return this.queueUrlField;
            }
            set { this.queueUrlField = value; }
        }

        /// <summary>
        /// Checks if QueueUrls property is set
        /// </summary>
        /// <returns>true if QueueUrls property is set</returns>
        internal bool IsSetQueueUrls()
        {
            return this.QueueUrl.Count > 0;
        }
    }
}
