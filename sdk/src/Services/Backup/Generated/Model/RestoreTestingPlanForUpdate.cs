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
 * Do not modify this file. This file is generated from the backup-2018-11-15.normal.json service model.
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
namespace Amazon.Backup.Model
{
    /// <summary>
    /// This contains metadata about a restore testing plan.
    /// </summary>
    public partial class RestoreTestingPlanForUpdate
    {
        private RestoreTestingRecoveryPointSelection _recoveryPointSelection;
        private string _scheduleExpression;
        private string _scheduleExpressionTimezone;
        private int? _startWindowHours;

        /// <summary>
        /// Gets and sets the property RecoveryPointSelection. 
        /// <para>
        /// Required: <c>Algorithm</c>; <c>RecoveryPointTypes</c>; <c>IncludeVaults</c> (<i>one
        /// or more</i>).
        /// </para>
        ///  
        /// <para>
        /// Optional: <i>SelectionWindowDays</i> (<i>'30' if not specified</i>); <c>ExcludeVaults</c>
        /// (defaults to empty list if not listed).
        /// </para>
        /// </summary>
        public RestoreTestingRecoveryPointSelection RecoveryPointSelection
        {
            get { return this._recoveryPointSelection; }
            set { this._recoveryPointSelection = value; }
        }

        // Check to see if RecoveryPointSelection property is set
        internal bool IsSetRecoveryPointSelection()
        {
            return this._recoveryPointSelection != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A CRON expression in specified timezone when a restore testing plan is executed.
        /// </para>
        /// </summary>
        public string ScheduleExpression
        {
            get { return this._scheduleExpression; }
            set { this._scheduleExpression = value; }
        }

        // Check to see if ScheduleExpression property is set
        internal bool IsSetScheduleExpression()
        {
            return this._scheduleExpression != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpressionTimezone. 
        /// <para>
        /// Optional. This is the timezone in which the schedule expression is set. By default,
        /// ScheduleExpressions are in UTC. You can modify this to a specified timezone.
        /// </para>
        /// </summary>
        public string ScheduleExpressionTimezone
        {
            get { return this._scheduleExpressionTimezone; }
            set { this._scheduleExpressionTimezone = value; }
        }

        // Check to see if ScheduleExpressionTimezone property is set
        internal bool IsSetScheduleExpressionTimezone()
        {
            return this._scheduleExpressionTimezone != null;
        }

        /// <summary>
        /// Gets and sets the property StartWindowHours. 
        /// <para>
        /// Defaults to 24 hours.
        /// </para>
        ///  
        /// <para>
        /// A value in hours after a restore test is scheduled before a job will be canceled if
        /// it doesn't start successfully. This value is optional. If this value is included,
        /// this parameter has a maximum value of 168 hours (one week).
        /// </para>
        /// </summary>
        public int StartWindowHours
        {
            get { return this._startWindowHours.GetValueOrDefault(); }
            set { this._startWindowHours = value; }
        }

        // Check to see if StartWindowHours property is set
        internal bool IsSetStartWindowHours()
        {
            return this._startWindowHours.HasValue; 
        }

    }
}