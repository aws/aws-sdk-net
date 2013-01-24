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

namespace Amazon.ElastiCache.Model
{
    /// <summary>
    /// <para> Contains pair of Topic and Topic Status. </para>
    /// </summary>
    public class NotificationConfiguration
    {
        
        private string topicArn;
        private string topicStatus;

        /// <summary>
        /// Specifies the topic Amazon Resource Name (ARN), identifying this resource.
        ///  
        /// </summary>
        public string TopicArn
        {
            get { return this.topicArn; }
            set { this.topicArn = value; }
        }

        /// <summary>
        /// Sets the TopicArn property
        /// </summary>
        /// <param name="topicArn">The value to set for the TopicArn property </param>
        /// <returns>this instance</returns>
        public NotificationConfiguration WithTopicArn(string topicArn)
        {
            this.topicArn = topicArn;
            return this;
        }
            

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this.topicArn != null;
        }

        /// <summary>
        /// Specifies the current state of this topic.
        ///  
        /// </summary>
        public string TopicStatus
        {
            get { return this.topicStatus; }
            set { this.topicStatus = value; }
        }

        /// <summary>
        /// Sets the TopicStatus property
        /// </summary>
        /// <param name="topicStatus">The value to set for the TopicStatus property </param>
        /// <returns>this instance</returns>
        public NotificationConfiguration WithTopicStatus(string topicStatus)
        {
            this.topicStatus = topicStatus;
            return this;
        }
            

        // Check to see if TopicStatus property is set
        internal bool IsSetTopicStatus()
        {
            return this.topicStatus != null;
        }
    }
}
