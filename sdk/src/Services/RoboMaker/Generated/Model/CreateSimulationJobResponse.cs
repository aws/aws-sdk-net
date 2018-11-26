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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the CreateSimulationJob operation.
    /// </summary>
    public partial class CreateSimulationJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _clientRequestToken;
        private FailureBehavior _failureBehavior;
        private SimulationJobErrorCode _failureCode;
        private string _iamRole;
        private DateTime? _lastUpdatedAt;
        private long? _maxJobDurationInSeconds;
        private OutputLocation _outputLocation;
        private List<RobotApplicationConfig> _robotApplications = new List<RobotApplicationConfig>();
        private List<SimulationApplicationConfig> _simulationApplications = new List<SimulationApplicationConfig>();
        private long? _simulationTimeMillis;
        private SimulationJobStatus _status;
        private VPCConfigResponse _vpcConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the simulation job.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property FailureBehavior. 
        /// <para>
        /// the failure behavior for the simulation job.
        /// </para>
        /// </summary>
        public FailureBehavior FailureBehavior
        {
            get { return this._failureBehavior; }
            set { this._failureBehavior = value; }
        }

        // Check to see if FailureBehavior property is set
        internal bool IsSetFailureBehavior()
        {
            return this._failureBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property FailureCode. 
        /// <para>
        /// The failure code of the simulation job if it failed.
        /// </para>
        /// </summary>
        public SimulationJobErrorCode FailureCode
        {
            get { return this._failureCode; }
            set { this._failureCode = value; }
        }

        // Check to see if FailureCode property is set
        internal bool IsSetFailureCode()
        {
            return this._failureCode != null;
        }

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The IAM role that allows the simulation job to call the AWS APIs that are specified
        /// in its associated policies on your behalf.
        /// </para>
        /// </summary>
        public string IamRole
        {
            get { return this._iamRole; }
            set { this._iamRole = value; }
        }

        // Check to see if IamRole property is set
        internal bool IsSetIamRole()
        {
            return this._iamRole != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the simulation job was last updated.
        /// </para>
        /// </summary>
        public DateTime LastUpdatedAt
        {
            get { return this._lastUpdatedAt.GetValueOrDefault(); }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxJobDurationInSeconds. 
        /// <para>
        /// The maximum simulation job duration in seconds. The value must be 8 days (691,200
        /// seconds) or less. 
        /// </para>
        /// </summary>
        public long MaxJobDurationInSeconds
        {
            get { return this._maxJobDurationInSeconds.GetValueOrDefault(); }
            set { this._maxJobDurationInSeconds = value; }
        }

        // Check to see if MaxJobDurationInSeconds property is set
        internal bool IsSetMaxJobDurationInSeconds()
        {
            return this._maxJobDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputLocation. 
        /// <para>
        /// Simulation job output files location.
        /// </para>
        /// </summary>
        public OutputLocation OutputLocation
        {
            get { return this._outputLocation; }
            set { this._outputLocation = value; }
        }

        // Check to see if OutputLocation property is set
        internal bool IsSetOutputLocation()
        {
            return this._outputLocation != null;
        }

        /// <summary>
        /// Gets and sets the property RobotApplications. 
        /// <para>
        /// The robot application used by the simulation job.
        /// </para>
        /// </summary>
        public List<RobotApplicationConfig> RobotApplications
        {
            get { return this._robotApplications; }
            set { this._robotApplications = value; }
        }

        // Check to see if RobotApplications property is set
        internal bool IsSetRobotApplications()
        {
            return this._robotApplications != null && this._robotApplications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SimulationApplications. 
        /// <para>
        /// The simulation application used by the simulation job.
        /// </para>
        /// </summary>
        public List<SimulationApplicationConfig> SimulationApplications
        {
            get { return this._simulationApplications; }
            set { this._simulationApplications = value; }
        }

        // Check to see if SimulationApplications property is set
        internal bool IsSetSimulationApplications()
        {
            return this._simulationApplications != null && this._simulationApplications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SimulationTimeMillis. 
        /// <para>
        /// The simulation job execution duration in milliseconds.
        /// </para>
        /// </summary>
        public long SimulationTimeMillis
        {
            get { return this._simulationTimeMillis.GetValueOrDefault(); }
            set { this._simulationTimeMillis = value; }
        }

        // Check to see if SimulationTimeMillis property is set
        internal bool IsSetSimulationTimeMillis()
        {
            return this._simulationTimeMillis.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the simulation job.
        /// </para>
        /// </summary>
        public SimulationJobStatus Status
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
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// Information about the vpc configuration.
        /// </para>
        /// </summary>
        public VPCConfigResponse VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}