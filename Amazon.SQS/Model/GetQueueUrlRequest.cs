/*******************************************************************************
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
    /// The <c>GetQueueUrl</c> action returns the URL of an existing queue.
    /// </summary>
    public class GetQueueUrlRequest
    {
        public string queueNameField;
        public string queueOwnerAWSAccountIdField;

        /// <summary>
        /// Gets and sets the QueueName property.  The name of the queue whose URL must be fetched.
        /// </summary>
        public string QueueName
        {
            get { return this.queueNameField; }
            set { this.queueNameField = value; }
        }

        /// <summary>
        /// Sets the QueueName property
        /// </summary>
        /// <param name="queueNameField">The name of the queue whose URL must be fetched.</param>
        /// <returns>this instance</returns>
        public GetQueueUrlRequest WithQueueName(string queueNameField)
        {
            this.queueNameField = queueNameField;
            return this;
        }

        /// <summary>
        /// Checks if QueueName property is set
        /// </summary>
        /// <returns>true if QueueName property is set</returns>
        public bool IsSetQueueName()
        {
            return this.queueNameField != null;
        }

        /// <summary>
        /// Gets and sets the QueueOwnerAWSAccountId property.  The AWS account number of the queue's owner.
        /// </summary>
        public string QueueOwnerAWSAccountId
        {
            get { return this.queueOwnerAWSAccountIdField; }
            set { this.queueOwnerAWSAccountIdField = value; }
        }

        /// <summary>
        /// Sets the QueueOwnerAWSAccountId property
        /// </summary>
        /// <param name="id">The AWS account number of the queue's owner.</param>
        /// <returns>this instance</returns>
        public GetQueueUrlRequest WithQueueOwnerAWSAccountId(string id)
        {
            this.queueOwnerAWSAccountIdField = id;
            return this;
        }

        /// <summary>
        /// Checks if QueueOwnerAWSAccountId property is set
        /// </summary>
        /// <returns>true if QueueOwnerAWSAccountId property is set</returns>
        public bool IsSetQueueOwnerAWSAccountId()
        {
            return this.queueOwnerAWSAccountIdField != null;
        }
    }
}
