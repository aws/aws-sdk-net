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
 * Do not modify this file. This file is generated from the cognito-idp-2016-04-18.normal.json service model.
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
namespace Amazon.CognitoIdentityProvider.Model
{
    /// <summary>
    /// Contextual user data used for evaluating the risk of an authentication event by user
    /// pool threat protection.
    /// </summary>
    public partial class ContextDataType
    {
        private string _encodedData;
        private List<HttpHeader> _httpHeaders = AWSConfigs.InitializeCollections ? new List<HttpHeader>() : null;
        private string _ipAddress;
        private string _serverName;
        private string _serverPath;

        /// <summary>
        /// Gets and sets the property EncodedData. 
        /// <para>
        /// Encoded device-fingerprint details that your app collected with the Amazon Cognito
        /// context data collection library. For more information, see <a href="https://docs.aws.amazon.com/cognito/latest/developerguide/cognito-user-pool-settings-adaptive-authentication.html#user-pool-settings-adaptive-authentication-device-fingerprint">Adding
        /// user device and session data to API requests</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=131072)]
        public string EncodedData
        {
            get { return this._encodedData; }
            set { this._encodedData = value; }
        }

        // Check to see if EncodedData property is set
        internal bool IsSetEncodedData()
        {
            return this._encodedData != null;
        }

        /// <summary>
        /// Gets and sets the property HttpHeaders. 
        /// <para>
        /// The HTTP headers from your user's authentication request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<HttpHeader> HttpHeaders
        {
            get { return this._httpHeaders; }
            set { this._httpHeaders = value; }
        }

        // Check to see if HttpHeaders property is set
        internal bool IsSetHttpHeaders()
        {
            return this._httpHeaders != null && (this._httpHeaders.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpAddress. 
        /// <para>
        /// The source IP address of your user's device.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=131072)]
        public string IpAddress
        {
            get { return this._ipAddress; }
            set { this._ipAddress = value; }
        }

        // Check to see if IpAddress property is set
        internal bool IsSetIpAddress()
        {
            return this._ipAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ServerName. 
        /// <para>
        /// The name of your application's service endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=131072)]
        public string ServerName
        {
            get { return this._serverName; }
            set { this._serverName = value; }
        }

        // Check to see if ServerName property is set
        internal bool IsSetServerName()
        {
            return this._serverName != null;
        }

        /// <summary>
        /// Gets and sets the property ServerPath. 
        /// <para>
        /// The path of your application's service endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=131072)]
        public string ServerPath
        {
            get { return this._serverPath; }
            set { this._serverPath = value; }
        }

        // Check to see if ServerPath property is set
        internal bool IsSetServerPath()
        {
            return this._serverPath != null;
        }

    }
}