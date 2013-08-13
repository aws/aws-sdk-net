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
    /// Creates an endpoint for a device on one of the supported push notification services, such as GCM and APNS.
    /// </summary>
    /// <remarks>
    /// This method requires the PlatformApplicationArn that is returned from <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.CreatePlatformApplication"/>. 
    /// The EndpointArn that is returned when using this method can then be used by the <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.Publish"/> method to 
    /// send a message to a mobile app or by the <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.Subscribe"/> action for subscription to a topic.        
    /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>.
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class CreatePlatformEndpointRequest : SNSRequest
    {
        
        private string platformApplicationArn;

        
        private string customUserData;

        
        private Dictionary<string, string> attributes;

        
        private string token;

        /// <summary>
        /// Unique identifier created by the notification service for an app on a device. 
        /// The specific name for Token will vary, depending on which notification service is being used. 
        /// For example, when using APNS as the notification service, you need the device token. 
        /// Alternatively, when using GCM or ADM, the device token equivalent is called the registration ID.
        /// </summary>
        /// <value>
        /// The string token.
        /// </value>
        [XmlElement(ElementName = "Token")]
        public string Token
        {
            get { return this.token; }
            set { this.token = value; }
        }

        /// <summary>
        /// Gets or sets the platform application ARN.
        /// </summary>
        /// <value>
        /// The platform application ARN.
        /// </value>
        [XmlElementAttribute(ElementName = "PlatformApplicationArn")]
        public string PlatformApplicationArn
        {
            get { return this.platformApplicationArn; }
            set { this.platformApplicationArn = value; }
        }

        /// <summary>
        /// Arbitrary user data to associate with the endpoint. SNS does not use this data.
        /// The data must be in UTF-8 format and less than 2KB.
        /// </summary>
        /// <value>
        /// The custom user data.
        /// </value>
        [XmlElementAttribute(ElementName = "CustomUserData")]
        public string CustomUserData
        {
            get { return this.customUserData; }
            set { this.customUserData = value; }
        }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <remarks>
        /// For a list of attributes, see <a href="http://docs.aws.amazon.com/sns/latest/api/API_SetEndpointAttributes.html">SetEndpointAttributes</a>.
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
        /// Determines whether the <see cref="P:PlatformApplicationArn"/> property is set.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the platform application ARN is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetPlatformApplicationArn()
        {
            return !String.IsNullOrEmpty(this.platformApplicationArn);
        }

        /// <summary>
        /// Determines whether the <see cref="P:Token"/> property is set.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the token is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetToken()
        {
            return !String.IsNullOrEmpty(this.token);
        }

        /// <summary>
        /// Determines whether the <see cref="CustomUserData"/> property is set.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if custom user data is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetCustomUserData()
        {
            return !String.IsNullOrEmpty(this.customUserData);
        }

        /// <summary>
        /// Modifies the platform application ARN in this request instance.
        /// </summary>
        /// <param name="platformApplicationArn">The platform application arn.</param>
        /// <returns>This instance.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePlatformEndpointRequest WithPlatformApplicationArn(string platformApplicationArn)
        {
            this.platformApplicationArn = platformApplicationArn;
            return this;
        }

        /// <summary>
        /// Modifies the token in this request instance.
        /// </summary>
        /// <param name="token">The token.</param>
        /// <returns>This instance.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePlatformEndpointRequest WithToken(string token)
        {
            this.token = token;
            return this;
        }

        /// <summary>
        /// Modifies the custom user data in this request instance.
        /// </summary>
        /// <param name="customUserData">The custom user data.</param>
        /// <returns>This instance.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePlatformEndpointRequest WithCustomUserData(string customUserData)
        {
            this.customUserData = customUserData;
            return this;
        }

        /// <summary>
        /// Modifies this request with the specified attributes.
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <returns>The current instance.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePlatformEndpointRequest WithAttributes(Dictionary<string, string> attributes)
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
        public CreatePlatformEndpointRequest WithAttribute(string key, string value)
        {
            if (String.IsNullOrEmpty(key))
                throw new ArgumentException("Invalid key; cannot be NULL or empty.");

            this.Attributes[key] = value;
            return this;
        }
    }
}
