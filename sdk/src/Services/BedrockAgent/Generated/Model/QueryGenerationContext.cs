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
 * Do not modify this file. This file is generated from the bedrock-agent-2023-06-05.normal.json service model.
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
namespace Amazon.BedrockAgent.Model
{
    /// <summary>
    /// &gt;Contains configurations for context to use during query generation.
    /// </summary>
    public partial class QueryGenerationContext
    {
        private List<CuratedQuery> _curatedQueries = AWSConfigs.InitializeCollections ? new List<CuratedQuery>() : null;
        private List<QueryGenerationTable> _tables = AWSConfigs.InitializeCollections ? new List<QueryGenerationTable>() : null;

        /// <summary>
        /// Gets and sets the property CuratedQueries. 
        /// <para>
        /// An array of objects, each of which defines information about example queries to help
        /// the query engine generate appropriate SQL queries.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<CuratedQuery> CuratedQueries
        {
            get { return this._curatedQueries; }
            set { this._curatedQueries = value; }
        }

        // Check to see if CuratedQueries property is set
        internal bool IsSetCuratedQueries()
        {
            return this._curatedQueries != null && (this._curatedQueries.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tables. 
        /// <para>
        /// An array of objects, each of which defines information about a table in the database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<QueryGenerationTable> Tables
        {
            get { return this._tables; }
            set { this._tables = value; }
        }

        // Check to see if Tables property is set
        internal bool IsSetTables()
        {
            return this._tables != null && (this._tables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}