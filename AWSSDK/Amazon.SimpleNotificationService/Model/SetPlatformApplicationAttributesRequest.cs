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
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Sets the attributes of the platform application object for the supported push notification services, 
    /// such as APNS and GCM.
    /// </summary>
    /// <remarks>
    /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class SetPlatformApplicationAttributesRequest : SNSRequest
    {
        
        private string platformApplicationArn;

        
        private Dictionary<string, string> attributes;

        /// <summary>
        /// Gets or sets the platform application ARN.
        /// </summary>
        /// <value>The name.</value>
        [XmlElementAttribute(ElementName = "PlatformApplicationArn")]
        public string PlatformApplicationArn
        {
            get { return this.platformApplicationArn; }
            set { this.platformApplicationArn = value; }
        }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <remarks>
        /// <para>A map of the platform application attributes. Attributes in this map include the following:</para>
        /// <ul>
        /// <li><code>PlatformCredential</code> - The credential received from the notification service. For APNS/APNS_SANDBOX, PlatformCredential is "private key". 
        /// For GCM, PlatformCredential is "API key". For ADM, PlatformCredential is "client secret".</li>
        /// <li><code>PlatformPrincipal</code> - The principal received from the notification service. For APNS/APNS_SANDBOX, PlatformPrincipal is "SSL certificate". 
        /// For GCM, PlatformPrincipal is not applicable. For ADM PlatformPrincipal is "client id".</li>        
        /// <li><code>EventEndpointCreated</code> - Topic ARN to which EndpointCreated event notifications should be sent.</li>
        /// <li><code>EventEndpointDeleted</code> - Topic ARN to which EndpointDeleted event notifications should be sent.</li>
        /// <li><code>EventEndpointUpdated</code> - Topic ARN to which EndpointUpdate event notifications should be sent.</li>        
        /// <li><code>EventDeliveryFailure</code> - Topic ARN to which DeliveryFailure event notifications should be sent upon Direct Publish delivery failure (permanent) to one of the application's endpoints.</li>        
        /// </ul>  
        /// </remarks>
        /// <value>The attributes.</value>
        [XmlElementAttribute(ElementName = "Attributes")]
        public Dictionary<string, string> Attributes
        {
            get
            {
                if (null == this.attributes)
                    this.attributes = new Dictionary<string, string>();
                return this.attributes;
            }
            set
            {
                this.attributes = value;
            }
        }

        /// <summary>
        /// Determines whether the target <see cref="P:Attributes"/> is set in this request.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if any attributes are set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetAttributes()
        {
            return this.attributes != null;
        }

        /// <summary>
        /// Determines whether the target <see cref="P:Platform"/> property is set.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the target platform is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetPlatformApplicationArn()
        {
            return !String.IsNullOrEmpty(this.platformApplicationArn);
        }

        /// <summary>
        /// Modifies the platform application ARN in this request.
        /// </summary>
        /// <param name="platformApplicationArn">The platform application arn.</param>
        /// <returns></returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPlatformApplicationAttributesRequest WithPlatformApplicationArn(string platformApplicationArn)
        {
            this.platformApplicationArn = platformApplicationArn;
            return this;
        }

        /// <summary>
        /// Modifies this request with the specified attributes.
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <returns>The current instance.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPlatformApplicationAttributesRequest WithAttributes(Dictionary<string, string> attributes)
        {
            this.attributes = attributes;
            return this;
        }

        /// <summary>
        /// Modifies this request to include the specified attribute. If an attribute already exists,
        /// its value will be replaced with the new value.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="value">The value.</param>
        /// <returns>The current instance.</returns>
        /// <exception cref="System.ArgumentException">Invalid key; cannot be NULL or empty.</exception>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetPlatformApplicationAttributesRequest WithAttribute(string key, string value)
        {
            if (String.IsNullOrEmpty(key))
                throw new ArgumentException("Invalid key; cannot be NULL or empty.");

            this.Attributes[key] = value;
            return this;
        }
    }
}
