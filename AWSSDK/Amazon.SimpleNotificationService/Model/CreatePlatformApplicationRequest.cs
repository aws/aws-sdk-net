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
    /// Creates a platform application object for one of the supported push notification services, 
    /// such as APNS and GCM, to which devices and mobile apps may register.
    /// </summary>
    /// <remarks>
    /// You must specify PlatformPrincipal and PlatformCredential attributes when using this method.
    /// The PlatformPrincipal is received from the notification service. For APNS/APNS_SANDBOX, PlatformPrincipal is "SSL certificate". 
    /// For GCM, PlatformPrincipal is not applicable. For ADM PlatformPrincipal is "client id". The PlatformCredential is also received from the notification service. 
    /// For APNS/APNS_SANDBOX, PlatformCredential is "private key". For GCM, PlatformCredential is "API key". For ADM, PlatformCredential is "client secret".   
    /// The PlatformApplicationArn that is returned by this method is then used as an attribute for the <see cref="Amazon.SimpleNotificationService.AmazonSimpleNotificationService.CreatePlatformEndpoint"/> method.
    /// For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using Amazon SNS Mobile Push Notifications</a>. 
    /// </remarks>
    [XmlRootAttribute(Namespace = "http://sns.amazonaws.com/doc/2010-03-31/", IsNullable = false)]
    public class CreatePlatformApplicationRequest : SNSRequest
    {
        
        private string name;

        
        private string platform;

        
        private Dictionary<string, string> attributes;

        /// <summary>
        /// Gets or sets the name. Application names must be made up of only uppercase and lowercase 
        /// ASCII letters, numbers, underscores, hyphens, and periods, and must be between 1 and 256 characters long.
        /// </summary>
        /// <value>The name.</value>
        [XmlElementAttribute(ElementName = "Name")]
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        /// <summary>
        /// Gets or sets the platform. The following platforms are supported: ADM (Amazon Device Messaging),
        /// APNS (Apple Push Notification Service), APNS_SANDBOX, and GCM (Google Cloud Messaging).
        /// </summary>
        /// <value>The platform.</value>
        [XmlElementAttribute(ElementName = "Platform")]
        public string Platform
        {
            get { return this.platform; }
            set { this.platform = value; }
        }

        /// <summary>
        /// Gets or sets the attributes. For a list of attributes, 
        /// see <a href="http://docs.aws.amazon.com/sns/latest/api/API_SetPlatformApplicationAttributes.html">SetPlatformApplicationAttributes</a>
        /// </summary>
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
        public bool IsSetPlatform()
        {
            return !String.IsNullOrEmpty(this.platform);
        }

        /// <summary>
        /// Determines whether the target <see cref="P:Name"/> property is set in this request.
        /// </summary>
        /// <returns>
        ///   <c>true</c> if the target name is set; otherwise, <c>false</c>.
        /// </returns>
        public bool IsSetName()
        {
            return !String.IsNullOrEmpty(this.name);
        }

        /// <summary>
        /// Modifies this request with the specified platform.
        /// </summary>
        /// <param name="platform">The platform.</param>
        /// <returns></returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePlatformApplicationRequest WithPlatform(string platform)
        {
            this.platform = platform;
            return this;
        }

        /// <summary>
        /// Modifies this request with the specified name.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns>The current instance.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePlatformApplicationRequest WithName(string name)
        {
            this.name = name;
            return this;
        }

        /// <summary>
        /// Modifies this request with the specified attributes.
        /// </summary>
        /// <param name="attributes">The attributes.</param>
        /// <returns>The current instance.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePlatformApplicationRequest WithAttributes(Dictionary<string, string> attributes)
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
        public CreatePlatformApplicationRequest WithAttribute(string key, string value)
        {
            if (String.IsNullOrEmpty(key))
                throw new ArgumentException("Invalid key; cannot be NULL or empty.");

            this.Attributes[key] = value;
            return this;
        }
    }
}
