/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2010-03-31
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleNotificationService.Model
{
    ///<summary>
    ///A wrapper type for the topic's Amazon Resource Name (ARN).
    ///To retrieve a topic's attributes, use GetTopicAttributes.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class Topic
    {    
        private string topicArnField;

        /// <summary>
        /// Gets and sets the TopicArn property.
        /// </summary>
        [XmlElementAttribute(ElementName = "TopicArn")]
        public string TopicArn
        {
            get { return this.topicArnField; }
            set { this.topicArnField = value; }
        }

        /// <summary>
        /// Sets the TopicArn property
        /// </summary>
        /// <param name="topicArn">TopicArn property</param>
        /// <returns>this instance</returns>
        public Topic WithTopicArn(string topicArn)
        {
            this.topicArnField = topicArn;
            return this;
        }

        /// <summary>
        /// Checks if TopicArn property is set
        /// </summary>
        /// <returns>true if TopicArn property is set</returns>
        public bool IsSetTopicArn()
        {
            return this.topicArnField != null;
        }

    }
}
