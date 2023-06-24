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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Information about a task defined for a maintenance window.
    /// </summary>
    public partial class MaintenanceWindowTask
    {
        private AlarmConfiguration _alarmConfiguration;
        private MaintenanceWindowTaskCutoffBehavior _cutoffBehavior;
        private string _description;
        private LoggingInfo _loggingInfo;
        private string _maxConcurrency;
        private string _maxErrors;
        private string _name;
        private int? _priority;
        private string _serviceRoleArn;
        private List<Target> _targets = new List<Target>();
        private string _taskArn;
        private Dictionary<string, MaintenanceWindowTaskParameterValueExpression> _taskParameters = new Dictionary<string, MaintenanceWindowTaskParameterValueExpression>();
        private MaintenanceWindowTaskType _type;
        private string _windowId;
        private string _windowTaskId;

        /// <summary>
        /// Gets and sets the property AlarmConfiguration. 
        /// <para>
        /// The details for the CloudWatch alarm applied to your maintenance window task.
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
        /// The specification for whether tasks should continue to run after the cutoff time specified
        /// in the maintenance windows is reached. 
        /// </para>
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
        /// A description of the task.
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
        /// Information about an S3 bucket to write task-level logs to.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>LoggingInfo</code> has been deprecated. To specify an Amazon Simple Storage
        /// Service (Amazon S3) bucket to contain logs, instead use the <code>OutputS3BucketName</code>
        /// and <code>OutputS3KeyPrefix</code> options in the <code>TaskInvocationParameters</code>
        /// structure. For information about how Amazon Web Services Systems Manager handles these
        /// options for the supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
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
        /// The maximum number of targets this task can be run for, in parallel.
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
        /// for this option. Instead, the system inserts a placeholder value of <code>1</code>.
        /// This value doesn't affect the running of your task.
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
        /// The maximum number of errors allowed before this task stops being scheduled.
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
        /// for this option. Instead, the system inserts a placeholder value of <code>1</code>.
        /// This value doesn't affect the running of your task.
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
        /// The task name.
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
        /// The priority of the task in the maintenance window. The lower the number, the higher
        /// the priority. Tasks that have the same priority are scheduled in parallel.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServiceRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) service
        /// role to use to publish Amazon Simple Notification Service (Amazon SNS) notifications
        /// for maintenance window Run Command tasks.
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
        /// The targets (either managed nodes or tags). Managed nodes are specified using <code>Key=instanceids,Values=&lt;instanceid1&gt;,&lt;instanceid2&gt;</code>.
        /// Tags are specified using <code>Key=&lt;tag name&gt;,Values=&lt;tag value&gt;</code>.
        /// </para>
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
            return this._targets != null && this._targets.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TaskArn. 
        /// <para>
        /// The resource that the task uses during execution. For <code>RUN_COMMAND</code> and
        /// <code>AUTOMATION</code> task types, <code>TaskArn</code> is the Amazon Web Services
        /// Systems Manager (SSM document) name or ARN. For <code>LAMBDA</code> tasks, it's the
        /// function name or ARN. For <code>STEP_FUNCTIONS</code> tasks, it's the state machine
        /// ARN.
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
        /// Gets and sets the property TaskParameters. 
        /// <para>
        /// The parameters that should be passed to the task when it is run.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>TaskParameters</code> has been deprecated. To specify parameters to pass to
        /// a task when it runs, instead use the <code>Parameters</code> option in the <code>TaskInvocationParameters</code>
        /// structure. For information about how Systems Manager handles these options for the
        /// supported maintenance window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
        /// </para>
        ///  </note>
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
            return this._taskParameters != null && this._taskParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of task.
        /// </para>
        /// </summary>
        public MaintenanceWindowTaskType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the maintenance window where the task is registered.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=20)]
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
        /// The task ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=36, Max=36)]
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