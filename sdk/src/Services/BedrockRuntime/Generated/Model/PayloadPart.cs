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
using Amazon.Runtime.EventStreams;
using Amazon.Runtime.EventStreams.Internal;
using Amazon.BedrockRuntime.Model.Internal.MarshallTransformations;
using Amazon.Runtime.EventStreams.Utils;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Payload content included in the response.
    /// </summary>
    public partial class PayloadPart
        : IEventStreamEvent
    {
        private MemoryStream _bytes;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// Base64-encoded bytes of payload data.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=1000000)]
        public MemoryStream Bytes
        {
            get { return this._bytes; }
            set { this._bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this._bytes != null;
        }

    }
}