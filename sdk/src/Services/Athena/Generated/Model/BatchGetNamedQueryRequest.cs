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
 * Do not modify this file. This file is generated from the athena-2017-05-18.normal.json service model.
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
namespace Amazon.Athena.Model
{
    /// <summary>
    /// Container for the parameters to the BatchGetNamedQuery operation.
    /// Returns the details of a single named query or a list of up to 50 queries, which you
    /// provide as an array of query ID strings. Requires you to have access to the workgroup
    /// in which the queries were saved. Use <a>ListNamedQueriesInput</a> to get the list
    /// of named query IDs in the specified workgroup. If information could not be retrieved
    /// for a submitted query ID, information about the query ID submitted is listed under
    /// <a>UnprocessedNamedQueryId</a>. Named queries differ from executed queries. Use <a>BatchGetQueryExecutionInput</a>
    /// to get details about each unique query execution, and <a>ListQueryExecutionsInput</a>
    /// to get a list of query execution IDs.
    /// </summary>
    public partial class BatchGetNamedQueryRequest : AmazonAthenaRequest
    {
        private List<string> _namedQueryIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property NamedQueryIds. 
        /// <para>
        /// An array of query IDs.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<string> NamedQueryIds
        {
            get { return this._namedQueryIds; }
            set { this._namedQueryIds = value; }
        }

        // Check to see if NamedQueryIds property is set
        internal bool IsSetNamedQueryIds()
        {
            return this._namedQueryIds != null && (this._namedQueryIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}