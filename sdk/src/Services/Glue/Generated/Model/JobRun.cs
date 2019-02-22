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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Contains information about a job run.
    /// </summary>
    public partial class JobRun
    {
        private int? _allocatedCapacity;
        private Dictionary<string, string> _arguments = new Dictionary<string, string>();
        private int? _attempt;
        private DateTime? _completedOn;
        private string _errorMessage;
        private int? _executionTime;
        private string _id;
        private string _jobName;
        private JobRunState _jobRunState;
        private DateTime? _lastModifiedOn;
        private string _logGroupName;
        private double? _maxCapacity;
        private NotificationProperty _notificationProperty;
        private List<Predecessor> _predecessorRuns = new List<Predecessor>();
        private string _previousRunId;
        private string _securityConfiguration;
        private DateTime? _startedOn;
        private int? _timeout;
        private string _triggerName;

        /// <summary>
        /// Gets and sets the property AllocatedCapacity. 
        /// <para>
        /// This field is deprecated, use <code>MaxCapacity</code> instead.
        /// </para>
        ///  
        /// <para>
        /// The number of AWS Glue data processing units (DPUs) allocated to this JobRun. From
        /// 2 to 100 DPUs can be allocated; the default is 10. A DPU is a relative measure of
        /// processing power that consists of 4 vCPUs of compute capacity and 16 GB of memory.
        /// For more information, see the <a href="https://aws.amazon.com/glue/pricing/">AWS Glue
        /// pricing page</a>.
        /// </para>
        /// </summary>
        [Obsolete("This property is deprecated, use MaxCapacity instead.")]
        public int AllocatedCapacity
        {
            get { return this._allocatedCapacity.GetValueOrDefault(); }
            set { this._allocatedCapacity = value; }
        }

        // Check to see if AllocatedCapacity property is set
        internal bool IsSetAllocatedCapacity()
        {
            return this._allocatedCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// The job arguments associated with this run. For this job run, they replace the default
        /// arguments set in the job definition itself.
        /// </para>
        ///  
        /// <para>
        /// You can specify arguments here that your own job-execution script consumes, as well
        /// as arguments that AWS Glue itself consumes.
        /// </para>
        ///  
        /// <para>
        /// For information about how to specify and consume your own job arguments, see the <a
        /// href="http://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-python-calling.html">Calling
        /// AWS Glue APIs in Python</a> topic in the developer guide.
        /// </para>
        ///  
        /// <para>
        /// For information about the key-value pairs that AWS Glue consumes to set up your job,
        /// see the <a href="http://docs.aws.amazon.com/glue/latest/dg/aws-glue-programming-etl-glue-arguments.html">Special
        /// Parameters Used by AWS Glue</a> topic in the developer guide.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null && this._arguments.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Attempt. 
        /// <para>
        /// The number of the attempt to run this job.
        /// </para>
        /// </summary>
        public int Attempt
        {
            get { return this._attempt.GetValueOrDefault(); }
            set { this._attempt = value; }
        }

        // Check to see if Attempt property is set
        internal bool IsSetAttempt()
        {
            return this._attempt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time this job run completed.
        /// </para>
        /// </summary>
        public DateTime CompletedOn
        {
            get { return this._completedOn.GetValueOrDefault(); }
            set { this._completedOn = value; }
        }

        // Check to see if CompletedOn property is set
        internal bool IsSetCompletedOn()
        {
            return this._completedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// An error message associated with this job run.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionTime. 
        /// <para>
        /// The amount of time (in seconds) that the job run consumed resources.
        /// </para>
        /// </summary>
        public int ExecutionTime
        {
            get { return this._executionTime.GetValueOrDefault(); }
            set { this._executionTime = value; }
        }

        // Check to see if ExecutionTime property is set
        internal bool IsSetExecutionTime()
        {
            return this._executionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of this job run.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job definition being used in this run.
        /// </para>
        /// </summary>
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobRunState. 
        /// <para>
        /// The current state of the job run.
        /// </para>
        /// </summary>
        public JobRunState JobRunState
        {
            get { return this._jobRunState; }
            set { this._jobRunState = value; }
        }

        // Check to see if JobRunState property is set
        internal bool IsSetJobRunState()
        {
            return this._jobRunState != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedOn. 
        /// <para>
        /// The last time this job run was modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedOn
        {
            get { return this._lastModifiedOn.GetValueOrDefault(); }
            set { this._lastModifiedOn = value; }
        }

        // Check to see if LastModifiedOn property is set
        internal bool IsSetLastModifiedOn()
        {
            return this._lastModifiedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LogGroupName. 
        /// <para>
        /// The name of the log group for secure logging, that can be server-side encrypted in
        /// CloudWatch using KMS. This name can be <code>/aws-glue/jobs/</code>, in which case
        /// the default encryption is <code>NONE</code>. If you add a role name and SecurityConfiguration
        /// name (in other words, <code>/aws-glue/jobs-yourRoleName-yourSecurityConfigurationName/</code>),
        /// then that security configuration will be used to encrypt the log group.
        /// </para>
        /// </summary>
        public string LogGroupName
        {
            get { return this._logGroupName; }
            set { this._logGroupName = value; }
        }

        // Check to see if LogGroupName property is set
        internal bool IsSetLogGroupName()
        {
            return this._logGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The number of AWS Glue data processing units (DPUs) that can be allocated when this
        /// job runs. A DPU is a relative measure of processing power that consists of 4 vCPUs
        /// of compute capacity and 16 GB of memory. For more information, see the <a href="https://aws.amazon.com/glue/pricing/">AWS
        /// Glue pricing page</a>.
        /// </para>
        ///  
        /// <para>
        /// The value that can be allocated for <code>MaxCapacity</code> depends on whether you
        /// are running a python shell job, or an Apache Spark ETL job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you specify a python shell job (<code>JobCommand.Name</code>="pythonshell"),
        /// you can allocate either 0.0625 or 1 DPU. The default is 0.0625 DPU.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you specify an Apache Spark ETL job (<code>JobCommand.Name</code>="glueetl"),
        /// you can allocate from 2 to 100 DPUs. The default is 10 DPUs. This job type cannot
        /// have a fractional DPU allocation.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public double MaxCapacity
        {
            get { return this._maxCapacity.GetValueOrDefault(); }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NotificationProperty. 
        /// <para>
        /// Specifies configuration properties of a job run notification.
        /// </para>
        /// </summary>
        public NotificationProperty NotificationProperty
        {
            get { return this._notificationProperty; }
            set { this._notificationProperty = value; }
        }

        // Check to see if NotificationProperty property is set
        internal bool IsSetNotificationProperty()
        {
            return this._notificationProperty != null;
        }

        /// <summary>
        /// Gets and sets the property PredecessorRuns. 
        /// <para>
        /// A list of predecessors to this job run.
        /// </para>
        /// </summary>
        public List<Predecessor> PredecessorRuns
        {
            get { return this._predecessorRuns; }
            set { this._predecessorRuns = value; }
        }

        // Check to see if PredecessorRuns property is set
        internal bool IsSetPredecessorRuns()
        {
            return this._predecessorRuns != null && this._predecessorRuns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property PreviousRunId. 
        /// <para>
        /// The ID of the previous run of this job. For example, the JobRunId specified in the
        /// StartJobRun action.
        /// </para>
        /// </summary>
        public string PreviousRunId
        {
            get { return this._previousRunId; }
            set { this._previousRunId = value; }
        }

        // Check to see if PreviousRunId property is set
        internal bool IsSetPreviousRunId()
        {
            return this._previousRunId != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the SecurityConfiguration structure to be used with this job run.
        /// </para>
        /// </summary>
        public string SecurityConfiguration
        {
            get { return this._securityConfiguration; }
            set { this._securityConfiguration = value; }
        }

        // Check to see if SecurityConfiguration property is set
        internal bool IsSetSecurityConfiguration()
        {
            return this._securityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property StartedOn. 
        /// <para>
        /// The date and time at which this job run was started.
        /// </para>
        /// </summary>
        public DateTime StartedOn
        {
            get { return this._startedOn.GetValueOrDefault(); }
            set { this._startedOn = value; }
        }

        // Check to see if StartedOn property is set
        internal bool IsSetStartedOn()
        {
            return this._startedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Timeout. 
        /// <para>
        /// The JobRun timeout in minutes. This is the maximum time that a job run can consume
        /// resources before it is terminated and enters <code>TIMEOUT</code> status. The default
        /// is 2,880 minutes (48 hours). This overrides the timeout value set in the parent job.
        /// </para>
        /// </summary>
        public int Timeout
        {
            get { return this._timeout.GetValueOrDefault(); }
            set { this._timeout = value; }
        }

        // Check to see if Timeout property is set
        internal bool IsSetTimeout()
        {
            return this._timeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TriggerName. 
        /// <para>
        /// The name of the trigger that started this job run.
        /// </para>
        /// </summary>
        public string TriggerName
        {
            get { return this._triggerName; }
            set { this._triggerName = value; }
        }

        // Check to see if TriggerName property is set
        internal bool IsSetTriggerName()
        {
            return this._triggerName != null;
        }

    }
}