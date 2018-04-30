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
    /// Container for the parameters to the RestoreTableToPointInTime operation.
    /// Restores the specified table to the specified point in time within <code>EarliestRestorableDateTime</code>
    /// and <code>LatestRestorableDateTime</code>. You can restore your table to any point
    /// in time during the last 35 days. Any number of users can execute up to 4 concurrent
    /// restores (any type of restore) in a given account. 
    /// 
    ///  
    /// <para>
    ///  When you restore using point in time recovery, DynamoDB restores your table data
    /// to the state based on the selected date and time (day:hour:minute:second) to a new
    /// table. 
    /// </para>
    ///  
    /// <para>
    ///  Along with data, the following are also included on the new restored table using
    /// point in time recovery: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Global secondary indexes (GSIs)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Local secondary indexes (LSIs)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Provisioned read and write capacity
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Encryption settings
    /// </para>
    ///  <important> 
    /// <para>
    ///  All these settings come from the current settings of the source table at the time
    /// of restore. 
    /// </para>
    ///  </important> </li> </ul> 
    /// <para>
    /// You must manually set up the following on the restored table:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Auto scaling policies
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// IAM policies
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Cloudwatch metrics and alarms
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Tags
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Stream settings
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Time to Live (TTL) settings
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Point in time recovery settings
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class RestoreTableToPointInTimeRequest : AmazonDynamoDBRequest
    {
        private DateTime? _restoreDateTime;
        private string _sourceTableName;
        private string _targetTableName;
        private bool? _useLatestRestorableTime;

        /// <summary>
        /// Gets and sets the property RestoreDateTime. 
        /// <para>
        /// Time in the past to restore the table to.
        /// </para>
        /// </summary>
        public DateTime RestoreDateTime
        {
            get { return this._restoreDateTime.GetValueOrDefault(); }
            set { this._restoreDateTime = value; }
        }

        // Check to see if RestoreDateTime property is set
        internal bool IsSetRestoreDateTime()
        {
            return this._restoreDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceTableName. 
        /// <para>
        /// Name of the source table that is being restored.
        /// </para>
        /// </summary>
        public string SourceTableName
        {
            get { return this._sourceTableName; }
            set { this._sourceTableName = value; }
        }

        // Check to see if SourceTableName property is set
        internal bool IsSetSourceTableName()
        {
            return this._sourceTableName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetTableName. 
        /// <para>
        /// The name of the new table to which it must be restored to.
        /// </para>
        /// </summary>
        public string TargetTableName
        {
            get { return this._targetTableName; }
            set { this._targetTableName = value; }
        }

        // Check to see if TargetTableName property is set
        internal bool IsSetTargetTableName()
        {
            return this._targetTableName != null;
        }

        /// <summary>
        /// Gets and sets the property UseLatestRestorableTime. 
        /// <para>
        /// Restore the table to the latest possible time. <code>LatestRestorableDateTime</code>
        /// is typically 5 minutes before the current time. 
        /// </para>
        /// </summary>
        public bool UseLatestRestorableTime
        {
            get { return this._useLatestRestorableTime.GetValueOrDefault(); }
            set { this._useLatestRestorableTime = value; }
        }

        // Check to see if UseLatestRestorableTime property is set
        internal bool IsSetUseLatestRestorableTime()
        {
            return this._useLatestRestorableTime.HasValue; 
        }

    }
}