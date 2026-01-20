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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Cache creation metrics for a specific TTL duration
    /// </summary>
    public partial class CacheDetail
    {
        private int? _inputTokens;
        private CacheTTL _ttl;

        /// <summary>
        /// Gets and sets the property InputTokens. 
        /// <para>
        /// Number of tokens written to cache with this TTL (cache creation tokens)
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0)]
        public int InputTokens
        {
            get { return this._inputTokens.GetValueOrDefault(); }
            set { this._inputTokens = value; }
        }

        // Check to see if InputTokens property is set
        internal bool IsSetInputTokens()
        {
            return this._inputTokens.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ttl. 
        /// <para>
        /// TTL duration for these cached tokens
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CacheTTL Ttl
        {
            get { return this._ttl; }
            set { this._ttl = value; }
        }

        // Check to see if Ttl property is set
        internal bool IsSetTtl()
        {
            return this._ttl != null;
        }

    }
}