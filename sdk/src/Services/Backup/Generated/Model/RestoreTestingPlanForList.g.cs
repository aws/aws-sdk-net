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

namespace Amazon.Backup.Model
{
    /// <summary>
    /// This contains metadata about a restore testing plan.
    /// </summary>
    public partial class RestoreTestingPlanForList
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a restore testing plan was created, in Unix format and Coordinated
        /// Universal Time (UTC). The value of <c>CreationTime</c> is accurate to milliseconds.
        /// For example, the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087
        /// AM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastExecutionTime. 
        /// <para>
        /// The last time a restore test was run with the specified restore testing plan. A date
        /// and time, in Unix format and Coordinated Universal Time (UTC). The value of <c>LastExecutionDate</c>
        /// is accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? LastExecutionTime { get; set; }

        /// <summary>
        /// Checks to see if the LastExecutionTime property is set.
        /// </summary>
        internal bool IsSetLastExecutionTime() => this.LastExecutionTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateTime. 
        /// <para>
        /// The date and time that the restore testing plan was updated. This update is in Unix
        /// format and Coordinated Universal Time (UTC). The value of <c>LastUpdateTime</c> is
        /// accurate to milliseconds. For example, the value 1516925490.087 represents Friday,
        /// January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? LastUpdateTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateTime property is set.
        /// </summary>
        internal bool IsSetLastUpdateTime() => this.LastUpdateTime.HasValue;

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanArn. 
        /// <para>
        /// An Amazon Resource Name (ARN) that uniquely identifiesa restore testing plan.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingPlanArn { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingPlanArn property is set.
        /// </summary>
        internal bool IsSetRestoreTestingPlanArn() => this.RestoreTestingPlanArn != null;

        /// <summary>
        /// Gets and sets the property RestoreTestingPlanName. 
        /// <para>
        /// The restore testing plan name.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string RestoreTestingPlanName { get; set; }

        /// <summary>
        /// Checks to see if the RestoreTestingPlanName property is set.
        /// </summary>
        internal bool IsSetRestoreTestingPlanName() => this.RestoreTestingPlanName != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpression. 
        /// <para>
        /// A CRON expression in specified timezone when a restore testing plan is executed. When
        /// no CRON expression is provided, Backup will use the default expression <c>cron(0 5
        /// ? * * *)</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ScheduleExpression { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpression property is set.
        /// </summary>
        internal bool IsSetScheduleExpression() => this.ScheduleExpression != null;

        /// <summary>
        /// Gets and sets the property ScheduleExpressionTimezone. 
        /// <para>
        /// Optional. This is the timezone in which the schedule expression is set. By default,
        /// ScheduleExpressions are in UTC. You can modify this to a specified timezone.
        /// </para>
        /// </summary>
        public string ScheduleExpressionTimezone { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleExpressionTimezone property is set.
        /// </summary>
        internal bool IsSetScheduleExpressionTimezone() => this.ScheduleExpressionTimezone != null;

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
        public int? StartWindowHours { get; set; }

        /// <summary>
        /// Checks to see if the StartWindowHours property is set.
        /// </summary>
        internal bool IsSetStartWindowHours() => this.StartWindowHours.HasValue;
    }
}
