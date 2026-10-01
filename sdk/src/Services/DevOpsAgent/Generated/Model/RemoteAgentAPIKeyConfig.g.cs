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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.DevOpsAgent.Model
{
    /// <summary>
    /// API key configuration for remote A2A agent.
    /// </summary>
    public partial class RemoteAgentAPIKeyConfig
    {
        /// <summary>
        /// Gets and sets the property ApiKeyHeader. 
        /// <para>
        /// HTTP header name to send the API key in requests to the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiKeyHeader { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeyHeader property is set.
        /// </summary>
        internal bool IsSetApiKeyHeader() => this.ApiKeyHeader != null;

        /// <summary>
        /// Gets and sets the property ApiKeyName. 
        /// <para>
        /// User friendly API key name specified by end user.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ApiKeyName { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeyName property is set.
        /// </summary>
        internal bool IsSetApiKeyName() => this.ApiKeyName != null;

        /// <summary>
        /// Gets and sets the property ApiKeyValue. 
        /// <para>
        /// API key value for authenticating with the service.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1)]
        public string ApiKeyValue { get; set; }

        /// <summary>
        /// Checks to see if the ApiKeyValue property is set.
        /// </summary>
        internal bool IsSetApiKeyValue() => this.ApiKeyValue != null;
    }
}
