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

namespace Amazon.S3.Model
{
    /// <summary>Topic Configuration
    /// </summary>
    public class TopicConfiguration
    {
        /// <summary>
        /// Bucket event for which to send notifications.
        /// </summary>
        public string Event { get; set; }

        // Check to see if Event property is set
        internal bool IsSetEvent()
        {
            return this.Event != null;
        }

        /// <summary>
        /// Amazon SNS topic to which Amazon S3 will publish a message to report the specified events for the bucket.
        /// </summary>
        public string Topic { get; set; }

        // Check to see if Topic property is set
        internal bool IsSetTopic()
        {
            return this.Topic != null;
        }
    }
}
