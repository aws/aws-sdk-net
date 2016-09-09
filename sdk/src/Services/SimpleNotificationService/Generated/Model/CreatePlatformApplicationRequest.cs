/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the sns-2010-03-31.normal.json service model.
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
    /// Container for the parameters to the CreatePlatformApplication operation.
    /// Creates a platform application object for one of the supported push notification services,
    /// such as APNS and GCM, to which devices and mobile apps may register. You must specify
    /// PlatformPrincipal and PlatformCredential attributes when using the <code>CreatePlatformApplication</code>
    /// action. The PlatformPrincipal is received from the notification service. For APNS/APNS_SANDBOX,
    /// PlatformPrincipal is "SSL certificate". For GCM, PlatformPrincipal is not applicable.
    /// For ADM, PlatformPrincipal is "client id". The PlatformCredential is also received
    /// from the notification service. For WNS, PlatformPrincipal is "Package Security Identifier".
    /// For MPNS, PlatformPrincipal is "TLS certificate". For Baidu, PlatformPrincipal is
    /// "API key".
    /// 
    ///  
    /// <para>
    /// For APNS/APNS_SANDBOX, PlatformCredential is "private key". For GCM, PlatformCredential
    /// is "API key". For ADM, PlatformCredential is "client secret". For WNS, PlatformCredential
    /// is "secret key". For MPNS, PlatformCredential is "private key". For Baidu, PlatformCredential
    /// is "secret key". The PlatformApplicationArn that is returned when using <code>CreatePlatformApplication</code>
    /// is then used as an attribute for the <code>CreatePlatformEndpoint</code> action. For
    /// more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/SNSMobilePush.html">Using
    /// Amazon SNS Mobile Push Notifications</a>. For more information about obtaining the
    /// PlatformPrincipal and PlatformCredential for each of the supported push notification
    /// services, see <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-apns.html">Getting
    /// Started with Apple Push Notification Service</a>, <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-adm.html">Getting
    /// Started with Amazon Device Messaging</a>, <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-baidu.html">Getting
    /// Started with Baidu Cloud Push</a>, <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-gcm.html">Getting
    /// Started with Google Cloud Messaging for Android</a>, <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-mpns.html">Getting
    /// Started with MPNS</a>, or <a href="http://docs.aws.amazon.com/sns/latest/dg/mobile-push-wns.html">Getting
    /// Started with WNS</a>. 
    /// </para>
    /// </summary>
    public partial class CreatePlatformApplicationRequest : AmazonSimpleNotificationServiceRequest
    {
        private Dictionary<string, string> _attributes = new Dictionary<string, string>();
        private string _name;
        private string _platform;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// For a list of attributes, see <a href="http://docs.aws.amazon.com/sns/latest/api/API_SetPlatformApplicationAttributes.html">SetPlatformApplicationAttributes</a>
        /// 
        /// </para>
        /// </summary>
        public Dictionary<string, string> Attributes
        {
            get { return this._attributes; }
            set { this._attributes = value; }
        }

        // Check to see if Attributes property is set
        internal bool IsSetAttributes()
        {
            return this._attributes != null && this._attributes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Application names must be made up of only uppercase and lowercase ASCII letters, numbers,
        /// underscores, hyphens, and periods, and must be between 1 and 256 characters long.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The following platforms are supported: ADM (Amazon Device Messaging), APNS (Apple
        /// Push Notification Service), APNS_SANDBOX, and GCM (Google Cloud Messaging).
        /// </para>
        /// </summary>
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

    }
}