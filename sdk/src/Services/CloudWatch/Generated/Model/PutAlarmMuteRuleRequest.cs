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
 * Do not modify this file. This file is generated from the monitoring-2010-08-01.normal.json service model.
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
    /// Container for the parameters to the PutAlarmMuteRule operation.
    /// Creates or updates an alarm mute rule.
    /// 
    ///  
    /// <para>
    /// Alarm mute rules automatically mute alarm actions during predefined time windows.
    /// When a mute rule is active, targeted alarms continue to evaluate metrics and transition
    /// between states, but their configured actions (such as Amazon SNS notifications or
    /// Auto Scaling actions) are muted.
    /// </para>
    ///  
    /// <para>
    /// You can create mute rules with recurring schedules using <c>cron</c> expressions or
    /// one-time mute windows using <c>at</c> expressions. Each mute rule can target up to
    /// 100 specific alarms by name.
    /// </para>
    ///  
    /// <para>
    /// If you specify a rule name that already exists, this operation updates the existing
    /// rule with the new configuration.
    /// </para>
    ///  
    /// <para>
    ///  <b>Permissions</b> 
    /// </para>
    ///  
    /// <para>
    /// To create or update a mute rule, you must have the <c>cloudwatch:PutAlarmMuteRule</c>
    /// permission on two types of resources: the alarm mute rule resource itself, and each
    /// alarm that the rule targets.
    /// </para>
    ///  
    /// <para>
    /// For example, If you want to allow a user to create mute rules that target only specific
    /// alarms named "WebServerCPUAlarm" and "DatabaseConnectionAlarm", you would create an
    /// IAM policy with one statement granting <c>cloudwatch:PutAlarmMuteRule</c> on the alarm
    /// mute rule resource (<c>arn:aws:cloudwatch:[REGION]:123456789012:alarm-mute:*</c>),
    /// and another statement granting <c>cloudwatch:PutAlarmMuteRule</c> on the targeted
    /// alarm resources (<c>arn:aws:cloudwatch:[REGION]:123456789012:alarm:WebServerCPUAlarm</c>
    /// and <c>arn:aws:cloudwatch:[REGION]:123456789012:alarm:DatabaseConnectionAlarm</c>).
    /// </para>
    ///  
    /// <para>
    /// You can also use IAM policy conditions to allow targeting alarms based on resource
    /// tags. For example, you can restrict users to create/update mute rules to only target
    /// alarms that have a specific tag key-value pair, such as <c>Team=TeamA</c>.
    /// </para>
    /// </summary>
    public partial class PutAlarmMuteRuleRequest : AmazonCloudWatchRequest
    {
        private string _description;
        private DateTime? _expireDate;
        private MuteTargets _muteTargets;
        private string _name;
        private Rule _rule;
        private DateTime? _startDate;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the alarm mute rule that helps you identify its purpose.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property ExpireDate. 
        /// <para>
        /// The date and time when the mute rule expires and is no longer evaluated. After this
        /// time, the rule status becomes EXPIRED and will no longer mute the targeted alarms.
        /// This date and time is interpreted according to the schedule timezone, or UTC if no
        /// timezone is specified.
        /// </para>
        /// </summary>
        public DateTime ExpireDate
        {
            get { return this._expireDate.GetValueOrDefault(); }
            set { this._expireDate = value; }
        }

        // Check to see if ExpireDate property is set
        internal bool IsSetExpireDate()
        {
            return this._expireDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MuteTargets. 
        /// <para>
        /// Specifies which alarms this rule applies to.
        /// </para>
        /// </summary>
        public MuteTargets MuteTargets
        {
            get { return this._muteTargets; }
            set { this._muteTargets = value; }
        }

        // Check to see if MuteTargets property is set
        internal bool IsSetMuteTargets()
        {
            return this._muteTargets != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the alarm mute rule. This name must be unique within your Amazon Web Services
        /// account and region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        /// The configuration that defines when and how long alarms should be muted.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Rule Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property StartDate. 
        /// <para>
        /// The date and time after which the mute rule takes effect. If not specified, the mute
        /// rule takes effect immediately upon creation and the mutes are applied as per the schedule
        /// expression. This date and time is interpreted according to the schedule timezone,
        /// or UTC if no timezone is specified.
        /// </para>
        /// </summary>
        public DateTime StartDate
        {
            get { return this._startDate.GetValueOrDefault(); }
            set { this._startDate = value; }
        }

        // Check to see if StartDate property is set
        internal bool IsSetStartDate()
        {
            return this._startDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the alarm mute rule. You can use tags
        /// to categorize and manage your mute rules.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}