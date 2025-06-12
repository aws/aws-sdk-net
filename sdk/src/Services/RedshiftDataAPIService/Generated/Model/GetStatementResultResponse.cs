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
 * Do not modify this file. This file is generated from the redshift-data-2019-12-20.normal.json service model.
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
namespace Amazon.RedshiftDataAPIService.Model
{
    /// <summary>
    /// This is the response object from the GetStatementResult operation.
    /// </summary>
    public partial class GetStatementResultResponse : AmazonWebServiceResponse
    {
        private List<ColumnMetadata> _columnMetadata = AWSConfigs.InitializeCollections ? new List<ColumnMetadata>() : null;
        private string _nextToken;
        private List<List<Field>> _records = AWSConfigs.InitializeCollections ? new List<List<Field>>() : null;
        private long? _totalNumRows;

        /// <summary>
        /// Gets and sets the property ColumnMetadata. 
        /// <para>
        /// The properties (metadata) of a column. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ColumnMetadata> ColumnMetadata
        {
            get { return this._columnMetadata; }
            set { this._columnMetadata = value; }
        }

        // Check to see if ColumnMetadata property is set
        internal bool IsSetColumnMetadata()
        {
            return this._columnMetadata != null && (this._columnMetadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A value that indicates the starting point for the next set of response records in
        /// a subsequent request. If a value is returned in a response, you can retrieve the next
        /// set of records by providing this returned NextToken value in the next NextToken parameter
        /// and retrying the command. If the NextToken field is empty, all response records have
        /// been retrieved for the request. 
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

        /// <summary>
        /// Gets and sets the property Records. 
        /// <para>
        /// The results of the SQL statement in JSON format.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<List<Field>> Records
        {
            get { return this._records; }
            set { this._records = value; }
        }

        // Check to see if Records property is set
        internal bool IsSetRecords()
        {
            return this._records != null && (this._records.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TotalNumRows. 
        /// <para>
        /// The total number of rows in the result set returned from a query. You can use this
        /// number to estimate the number of calls to the <c>GetStatementResult</c> operation
        /// needed to page through the results. 
        /// </para>
        /// </summary>
        public long? TotalNumRows
        {
            get { return this._totalNumRows; }
            set { this._totalNumRows = value; }
        }

        // Check to see if TotalNumRows property is set
        internal bool IsSetTotalNumRows()
        {
            return this._totalNumRows.HasValue; 
        }

    }
}