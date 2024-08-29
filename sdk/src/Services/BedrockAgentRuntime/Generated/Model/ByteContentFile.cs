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
 * Do not modify this file. This file is generated from the bedrock-agent-runtime-2023-07-26.normal.json service model.
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
namespace Amazon.BedrockAgentRuntime.Model
{
    /// <summary>
    /// The property contains the file to chat with, along with its attributes.
    /// </summary>
    public partial class ByteContentFile
    {
        private MemoryStream _data;
        private string _mediaType;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The raw bytes of the file to attach. The maximum size of all files that is attached
        /// is 10MB. You can attach a maximum of 5 files. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=10485760)]
        public MemoryStream Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property MediaType. 
        /// <para>
        /// The MIME type of data contained in the file used for chat.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string MediaType
        {
            get { return this._mediaType; }
            set { this._mediaType = value; }
        }

        // Check to see if MediaType property is set
        internal bool IsSetMediaType()
        {
            return this._mediaType != null;
        }

    }
}