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
    /// Container for the parameters to the PutCompositeAlarm operation.
    /// Creates or updates a <i>composite alarm</i>. When you create a composite alarm, you
    /// specify a rule expression for the alarm that takes into account the alarm states of
    /// other alarms that you have created. The composite alarm goes into ALARM state only
    /// if all conditions of the rule are met.
    /// 
    ///  
    /// <para>
    /// The alarms specified in a composite alarm's rule expression can include metric alarms
    /// and other composite alarms. The rule expression of a composite alarm can include as
    /// many as 100 underlying alarms. Any single alarm can be included in the rule expressions
    /// of as many as 150 composite alarms.
    /// </para>
    ///  
    /// <para>
    /// Using composite alarms can reduce alarm noise. You can create multiple metric alarms,
    /// and also create a composite alarm and set up alerts only for the composite alarm.
    /// For example, you could create a composite alarm that goes into ALARM state only when
    /// more than one of the underlying metric alarms are in ALARM state.
    /// </para>
    ///  
    /// <para>
    /// Composite alarms can take the following actions:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Notify Amazon SNS topics.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Invoke Lambda functions.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create OpsItems in Systems Manager Ops Center.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Create incidents in Systems Manager Incident Manager.
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// It is possible to create a loop or cycle of composite alarms, where composite alarm
    /// A depends on composite alarm B, and composite alarm B also depends on composite alarm
    /// A. In this scenario, you can't delete any composite alarm that is part of the cycle
    /// because there is always still a composite alarm that depends on that alarm that you
    /// want to delete.
    /// </para>
    ///  
    /// <para>
    /// To get out of such a situation, you must break the cycle by changing the rule of one
    /// of the composite alarms in the cycle to remove a dependency that creates the cycle.
    /// The simplest change to make to break a cycle is to change the <c>AlarmRule</c> of
    /// one of the alarms to <c>false</c>. 
    /// </para>
    ///  
    /// <para>
    /// Additionally, the evaluation of composite alarms stops if CloudWatch detects a cycle
    /// in the evaluation path. 
    /// </para>
    ///  </note> 
    /// <para>
    /// When this operation creates an alarm, the alarm state is immediately set to <c>INSUFFICIENT_DATA</c>.
    /// The alarm is then evaluated and its state is set appropriately. Any actions associated
    /// with the new state are then executed. For a composite alarm, this initial time after
    /// creation is the only time that the alarm can be in <c>INSUFFICIENT_DATA</c> state.
    /// </para>
    ///  
    /// <para>
    /// When you update an existing alarm, its state is left unchanged, but the update completely
    /// overwrites the previous configuration of the alarm.
    /// </para>
    ///  
    /// <para>
    /// To use this operation, you must be signed on with the <c>cloudwatch:PutCompositeAlarm</c>
    /// permission that is scoped to <c>*</c>. You can't create a composite alarms if your
    /// <c>cloudwatch:PutCompositeAlarm</c> permission has a narrower scope.
    /// </para>
    ///  
    /// <para>
    /// If you are an IAM user, you must have <c>iam:CreateServiceLinkedRole</c> to create
    /// a composite alarm that has Systems Manager OpsItem actions.
    /// </para>
    /// </summary>
    public partial class PutCompositeAlarmRequest : AmazonCloudWatchRequest
    {
        private bool? _actionsEnabled;
        private string _actionsSuppressor;
        private int? _actionsSuppressorExtensionPeriod;
        private int? _actionsSuppressorWaitPeriod;
        private List<string> _alarmActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _alarmDescription;
        private string _alarmName;
        private string _alarmRule;
        private List<string> _insufficientDataActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _okActions = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property ActionsEnabled. 
        /// <para>
        /// Indicates whether actions should be executed during any changes to the alarm state
        /// of the composite alarm. The default is <c>TRUE</c>.
        /// </para>
        /// </summary>
        public bool? ActionsEnabled
        {
            get { return this._actionsEnabled; }
            set { this._actionsEnabled = value; }
        }

        // Check to see if ActionsEnabled property is set
        internal bool IsSetActionsEnabled()
        {
            return this._actionsEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActionsSuppressor. 
        /// <para>
        ///  Actions will be suppressed if the suppressor alarm is in the <c>ALARM</c> state.
        /// <c>ActionsSuppressor</c> can be an AlarmName or an Amazon Resource Name (ARN) from
        /// an existing alarm. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ActionsSuppressor
        {
            get { return this._actionsSuppressor; }
            set { this._actionsSuppressor = value; }
        }

        // Check to see if ActionsSuppressor property is set
        internal bool IsSetActionsSuppressor()
        {
            return this._actionsSuppressor != null;
        }

        /// <summary>
        /// Gets and sets the property ActionsSuppressorExtensionPeriod. 
        /// <para>
        ///  The maximum time in seconds that the composite alarm waits after suppressor alarm
        /// goes out of the <c>ALARM</c> state. After this time, the composite alarm performs
        /// its actions. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>ExtensionPeriod</c> is required only when <c>ActionsSuppressor</c> is specified.
        /// 
        /// </para>
        ///  </important>
        /// </summary>
        public int? ActionsSuppressorExtensionPeriod
        {
            get { return this._actionsSuppressorExtensionPeriod; }
            set { this._actionsSuppressorExtensionPeriod = value; }
        }

        // Check to see if ActionsSuppressorExtensionPeriod property is set
        internal bool IsSetActionsSuppressorExtensionPeriod()
        {
            return this._actionsSuppressorExtensionPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActionsSuppressorWaitPeriod. 
        /// <para>
        ///  The maximum time in seconds that the composite alarm waits for the suppressor alarm
        /// to go into the <c>ALARM</c> state. After this time, the composite alarm performs its
        /// actions. 
        /// </para>
        ///  <important> 
        /// <para>
        ///  <c>WaitPeriod</c> is required only when <c>ActionsSuppressor</c> is specified. 
        /// </para>
        ///  </important>
        /// </summary>
        public int? ActionsSuppressorWaitPeriod
        {
            get { return this._actionsSuppressorWaitPeriod; }
            set { this._actionsSuppressorWaitPeriod = value; }
        }

        // Check to see if ActionsSuppressorWaitPeriod property is set
        internal bool IsSetActionsSuppressorWaitPeriod()
        {
            return this._actionsSuppressorWaitPeriod.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AlarmActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the <c>ALARM</c> state from
        /// any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// Valid Values: ]
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon SNS actions:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i> </c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Lambda actions:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Invoke the latest version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a specific version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>version-number</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a function by using an alias Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>alias-name</i>
        /// </c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Systems Manager actions:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:ssm:<i>region</i>:<i>account-id</i>:opsitem:<i>severity</i> </c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Start a Amazon Q Developer operational investigation</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:aiops:<i>region</i>:<i>account-id</i>:investigation-group:<i>investigation-group-id</i>
        /// </c> 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> AlarmActions
        {
            get { return this._alarmActions; }
            set { this._alarmActions = value; }
        }

        // Check to see if AlarmActions property is set
        internal bool IsSetAlarmActions()
        {
            return this._alarmActions != null && (this._alarmActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AlarmDescription. 
        /// <para>
        /// The description for the composite alarm.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string AlarmDescription
        {
            get { return this._alarmDescription; }
            set { this._alarmDescription = value; }
        }

        // Check to see if AlarmDescription property is set
        internal bool IsSetAlarmDescription()
        {
            return this._alarmDescription != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmName. 
        /// <para>
        /// The name for the composite alarm. This name must be unique within the Region.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AlarmName
        {
            get { return this._alarmName; }
            set { this._alarmName = value; }
        }

        // Check to see if AlarmName property is set
        internal bool IsSetAlarmName()
        {
            return this._alarmName != null;
        }

        /// <summary>
        /// Gets and sets the property AlarmRule. 
        /// <para>
        /// An expression that specifies which other alarms are to be evaluated to determine this
        /// composite alarm's state. For each alarm that you reference, you designate a function
        /// that specifies whether that alarm needs to be in ALARM state, OK state, or INSUFFICIENT_DATA
        /// state. You can use operators (AND, OR and NOT) to combine multiple functions in a
        /// single expression. You can use parenthesis to logically group the functions in your
        /// expression.
        /// </para>
        ///  
        /// <para>
        /// You can use either alarm names or ARNs to reference the other alarms that are to be
        /// evaluated.
        /// </para>
        ///  
        /// <para>
        /// Functions can include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALARM("<i>alarm-name</i> or <i>alarm-ARN</i>")</c> is TRUE if the named alarm
        /// is in ALARM state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OK("<i>alarm-name</i> or <i>alarm-ARN</i>")</c> is TRUE if the named alarm is
        /// in OK state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>INSUFFICIENT_DATA("<i>alarm-name</i> or <i>alarm-ARN</i>")</c> is TRUE if the
        /// named alarm is in INSUFFICIENT_DATA state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRUE</c> always evaluates to TRUE.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FALSE</c> always evaluates to FALSE.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// TRUE and FALSE are useful for testing a complex <c>AlarmRule</c> structure, and for
        /// testing your alarm actions.
        /// </para>
        ///  
        /// <para>
        /// Alarm names specified in <c>AlarmRule</c> can be surrounded with double-quotes ("),
        /// but do not have to be.
        /// </para>
        ///  
        /// <para>
        /// The following are some examples of <c>AlarmRule</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALARM(CPUUtilizationTooHigh) AND ALARM(DiskReadOpsTooHigh)</c> specifies that
        /// the composite alarm goes into ALARM state only if both CPUUtilizationTooHigh and DiskReadOpsTooHigh
        /// alarms are in ALARM state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ALARM(CPUUtilizationTooHigh) AND NOT ALARM(DeploymentInProgress)</c> specifies
        /// that the alarm goes to ALARM state if CPUUtilizationTooHigh is in ALARM state and
        /// DeploymentInProgress is not in ALARM state. This example reduces alarm noise during
        /// a known deployment window.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>(ALARM(CPUUtilizationTooHigh) OR ALARM(DiskReadOpsTooHigh)) AND OK(NetworkOutTooHigh)</c>
        /// goes into ALARM state if CPUUtilizationTooHigh OR DiskReadOpsTooHigh is in ALARM state,
        /// and if NetworkOutTooHigh is in OK state. This provides another example of using a
        /// composite alarm to prevent noise. This rule ensures that you are not notified with
        /// an alarm action on high CPU or disk usage if a known network problem is also occurring.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The <c>AlarmRule</c> can specify as many as 100 "children" alarms. The <c>AlarmRule</c>
        /// expression can have as many as 500 elements. Elements are child alarms, TRUE or FALSE
        /// statements, and parentheses.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10240)]
        public string AlarmRule
        {
            get { return this._alarmRule; }
            set { this._alarmRule = value; }
        }

        // Check to see if AlarmRule property is set
        internal bool IsSetAlarmRule()
        {
            return this._alarmRule != null;
        }

        /// <summary>
        /// Gets and sets the property InsufficientDataActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to the <c>INSUFFICIENT_DATA</c>
        /// state from any other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// Valid Values: ]
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon SNS actions:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i> </c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Lambda actions:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Invoke the latest version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a specific version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>version-number</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a function by using an alias Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>alias-name</i>
        /// </c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> InsufficientDataActions
        {
            get { return this._insufficientDataActions; }
            set { this._insufficientDataActions = value; }
        }

        // Check to see if InsufficientDataActions property is set
        internal bool IsSetInsufficientDataActions()
        {
            return this._insufficientDataActions != null && (this._insufficientDataActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OKActions. 
        /// <para>
        /// The actions to execute when this alarm transitions to an <c>OK</c> state from any
        /// other state. Each action is specified as an Amazon Resource Name (ARN).
        /// </para>
        ///  
        /// <para>
        /// Valid Values: ]
        /// </para>
        ///  
        /// <para>
        ///  <b>Amazon SNS actions:</b> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sns:<i>region</i>:<i>account-id</i>:<i>sns-topic-name</i> </c> 
        /// </para>
        ///  
        /// <para>
        ///  <b>Lambda actions:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Invoke the latest version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a specific version of a Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>version-number</i>
        /// </c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Invoke a function by using an alias Lambda function: <c>arn:aws:lambda:<i>region</i>:<i>account-id</i>:function:<i>function-name</i>:<i>alias-name</i>
        /// </c> 
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> OKActions
        {
            get { return this._okActions; }
            set { this._okActions = value; }
        }

        // Check to see if OKActions property is set
        internal bool IsSetOKActions()
        {
            return this._okActions != null && (this._okActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the alarm. You can associate as many as
        /// 50 tags with an alarm. To be able to associate tags with the alarm when you create
        /// the alarm, you must have the <c>cloudwatch:TagResource</c> permission.
        /// </para>
        ///  
        /// <para>
        /// Tags can help you organize and categorize your resources. You can also use them to
        /// scope user permissions by granting a user permission to access or change only resources
        /// with certain tag values.
        /// </para>
        ///  
        /// <para>
        /// If you are using this operation to update an existing alarm, any tags you specify
        /// in this parameter are ignored. To change the tags of an existing alarm, use <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_TagResource.html">TagResource</a>
        /// or <a href="https://docs.aws.amazon.com/AmazonCloudWatch/latest/APIReference/API_UntagResource.html">UntagResource</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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