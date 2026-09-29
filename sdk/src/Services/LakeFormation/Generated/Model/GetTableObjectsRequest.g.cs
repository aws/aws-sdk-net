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

namespace Amazon.LakeFormation.Model
{
    /// <summary>
    /// Container for the parameters to the GetTableObjects operation. Returns the set of
    /// Amazon S3 objects that make up the specified governed table. A transaction ID or timestamp
    /// can be specified for time-travel queries.
    /// </summary>
    public partial class GetTableObjectsRequest : AmazonLakeFormationRequest
    {
        /// <summary>
        /// Gets and sets the property CatalogId. 
        /// <para>
        /// The catalog containing the governed table. Defaults to the caller’s account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string CatalogId { get; set; }

        /// <summary>
        /// Checks to see if the CatalogId property is set.
        /// </summary>
        internal bool IsSetCatalogId() => this.CatalogId != null;

        /// <summary>
        /// Gets and sets the property DatabaseName. 
        /// <para>
        /// The database containing the governed table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string DatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the DatabaseName property is set.
        /// </summary>
        internal bool IsSetDatabaseName() => this.DatabaseName != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Specifies how many values to return in a page.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A continuation token if this is not the first call to retrieve these objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 4096)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property PartitionPredicate. 
        /// <para>
        /// A predicate to filter the objects returned based on the partition keys defined in
        /// the governed table.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The comparison operators supported are: =, >, &lt;, >=, &lt;=
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
        [AWSProperty(Min = 0, Max = 2048)]
        public string PartitionPredicate { get; set; }

        /// <summary>
        /// Checks to see if the PartitionPredicate property is set.
        /// </summary>
        internal bool IsSetPartitionPredicate() => this.PartitionPredicate != null;

        /// <summary>
        /// Gets and sets the property QueryAsOfTime. 
        /// <para>
        /// The time as of when to read the governed table contents. If not set, the most recent
        /// transaction commit time is used. Cannot be specified along with <c>TransactionId</c>.
        /// </para>
        /// </summary>
        public DateTime? QueryAsOfTime { get; set; }

        /// <summary>
        /// Checks to see if the QueryAsOfTime property is set.
        /// </summary>
        internal bool IsSetQueryAsOfTime() => this.QueryAsOfTime.HasValue;

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The governed table for which to retrieve objects.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string TableName { get; set; }

        /// <summary>
        /// Checks to see if the TableName property is set.
        /// </summary>
        internal bool IsSetTableName() => this.TableName != null;

        /// <summary>
        /// Gets and sets the property TransactionId. 
        /// <para>
        /// The transaction ID at which to read the governed table contents. If this transaction
        /// has aborted, an error is returned. If not set, defaults to the most recent committed
        /// transaction. Cannot be specified along with <c>QueryAsOfTime</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string TransactionId { get; set; }

        /// <summary>
        /// Checks to see if the TransactionId property is set.
        /// </summary>
        internal bool IsSetTransactionId() => this.TransactionId != null;
    }
}
