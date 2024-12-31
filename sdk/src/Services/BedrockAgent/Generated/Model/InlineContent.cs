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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// Contains information about content defined inline to ingest into a data source. Choose
    /// a <c>type</c> and include the field that corresponds to it.
    /// </summary>
    public partial class InlineContent
    {
        private ByteContentDoc _byteContent;
        private TextContentDoc _textContent;
        private InlineContentType _type;

        /// <summary>
        /// Gets and sets the property ByteContent. 
        /// <para>
        /// Contains information about content defined inline in bytes.
        /// </para>
        /// </summary>
        public ByteContentDoc ByteContent
        {
            get { return this._byteContent; }
            set { this._byteContent = value; }
        }

        // Check to see if ByteContent property is set
        internal bool IsSetByteContent()
        {
            return this._byteContent != null;
        }

        /// <summary>
        /// Gets and sets the property TextContent. 
        /// <para>
        /// Contains information about content defined inline in text.
        /// </para>
        /// </summary>
        public TextContentDoc TextContent
        {
            get { return this._textContent; }
            set { this._textContent = value; }
        }

        // Check to see if TextContent property is set
        internal bool IsSetTextContent()
        {
            return this._textContent != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of inline content to define.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InlineContentType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}