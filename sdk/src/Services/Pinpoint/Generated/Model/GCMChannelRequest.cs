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
    /// Specifies the status and settings of the GCM channel for an application. This channel
    /// enables Amazon Pinpoint to send push notifications through the Firebase Cloud Messaging
    /// (FCM), formerly Google Cloud Messaging (GCM), service.
    /// </summary>
    public partial class GCMChannelRequest
    {
        private string _apiKey;
        private string _defaultAuthenticationMethod;
        private bool? _enabled;
        private string _serviceJson;

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The Web API Key, also referred to as an <i>API_KEY</i> or <i>server key</i>, that
        /// you received from Google to communicate with Google services.
        /// </para>
        /// </summary>
        public string ApiKey
        {
            get { return this._apiKey; }
            set { this._apiKey = value; }
        }

        // Check to see if ApiKey property is set
        internal bool IsSetApiKey()
        {
            return this._apiKey != null;
        }

        /// <summary>
        /// Gets and sets the property DefaultAuthenticationMethod. 
        /// <para>
        /// The default authentication method used for GCM. Values are either "TOKEN" or "KEY".
        /// Defaults to "KEY".
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
        /// Specifies whether to enable the GCM channel for the application.
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
        /// Gets and sets the property ServiceJson. 
        /// <para>
        /// The contents of the JSON file provided by Google during registration in order to generate
        /// an access token for authentication. For more information see <a href="https://firebase.google.com/docs/cloud-messaging/migrate-v1">Migrate
        /// from legacy FCM APIs to HTTP v1</a>.
        /// </para>
        /// </summary>
        public string ServiceJson
        {
            get { return this._serviceJson; }
            set { this._serviceJson = value; }
        }

        // Check to see if ServiceJson property is set
        internal bool IsSetServiceJson()
        {
            return this._serviceJson != null;
        }

    }
}