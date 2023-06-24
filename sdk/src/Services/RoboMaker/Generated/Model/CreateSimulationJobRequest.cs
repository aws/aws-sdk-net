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
 * Do not modify this file. This file is generated from the robomaker-2018-06-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// Container for the parameters to the CreateSimulationJob operation.
    /// Creates a simulation job.
    /// 
    ///  <note> 
    /// <para>
    /// After 90 days, simulation jobs expire and will be deleted. They will no longer be
    /// accessible. 
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreateSimulationJobRequest : AmazonRoboMakerRequest
    {
        private string _clientRequestToken;
        private Compute _compute;
        private List<DataSourceConfig> _dataSources = new List<DataSourceConfig>();
        private FailureBehavior _failureBehavior;
        private string _iamRole;
        private LoggingConfig _loggingConfig;
        private long? _maxJobDurationInSeconds;
        private OutputLocation _outputLocation;
        private List<RobotApplicationConfig> _robotApplications = new List<RobotApplicationConfig>();
        private List<SimulationApplicationConfig> _simulationApplications = new List<SimulationApplicationConfig>();
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private VPCConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Compute. 
        /// <para>
        /// Compute information for the simulation job.
        /// </para>
        /// </summary>
        public Compute Compute
        {
            get { return this._compute; }
            set { this._compute = value; }
        }

        // Check to see if Compute property is set
        internal bool IsSetCompute()
        {
            return this._compute != null;
        }

        /// <summary>
        /// Gets and sets the property DataSources. 
        /// <para>
        /// Specify data sources to mount read-only files from S3 into your simulation. These
        /// files are available under <code>/opt/robomaker/datasources/data_source_name</code>.
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// There is a limit of 100 files and a combined size of 25GB for all <code>DataSourceConfig</code>
        /// objects. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=6)]
        public List<DataSourceConfig> DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null && this._dataSources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailureBehavior. 
        /// <para>
        /// The failure behavior the simulation job.
        /// </para>
        ///  <dl> <dt>Continue</dt> <dd> 
        /// <para>
        /// Leaves the instance running for its maximum timeout duration after a <code>4XX</code>
        /// error code.
        /// </para>
        ///  </dd> <dt>Fail</dt> <dd> 
        /// <para>
        /// Stop the simulation job and terminate the instance.
        /// </para>
        ///  </dd> </dl>
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
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The IAM role name that allows the simulation instance to call the AWS APIs that are
        /// specified in its associated policies on your behalf. This is how credentials are passed
        /// in to your simulation job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property LoggingConfig. 
        /// <para>
        /// The logging configuration.
        /// </para>
        /// </summary>
        public LoggingConfig LoggingConfig
        {
            get { return this._loggingConfig; }
            set { this._loggingConfig = value; }
        }

        // Check to see if LoggingConfig property is set
        internal bool IsSetLoggingConfig()
        {
            return this._loggingConfig != null;
        }

        /// <summary>
        /// Gets and sets the property MaxJobDurationInSeconds. 
        /// <para>
        /// The maximum simulation job duration in seconds (up to 14 days or 1,209,600 seconds.
        /// When <code>maxJobDurationInSeconds</code> is reached, the simulation job will status
        /// will transition to <code>Completed</code>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Location for output files generated by the simulation job.
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
        /// The robot application to use in the simulation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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
        /// The simulation application to use in the simulation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map that contains tag keys and tag values that are attached to the simulation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// If your simulation job accesses resources in a VPC, you provide this parameter identifying
        /// the list of security group IDs and subnet IDs. These must belong to the same VPC.
        /// You must provide at least one security group and one subnet ID. 
        /// </para>
        /// </summary>
        public VPCConfig VpcConfig
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