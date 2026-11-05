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
    /// Container for the parameters to the PutAlarmMuteRule operation. Creates or updates
    /// an alarm mute rule. <para> Alarm mute rules automatically mute alarm actions during
    /// predefined time windows. When a mute rule is active, targeted alarms continue to evaluate
    /// metrics and transition between states, but their configured actions (such as Amazon
    /// SNS notifications or Auto Scaling actions) are muted. </para> <para> You can create
    /// mute rules with recurring schedules using <c>cron</c> expressions or one-time mute
    /// windows using <c>at</c> expressions. Each mute rule can target up to 100 specific
    /// alarms by name. </para> <para> If you specify a rule name that already exists, this
    /// operation updates the existing rule with the new configuration. </para> <para> <b>Permissions</b>
    /// </para> <para> To create or update a mute rule, you must have the <c>cloudwatch:PutAlarmMuteRule</c>
    /// permission on two types of resources: the alarm mute rule resource itself, and each
    /// alarm that the rule targets. </para> <para> For example, If you want to allow a user
    /// to create mute rules that target only specific alarms named "WebServerCPUAlarm" and
    /// "DatabaseConnectionAlarm", you would create an IAM policy with one statement granting
    /// <c>cloudwatch:PutAlarmMuteRule</c> on the alarm mute rule resource (<c>arn:aws:cloudwatch:[REGION]:123456789012:alarm-mute-rule:*</c>),
    /// and another statement granting <c>cloudwatch:PutAlarmMuteRule</c> on the targeted
    /// alarm resources (<c>arn:aws:cloudwatch:[REGION]:123456789012:alarm:WebServerCPUAlarm</c>
    /// and <c>arn:aws:cloudwatch:[REGION]:123456789012:alarm:DatabaseConnectionAlarm</c>).
    /// </para> <para> You can also use IAM policy conditions to allow targeting alarms based
    /// on resource tags. For example, you can restrict users to create/update mute rules
    /// to only target alarms that have a specific tag key-value pair, such as <c>Team=TeamA</c>.
    /// </para>
    /// </summary>
    public partial class PutAlarmMuteRuleRequest : AmazonCloudWatchRequest
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the alarm mute rule that helps you identify its purpose.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property ExpireDate. 
        /// <para>
        /// The date and time when the mute rule expires and is no longer evaluated, specified
        /// as a timestamp in ISO 8601 format (for example, <c>2026-12-31T23:59:59Z</c>). After
        /// this time, the rule status becomes EXPIRED and will no longer mute the targeted alarms.
        /// </para>
        /// </summary>
        public DateTime? ExpireDate { get; set; }

        /// <summary>
        /// Checks to see if the ExpireDate property is set.
        /// </summary>
        internal bool IsSetExpireDate() => this.ExpireDate.HasValue;

        /// <summary>
        /// Gets and sets the property MuteTargets. 
        /// <para>
        /// Specifies which alarms this rule applies to.
        /// </para>
        /// </summary>
        public MuteTargets MuteTargets { get; set; }

        /// <summary>
        /// Checks to see if the MuteTargets property is set.
        /// </summary>
        internal bool IsSetMuteTargets() => this.MuteTargets != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the alarm mute rule. This name must be unique within your Amazon Web Services
        /// account and region.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The configuration that defines when and how long alarms should be muted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Rule Rule { get; set; }

        /// <summary>
        /// Checks to see if the Rule property is set.
        /// </summary>
        internal bool IsSetRule() => this.Rule != null;

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time after which the mute rule takes effect, specified as a timestamp
        /// in ISO 8601 format (for example, <c>2026-04-15T08:00:00Z</c>). If not specified, the
        /// mute rule takes effect immediately upon creation and the mutes are applied as per
        /// the schedule expression.
        /// </para>
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Checks to see if the StartDate property is set.
        /// </summary>
        internal bool IsSetStartDate() => this.StartDate.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the alarm mute rule. You can use tags
        /// to categorize and manage your mute rules.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
