/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePlatformApplication operation.
    /// Creates a platform application object for one of the supported push notification services,
    /// such as APNS and GCM (Firebase Cloud Messaging), to which devices and mobile apps
    /// may register. You must specify <code>PlatformPrincipal</code> and <code>PlatformCredential</code>
    /// attributes when using the <code>CreatePlatformApplication</code> action.
    /// 
    ///  
    /// <para>
    ///  <code>PlatformPrincipal</code> and <code>PlatformCredential</code> are received from
    /// the notification service.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For <code>ADM</code>, <code>PlatformPrincipal</code> is <code>client id</code> and
    /// <code>PlatformCredential</code> is <code>client secret</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <code>Baidu</code>, <code>PlatformPrincipal</code> is <code>API key</code> and
    /// <code>PlatformCredential</code> is <code>secret key</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <code>APNS</code> and <code>APNS_SANDBOX</code>, <code>PlatformPrincipal</code>
    /// is <code>SSL certificate</code> and <code>PlatformCredential</code> is <code>private
    /// key</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <code>GCM</code> (Firebase Cloud Messaging), there is no <code>PlatformPrincipal</code>
    /// and the <code>PlatformCredential</code> is <code>API key</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <code>MPNS</code>, <code>PlatformPrincipal</code> is <code>TLS certificate</code>
    /// and <code>PlatformCredential</code> is <code>private key</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For <code>WNS</code>, <code>PlatformPrincipal</code> is <code>Package Security Identifier</code>
    /// and <code>PlatformCredential</code> is <code>secret key</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use the returned <code>PlatformApplicationArn</code> as an attribute for the
    /// <code>CreatePlatformEndpoint</code> action.
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
        /// For a list of attributes, see <a href="https://docs.aws.amazon.com/sns/latest/api/API_SetPlatformApplicationAttributes.html">SetPlatformApplicationAttributes</a>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        [AWSProperty(Required=true)]
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
        /// Push Notification Service), APNS_SANDBOX, and GCM (Firebase Cloud Messaging).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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