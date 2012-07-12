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
    /// <summary>
    /// Allows a topic owner to set a topic's attributes.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class SetTopicAttributesRequest
    {    
        private string topicArnField;
        private string attributeNameField;
        private string attributeValueField;

        /// <summary>
        /// Gets and sets the TopicArn property.
        /// The Amazon Reference Name (ARN) of the topic the client wishes
        /// to set the attribute value of.
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
        /// <param name="topicArn">The Amazon Reference Name (ARN) of the topic the client wishes
        /// to set the attribute value of.</param>
        /// <returns>this instance</returns>
        public SetTopicAttributesRequest WithTopicArn(string topicArn)
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

        /// <summary>
        /// Gets and sets the AttributeName property.
        /// The name of the attribute the client wishes to set.
        /// Only a subset of a topic's attributes can be set.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeName")]
        public string AttributeName
        {
            get { return this.attributeNameField; }
            set { this.attributeNameField = value; }
        }

        /// <summary>
        /// Sets the AttributeName property
        /// </summary>
        /// <param name="attributeName">The name of the attribute the client wishes to set.
        /// Only a subset of a topic's attributes can be set.</param>
        /// <returns>this instance</returns>
        public SetTopicAttributesRequest WithAttributeName(string attributeName)
        {
            this.attributeNameField = attributeName;
            return this;
        }

        /// <summary>
        /// Checks if AttributeName property is set
        /// </summary>
        /// <returns>true if AttributeName property is set</returns>
        public bool IsSetAttributeName()
        {
            return this.attributeNameField != null;
        }

        /// <summary>
        /// Gets and sets the AttributeValue property.
        /// The value of the attribute the client wishes to set.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeValue")]
        public string AttributeValue
        {
            get { return this.attributeValueField; }
            set { this.attributeValueField = value; }
        }

        /// <summary>
        /// Sets the AttributeValue property
        /// </summary>
        /// <param name="attributeValue">The value of the attribute the client wishes to set.</param>
        /// <returns>this instance</returns>
        public SetTopicAttributesRequest WithAttributeValue(string attributeValue)
        {
            this.attributeValueField = attributeValue;
            return this;
        }

        /// <summary>
        /// Checks if AttributeValue property is set
        /// </summary>
        /// <returns>true if AttributeValue property is set</returns>
        public bool IsSetAttributeValue()
        {
            return this.attributeValueField != null;
        }

    }
}
