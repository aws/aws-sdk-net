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

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the SetTopicAttributes operation.
    /// <para>The <c>SetTopicAttributes</c> action allows a topic owner to set an attribute of the topic to a new value.</para>
    /// </summary>
    public partial class SetTopicAttributesRequest : AmazonWebServiceRequest
    {
        private string topicArn;
        private string attributeName;
        private string attributeValue;
        /// <summary>
        /// Default constructor for a new SetTopicAttributesRequest object.  Callers should use the
        /// properties to initialize this object after creating it.
        /// </summary>
        public SetTopicAttributesRequest() {}
    
        /// <summary>
        /// Constructs a new SetTopicAttributesRequest object.
        /// Callers should use the properties initialize any additional object members.
        /// </summary>
        /// 
        /// <param name="topicArn"> The ARN of the topic to modify. </param>
        /// <param name="attributeName"> The name of the attribute you want to set. Only a subset of the topic's attributes are mutable. Valid values:
        /// <c>Policy</c> | <c>DisplayName</c> | <c>DeliveryPolicy</c> </param>
        /// <param name="attributeValue"> The new value for the attribute. </param>
        public SetTopicAttributesRequest(string topicArn, string attributeName, string attributeValue)
        {
            this.topicArn = topicArn;
            this.attributeName = attributeName;
            this.attributeValue = attributeValue;
        }
    

        /// <summary>
        /// The ARN of the topic to modify.
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

        /// <summary>
        /// The name of the attribute you want to set. Only a subset of the topic's attributes are mutable. Valid values: <c>Policy</c> |
        /// <c>DisplayName</c> | <c>DeliveryPolicy</c>
        ///  
        /// </summary>
        public string AttributeName
        {
            get { return this.attributeName; }
            set { this.attributeName = value; }
        }

        // Check to see if AttributeName property is set
        internal bool IsSetAttributeName()
        {
            return this.attributeName != null;
        }

        /// <summary>
        /// The new value for the attribute.
        ///  
        /// </summary>
        public string AttributeValue
        {
            get { return this.attributeValue; }
            set { this.attributeValue = value; }
        }

        // Check to see if AttributeValue property is set
        internal bool IsSetAttributeValue()
        {
            return this.attributeValue != null;
        }

    }
}
    
