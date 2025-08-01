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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SimpleNotificationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePlatformApplication operation.
    /// Creates a platform application object for one of the supported push notification services,
    /// such as APNS and GCM (Firebase Cloud Messaging), to which devices and mobile apps
    /// may register. You must specify <c>PlatformPrincipal</c> and <c>PlatformCredential</c>
    /// attributes when using the <c>CreatePlatformApplication</c> action.
    /// 
    ///  
    /// <para>
    ///  <c>PlatformPrincipal</c> and <c>PlatformCredential</c> are received from the notification
    /// service.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// For ADM, <c>PlatformPrincipal</c> is <c>client id</c> and <c>PlatformCredential</c>
    /// is <c>client secret</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For APNS and <c>APNS_SANDBOX</c> using certificate credentials, <c>PlatformPrincipal</c>
    /// is <c>SSL certificate</c> and <c>PlatformCredential</c> is <c>private key</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For APNS and <c>APNS_SANDBOX</c> using token credentials, <c>PlatformPrincipal</c>
    /// is <c>signing key ID</c> and <c>PlatformCredential</c> is <c>signing key</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For Baidu, <c>PlatformPrincipal</c> is <c>API key</c> and <c>PlatformCredential</c>
    /// is <c>secret key</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For GCM (Firebase Cloud Messaging) using key credentials, there is no <c>PlatformPrincipal</c>.
    /// The <c>PlatformCredential</c> is <c>API key</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For GCM (Firebase Cloud Messaging) using token credentials, there is no <c>PlatformPrincipal</c>.
    /// The <c>PlatformCredential</c> is a JSON formatted private key file. When using the
    /// Amazon Web Services CLI or Amazon Web Services SDKs, the file must be in string format
    /// and special characters must be ignored. To format the file correctly, Amazon SNS recommends
    /// using the following command: <c>SERVICE_JSON=$(jq @json &lt; service.json)</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For MPNS, <c>PlatformPrincipal</c> is <c>TLS certificate</c> and <c>PlatformCredential</c>
    /// is <c>private key</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For WNS, <c>PlatformPrincipal</c> is <c>Package Security Identifier</c> and <c>PlatformCredential</c>
    /// is <c>secret key</c>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use the returned <c>PlatformApplicationArn</c> as an attribute for the <c>CreatePlatformEndpoint</c>
    /// action.
    /// </para>
    /// </summary>
    public partial class CreatePlatformApplicationRequest : AmazonSimpleNotificationServiceRequest
    {
        private Dictionary<string, string> _attributes = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _name;
        private string _platform;

        /// <summary>
        /// Gets and sets the property Attributes. 
        /// <para>
        /// For a list of attributes, see <a href="https://docs.aws.amazon.com/sns/latest/api/API_SetPlatformApplicationAttributes.html">
        /// <c>SetPlatformApplicationAttributes</c> </a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._attributes != null && (this._attributes.Count > 0 || !AWSConfigs.InitializeCollections); 
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