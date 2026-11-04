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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the ModifyScheduledAction operation. Modifies a scheduled
    /// action.
    /// </summary>
    public partial class ModifyScheduledActionRequest : AmazonRedshiftRequest
    {
        /// <summary>
        /// Gets and sets the property Enable. 
        /// <para>
        /// A modified enable flag of the scheduled action. If true, the scheduled action is active.
        /// If false, the scheduled action is disabled. 
        /// </para>
        /// </summary>
        public bool? Enable { get; set; }

        /// <summary>
        /// Checks to see if the Enable property is set.
        /// </summary>
        internal bool IsSetEnable() => this.Enable.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A modified end time of the scheduled action. For more information about this parameter,
        /// see <a>ScheduledAction</a>. 
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// A different IAM role to assume to run the target action. For more information about
        /// this parameter, see <a>ScheduledAction</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string IamRole { get; set; }

        /// <summary>
        /// Checks to see if the IamRole property is set.
        /// </summary>
        internal bool IsSetIamRole() => this.IamRole != null;

        /// <summary>
        /// Gets and sets the property Schedule. 
        /// <para>
        /// A modified schedule in either <c>at( )</c> or <c>cron( )</c> format. For more information
        /// about this parameter, see <a>ScheduledAction</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string Schedule { get; set; }

        /// <summary>
        /// Checks to see if the Schedule property is set.
        /// </summary>
        internal bool IsSetSchedule() => this.Schedule != null;

        /// <summary>
        /// Gets and sets the property ScheduledActionDescription. 
        /// <para>
        /// A modified description of the scheduled action. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2147483647)]
        public string ScheduledActionDescription { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledActionDescription property is set.
        /// </summary>
        internal bool IsSetScheduledActionDescription() => this.ScheduledActionDescription != null;

        /// <summary>
        /// Gets and sets the property ScheduledActionName. 
        /// <para>
        /// The name of the scheduled action to modify. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2147483647)]
        public string ScheduledActionName { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledActionName property is set.
        /// </summary>
        internal bool IsSetScheduledActionName() => this.ScheduledActionName != null;

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A modified start time of the scheduled action. For more information about this parameter,
        /// see <a>ScheduledAction</a>. 
        /// </para>
        /// </summary>
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Checks to see if the StartTime property is set.
        /// </summary>
        internal bool IsSetStartTime() => this.StartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TargetAction. 
        /// <para>
        /// A modified JSON format of the scheduled action. For more information about this parameter,
        /// see <a>ScheduledAction</a>. 
        /// </para>
        /// </summary>
        public ScheduledActionType TargetAction { get; set; }

        /// <summary>
        /// Checks to see if the TargetAction property is set.
        /// </summary>
        internal bool IsSetTargetAction() => this.TargetAction != null;
    }
}
