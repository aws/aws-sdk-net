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
    /// Container for the parameters to the UpdateContinuousBackups operation.
    /// <c>UpdateContinuousBackups</c> enables or disables point in time recovery for the
    /// specified table. A successful <c>UpdateContinuousBackups</c> call returns the current
    /// <c>ContinuousBackupsDescription</c>. Continuous backups are <c>ENABLED</c> on all
    /// tables at table creation. If point in time recovery is enabled, <c>PointInTimeRecoveryStatus</c>
    /// will be set to ENABLED.
    /// 
    ///  
    /// <para>
    ///  Once continuous backups and point in time recovery are enabled, you can restore to
    /// any point in time within <c>EarliestRestorableDateTime</c> and <c>LatestRestorableDateTime</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    ///  <c>LatestRestorableDateTime</c> is typically 5 minutes before the current time. You
    /// can restore your table to any point in time in the last 35 days. You can set the <c>RecoveryPeriodInDays</c>
    /// to any value between 1 and 35 days.
    /// </para>
    /// </summary>
    public partial class UpdateContinuousBackupsRequest : AmazonDynamoDBRequest
    {
        private PointInTimeRecoverySpecification _pointInTimeRecoverySpecification;
        private string _tableName;

        /// <summary>
        /// Gets and sets the property PointInTimeRecoverySpecification. 
        /// <para>
        /// Represents the settings used to enable point in time recovery.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PointInTimeRecoverySpecification PointInTimeRecoverySpecification
        {
            get { return this._pointInTimeRecoverySpecification; }
            set { this._pointInTimeRecoverySpecification = value; }
        }

        // Check to see if PointInTimeRecoverySpecification property is set
        internal bool IsSetPointInTimeRecoverySpecification()
        {
            return this._pointInTimeRecoverySpecification != null;
        }

        /// <summary>
        /// Gets and sets the property TableName. 
        /// <para>
        /// The name of the table. You can also provide the Amazon Resource Name (ARN) of the
        /// table in this parameter.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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

    }
}