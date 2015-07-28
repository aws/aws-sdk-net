/*
 * Copyright 2010-2015 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.S3.Model
{
    /// <summary>
    /// This class contains the configuration Amazon S3 uses to figure out what events you want to listen 
    /// and send the event to an Amazon SNS topic.
    /// <para>
    /// The topic's policy must allow S3 to publish messages to it. The utility method 
    /// Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient.AuthorizeS3ToPublish(string,string)
    /// can be used to help setup the topic policy.
    /// </para>
    /// </summary>
    public class TopicConfiguration : NotificationConfiguration
    {
        /// <summary>
        /// Gets and set the Id property. The Id will be provided in the event content and can be used 
        /// to identify which configuration caused an event to fire. If the Id is not provided for the configuration, one will be generated.
        /// </summary>
        public string Id { get; set; }

        internal bool IsSetId()
        {
            return this.Id != null;
        }

        /// <summary>
        /// Bucket event for which to send notifications.
        /// <para>
        /// Topic configurations can now contain multiple events. This property is obsolete in favor of the Events property.
        /// This property will aways get or set the the zeroth element in the Events collection.
        /// </para>
        /// </summary>
        [Obsolete("The Event property is now obsolete in favor the Events property.")]
        public string Event 
        { 
            get
            {
                if (!this.IsSetEvents())
                    return null;

                return this.Events[0];
            }
            set
            {
                if (this.Events == null)
                    this.Events = new List<EventType>();

                if (this.Events.Count == 0)
                    this.Events.Add(value);
                else
                    this.Events[0] = value;
            }
        }

        /// <summary>
        /// Gets and sets the Topic property. Amazon SNS topic to which Amazon S3 will publish a message to report the 
        /// specified events for the bucket.
        /// <para>
        /// The topic's policy must allow S3 to publish messages to it. The utility method 
        /// Amazon.SimpleNotificationService.AmazonSimpleNotificationServiceClient.AuthorizeS3ToPublish(string,string)
        /// can be used to help setup the topic policy.
        /// </para>
        /// </summary>
        public string Topic { get; set; }

        // Check to see if Topic property is set
        internal bool IsSetTopic()
        {
            return this.Topic != null;
        }
    }
}
