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
 * Do not modify this file. This file is generated from the ssm-2014-11-06.normal.json service model.
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
namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateMaintenanceWindowTask operation.
    /// Modifies a task assigned to a maintenance window. You can't change the task type,
    /// but you can change the following values:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>TaskARN</c>. For example, you can change a <c>RUN_COMMAND</c> task from <c>AWS-RunPowerShellScript</c>
    /// to <c>AWS-RunShellScript</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ServiceRoleArn</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>TaskInvocationParameters</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>Priority</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MaxConcurrency</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>MaxErrors</c> 
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// One or more targets must be specified for maintenance window Run Command-type tasks.
    /// Depending on the task, targets are optional for other maintenance window task types
    /// (Automation, Lambda, and Step Functions). For more information about running tasks
    /// that don't specify targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/maintenance-windows-targetless-tasks.html">Registering
    /// maintenance window tasks without targets</a> in the <i>Amazon Web Services Systems
    /// Manager User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// If the value for a parameter in <c>UpdateMaintenanceWindowTask</c> is null, then the
    /// corresponding field isn't modified. If you set <c>Replace</c> to true, then all fields
    /// required by the <a>RegisterTaskWithMaintenanceWindow</a> operation are required for
    /// this request. Optional fields that aren't specified are set to null.
    /// </para>
    ///  <important> 
    /// <para>
    /// When you update a maintenance window task that has options specified in <c>TaskInvocationParameters</c>,
    /// you must provide again all the <c>TaskInvocationParameters</c> values that you want
    /// to retain. The values you don't specify again are removed. For example, suppose that
    /// when you registered a Run Command task, you specified <c>TaskInvocationParameters</c>
    /// values for <c>Comment</c>, <c>NotificationConfig</c>, and <c>OutputS3BucketName</c>.
    /// If you update the maintenance window task and specify only a different <c>OutputS3BucketName</c>
    /// value, the values for <c>Comment</c> and <c>NotificationConfig</c> are removed.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class UpdateMaintenanceWindowTaskRequest : AmazonSimpleSystemsManagementRequest
    {
        private AlarmConfiguration _alarmConfiguration;
        private MaintenanceWindowTaskCutoffBehavior _cutoffBehavior;
        private string _description;
        private LoggingInfo _loggingInfo;
        private string _maxConcurrency;
        private string _maxErrors;
        private string _name;
        private int? _priority;
        private bool? _replace;
        private string _serviceRoleArn;
        private List<Target> _targets = AWSConfigs.InitializeCollections ? new List<Target>() : null;
        private string _taskArn;
        private MaintenanceWindowTaskInvocationParameters _taskInvocationParameters;
        private Dictionary<string, MaintenanceWindowTaskParameterValueExpression> _taskParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, MaintenanceWindowTaskParameterValueExpression>() : null;
        private string _windowId;
        private string _windowTaskId;

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The CloudWatch alarm you want to apply to your maintenance window task.
        /// </para>
        /// </summary>
        public AlarmConfiguration AlarmConfiguration
        {
            get { return this._alarmConfiguration; }
            set { this._alarmConfiguration = value; }
        }

        // Check to see if AlarmConfiguration property is set
        internal bool IsSetAlarmConfiguration()
        {
            return this._alarmConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CutoffBehavior. 
        /// <para>
        /// Indicates whether tasks should continue to run after the cutoff time specified in
        /// the maintenance windows is reached. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CONTINUE_TASK</c>: When the cutoff time is reached, any tasks that are running
        /// continue. The default value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CANCEL_TASK</c>:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For Automation, Lambda, Step Functions tasks: When the cutoff time is reached, any
        /// task invocations that are already running continue, but no new task invocations are
        /// started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For Run Command tasks: When the cutoff time is reached, the system sends a <a>CancelCommand</a>
        /// operation that attempts to cancel the command associated with the task. However, there
        /// is no guarantee that the command will be terminated and the underlying process stopped.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The status for tasks that are not completed is <c>TIMED_OUT</c>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public MaintenanceWindowTaskCutoffBehavior CutoffBehavior
        {
            get { return this._cutoffBehavior; }
            set { this._cutoffBehavior = value; }
        }

        // Check to see if CutoffBehavior property is set
        internal bool IsSetCutoffBehavior()
        {
            return this._cutoffBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The new task description to specify.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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
        /// Gets and sets the property LoggingInfo. 
        /// <para>
        /// The new logging location in Amazon S3 to specify.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>LoggingInfo</c> has been deprecated. To specify an Amazon Simple Storage Service
        /// (Amazon S3) bucket to contain logs, instead use the <c>OutputS3BucketName</c> and
        /// <c>OutputS3KeyPrefix</c> options in the <c>TaskInvocationParameters</c> structure.
        /// For information about how Amazon Web Services Systems Manager handles these options
        /// for the supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public LoggingInfo LoggingInfo
        {
            get { return this._loggingInfo; }
            set { this._loggingInfo = value; }
        }

        // Check to see if LoggingInfo property is set
        internal bool IsSetLoggingInfo()
        {
            return this._loggingInfo != null;
        }

        /// <summary>
        /// Gets and sets the property MaxConcurrency. 
        /// <para>
        /// The new <c>MaxConcurrency</c> value you want to specify. <c>MaxConcurrency</c> is
        /// the number of targets that are allowed to run this task, in parallel.
        /// </para>
        ///  <note> 
        /// <para>
        /// Although this element is listed as "Required: No", a value can be omitted only when
        /// you are registering or updating a <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/maintenance-windows-targetless-tasks.html">targetless
        /// task</a> You must provide a value in all other cases.
        /// </para>
        ///  
        /// <para>
        /// For maintenance window tasks without a target specified, you can't supply a value
        /// for this option. Instead, the system inserts a placeholder value of <c>1</c>. This
        /// value doesn't affect the running of your task.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string MaxConcurrency
        {
            get { return this._maxConcurrency; }
            set { this._maxConcurrency = value; }
        }

        // Check to see if MaxConcurrency property is set
        internal bool IsSetMaxConcurrency()
        {
            return this._maxConcurrency != null;
        }

        /// <summary>
        /// Gets and sets the property MaxErrors. 
        /// <para>
        /// The new <c>MaxErrors</c> value to specify. <c>MaxErrors</c> is the maximum number
        /// of errors that are allowed before the task stops being scheduled.
        /// </para>
        ///  <note> 
        /// <para>
        /// Although this element is listed as "Required: No", a value can be omitted only when
        /// you are registering or updating a <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/maintenance-windows-targetless-tasks.html">targetless
        /// task</a> You must provide a value in all other cases.
        /// </para>
        ///  
        /// <para>
        /// For maintenance window tasks without a target specified, you can't supply a value
        /// for this option. Instead, the system inserts a placeholder value of <c>1</c>. This
        /// value doesn't affect the running of your task.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=7)]
        public string MaxErrors
        {
            get { return this._maxErrors; }
            set { this._maxErrors = value; }
        }

        // Check to see if MaxErrors property is set
        internal bool IsSetMaxErrors()
        {
            return this._maxErrors != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The new task name to specify.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=128)]
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
        /// Gets and sets the property Priority. 
        /// <para>
        /// The new task priority to specify. The lower the number, the higher the priority. Tasks
        /// that have the same priority are scheduled in parallel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Replace. 
        /// <para>
        /// If True, then all fields that are required by the <a>RegisterTaskWithMaintenanceWindow</a>
        /// operation are also required for this API request. Optional fields that aren't specified
        /// are set to null.
        /// </para>
        /// </summary>
        public bool? Replace
        {
            get { return this._replace; }
            set { this._replace = value; }
        }

        // Check to see if Replace property is set
        internal bool IsSetReplace()
        {
            return this._replace.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM service role for Amazon Web Services Systems
        /// Manager to assume when running a maintenance window task. If you do not specify a
        /// service role ARN, Systems Manager uses a service-linked role in your account. If no
        /// appropriate service-linked role for Systems Manager exists in your account, it is
        /// created when you run <c>RegisterTaskWithMaintenanceWindow</c>.
        /// </para>
        ///  
        /// <para>
        /// However, for an improved security posture, we strongly recommend creating a custom
        /// policy and custom service role for running your maintenance window tasks. The policy
        /// can be crafted to provide only the permissions needed for your particular maintenance
        /// window tasks. For more information, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/sysman-maintenance-permissions.html">Setting
        /// up Maintenance Windows</a> in the in the <i>Amazon Web Services Systems Manager User
        /// Guide</i>.
        /// </para>
        /// </summary>
        public string ServiceRoleArn
        {
            get { return this._serviceRoleArn; }
            set { this._serviceRoleArn = value; }
        }

        // Check to see if ServiceRoleArn property is set
        internal bool IsSetServiceRoleArn()
        {
            return this._serviceRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Targets. 
        /// <para>
        /// The targets (either managed nodes or tags) to modify. Managed nodes are specified
        /// using the format <c>Key=instanceids,Values=instanceID_1,instanceID_2</c>. Tags are
        /// specified using the format <c> Key=tag_name,Values=tag_value</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// One or more targets must be specified for maintenance window Run Command-type tasks.
        /// Depending on the task, targets are optional for other maintenance window task types
        /// (Automation, Lambda, and Step Functions). For more information about running tasks
        /// that don't specify targets, see <a href="https://docs.aws.amazon.com/systems-manager/latest/userguide/maintenance-windows-targetless-tasks.html">Registering
        /// maintenance window tasks without targets</a> in the <i>Amazon Web Services Systems
        /// Manager User Guide</i>.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=5)]
        public List<Target> Targets
        {
            get { return this._targets; }
            set { this._targets = value; }
        }

        // Check to see if Targets property is set
        internal bool IsSetTargets()
        {
            return this._targets != null && (this._targets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The task ARN to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string TaskArn
        {
            get { return this._taskArn; }
            set { this._taskArn = value; }
        }

        // Check to see if TaskArn property is set
        internal bool IsSetTaskArn()
        {
            return this._taskArn != null;
        }

        /// <summary>
        /// Gets and sets the property TaskInvocationParameters. 
        /// <para>
        /// The parameters that the task should use during execution. Populate only the fields
        /// that match the task type. All other fields should be empty.
        /// </para>
        ///  <important> 
        /// <para>
        /// When you update a maintenance window task that has options specified in <c>TaskInvocationParameters</c>,
        /// you must provide again all the <c>TaskInvocationParameters</c> values that you want
        /// to retain. The values you don't specify again are removed. For example, suppose that
        /// when you registered a Run Command task, you specified <c>TaskInvocationParameters</c>
        /// values for <c>Comment</c>, <c>NotificationConfig</c>, and <c>OutputS3BucketName</c>.
        /// If you update the maintenance window task and specify only a different <c>OutputS3BucketName</c>
        /// value, the values for <c>Comment</c> and <c>NotificationConfig</c> are removed.
        /// </para>
        ///  </important>
        /// </summary>
        public MaintenanceWindowTaskInvocationParameters TaskInvocationParameters
        {
            get { return this._taskInvocationParameters; }
            set { this._taskInvocationParameters = value; }
        }

        // Check to see if TaskInvocationParameters property is set
        internal bool IsSetTaskInvocationParameters()
        {
            return this._taskInvocationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property TaskParameters. 
        /// <para>
        /// The parameters to modify.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>TaskParameters</c> has been deprecated. To specify parameters to pass to a task
        /// when it runs, instead use the <c>Parameters</c> option in the <c>TaskInvocationParameters</c>
        /// structure. For information about how Systems Manager handles these options for the
        /// supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The map has the following format:
        /// </para>
        ///  
        /// <para>
        /// Key: string, between 1 and 255 characters
        /// </para>
        ///  
        /// <para>
        /// Value: an array of strings, each string is between 1 and 255 characters
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public Dictionary<string, MaintenanceWindowTaskParameterValueExpression> TaskParameters
        {
            get { return this._taskParameters; }
            set { this._taskParameters = value; }
        }

        // Check to see if TaskParameters property is set
        internal bool IsSetTaskParameters()
        {
            return this._taskParameters != null && (this._taskParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The maintenance window ID that contains the task to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=20)]
        public string WindowId
        {
            get { return this._windowId; }
            set { this._windowId = value; }
        }

        // Check to see if WindowId property is set
        internal bool IsSetWindowId()
        {
            return this._windowId != null;
        }

        /// <summary>
        /// Gets and sets the property WindowTaskId. 
        /// <para>
        /// The task ID to modify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string WindowTaskId
        {
            get { return this._windowTaskId; }
            set { this._windowTaskId = value; }
        }

        // Check to see if WindowTaskId property is set
        internal bool IsSetWindowTaskId()
        {
            return this._windowTaskId != null;
        }

    }
}