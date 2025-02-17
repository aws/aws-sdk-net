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
    public partial class RestoreTestingPlanForCreate
    {
        private RestoreTestingRecoveryPointSelection _recoveryPointSelection;
        private string _restoreTestingPlanName;
        private string _scheduleExpression;
        private string _scheduleExpressionTimezone;
        private int? _startWindowHours;

        /// <summary>
        /// Gets and sets the property RecoveryPointSelection. 
        /// <para>
        ///  <c>RecoveryPointSelection</c> has five parameters (three required and two optional).
        /// The values you specify determine which recovery point is included in the restore test.
        /// You must indicate with <c>Algorithm</c> if you want the latest recovery point within
        /// your <c>SelectionWindowDays</c> or if you want a random recovery point, and you must
        /// indicate through <c>IncludeVaults</c> from which vaults the recovery points can be
        /// chosen.
        /// </para>
        ///  
        /// <para>
        ///  <c>Algorithm</c> (<i>required</i>) Valid values: "<c>LATEST_WITHIN_WINDOW</c>" or
        /// "<c>RANDOM_WITHIN_WINDOW</c>".
        /// </para>
        ///  
        /// <para>
        ///  <c>Recovery point types</c> (<i>required</i>) Valid values: "<c>SNAPSHOT</c>" and/or
        /// "<c>CONTINUOUS</c>". Include <c>SNAPSHOT</c> to restore only snapshot recovery points;
        /// include <c>CONTINUOUS</c> to restore continuous recovery points (point in time restore
        /// / PITR); use both to restore either a snapshot or a continuous recovery point. The
        /// recovery point will be determined by the value for <c>Algorithm</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>IncludeVaults</c> (<i>required</i>). You must include one or more backup vaults.
        /// Use the wildcard ["*"] or specific ARNs.
        /// </para>
        ///  
        /// <para>
        ///  <c>SelectionWindowDays</c> (<i>optional</i>) Value must be an integer (in days) from
        /// 1 to 365. If not included, the value defaults to <c>30</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>ExcludeVaults</c> (<i>optional</i>). You can choose to input one or more specific
        /// backup vault ARNs to exclude those vaults' contents from restore eligibility. Or,
        /// you can include a list of selectors. If this parameter and its value are not included,
        /// it defaults to empty list.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// The RestoreTestingPlanName is a unique string that is the name of the restore testing
        /// plan. This cannot be changed after creation, and it must consist of only alphanumeric
        /// characters and underscores.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestoreTestingPlanName
        {
            get { return this._restoreTestingPlanName; }
            set { this._restoreTestingPlanName = value; }
        }

        // Check to see if RestoreTestingPlanName property is set
        internal bool IsSetRestoreTestingPlanName()
        {
            return this._restoreTestingPlanName != null;
        }

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A CRON expression in specified timezone when a restore testing plan is executed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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