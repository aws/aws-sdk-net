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
    /// Configuration for content retrieval operations.
    /// </summary>
    public partial class RetrievalConfiguration
    {
        private RetrievalFilterConfiguration _filter;
        private KnowledgeSource _knowledgeSource;
        private int? _numberOfResults;
        private KnowledgeBaseSearchType _overrideKnowledgeBaseSearchType;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// The filter configuration for content retrieval.
        /// </para>
        /// </summary>
        public RetrievalFilterConfiguration Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property KnowledgeSource. 
        /// <para>
        /// The knowledge source configuration for content retrieval.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public KnowledgeSource KnowledgeSource
        {
            get { return this._knowledgeSource; }
            set { this._knowledgeSource = value; }
        }

        // Check to see if KnowledgeSource property is set
        internal bool IsSetKnowledgeSource()
        {
            return this._knowledgeSource != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfResults. 
        /// <para>
        /// The number of results to retrieve.
        /// </para>
        /// </summary>
        public int? NumberOfResults
        {
            get { return this._numberOfResults; }
            set { this._numberOfResults = value; }
        }

        // Check to see if NumberOfResults property is set
        internal bool IsSetNumberOfResults()
        {
            return this._numberOfResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OverrideKnowledgeBaseSearchType. 
        /// <para>
        /// Override setting for the knowledge base search type during retrieval.
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