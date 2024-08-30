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
    public partial class RestoreTestingPlanForGet
    {
        private DateTime? _creationTime;
        private string _creatorRequestId;
        private DateTime? _lastExecutionTime;
        private DateTime? _lastUpdateTime;
        private RestoreTestingRecoveryPointSelection _recoveryPointSelection;
        private string _restoreTestingPlanArn;
        private string _restoreTestingPlanName;
        private string _scheduleExpression;
        private string _scheduleExpressionTimezone;
        private int? _startWindowHours;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a restore testing plan was created, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationTime</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatorRequestId. 
        /// <para>
        /// This identifies the request and allows failed requests to be retried without the risk
        /// of running the operation twice. If the request includes a <c>CreatorRequestId</c>
        /// that matches an existing backup plan, that plan is returned. This parameter is optional.
        /// </para>
        ///  
        /// <para>
        /// If used, this parameter must contain 1 to 50 alphanumeric or '-_.' characters.
        /// </para>
        /// </summary>
        public string CreatorRequestId
        {
            get { return this._creatorRequestId; }
            set { this._creatorRequestId = value; }
        }

        // Check to see if CreatorRequestId property is set
        internal bool IsSetCreatorRequestId()
        {
            return this._creatorRequestId != null;
        }

        /// <summary>
        /// Gets and sets the property LastExecutionTime. 
        /// <para>
        /// The last time a restore test was run with the specified restore testing plan. A date
        /// and time, in Unix format and Coordinated Universal Time (UTC). The value of <c>LastExecutionDate</c>
        /// is accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime LastExecutionTime
        {
            get { return this._lastExecutionTime.GetValueOrDefault(); }
            set { this._lastExecutionTime = value; }
        }

        // Check to see if LastExecutionTime property is set
        internal bool IsSetLastExecutionTime()
        {
            return this._lastExecutionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time that the restore testing plan was updated. This update is in Unix
        /// format and Coordinated Universal Time (UTC). The value of <c>LastUpdateTime</c> is
        /// accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime LastUpdateTime
        {
            get { return this._lastUpdateTime.GetValueOrDefault(); }
            set { this._lastUpdateTime = value; }
        }

        // Check to see if LastUpdateTime property is set
        internal bool IsSetLastUpdateTime()
        {
            return this._lastUpdateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RecoveryPointSelection. 
        /// <para>
        /// The specified criteria to assign a set of resources, such as recovery point types
        /// or backup vaults.
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
        /// Gets and sets the property RestoreTestingPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifies a restore testing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RestoreTestingPlanArn
        {
            get { return this._restoreTestingPlanArn; }
            set { this._restoreTestingPlanArn = value; }
        }

        // Check to see if RestoreTestingPlanArn property is set
        internal bool IsSetRestoreTestingPlanArn()
        {
            return this._restoreTestingPlanArn != null;
        }

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// The restore testing plan name.
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