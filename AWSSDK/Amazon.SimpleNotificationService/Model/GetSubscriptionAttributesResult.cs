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
    /// Encapsulates the result of the GetSubscriptionAttributes action.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class GetSubscriptionAttributesResult
    {
        private List<SubscriptionAttribute> attributesField;

        /// <summary>
        /// Gets and sets the Attributes property.
        /// A map of the subscription's attributes. Attributes in this map include the following:
        /// 
        ///     <ul>
        ///     <li>SubscriptionArn -- the subscription's ARN</li>
        ///     <li>TopicArn -- the topic ARN which the subscription is associated with</li>
        ///     <li>Owner -- the AWS account ID of the subscription's owner</li>
        ///     <li>ConfirmationWasAuthenticated -- True if the subscription confirmation request was authenticated</li>
        ///     <li>DeliveryPolicy -- the JSON serialization of the subscription's delivery policy</li>
        ///     <li>EffectiveDeliveryPolicy -- the JSON serialization of the effective delivery policy which takes 
        ///         into the topic delivery policy and account system defaults</li>
        ///     </ul>
        /// </summary>
        [XmlElementAttribute(ElementName = "Attributes")]
        public List<SubscriptionAttribute> Attributes
        {
            get { return this.attributesField; }
            set { this.attributesField = value; }
        }

        /// <summary>
        /// Checks if Attributes property is set
        /// </summary>
        /// <returns>true if Attributes property is set</returns>
        public bool IsSetAttributes()
        {
            return this.attributesField != null &&
                this.attributesField.Count > 0;
        }

        /// <summary>
        /// XML Representation of this object
        /// </summary>
        /// <returns>XML String</returns>
        public string ToXML()
        {
            StringBuilder xml = new StringBuilder(1024);
            System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(this.GetType());
            using (StringWriter sw = new StringWriter(xml))
            {
                serializer.Serialize(sw, this);
            }
            return xml.ToString();
        }

        /// <summary>
        /// String Representation of this object. Overrides Object.ToString()
        /// </summary>
        /// <returns>This object as a string</returns>
        public override string ToString()
        {
            return this.ToXML();
        }
    }
}
