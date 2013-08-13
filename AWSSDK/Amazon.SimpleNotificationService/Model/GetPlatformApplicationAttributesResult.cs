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
    /// Encapsulates the result of the GetPlatformApplicationAttributes request.
    /// </summary>
     [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class GetPlatformApplicationAttributesResult
    {
        
        private List<PlatformApplicationAttribute> attributes;

        /// <summary>
        /// Gets or sets the collection of platform application attributes.
        /// </summary>
        /// <remarks>
        /// <p>Attributes include the following:</p>
        /// <ul>      
        /// <li><code>EventEndpointCreated</code> -- Topic ARN to which EndpointCreated event notifications should be sent.</li>
        /// <li><code>EventEndpointDeleted</code> -- Topic ARN to which EndpointDeleted event notifications should be sent.</li>
        /// <li><code>EventEndpointUpdated</code> -- Topic ARN to which EndpointUpdate event notifications should be sent.</li>
        /// <li><code>EventDeliveryFailure</code> -- Topic ARN to which DeliveryFailure event notifications should be sent upon Direct Publish delivery failure (permanent) to one of the application's endpoints.</li>
        /// </ul>
        /// 
        /// </remarks>
        /// <value>The platform application attributes.</value>
        [XmlElement(ElementName = "Attributes")]
        public List<PlatformApplicationAttribute> Attributes
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
