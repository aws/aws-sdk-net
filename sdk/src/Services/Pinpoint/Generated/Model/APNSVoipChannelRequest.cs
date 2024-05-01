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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the status and settings of the APNs (Apple Push Notification service) VoIP
    /// channel for an application.
    /// </summary>
    public partial class APNSVoipChannelRequest
    {
        private string _bundleId;
        private string _certificate;
        private string _defaultAuthenticationMethod;
        private bool? _enabled;
        private string _privateKey;
        private string _teamId;
        private string _tokenKey;
        private string _tokenKeyId;

        /// <summary>
        /// Gets and sets the property BundleId. 
        /// <para>
        /// The bundle identifier that's assigned to your iOS app. This identifier is used for
        /// APNs tokens.
        /// </para>
        /// </summary>
        public string BundleId
        {
            get { return this._bundleId; }
            set { this._bundleId = value; }
        }

        // Check to see if BundleId property is set
        internal bool IsSetBundleId()
        {
            return this._bundleId != null;
        }

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The APNs client certificate that you received from Apple, if you want Amazon Pinpoint
        /// to communicate with APNs by using an APNs certificate.
        /// </para>
        /// </summary>
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultAuthenticationMethod. 
        /// <para>
        /// The default authentication method that you want Amazon Pinpoint to use when authenticating
        /// with APNs, key or certificate.
        /// </para>
        /// </summary>
        public string DefaultAuthenticationMethod
        {
            get { return this._defaultAuthenticationMethod; }
            set { this._defaultAuthenticationMethod = value; }
        }

        // Check to see if DefaultAuthenticationMethod property is set
        internal bool IsSetDefaultAuthenticationMethod()
        {
            return this._defaultAuthenticationMethod != null;
        }

        /// <summary>
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to enable the APNs VoIP channel for the application.
        /// </para>
        /// </summary>
        public bool? Enabled
        {
            get { return this._enabled; }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// The private key for the APNs client certificate that you want Amazon Pinpoint to use
        /// to communicate with APNs.
        /// </para>
        /// </summary>
        public string PrivateKey
        {
            get { return this._privateKey; }
            set { this._privateKey = value; }
        }

        // Check to see if PrivateKey property is set
        internal bool IsSetPrivateKey()
        {
            return this._privateKey != null;
        }

        /// <summary>
        /// Gets and sets the property TeamId. 
        /// <para>
        /// The identifier that's assigned to your Apple developer account team. This identifier
        /// is used for APNs tokens.
        /// </para>
        /// </summary>
        public string TeamId
        {
            get { return this._teamId; }
            set { this._teamId = value; }
        }

        // Check to see if TeamId property is set
        internal bool IsSetTeamId()
        {
            return this._teamId != null;
        }

        /// <summary>
        /// Gets and sets the property TokenKey. 
        /// <para>
        /// The authentication key to use for APNs tokens.
        /// </para>
        /// </summary>
        public string TokenKey
        {
            get { return this._tokenKey; }
            set { this._tokenKey = value; }
        }

        // Check to see if TokenKey property is set
        internal bool IsSetTokenKey()
        {
            return this._tokenKey != null;
        }

        /// <summary>
        /// Gets and sets the property TokenKeyId. 
        /// <para>
        /// The key identifier that's assigned to your APNs signing key, if you want Amazon Pinpoint
        /// to communicate with APNs by using APNs tokens.
        /// </para>
        /// </summary>
        public string TokenKeyId
        {
            get { return this._tokenKeyId; }
            set { this._tokenKeyId = value; }
        }

        // Check to see if TokenKeyId property is set
        internal bool IsSetTokenKeyId()
        {
            return this._tokenKeyId != null;
        }

    }
}