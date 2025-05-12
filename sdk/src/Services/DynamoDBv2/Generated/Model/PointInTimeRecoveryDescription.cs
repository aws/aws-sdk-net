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
    /// The description of the point in time settings applied to the table.
    /// </summary>
    public partial class PointInTimeRecoveryDescription
    {
        private DateTime? _earliestRestorableDateTime;
        private DateTime? _latestRestorableDateTime;
        private PointInTimeRecoveryStatus _pointInTimeRecoveryStatus;
        private int? _recoveryPeriodInDays;

        /// <summary>
        /// Gets and sets the property EarliestRestorableDateTime. 
        /// <para>
        /// Specifies the earliest point in time you can restore your table to. You can restore
        /// your table to any point in time during the last 35 days. 
        /// </para>
        /// </summary>
        public DateTime? EarliestRestorableDateTime
        {
            get { return this._earliestRestorableDateTime; }
            set { this._earliestRestorableDateTime = value; }
        }

        // Check to see if EarliestRestorableDateTime property is set
        internal bool IsSetEarliestRestorableDateTime()
        {
            return this._earliestRestorableDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestRestorableDateTime. 
        /// <para>
        ///  <c>LatestRestorableDateTime</c> is typically 5 minutes before the current time. 
        /// </para>
        /// </summary>
        public DateTime? LatestRestorableDateTime
        {
            get { return this._latestRestorableDateTime; }
            set { this._latestRestorableDateTime = value; }
        }

        // Check to see if LatestRestorableDateTime property is set
        internal bool IsSetLatestRestorableDateTime()
        {
            return this._latestRestorableDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PointInTimeRecoveryStatus. 
        /// <para>
        /// The current state of point in time recovery:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ENABLED</c> - Point in time recovery is enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DISABLED</c> - Point in time recovery is disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public PointInTimeRecoveryStatus PointInTimeRecoveryStatus
        {
            get { return this._pointInTimeRecoveryStatus; }
            set { this._pointInTimeRecoveryStatus = value; }
        }

        // Check to see if PointInTimeRecoveryStatus property is set
        internal bool IsSetPointInTimeRecoveryStatus()
        {
            return this._pointInTimeRecoveryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RecoveryPeriodInDays. 
        /// <para>
        /// The number of preceding days for which continuous backups are taken and maintained.
        /// Your table data is only recoverable to any point-in-time from within the configured
        /// recovery period. This parameter is optional.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=35)]
        public int? RecoveryPeriodInDays
        {
            get { return this._recoveryPeriodInDays; }
            set { this._recoveryPeriodInDays = value; }
        }

        // Check to see if RecoveryPeriodInDays property is set
        internal bool IsSetRecoveryPeriodInDays()
        {
            return this._recoveryPeriodInDays.HasValue; 
        }

    }
}