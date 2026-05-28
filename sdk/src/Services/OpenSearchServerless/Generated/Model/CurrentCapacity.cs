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
 * Do not modify this file. This file is generated from the opensearchserverless-2021-11-01.normal.json service model.
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
namespace Amazon.OpenSearchServerless.Model
{
    /// <summary>
    /// Current search and indexing capacity for an OpenSearch Serverless collection group.
    /// Measured in OpenSearch Compute Units (OCUs).
    /// </summary>
    public partial class CurrentCapacity
    {
        private CapacityDetails _indexing;
        private CapacityDetails _search;

        /// <summary>
        /// Gets and sets the property Indexing. 
        /// <para>
        /// The indexing capacity for the collection group.
        /// </para>
        /// </summary>
        public CapacityDetails Indexing
        {
            get { return this._indexing; }
            set { this._indexing = value; }
        }

        // Check to see if Indexing property is set
        internal bool IsSetIndexing()
        {
            return this._indexing != null;
        }

        /// <summary>
        /// Gets and sets the property Search. 
        /// <para>
        /// The search capacity for the collection group.
        /// </para>
        /// </summary>
        public CapacityDetails Search
        {
            get { return this._search; }
            set { this._search = value; }
        }

        // Check to see if Search property is set
        internal bool IsSetSearch()
        {
            return this._search != null;
        }

    }
}