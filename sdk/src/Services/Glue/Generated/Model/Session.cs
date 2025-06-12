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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
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
namespace Amazon.Glue.Model
{
    /// <summary>
    /// The period in which a remote Spark runtime environment is running.
    /// </summary>
    public partial class Session
    {
        private SessionCommand _command;
        private DateTime? _completedOn;
        private ConnectionsList _connections;
        private DateTime? _createdOn;
        private Dictionary<string, string> _defaultArguments = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _description;
        private double? _dpuSeconds;
        private string _errorMessage;
        private double? _executionTime;
        private string _glueVersion;
        private string _id;
        private int? _idleTimeout;
        private double? _maxCapacity;
        private int? _numberOfWorkers;
        private string _profileName;
        private double? _progress;
        private string _role;
        private string _securityConfiguration;
        private SessionStatus _status;
        private WorkerType _workerType;

        /// <summary>
        /// Gets and sets the property Command. 
        /// <para>
        /// The command object.See SessionCommand.
        /// </para>
        /// </summary>
        public SessionCommand Command
        {
            get { return this._command; }
            set { this._command = value; }
        }

        // Check to see if Command property is set
        internal bool IsSetCommand()
        {
            return this._command != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedOn. 
        /// <para>
        /// The date and time that this session is completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedOn
        {
            get { return this._completedOn; }
            set { this._completedOn = value; }
        }

        // Check to see if CompletedOn property is set
        internal bool IsSetCompletedOn()
        {
            return this._completedOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Connections. 
        /// <para>
        /// The number of connections used for the session.
        /// </para>
        /// </summary>
        public ConnectionsList Connections
        {
            get { return this._connections; }
            set { this._connections = value; }
        }

        // Check to see if Connections property is set
        internal bool IsSetConnections()
        {
            return this._connections != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedOn. 
        /// <para>
        /// The time and date when the session was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedOn
        {
            get { return this._createdOn; }
            set { this._createdOn = value; }
        }

        // Check to see if CreatedOn property is set
        internal bool IsSetCreatedOn()
        {
            return this._createdOn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultArguments. 
        /// <para>
        /// A map array of key-value pairs. Max is 75 pairs. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=75)]
        public Dictionary<string, string> DefaultArguments
        {
            get { return this._defaultArguments; }
            set { this._defaultArguments = value; }
        }

        // Check to see if DefaultArguments property is set
        internal bool IsSetDefaultArguments()
        {
            return this._defaultArguments != null && (this._defaultArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// Gets and sets the property DPUSeconds. 
        /// <para>
        /// The DPUs consumed by the session (formula: ExecutionTime * MaxCapacity).
        /// </para>
        /// </summary>
        public double? DPUSeconds
        {
            get { return this._dpuSeconds; }
            set { this._dpuSeconds = value; }
        }

        // Check to see if DPUSeconds property is set
        internal bool IsSetDPUSeconds()
        {
            return this._dpuSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message displayed during the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
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
        /// The total time the session ran for.
        /// </para>
        /// </summary>
        public double? ExecutionTime
        {
            get { return this._executionTime; }
            set { this._executionTime = value; }
        }

        // Check to see if ExecutionTime property is set
        internal bool IsSetExecutionTime()
        {
            return this._executionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// The Glue version determines the versions of Apache Spark and Python that Glue supports.
        /// The GlueVersion must be greater than 2.0.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string GlueVersion
        {
            get { return this._glueVersion; }
            set { this._glueVersion = value; }
        }

        // Check to see if GlueVersion property is set
        internal bool IsSetGlueVersion()
        {
            return this._glueVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property IdleTimeout. 
        /// <para>
        /// The number of minutes when idle before the session times out.
        /// </para>
        /// </summary>
        public int? IdleTimeout
        {
            get { return this._idleTimeout; }
            set { this._idleTimeout = value; }
        }

        // Check to see if IdleTimeout property is set
        internal bool IsSetIdleTimeout()
        {
            return this._idleTimeout.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxCapacity. 
        /// <para>
        /// The number of Glue data processing units (DPUs) that can be allocated when the job
        /// runs. A DPU is a relative measure of processing power that consists of 4 vCPUs of
        /// compute capacity and 16 GB memory. 
        /// </para>
        /// </summary>
        public double? MaxCapacity
        {
            get { return this._maxCapacity; }
            set { this._maxCapacity = value; }
        }

        // Check to see if MaxCapacity property is set
        internal bool IsSetMaxCapacity()
        {
            return this._maxCapacity.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers of a defined <c>WorkerType</c> to use for the session.
        /// </para>
        /// </summary>
        public int? NumberOfWorkers
        {
            get { return this._numberOfWorkers; }
            set { this._numberOfWorkers = value; }
        }

        // Check to see if NumberOfWorkers property is set
        internal bool IsSetNumberOfWorkers()
        {
            return this._numberOfWorkers.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProfileName. 
        /// <para>
        /// The name of an Glue usage profile associated with the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string ProfileName
        {
            get { return this._profileName; }
            set { this._profileName = value; }
        }

        // Check to see if ProfileName property is set
        internal bool IsSetProfileName()
        {
            return this._profileName != null;
        }

        /// <summary>
        /// Gets and sets the property Progress. 
        /// <para>
        /// The code execution progress of the session.
        /// </para>
        /// </summary>
        public double? Progress
        {
            get { return this._progress; }
            set { this._progress = value; }
        }

        // Check to see if Progress property is set
        internal bool IsSetProgress()
        {
            return this._progress.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Role. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the IAM role associated with the Session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string Role
        {
            get { return this._role; }
            set { this._role = value; }
        }

        // Check to see if Role property is set
        internal bool IsSetRole()
        {
            return this._role != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the SecurityConfiguration structure to be used with the session.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The session status. 
        /// </para>
        /// </summary>
        public SessionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated when a session runs. Accepts a value
        /// of <c>G.1X</c>, <c>G.2X</c>, <c>G.4X</c>, or <c>G.8X</c> for Spark sessions. Accepts
        /// the value <c>Z.2X</c> for Ray sessions.
        /// </para>
        /// </summary>
        public WorkerType WorkerType
        {
            get { return this._workerType; }
            set { this._workerType = value; }
        }

        // Check to see if WorkerType property is set
        internal bool IsSetWorkerType()
        {
            return this._workerType != null;
        }

    }
}