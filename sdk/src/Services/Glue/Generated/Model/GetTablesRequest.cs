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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// Container for the parameters to the GetTables operation.
    /// Retrieves the definitions of some or all of the tables in a given <c>Database</c>.
    /// </summary>
    public partial class GetTablesRequest : AmazonGlueRequest
    {
        private List<string> _attributesToGet = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _catalogId;
        private string _databaseName;
        private string _expression;
        private bool? _includeStatusDetails;
        private int? _maxResults;
        private string _nextToken;
        private DateTime? _queryAsOfTime;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property AttributesToGet. 
        /// <para>
        ///  Specifies the table fields returned by the <c>GetTables</c> call. This parameter
        /// doesn’t accept an empty list. The request must include <c>NAME</c>.
        /// </para>
        ///  
        /// <para>
        /// The following are the valid combinations of values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>NAME</c> - Names of all tables in the database.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NAME</c>, <c>TABLE_TYPE</c> - Names of all tables and the table types.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AttributesToGet
        {
            get { return this._attributesToGet; }
            set { this._attributesToGet = value; }
        }

        // Check to see if AttributesToGet property is set
        internal bool IsSetAttributesToGet()
        {
            return this._attributesToGet != null && (this._attributesToGet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The ID of the Data Catalog where the tables reside. If none is provided, the Amazon
        /// Web Services account ID is used by default.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string CatalogId
        {
            get { return this._catalogId; }
            set { this._catalogId = value; }
        }

        // Check to see if CatalogId property is set
        internal bool IsSetCatalogId()
        {
            return this._catalogId != null;
        }

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database in the catalog whose tables to list. For Hive compatibility, this name
        /// is entirely lowercase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string DatabaseName
        {
            get { return this._databaseName; }
            set { this._databaseName = value; }
        }

        // Check to see if DatabaseName property is set
        internal bool IsSetDatabaseName()
        {
            return this._databaseName != null;
        }

        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// A regular expression pattern. If present, only those tables whose names match the
        /// pattern are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string Expression
        {
            get { return this._expression; }
            set { this._expression = value; }
        }

        // Check to see if Expression property is set
        internal bool IsSetExpression()
        {
            return this._expression != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeStatusDetails. 
        /// <para>
        /// Specifies whether to include status details related to a request to create or update
        /// an Glue Data Catalog view.
        /// </para>
        /// </summary>
        public bool? IncludeStatusDetails
        {
            get { return this._includeStatusDetails; }
            set { this._includeStatusDetails = value; }
        }

        // Check to see if IncludeStatusDetails property is set
        internal bool IsSetIncludeStatusDetails()
        {
            return this._includeStatusDetails.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of tables to return in a single response.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token, included if this is a continuation call.
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
        /// Gets and sets the property QueryAsOfTime. 
        /// <para>
        /// The time as of when to read the table contents. If not set, the most recent transaction
        /// commit time will be used. Cannot be specified along with <c>TransactionId</c>.
        /// </para>
        /// </summary>
        public DateTime? QueryAsOfTime
        {
            get { return this._queryAsOfTime; }
            set { this._queryAsOfTime = value; }
        }

        // Check to see if QueryAsOfTime property is set
        internal bool IsSetQueryAsOfTime()
        {
            return this._queryAsOfTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID at which to read the table contents.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string TransactionId
        {
            get { return this._transactionId; }
            set { this._transactionId = value; }
        }

        // Check to see if TransactionId property is set
        internal bool IsSetTransactionId()
        {
            return this._transactionId != null;
        }

    }
}