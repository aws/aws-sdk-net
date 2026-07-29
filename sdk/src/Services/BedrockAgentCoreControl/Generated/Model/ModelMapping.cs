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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// The configuration that translates model IDs between client-facing names and provider
    /// model IDs.
    /// </summary>
    public partial class ModelMapping
    {
        private ProviderPrefix _providerPrefix;

        /// <summary>
        /// Gets and sets the property ProviderPrefix. 
        /// <para>
        /// The provider prefix configuration used for model ID translation.
        /// </para>
        /// </summary>
        public ProviderPrefix ProviderPrefix
        {
            get { return this._providerPrefix; }
            set { this._providerPrefix = value; }
        }

        // Check to see if ProviderPrefix property is set
        internal bool IsSetProviderPrefix()
        {
            return this._providerPrefix != null;
        }

    }
}