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
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
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
namespace Amazon.S3.Model
{
    /// <summary>
    /// Specifies the configuration for publishing messages to an Amazon Simple Queue Service
    /// (Amazon SQS) queue when Amazon S3 detects specified events.
    /// 
    /// This class contains the configuration Amazon S3 uses to figure out what events you
    /// want to listen and send the event to an Amazon SQS queue. <para>The queue's policy
    /// must allow S3 to send messages to it. The utility method Amazon.SQS.AmazonSQSClient.AuthorizeS3ToSendMessage(string,string)
    /// can be used to help setup the queue policy.</para>
    /// </summary>
    public partial class QueueConfiguration : NotificationConfiguration
    {
        private string _id;
        private string _queue;

        /// <summary>
        /// Gets and sets the property Id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Queue. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SQS queue to which Amazon S3 publishes
        /// a message when it detects events of the specified type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Queue
        {
            get { return this._queue; }
            set { this._queue = value; }
        }

        // Check to see if Queue property is set
        internal bool IsSetQueue()
        {
            return this._queue != null;
        }

    }
}