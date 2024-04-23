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
 * Do not modify this file. This file is generated from the qbusiness-2023-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.QBusiness.Model
{
    /// <summary>
    /// The documents used to generate an Amazon Q Business web experience response.
    /// </summary>
    public partial class SourceAttribution
    {
        private int? _citationNumber;
        private string _snippet;
        private List<TextSegment> _textMessageSegments = AWSConfigs.InitializeCollections ? new List<TextSegment>() : null;
        private string _title;
        private DateTime? _updatedAt;
        private string _url;

        /// <summary>
        /// Gets and sets the property CitationNumber. 
        /// <para>
        /// The number attached to a citation in an Amazon Q Business generated response.
        /// </para>
        /// </summary>
        public int CitationNumber
        {
            get { return this._citationNumber.GetValueOrDefault(); }
            set { this._citationNumber = value; }
        }

        // Check to see if CitationNumber property is set
        internal bool IsSetCitationNumber()
        {
            return this._citationNumber.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Snippet. 
        /// <para>
        /// The content extract from the document on which the generated response is based. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Snippet
        {
            get { return this._snippet; }
            set { this._snippet = value; }
        }

        // Check to see if Snippet property is set
        internal bool IsSetSnippet()
        {
            return this._snippet != null;
        }

        /// <summary>
        /// Gets and sets the property TextMessageSegments. 
        /// <para>
        /// A text extract from a source document that is used for source attribution.
        /// </para>
        /// </summary>
        public List<TextSegment> TextMessageSegments
        {
            get { return this._textMessageSegments; }
            set { this._textMessageSegments = value; }
        }

        // Check to see if TextMessageSegments property is set
        internal bool IsSetTextMessageSegments()
        {
            return this._textMessageSegments != null && (this._textMessageSegments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the document which is the source for the Amazon Q Business generated
        /// response. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The Unix timestamp when the Amazon Q Business application was last updated.
        /// </para>
        /// </summary>
        public DateTime UpdatedAt
        {
            get { return this._updatedAt.GetValueOrDefault(); }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Url. 
        /// <para>
        /// The URL of the document which is the source for the Amazon Q Business generated response.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string Url
        {
            get { return this._url; }
            set { this._url = value; }
        }

        // Check to see if Url property is set
        internal bool IsSetUrl()
        {
            return this._url != null;
        }

    }
}