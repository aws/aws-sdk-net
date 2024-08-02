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
 * Do not modify this file. This file is generated from the dynamodb-2012-08-10.normal.json service model.
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
namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the ListGlobalTables operation.
    /// Lists all global tables that have a replica in the specified Region.
    /// 
    ///  <important> 
    /// <para>
    /// This documentation is for version 2017.11.29 (Legacy) of global tables, which should
    /// be avoided for new global tables. Customers should use <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/GlobalTables.html">Global
    /// Tables version 2019.11.21 (Current)</a> when possible, because it provides greater
    /// flexibility, higher efficiency, and consumes less write capacity than 2017.11.29 (Legacy).
    /// </para>
    ///  
    /// <para>
    /// To determine which version you're using, see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/globaltables.DetermineVersion.html">Determining
    /// the global table version you are using</a>. To update existing global tables from
    /// version 2017.11.29 (Legacy) to version 2019.11.21 (Current), see <a href="https://docs.aws.amazon.com/amazondynamodb/latest/developerguide/V2globaltables_upgrade.html">Upgrading
    /// global tables</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class ListGlobalTablesRequest : AmazonDynamoDBRequest
    {
        private string _exclusiveStartGlobalTableName;
        private int? _limit;
        private string _regionName;

        /// <summary>
        /// Gets and sets the property ExclusiveStartGlobalTableName. 
        /// <para>
        /// The first global table name that this operation will evaluate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=255)]
        public string ExclusiveStartGlobalTableName
        {
            get { return this._exclusiveStartGlobalTableName; }
            set { this._exclusiveStartGlobalTableName = value; }
        }

        // Check to see if ExclusiveStartGlobalTableName property is set
        internal bool IsSetExclusiveStartGlobalTableName()
        {
            return this._exclusiveStartGlobalTableName != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of table names to return, if the parameter is not specified DynamoDB
        /// defaults to 100.
        /// </para>
        ///  
        /// <para>
        /// If the number of global tables DynamoDB finds reaches this limit, it stops the operation
        /// and returns the table names collected up to that point, with a table name in the <c>LastEvaluatedGlobalTableName</c>
        /// to apply in a subsequent operation to the <c>ExclusiveStartGlobalTableName</c> parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? Limit
        {
            get { return this._limit; }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RegionName. 
        /// <para>
        /// Lists the global tables in a specific Region.
        /// </para>
        /// </summary>
        public string RegionName
        {
            get { return this._regionName; }
            set { this._regionName = value; }
        }

        // Check to see if RegionName property is set
        internal bool IsSetRegionName()
        {
            return this._regionName != null;
        }

    }
}