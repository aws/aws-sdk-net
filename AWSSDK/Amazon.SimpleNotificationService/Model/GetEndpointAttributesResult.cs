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
 *  API Version: 2010-05-02
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Encapsulates the result of the GetEndpointAttributes request.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class GetEndpointAttributesResult
    {
        
        private List<EndpointAttribute> attributes;

        /// <summary>
        /// Gets or sets the collection of endpoint attributes.
        /// </summary>
        /// <remarks>
        /// <para>Attributes include the following:</para>
        /// <ul>
        /// <li><code>CustomUserData</code> - arbitrary user data to associate with the endpoint. SNS does not use this data. The data must be in UTF-8 format and less than 2KB.</li>
        /// <li><code>Enabled</code> - flag that enables/disables delivery to the endpoint. 
        /// Message Processor will set this to false when a notification service indicates to SNS that the endpoint is invalid. 
        /// Users can set it back to true, typically after updating Token.</li>
        /// <li><code>Token</code> - device token, also referred to as a registration id, for an app and mobile device. 
        /// This is returned from the notification service when an app and mobile device are registered with the notification service.</li>           
        /// </ul>
        /// </remarks>
        /// <value>The endpoint attributes.</value>
        [XmlElement(ElementName = "Attributes")]
        public List<EndpointAttribute> Attributes
        {
            get { return this.attributes; }
            set { this.attributes = value; }
        }

        /// <summary>
        /// Determines whether the <see cref="P:Attributes"/> property is set.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the <see cref="P:Attributes"/> property is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetAttributes()
        {
            return null != this.attributes;
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
