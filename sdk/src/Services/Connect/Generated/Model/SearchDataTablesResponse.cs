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
 * Do not modify this file. This file is generated from the connect-2017-08-08.normal.json service model.
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
namespace Amazon.Connect.Model
{
    /// <summary>
    /// This is the response object from the SearchDataTables operation.
    /// </summary>
    public partial class SearchDataTablesResponse : AmazonWebServiceResponse
    {
        private long? _approximateTotalCount;
        private List<DataTable> _dataTables = AWSConfigs.InitializeCollections ? new List<DataTable>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApproximateTotalCount. 
        /// <para>
        /// The approximate number of data tables that matched the search criteria.
        /// </para>
        /// </summary>
        public long? ApproximateTotalCount
        {
            get { return this._approximateTotalCount; }
            set { this._approximateTotalCount = value; }
        }

        // Check to see if ApproximateTotalCount property is set
        internal bool IsSetApproximateTotalCount()
        {
            return this._approximateTotalCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataTables. 
        /// <para>
        /// An array of data tables matching the search criteria with the same structure as DescribeTable
        /// except Version, VersionDescription, and LockVersion are omitted.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataTable> DataTables
        {
            get { return this._dataTables; }
            set { this._dataTables = value; }
        }

        // Check to see if DataTables property is set
        internal bool IsSetDataTables()
        {
            return this._dataTables != null && (this._dataTables.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Specify the pagination token from a previous request to retrieve the next page of
        /// results.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}