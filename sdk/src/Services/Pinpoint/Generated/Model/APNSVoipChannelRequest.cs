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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Apple VoIP Push Notification Service channel definition.
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
        /// Gets and sets the property BundleId. The bundle id used for APNs Tokens.
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
        /// Gets and sets the property Certificate. The distribution certificate from Apple.
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
        /// Gets and sets the property DefaultAuthenticationMethod. The default authentication
        /// method used for APNs.
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
        /// Gets and sets the property Enabled. If the channel is enabled for sending messages.
        /// </summary>
        public bool Enabled
        {
            get { return this._enabled.GetValueOrDefault(); }
            set { this._enabled = value; }
        }

        // Check to see if Enabled property is set
        internal bool IsSetEnabled()
        {
            return this._enabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateKey. The certificate private key.
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
        /// Gets and sets the property TeamId. The team id used for APNs Tokens.
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
        /// Gets and sets the property TokenKey. The token key used for APNs Tokens.
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
        /// Gets and sets the property TokenKeyId. The token key used for APNs Tokens.
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