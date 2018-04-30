/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DynamoDBv2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateGlobalTable operation.
    /// Creates a global table from an existing table. A global table creates a replication
    /// relationship between two or more DynamoDB tables with the same table name in the provided
    /// regions. 
    /// 
    ///  
    /// <para>
    ///  Tables can only be added as the replicas of a global table group under the following
    /// conditions: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  The tables must have the same name. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The tables must contain no items. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The tables must have the same hash key and sort key (if present). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The tables must have DynamoDB Streams enabled (NEW_AND_OLD_IMAGES). 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The tables must have same provisioned and maximum write capacity units. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  If global secondary indexes are specified, then the following conditions must also
    /// be met: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  The global secondary indexes must have the same name. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The global secondary indexes must have the same hash key and sort key (if present).
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  The global secondary indexes must have the same provisioned and maximum write capacity
    /// units. 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateGlobalTableRequest : AmazonDynamoDBRequest
    {
        private string _globalTableName;
        private List<Replica> _replicationGroup = new List<Replica>();

        /// <summary>
        /// Gets and sets the property GlobalTableName. 
        /// <para>
        /// The global table name.
        /// </para>
        /// </summary>
        public string GlobalTableName
        {
            get { return this._globalTableName; }
            set { this._globalTableName = value; }
        }

        // Check to see if GlobalTableName property is set
        internal bool IsSetGlobalTableName()
        {
            return this._globalTableName != null;
        }

        /// <summary>
        /// Gets and sets the property ReplicationGroup. 
        /// <para>
        /// The regions where the global table needs to be created.
        /// </para>
        /// </summary>
        public List<Replica> ReplicationGroup
        {
            get { return this._replicationGroup; }
            set { this._replicationGroup = value; }
        }

        // Check to see if ReplicationGroup property is set
        internal bool IsSetReplicationGroup()
        {
            return this._replicationGroup != null && this._replicationGroup.Count > 0; 
        }

    }
}