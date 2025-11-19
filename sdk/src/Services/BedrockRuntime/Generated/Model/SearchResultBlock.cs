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
    /// A search result block that enables natural citations with proper source attribution
    /// for retrieved content.
    /// 
    ///  <note> 
    /// <para>
    /// This field is only supported by Anthropic Claude Opus 4.1, Opus 4, Sonnet 4.5, Sonnet
    /// 4, Sonnet 3.7, and 3.5 Haiku models.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class SearchResultBlock
    {
        private CitationsConfig _citations;
        private List<SearchResultContentBlock> _content = AWSConfigs.InitializeCollections ? new List<SearchResultContentBlock>() : null;
        private string _source;
        private string _title;

        /// <summary>
        /// Gets and sets the property Citations. 
        /// <para>
        /// Configuration setting for citations
        /// </para>
        /// </summary>
        public CitationsConfig Citations
        {
            get { return this._citations; }
            set { this._citations = value; }
        }

        // Check to see if Citations property is set
        internal bool IsSetCitations()
        {
            return this._citations != null;
        }

        /// <summary>
        /// Gets and sets the property Content. 
        /// <para>
        /// An array of search result content block.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<SearchResultContentBlock> Content
        {
            get { return this._content; }
            set { this._content = value; }
        }

        // Check to see if Content property is set
        internal bool IsSetContent()
        {
            return this._content != null && (this._content.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source URL or identifier for the content.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// A descriptive title for the search result.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Title
        {
            get { return this._title; }
            set { this._title = value; }
        }

        // Check to see if Title property is set
        internal bool IsSetTitle()
        {
            return this._title != null;
        }

    }
}