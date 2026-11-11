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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Summary information about an alarm mute rule, including its name, status, and configuration
    /// details.
    /// </summary>
    public partial class AlarmMuteRuleSummary
    {
        /// <summary>
        /// Gets and sets the property AlarmMuteRuleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the alarm mute rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1600)]
        public string AlarmMuteRuleArn { get; set; }

        /// <summary>
        /// Checks to see if the AlarmMuteRuleArn property is set.
        /// </summary>
        internal bool IsSetAlarmMuteRuleArn() => this.AlarmMuteRuleArn != null;

        /// <summary>
        /// Gets and sets the property ExpireDate. 
        /// <para>
        /// The date and time when the mute rule expires and is no longer evaluated. This field
        /// is only present if an expiration date was configured.
        /// </para>
        /// </summary>
        public DateTime? ExpireDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpireDate property is set.
        /// </summary>
        internal bool IsSetExpireDate() => this.ExpireDate.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedTimestamp. 
        /// <para>
        /// The date and time when the mute rule was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTimestamp() => this.LastUpdatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property MuteType. 
        /// <para>
        /// Indicates whether the mute rule is one-time or recurring. Valid values are <c>ONE_TIME</c>
        /// or <c>RECURRING</c>.
        /// </para>
        /// </summary>
        public string MuteType { get; set; }

        /// <summary>
        /// Checks to see if the MuteType property is set.
        /// </summary>
        internal bool IsSetMuteType() => this.MuteType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the alarm mute rule. Valid values are <c>SCHEDULED</c>, <c>ACTIVE</c>,
        /// or <c>EXPIRED</c>.
        /// </para>
        /// </summary>
        public AlarmMuteRuleStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
