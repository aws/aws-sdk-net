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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// Left expression of the event metadata filter.
    /// </summary>
    public partial class LeftExpression
    {
        private string _metadataKey;

        /// <summary>
        /// Gets and sets the property MetadataKey. 
        /// <para>
        /// Key associated with the metadata in an event.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string MetadataKey
        {
            get { return this._metadataKey; }
            set { this._metadataKey = value; }
        }

        // Check to see if MetadataKey property is set
        internal bool IsSetMetadataKey()
        {
            return this._metadataKey != null;
        }

    }
}