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
    /// The data of the configuration for a <c>KNOWLEDGE_BASE</c> type Amazon Q in Connect
    /// Assistant Association.
    /// </summary>
    public partial class KnowledgeBaseAssociationConfigurationData
    {
        /// <summary>
        /// Gets and sets the property ContentTagFilter.
        /// </summary>
        public TagFilter ContentTagFilter { get; set; }

        /// <summary>
        /// Checks to see if the ContentTagFilter property is set.
        /// </summary>
        internal bool IsSetContentTagFilter() => this.ContentTagFilter != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return per page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property OverrideKnowledgeBaseSearchType. 
        /// <para>
        /// The search type to be used against the Knowledge Base for this request. The values
        /// can be <c>SEMANTIC</c> which uses vector embeddings or <c>HYBRID</c> which use vector
        /// embeddings and raw text
        /// </para>
        /// </summary>
        public KnowledgeBaseSearchType OverrideKnowledgeBaseSearchType { get; set; }

        /// <summary>
        /// Checks to see if the OverrideKnowledgeBaseSearchType property is set.
        /// </summary>
        internal bool IsSetOverrideKnowledgeBaseSearchType() => this.OverrideKnowledgeBaseSearchType != null;
    }
}
