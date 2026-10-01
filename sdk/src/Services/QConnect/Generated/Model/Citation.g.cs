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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CitationSpan.
        /// </summary>
        [AWSProperty(Required = true)]
        public CitationSpan CitationSpan { get; set; }

        /// <summary>
        /// Checks to see if the CitationSpan property is set.
        /// </summary>
        internal bool IsSetCitationSpan() => this.CitationSpan != null;

        /// <summary>
        /// Gets and sets the property ContentId. 
        /// <para>
        /// The identifier of the content being cited.
        /// </para>
        /// </summary>
        public string ContentId { get; set; }

        /// <summary>
        /// Checks to see if the ContentId property is set.
        /// </summary>
        internal bool IsSetContentId() => this.ContentId != null;

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base containing the cited content.
        /// </para>
        /// </summary>
        public string KnowledgeBaseId { get; set; }

        /// <summary>
        /// Checks to see if the KnowledgeBaseId property is set.
        /// </summary>
        internal bool IsSetKnowledgeBaseId() => this.KnowledgeBaseId != null;

        /// <summary>
        /// Gets and sets the property ReferenceType. 
        /// <para>
        /// A type to define the KB origin of a cited content
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReferenceType ReferenceType { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceType property is set.
        /// </summary>
        internal bool IsSetReferenceType() => this.ReferenceType != null;

        /// <summary>
        /// Gets and sets the property SourceURL. 
        /// <para>
        /// The source URL for the citation.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string SourceURL { get; set; }

        /// <summary>
        /// Checks to see if the SourceURL property is set.
        /// </summary>
        internal bool IsSetSourceURL() => this.SourceURL != null;

        /// <summary>
        /// Gets and sets the property Title. 
        /// <para>
        /// The title of the cited content.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string Title { get; set; }

        /// <summary>
        /// Checks to see if the Title property is set.
        /// </summary>
        internal bool IsSetTitle() => this.Title != null;
    }
}
