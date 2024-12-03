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
    /// Reference information about the content.
    /// </summary>
    public partial class ContentReference
    {
        private string _contentArn;
        private string _contentId;
        private string _knowledgeBaseArn;
        private string _knowledgeBaseId;
        private ReferenceType _referenceType;
        private string _sourceurl;

        /// <summary>
        /// Gets and sets the property ContentArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the content.
        /// </para>
        /// </summary>
        public string ContentArn
        {
            get { return this._contentArn; }
            set { this._contentArn = value; }
        }

        // Check to see if ContentArn property is set
        internal bool IsSetContentArn()
        {
            return this._contentArn != null;
        }

        /// <summary>
        /// Gets and sets the property ContentId. 
        /// <para>
        /// The identifier of the content.
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
        /// Gets and sets the property KnowledgeBaseArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the knowledge base.
        /// </para>
        /// </summary>
        public string KnowledgeBaseArn
        {
            get { return this._knowledgeBaseArn; }
            set { this._knowledgeBaseArn = value; }
        }

        // Check to see if KnowledgeBaseArn property is set
        internal bool IsSetKnowledgeBaseArn()
        {
            return this._knowledgeBaseArn != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeBaseId. 
        /// <para>
        /// The identifier of the knowledge base. This should not be a QUICK_RESPONSES type knowledge
        /// base.
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
        /// The type of reference content.
        /// </para>
        /// </summary>
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
        /// The web URL of the source content.
        /// </para>
        /// </summary>
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

    }
}