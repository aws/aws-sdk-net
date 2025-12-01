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
 * Do not modify this file. This file is generated from the qconnect-2020-10-19.normal.json service model.
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
namespace Amazon.QConnect.Model
{
    /// <summary>
    /// A citation that references source content.
    /// </summary>
    public partial class Citation
    {
        private CitationSpan _citationSpan;
        private string _contentId;
        private string _knowledgeBaseId;
        private ReferenceType _referenceType;
        private string _sourceurl;
        private string _title;

        /// <summary>
        /// Gets and sets the property CitationSpan.
        /// </summary>
        [AWSProperty(Required=true)]
        public CitationSpan CitationSpan
        {
            get { return this._citationSpan; }
            set { this._citationSpan = value; }
        }

        // Check to see if CitationSpan property is set
        internal bool IsSetCitationSpan()
        {
            return this._citationSpan != null;
        }

        /// <summary>
        /// Gets and sets the property ContentId. 
        /// <para>
        /// The identifier of the content being cited.
        /// </para>
        /// </summary>
        public string ContentId
        {
            get { return this._contentId; }
            set { this._contentId = value; }
        }

        // Check to see if ContentId property is set
        internal bool IsSetContentId()
        {
            return this._contentId != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base containing the cited content.
        /// </para>
        /// </summary>
        public string KnowledgeBaseId
        {
            get { return this._knowledgeBaseId; }
            set { this._knowledgeBaseId = value; }
        }

        // Check to see if KnowledgeBaseId property is set
        internal bool IsSetKnowledgeBaseId()
        {
            return this._knowledgeBaseId != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceType. 
        /// <para>
        /// A type to define the KB origin of a cited content
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReferenceType ReferenceType
        {
            get { return this._referenceType; }
            set { this._referenceType = value; }
        }

        // Check to see if ReferenceType property is set
        internal bool IsSetReferenceType()
        {
            return this._referenceType != null;
        }

        /// <summary>
        /// Gets and sets the property SourceURL. 
        /// <para>
        /// The source URL for the citation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SourceURL
        {
            get { return this._sourceurl; }
            set { this._sourceurl = value; }
        }

        // Check to see if SourceURL property is set
        internal bool IsSetSourceURL()
        {
            return this._sourceurl != null;
        }

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the cited content.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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