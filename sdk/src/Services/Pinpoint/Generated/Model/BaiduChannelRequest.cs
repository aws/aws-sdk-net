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

namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the status and settings of the Baidu (Baidu Cloud Push) channel for an application.
    /// </summary>
    public partial class BaiduChannelRequest
    {
        private string _apiKey;
        private bool? _enabled;
        private string _secretKey;

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The API key that you received from the Baidu Cloud Push service to communicate with
        /// the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Enabled. 
        /// <para>
        /// Specifies whether to enable the Baidu channel for the application.
        /// </para>
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
        /// Gets and sets the property SecretKey. 
        /// <para>
        /// The secret key that you received from the Baidu Cloud Push service to communicate
        /// with the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SecretKey
        {
            get { return this._secretKey; }
            set { this._secretKey = value; }
        }

        // Check to see if SecretKey property is set
        internal bool IsSetSecretKey()
        {
            return this._secretKey != null;
        }

    }
}