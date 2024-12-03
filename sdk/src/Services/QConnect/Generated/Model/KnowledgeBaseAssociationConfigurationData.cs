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
    /// The data of the configuration for a <c>KNOWLEDGE_BASE</c> type Amazon Q in Connect
    /// Assistant Association.
    /// </summary>
    public partial class KnowledgeBaseAssociationConfigurationData
    {
        private TagFilter _contentTagFilter;
        private int? _maxResults;
        private KnowledgeBaseSearchType _overrideKnowledgeBaseSearchType;

        /// <summary>
        /// Gets and sets the property ContentTagFilter.
        /// </summary>
        public TagFilter ContentTagFilter
        {
            get { return this._contentTagFilter; }
            set { this._contentTagFilter = value; }
        }

        // Check to see if ContentTagFilter property is set
        internal bool IsSetContentTagFilter()
        {
            return this._contentTagFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OverrideKnowledgeBaseSearchType. 
        /// <para>
        /// The search type to be used against the Knowledge Base for this request. The values
        /// can be <c>SEMANTIC</c> which uses vector embeddings or <c>HYBRID</c> which use vector
        /// embeddings and raw text
        /// </para>
        /// </summary>
        public KnowledgeBaseSearchType OverrideKnowledgeBaseSearchType
        {
            get { return this._overrideKnowledgeBaseSearchType; }
            set { this._overrideKnowledgeBaseSearchType = value; }
        }

        // Check to see if OverrideKnowledgeBaseSearchType property is set
        internal bool IsSetOverrideKnowledgeBaseSearchType()
        {
            return this._overrideKnowledgeBaseSearchType != null;
        }

    }
}