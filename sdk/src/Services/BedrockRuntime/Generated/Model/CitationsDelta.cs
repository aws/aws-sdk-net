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
    /// Contains incremental updates to citation information during streaming responses. This
    /// allows clients to build up citation data progressively as the response is generated.
    /// </summary>
    public partial class CitationsDelta
    {
        private CitationLocation _location;
        private List<CitationSourceContentDelta> _sourceContent = AWSConfigs.InitializeCollections ? new List<CitationSourceContentDelta>() : null;
        private string _title;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// Specifies the precise location within a source document where cited content can be
        /// found. This can include character-level positions, page numbers, or document chunks
        /// depending on the document type and indexing method.
        /// </para>
        /// </summary>
        public CitationLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property SourceContent. 
        /// <para>
        /// The specific content from the source document that was referenced or cited in the
        /// generated response.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CitationSourceContentDelta> SourceContent
        {
            get { return this._sourceContent; }
            set { this._sourceContent = value; }
        }

        // Check to see if SourceContent property is set
        internal bool IsSetSourceContent()
        {
            return this._sourceContent != null && (this._sourceContent.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title or identifier of the source document being cited.
        /// </para>
        /// </summary>
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