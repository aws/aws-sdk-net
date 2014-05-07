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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SQS.Model
{
    /// <summary>
    /// 
    /// </summary>
    public partial class ChangeMessageVisibilityRequest : AmazonSQSRequest
    {
        private string _queueUrl;
        private string _receiptHandle;
        private int? _visibilityTimeout;


        /// <summary>
        /// Gets and sets the property QueueUrl. 
        /// <para>
        /// The URL of the Amazon SQS queue to take action on.
        /// </para>
        /// </summary>
        public string QueueUrl
        {
            get { return this._queueUrl; }
            set { this._queueUrl = value; }
        }

        // Check to see if QueueUrl property is set
        internal bool IsSetQueueUrl()
        {
            return this._queueUrl != null;
        }


        /// <summary>
        /// Gets and sets the property ReceiptHandle. 
        /// <para>
        /// The receipt handle associated with the message whose visibility timeout      should
        /// be changed. This parameter is returned by the <a>ReceiveMessage</a> action.
        /// </para>
        /// </summary>
        public string ReceiptHandle
        {
            get { return this._receiptHandle; }
            set { this._receiptHandle = value; }
        }

        // Check to see if ReceiptHandle property is set
        internal bool IsSetReceiptHandle()
        {
            return this._receiptHandle != null;
        }


        /// <summary>
        /// Gets and sets the property VisibilityTimeout. 
        /// <para>
        /// The new value (in seconds - from 0 to 43200 - maximum 12 hours) for the message's
        /// visibility timeout.
        /// </para>
        /// </summary>
        public int VisibilityTimeout
        {
            get { return this._visibilityTimeout.GetValueOrDefault(); }
            set { this._visibilityTimeout = value; }
        }

        // Check to see if VisibilityTimeout property is set
        internal bool IsSetVisibilityTimeout()
        {
            return this._visibilityTimeout.HasValue; 
        }

    }
}