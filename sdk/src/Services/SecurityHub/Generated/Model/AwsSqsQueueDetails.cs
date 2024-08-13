/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Data about a queue.
    /// </summary>
    public partial class AwsSqsQueueDetails
    {
        private string _deadLetterTargetArn;
        private int? _kmsDataKeyReusePeriodSeconds;
        private string _kmsMasterKeyId;
        private string _queueName;

        /// <summary>
        /// Gets and sets the property DeadLetterTargetArn. 
        /// <para>
        /// The ARN of the dead-letter queue to which Amazon SQS moves messages after the value
        /// of <c>maxReceiveCount</c> is exceeded. 
        /// </para>
        /// </summary>
        public string DeadLetterTargetArn
        {
            get { return this._deadLetterTargetArn; }
            set { this._deadLetterTargetArn = value; }
        }

        // Check to see if DeadLetterTargetArn property is set
        internal bool IsSetDeadLetterTargetArn()
        {
            return this._deadLetterTargetArn != null;
        }

        /// <summary>
        /// Gets and sets the property KmsDataKeyReusePeriodSeconds. 
        /// <para>
        /// The length of time, in seconds, for which Amazon SQS can reuse a data key to encrypt
        /// or decrypt messages before calling KMS again.
        /// </para>
        /// </summary>
        public int? KmsDataKeyReusePeriodSeconds
        {
            get { return this._kmsDataKeyReusePeriodSeconds; }
            set { this._kmsDataKeyReusePeriodSeconds = value; }
        }

        // Check to see if KmsDataKeyReusePeriodSeconds property is set
        internal bool IsSetKmsDataKeyReusePeriodSeconds()
        {
            return this._kmsDataKeyReusePeriodSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property KmsMasterKeyId. 
        /// <para>
        /// The ID of an Amazon Web Services managed key for Amazon SQS or a custom KMS key.
        /// </para>
        /// </summary>
        public string KmsMasterKeyId
        {
            get { return this._kmsMasterKeyId; }
            set { this._kmsMasterKeyId = value; }
        }

        // Check to see if KmsMasterKeyId property is set
        internal bool IsSetKmsMasterKeyId()
        {
            return this._kmsMasterKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property QueueName. 
        /// <para>
        /// The name of the new queue.
        /// </para>
        /// </summary>
        public string QueueName
        {
            get { return this._queueName; }
            set { this._queueName = value; }
        }

        // Check to see if QueueName property is set
        internal bool IsSetQueueName()
        {
            return this._queueName != null;
        }

    }
}