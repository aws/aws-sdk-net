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
    /// Container for the parameters to the UpdateGlobalTableSettings operation.
    /// Updates settings for a global table.
    /// </summary>
    public partial class UpdateGlobalTableSettingsRequest : AmazonDynamoDBRequest
    {
        private List<GlobalTableGlobalSecondaryIndexSettingsUpdate> _globalTableGlobalSecondaryIndexSettingsUpdate = new List<GlobalTableGlobalSecondaryIndexSettingsUpdate>();
        private string _globalTableName;
        private long? _globalTableProvisionedWriteCapacityUnits;
        private List<ReplicaSettingsUpdate> _replicaSettingsUpdate = new List<ReplicaSettingsUpdate>();

        /// <summary>
        /// Gets and sets the property GlobalTableGlobalSecondaryIndexSettingsUpdate. 
        /// <para>
        /// Represents the settings of a global secondary index for a global table that will be
        /// modified.
        /// </para>
        /// </summary>
        public List<GlobalTableGlobalSecondaryIndexSettingsUpdate> GlobalTableGlobalSecondaryIndexSettingsUpdate
        {
            get { return this._globalTableGlobalSecondaryIndexSettingsUpdate; }
            set { this._globalTableGlobalSecondaryIndexSettingsUpdate = value; }
        }

        // Check to see if GlobalTableGlobalSecondaryIndexSettingsUpdate property is set
        internal bool IsSetGlobalTableGlobalSecondaryIndexSettingsUpdate()
        {
            return this._globalTableGlobalSecondaryIndexSettingsUpdate != null && this._globalTableGlobalSecondaryIndexSettingsUpdate.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property GlobalTableName. 
        /// <para>
        /// The name of the global table
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
        /// Gets and sets the property GlobalTableProvisionedWriteCapacityUnits. 
        /// <para>
        /// The maximum number of writes consumed per second before DynamoDB returns a <code>ThrottlingException.</code>
        /// 
        /// </para>
        /// </summary>
        public long GlobalTableProvisionedWriteCapacityUnits
        {
            get { return this._globalTableProvisionedWriteCapacityUnits.GetValueOrDefault(); }
            set { this._globalTableProvisionedWriteCapacityUnits = value; }
        }

        // Check to see if GlobalTableProvisionedWriteCapacityUnits property is set
        internal bool IsSetGlobalTableProvisionedWriteCapacityUnits()
        {
            return this._globalTableProvisionedWriteCapacityUnits.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicaSettingsUpdate. 
        /// <para>
        /// Represents the settings for a global table in a region that will be modified.
        /// </para>
        /// </summary>
        public List<ReplicaSettingsUpdate> ReplicaSettingsUpdate
        {
            get { return this._replicaSettingsUpdate; }
            set { this._replicaSettingsUpdate = value; }
        }

        // Check to see if ReplicaSettingsUpdate property is set
        internal bool IsSetReplicaSettingsUpdate()
        {
            return this._replicaSettingsUpdate != null && this._replicaSettingsUpdate.Count > 0; 
        }

    }
}