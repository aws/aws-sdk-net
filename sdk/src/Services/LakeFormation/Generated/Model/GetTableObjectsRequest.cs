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
 * Do not modify this file. This file is generated from the lakeformation-2017-03-31.normal.json service model.
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
namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetTableObjects operation.
    /// Returns the set of Amazon S3 objects that make up the specified governed table. A
    /// transaction ID or timestamp can be specified for time-travel queries.
    /// </summary>
    public partial class GetTableObjectsRequest : AmazonLakeFormationRequest
    {
        private string _catalogId;
        private string _databaseName;
        private int? _maxResults;
        private string _nextToken;
        private string _partitionPredicate;
        private DateTime? _queryAsOfTime;
        private string _tableName;
        private string _transactionId;

        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The catalog containing the governed table. Defaults to the caller’s account.
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
        /// The database containing the governed table.
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
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies how many values to return in a page.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// A continuation token if this is not the first call to retrieve these objects.
        /// </para>
        /// </summary>
        [AWSProperty(Max=4096)]
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
        /// Gets and sets the property PartitionPredicate. 
        /// <para>
        /// A predicate to filter the objects returned based on the partition keys defined in
        /// the governed table.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The comparison operators supported are: =, &gt;, &lt;, &gt;=, &lt;=
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The logical operators supported are: AND
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The data types supported are integer, long, date(yyyy-MM-dd), timestamp(yyyy-MM-dd
        /// HH:mm:ssXXX or yyyy-MM-dd HH:mm:ss"), string and decimal.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string PartitionPredicate
        {
            get { return this._partitionPredicate; }
            set { this._partitionPredicate = value; }
        }

        // Check to see if PartitionPredicate property is set
        internal bool IsSetPartitionPredicate()
        {
            return this._partitionPredicate != null;
        }

        /// <summary>
        /// Gets and sets the property QueryAsOfTime. 
        /// <para>
        /// The time as of when to read the governed table contents. If not set, the most recent
        /// transaction commit time is used. Cannot be specified along with <c>TransactionId</c>.
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
        /// Gets and sets the property TableName. 
        /// <para>
        /// The governed table for which to retrieve objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string TableName
        {
            get { return this._tableName; }
            set { this._tableName = value; }
        }

        // Check to see if TableName property is set
        internal bool IsSetTableName()
        {
            return this._tableName != null;
        }

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID at which to read the governed table contents. If this transaction
        /// has aborted, an error is returned. If not set, defaults to the most recent committed
        /// transaction. Cannot be specified along with <c>QueryAsOfTime</c>.
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