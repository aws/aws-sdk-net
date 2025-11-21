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
 * Do not modify this file. This file is generated from the quicksight-2018-04-01.normal.json service model.
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
namespace Amazon.QuickSight.Model
{
    /// <summary>
    /// Configuration for API key-based authentication to external services.
    /// </summary>
    public partial class APIKeyConnectionMetadata
    {
        private string _apiKey;
        private string _baseEndpoint;
        private string _email;

        /// <summary>
        /// Gets and sets the property ApiKey. 
        /// <para>
        /// The API key used for authentication.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
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
        /// Gets and sets the property BaseEndpoint. 
        /// <para>
        /// The base URL endpoint for the external service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=8192)]
        public string BaseEndpoint
        {
            get { return this._baseEndpoint; }
            set { this._baseEndpoint = value; }
        }

        // Check to see if BaseEndpoint property is set
        internal bool IsSetBaseEndpoint()
        {
            return this._baseEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property Email. 
        /// <para>
        /// The email address associated with the API key, if required.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string Email
        {
            get { return this._email; }
            set { this._email = value; }
        }

        // Check to see if Email property is set
        internal bool IsSetEmail()
        {
            return this._email != null;
        }

    }
}