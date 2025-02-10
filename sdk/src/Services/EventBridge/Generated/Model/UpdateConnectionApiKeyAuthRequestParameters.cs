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
 * Do not modify this file. This file is generated from the eventbridge-2015-10-07.normal.json service model.
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
namespace Amazon.EventBridge.Model
{
    /// <summary>
    /// Contains the API key authorization parameters to use to update the connection.
    /// </summary>
    public partial class UpdateConnectionApiKeyAuthRequestParameters
    {
        private string _apiKeyName;
        private string _apiKeyValue;

        /// <summary>
        /// Gets and sets the property ApiKeyName. 
        /// <para>
        /// The name of the API key to use for authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
        public string ApiKeyName
        {
            get { return this._apiKeyName; }
            set { this._apiKeyName = value; }
        }

        // Check to see if ApiKeyName property is set
        internal bool IsSetApiKeyName()
        {
            return this._apiKeyName != null;
        }

        /// <summary>
        /// Gets and sets the property ApiKeyValue. 
        /// <para>
        /// The value associated with the API key to use for authorization.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=512)]
        public string ApiKeyValue
        {
            get { return this._apiKeyValue; }
            set { this._apiKeyValue = value; }
        }

        // Check to see if ApiKeyValue property is set
        internal bool IsSetApiKeyValue()
        {
            return this._apiKeyValue != null;
        }

    }
}