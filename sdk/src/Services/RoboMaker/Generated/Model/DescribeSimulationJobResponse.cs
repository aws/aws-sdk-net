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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.RoboMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeSimulationJob operation.
    /// </summary>
    public partial class DescribeSimulationJobResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private string _clientRequestToken;
        private ComputeResponse _compute;
        private List<DataSource> _dataSources = AWSConfigs.InitializeCollections ? new List<DataSource>() : null;
        private FailureBehavior _failureBehavior;
        private SimulationJobErrorCode _failureCode;
        private string _failureReason;
        private string _iamRole;
        private DateTime? _lastStartedAt;
        private DateTime? _lastUpdatedAt;
        private LoggingConfig _loggingConfig;
        private long? _maxJobDurationInSeconds;
        private string _name;
        private NetworkInterface _networkInterface;
        private OutputLocation _outputLocation;
        private List<RobotApplicationConfig> _robotApplications = AWSConfigs.InitializeCollections ? new List<RobotApplicationConfig>() : null;
        private List<SimulationApplicationConfig> _simulationApplications = AWSConfigs.InitializeCollections ? new List<SimulationApplicationConfig>() : null;
        private long? _simulationTimeMillis;
        private SimulationJobStatus _status;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private VPCConfigResponse _vpcConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the simulation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1224)]
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
        public ComputeResponse Compute
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
        /// The data sources for the simulation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<DataSource> DataSources
        {
            get { return this._dataSources; }
            set { this._dataSources = value; }
        }

        // Check to see if DataSources property is set
        internal bool IsSetDataSources()
        {
            return this._dataSources != null && (this._dataSources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailureBehavior. 
        /// <para>
        /// The failure behavior for the simulation job.
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
        /// The failure code of the simulation job if it failed:
        /// </para>
        ///  <dl> <dt>InternalServiceError</dt> <dd> 
        /// <para>
        /// Internal service error.
        /// </para>
        ///  </dd> <dt>RobotApplicationCrash</dt> <dd> 
        /// <para>
        /// Robot application exited abnormally.
        /// </para>
        ///  </dd> <dt>SimulationApplicationCrash</dt> <dd> 
        /// <para>
        ///  Simulation application exited abnormally.
        /// </para>
        ///  </dd> <dt>BadPermissionsRobotApplication</dt> <dd> 
        /// <para>
        /// Robot application bundle could not be downloaded.
        /// </para>
        ///  </dd> <dt>BadPermissionsSimulationApplication</dt> <dd> 
        /// <para>
        /// Simulation application bundle could not be downloaded.
        /// </para>
        ///  </dd> <dt>BadPermissionsS3Output</dt> <dd> 
        /// <para>
        /// Unable to publish outputs to customer-provided S3 bucket.
        /// </para>
        ///  </dd> <dt>BadPermissionsCloudwatchLogs</dt> <dd> 
        /// <para>
        /// Unable to publish logs to customer-provided CloudWatch Logs resource.
        /// </para>
        ///  </dd> <dt>SubnetIpLimitExceeded</dt> <dd> 
        /// <para>
        /// Subnet IP limit exceeded.
        /// </para>
        ///  </dd> <dt>ENILimitExceeded</dt> <dd> 
        /// <para>
        /// ENI limit exceeded.
        /// </para>
        ///  </dd> <dt>BadPermissionsUserCredentials</dt> <dd> 
        /// <para>
        /// Unable to use the Role provided.
        /// </para>
        ///  </dd> <dt>InvalidBundleRobotApplication</dt> <dd> 
        /// <para>
        /// Robot bundle cannot be extracted (invalid format, bundling error, or other issue).
        /// </para>
        ///  </dd> <dt>InvalidBundleSimulationApplication</dt> <dd> 
        /// <para>
        /// Simulation bundle cannot be extracted (invalid format, bundling error, or other issue).
        /// </para>
        ///  </dd> <dt>RobotApplicationVersionMismatchedEtag</dt> <dd> 
        /// <para>
        /// Etag for RobotApplication does not match value during version creation.
        /// </para>
        ///  </dd> <dt>SimulationApplicationVersionMismatchedEtag</dt> <dd> 
        /// <para>
        /// Etag for SimulationApplication does not match value during version creation.
        /// </para>
        ///  </dd> </dl>
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
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// Details about why the simulation job failed. For more information about troubleshooting,
        /// see <a href="https://docs.aws.amazon.com/robomaker/latest/dg/troubleshooting.html">Troubleshooting</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property IamRole. 
        /// <para>
        /// The IAM role that allows the simulation instance to call the AWS APIs that are specified
        /// in its associated policies on your behalf.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property LastStartedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the simulation job was last started.
        /// </para>
        /// </summary>
        public DateTime? LastStartedAt
        {
            get { return this._lastStartedAt; }
            set { this._lastStartedAt = value; }
        }

        // Check to see if LastStartedAt property is set
        internal bool IsSetLastStartedAt()
        {
            return this._lastStartedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time, in milliseconds since the epoch, when the simulation job was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
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
        /// The maximum job duration in seconds. The value must be 8 days (691,200 seconds) or
        /// less.
        /// </para>
        /// </summary>
        public long? MaxJobDurationInSeconds
        {
            get { return this._maxJobDurationInSeconds; }
            set { this._maxJobDurationInSeconds = value; }
        }

        // Check to see if MaxJobDurationInSeconds property is set
        internal bool IsSetMaxJobDurationInSeconds()
        {
            return this._maxJobDurationInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the simulation job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property NetworkInterface. 
        /// <para>
        /// The network interface information for the simulation job.
        /// </para>
        /// </summary>
        public NetworkInterface NetworkInterface
        {
            get { return this._networkInterface; }
            set { this._networkInterface = value; }
        }

        // Check to see if NetworkInterface property is set
        internal bool IsSetNetworkInterface()
        {
            return this._networkInterface != null;
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
        /// A list of robot applications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._robotApplications != null && (this._robotApplications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SimulationApplications. 
        /// <para>
        /// A list of simulation applications.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._simulationApplications != null && (this._simulationApplications.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SimulationTimeMillis. 
        /// <para>
        /// The simulation job execution duration in milliseconds.
        /// </para>
        /// </summary>
        public long? SimulationTimeMillis
        {
            get { return this._simulationTimeMillis; }
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The list of all tags added to the specified simulation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The VPC configuration.
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