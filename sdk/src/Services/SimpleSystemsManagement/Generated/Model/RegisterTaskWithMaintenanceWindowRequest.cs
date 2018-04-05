/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// Container for the parameters to the RegisterTaskWithMaintenanceWindow operation.
    /// Adds a new task to a Maintenance Window.
    /// </summary>
    public partial class RegisterTaskWithMaintenanceWindowRequest : AmazonSimpleSystemsManagementRequest
    {
        private string _clientToken;
        private string _description;
        private LoggingInfo _loggingInfo;
        private string _maxConcurrency;
        private string _maxErrors;
        private string _name;
        private int? _priority;
        private string _serviceRoleArn;
        private List<Target> _targets = new List<Target>();
        private string _taskArn;
        private MaintenanceWindowTaskInvocationParameters _taskInvocationParameters;
        private Dictionary<string, MaintenanceWindowTaskParameterValueExpression> _taskParameters = new Dictionary<string, MaintenanceWindowTaskParameterValueExpression>();
        private MaintenanceWindowTaskType _taskType;
        private string _windowId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// User-provided idempotency token.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// An optional description for the task.
        /// </para>
        /// </summary>
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
        /// A structure containing information about an Amazon S3 bucket to write instance-level
        /// logs to. 
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>LoggingInfo</code> has been deprecated. To specify an S3 bucket to contain
        /// logs, instead use the <code>OutputS3BucketName</code> and <code>OutputS3KeyPrefix</code>
        /// options in the <code>TaskInvocationParameters</code> structure. For information about
        /// how Systems Manager handles these options for the supported Maintenance Window task
        /// types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
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
        /// The maximum number of targets this task can be run for in parallel.
        /// </para>
        /// </summary>
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
        /// </summary>
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
        /// An optional name for the task.
        /// </para>
        /// </summary>
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
        /// The priority of the task in the Maintenance Window, the lower the number the higher
        /// the priority. Tasks in a Maintenance Window are scheduled in priority order with tasks
        /// that have the same priority scheduled in parallel.
        /// </para>
        /// </summary>
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
        /// The role that should be assumed when executing the task.
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
        /// The targets (either instances or Maintenance Window targets).
        /// </para>
        ///  
        /// <para>
        /// Specify instances using the following format: 
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=InstanceIds,Values=&lt;instance-id-1&gt;,&lt;instance-id-2&gt;</code> 
        /// </para>
        ///  
        /// <para>
        /// Specify Maintenance Window targets using the following format:
        /// </para>
        ///  
        /// <para>
        ///  <code>Key=&lt;WindowTargetIds&gt;,Values=&lt;window-target-id-1&gt;,&lt;window-target-id-2&gt;</code>
        /// 
        /// </para>
        /// </summary>
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
        /// The ARN of the task to execute 
        /// </para>
        /// </summary>
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
        /// The parameters that should be passed to the task when it is executed.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>TaskParameters</code> has been deprecated. To specify parameters to pass to
        /// a task when it runs, instead use the <code>Parameters</code> option in the <code>TaskInvocationParameters</code>
        /// structure. For information about how Systems Manager handles these options for the
        /// supported Maintenance Window task types, see <a>MaintenanceWindowTaskInvocationParameters</a>.
        /// </para>
        ///  </note>
        /// </summary>
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
        /// Gets and sets the property TaskType. 
        /// <para>
        /// The type of task being registered.
        /// </para>
        /// </summary>
        public MaintenanceWindowTaskType TaskType
        {
            get { return this._taskType; }
            set { this._taskType = value; }
        }

        // Check to see if TaskType property is set
        internal bool IsSetTaskType()
        {
            return this._taskType != null;
        }

        /// <summary>
        /// Gets and sets the property WindowId. 
        /// <para>
        /// The ID of the Maintenance Window the task should be added to.
        /// </para>
        /// </summary>
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

    }
}