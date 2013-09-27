/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.IO;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Sets an attribute of the topic to a new value.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class SetSubscriptionAttributesRequest : SNSRequest
    {
        private string subscriptionArnField;
        private string attributeNameField;
        private string attributeValueField;

        /// <summary>
        /// The Amazon Reference Name (ARN) of the subscription you want to set the attribute value of.
        /// </summary>
        [XmlElementAttribute(ElementName = "SubscriptionArn")]
        public string SubscriptionArn
        {
            get { return this.subscriptionArnField; }
            set { this.subscriptionArnField = value; }
        }

        /// <summary>
        /// Sets the Amazon Reference Name (ARN) of the subscription you want to set the attribute value of.
        /// </summary>
        /// <param name="subscriptionArn">The Amazon Reference Name (ARN) of the subscription.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetSubscriptionAttributesRequest WithSubscriptionArn(string subscriptionArn)
        {
            this.subscriptionArnField = subscriptionArn;
            return this;
        }

        /// <summary>
        /// Checks if TopicArn SubscriptionArn is set
        /// </summary>
        /// <returns>true if SubscriptionArn property is set</returns>
        public bool IsSetSubscriptionArn()
        {
            return this.subscriptionArnField != null;
        }

        /// <summary>
        /// The name of the attribute the client wishes to set.
        /// Only a subset of a subscription's attributes can be set.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeName")]
        public string AttributeName
        {
            get { return this.attributeNameField; }
            set { this.attributeNameField = value; }
        }

        /// <summary>
        /// Sets the name of the attribute you want to set.
        /// </summary>
        /// <param name="attributeName">The name of the attribute you want to set.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetSubscriptionAttributesRequest WithAttributeName(string attributeName)
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
        /// The value of the attribute you want to set.
        /// </summary>
        [XmlElementAttribute(ElementName = "AttributeValue")]
        public string AttributeValue
        {
            get { return this.attributeValueField; }
            set { this.attributeValueField = value; }
        }

        /// <summary>
        /// Sets the value of the attribute you want to set.
        /// </summary>
        /// <param name="attributeValue">The value of the attribute you want to set.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetSubscriptionAttributesRequest WithAttributeValue(string attributeValue)
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
