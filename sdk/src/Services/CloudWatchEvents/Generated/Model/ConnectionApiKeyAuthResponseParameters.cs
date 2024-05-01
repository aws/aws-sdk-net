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
 * Do not modify this file. This file is generated from the events-2015-10-07.normal.json service model.
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
namespace Amazon.CloudWatchEvents.Model
{
    /// <summary>
    /// Contains the authorization parameters for the connection if API Key is specified as
    /// the authorization type.
    /// </summary>
    public partial class ConnectionApiKeyAuthResponseParameters
    {
        private string _apiKeyName;

        /// <summary>
        /// Gets and sets the property ApiKeyName. 
        /// <para>
        /// The name of the header to use for the <c>APIKeyValue</c> used for authorization.
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

    }
}