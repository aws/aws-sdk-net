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
    /// Sets the attributes for the an endpoint for a device on one of the supported push notification services, such as GCM and APNS.
    /// </summary>
    /// <remarks>
    /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class SetEndpointAttributesRequest : SNSRequest
    {
        
        private string endpointArn;

        
        private Dictionary<string, string> attributes;

        /// <summary>
        /// Gets or sets the endpoint ARN.
        /// </summary>
        /// <value>The name.</value>
        [XmlElementAttribute(ElementName = "EndpointArn")]
        public string EndpointArn
        {
            get { return this.endpointArn; }
            set { this.endpointArn = value; }
        }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <remarks>
        /// <para>A map of the endpoint attributes. Attributes in this map include the following:</para>
        /// <ul>
        /// <li><code>CustomUserData</code> - arbitrary user data to associate with the endpoint. SNS does not use this data. The data must be in UTF-8 format and less than 2KB.</li>
        /// <li><code>Enabled</code> - flag that enables/disables delivery to the endpoint. 
        /// Message Processor will set this to false when a notification service indicates to SNS that the endpoint is invalid. 
        /// Users can set it back to true, typically after updating Token.</li>
        /// <li><code>Token</code> - device token, also referred to as a registration id, for an app and mobile device. 
        /// This is returned from the notification service when an app and mobile device are registered with the notification service.</li>           
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
        public bool IsSetEndpointArn()
        {
            return !String.IsNullOrEmpty(this.endpointArn);
        }

        /// <summary>
        /// Modifies the endpoint ARN in this request.
        /// </summary>
        /// <param name="endpointArn">The endpoint arn.</param>
        /// <returns></returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetEndpointAttributesRequest WithEndpointArn(string endpointArn)
        {
            this.endpointArn = endpointArn;
            return this;
        }

        /// <summary>
        /// Modifies this request with the specified attributes.
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <returns>The current instance.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public SetEndpointAttributesRequest WithAttributes(Dictionary<string, string> attributes)
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
        public SetEndpointAttributesRequest WithAttribute(string key, string value)
        {
            if (String.IsNullOrEmpty(key))
                throw new ArgumentException("Invalid key; cannot be NULL or empty.");

            this.Attributes[key] = value;
            return this;
        }
    }
}
