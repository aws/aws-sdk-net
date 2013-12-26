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

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// <para>A wrapper type for the topic's Amazon Resource Name (ARN). To retrieve a topic's attributes, use <c>GetTopicAttributes</c> .</para>
    /// </summary>
    public class Topic
    {
        
        private string topicArn;

        /// <summary>
        /// Default constructor for a new Topic object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public Topic() {}
    

        /// <summary>
        /// The topic's ARN.
        ///  
        /// </summary>
        public string TopicArn
        {
            get { return this.topicArn; }
            set { this.topicArn = value; }
        }

        // Check to see if TopicArn property is set
        internal bool IsSetTopicArn()
        {
            return this.topicArn != null;
        }
    }
}
