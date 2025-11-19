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
    /// Contains information about a citation that references a specific source document.
    /// Citations provide traceability between the model's generated response and the source
    /// documents that informed that response.
    /// </summary>
    public partial class Citation
    {
        private CitationLocation _location;
        private string _source;
        private List<CitationSourceContent> _sourceContent = AWSConfigs.InitializeCollections ? new List<CitationSourceContent>() : null;
        private string _title;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The precise location within the source document where the cited content can be found,
        /// including character positions, page numbers, or chunk identifiers.
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
        /// Gets and sets the property Source. 
        /// <para>
        /// The source from the original search result that provided the cited content.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SourceContent. 
        /// <para>
        /// The specific content from the source document that was referenced or cited in the
        /// generated response.
        /// </para>
        /// </summary>
        public List<CitationSourceContent> SourceContent
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