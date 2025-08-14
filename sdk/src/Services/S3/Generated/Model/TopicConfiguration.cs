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
    /// A container for specifying the configuration for publication of messages to an Amazon
    /// Simple Notification Service (Amazon SNS) topic when Amazon S3 detects specified events.
    /// 
    /// This class contains the configuration Amazon S3 uses to figure out what events you
    /// want to listen and send the event to an Amazon SNS topic. The topic's policy must
    /// allow S3 to publish messages to it. The utility method Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient.AuthorizeS3ToPublish(string,string)
    /// can be used to help setup the topic policy.
    /// </summary>
    public partial class TopicConfiguration : NotificationConfiguration
    {
        private string _id;
        private string _topic;

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
        /// Gets and sets the property Topic. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon SNS topic to which Amazon S3 publishes
        /// a message when it detects events of the specified type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Topic
        {
            get { return this._topic; }
            set { this._topic = value; }
        }

        // Check to see if Topic property is set
        internal bool IsSetTopic()
        {
            return this._topic != null;
        }

    }
}