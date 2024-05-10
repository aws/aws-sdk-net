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
 * Do not modify this file. This file is generated from the finspace-2021-03-12.normal.json service model.
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
namespace Amazon.Finspace.Model
{
    /// <summary>
    /// Container for the parameters to the CreateKxCluster operation.
    /// Creates a new kdb cluster.
    /// </summary>
    public partial class CreateKxClusterRequest : AmazonFinspaceRequest
    {
        private AutoScalingConfiguration _autoScalingConfiguration;
        private string _availabilityZoneId;
        private KxAzMode _azMode;
        private List<KxCacheStorageConfiguration> _cacheStorageConfigurations = AWSConfigs.InitializeCollections ? new List<KxCacheStorageConfiguration>() : null;
        private CapacityConfiguration _capacityConfiguration;
        private string _clientToken;
        private string _clusterDescription;
        private string _clusterName;
        private KxClusterType _clusterType;
        private CodeConfiguration _code;
        private List<KxCommandLineArgument> _commandLineArguments = AWSConfigs.InitializeCollections ? new List<KxCommandLineArgument>() : null;
        private List<KxDatabaseConfiguration> _databases = AWSConfigs.InitializeCollections ? new List<KxDatabaseConfiguration>() : null;
        private string _environmentId;
        private string _executionRole;
        private string _initializationScript;
        private string _releaseLabel;
        private KxSavedownStorageConfiguration _savedownStorageConfiguration;
        private KxScalingGroupConfiguration _scalingGroupConfiguration;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private TickerplantLogConfiguration _tickerplantLogConfiguration;
        private VpcConfiguration _vpcConfiguration;

        /// <summary>
        /// Gets and sets the property AutoScalingConfiguration. 
        /// <para>
        /// The configuration based on which FinSpace will scale in or scale out nodes in your
        /// cluster.
        /// </para>
        /// </summary>
        public AutoScalingConfiguration AutoScalingConfiguration
        {
            get { return this._autoScalingConfiguration; }
            set { this._autoScalingConfiguration = value; }
        }

        // Check to see if AutoScalingConfiguration property is set
        internal bool IsSetAutoScalingConfiguration()
        {
            return this._autoScalingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZoneId. 
        /// <para>
        /// The availability zone identifiers for the requested regions.
        /// </para>
        /// </summary>
        [AWSProperty(Min=8, Max=12)]
        public string AvailabilityZoneId
        {
            get { return this._availabilityZoneId; }
            set { this._availabilityZoneId = value; }
        }

        // Check to see if AvailabilityZoneId property is set
        internal bool IsSetAvailabilityZoneId()
        {
            return this._availabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property AzMode. 
        /// <para>
        /// The number of availability zones you want to assign per cluster. This can be one of
        /// the following 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SINGLE</c> – Assigns one availability zone per cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MULTI</c> – Assigns all the availability zones per cluster.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public KxAzMode AzMode
        {
            get { return this._azMode; }
            set { this._azMode = value; }
        }

        // Check to see if AzMode property is set
        internal bool IsSetAzMode()
        {
            return this._azMode != null;
        }

        /// <summary>
        /// Gets and sets the property CacheStorageConfigurations. 
        /// <para>
        /// The configurations for a read only cache storage associated with a cluster. This cache
        /// will be stored as an FSx Lustre that reads from the S3 store. 
        /// </para>
        /// </summary>
        public List<KxCacheStorageConfiguration> CacheStorageConfigurations
        {
            get { return this._cacheStorageConfigurations; }
            set { this._cacheStorageConfigurations = value; }
        }

        // Check to see if CacheStorageConfigurations property is set
        internal bool IsSetCacheStorageConfigurations()
        {
            return this._cacheStorageConfigurations != null && (this._cacheStorageConfigurations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CapacityConfiguration. 
        /// <para>
        /// A structure for the metadata of a cluster. It includes information like the CPUs needed,
        /// memory of instances, and number of instances.
        /// </para>
        /// </summary>
        public CapacityConfiguration CapacityConfiguration
        {
            get { return this._capacityConfiguration; }
            set { this._capacityConfiguration = value; }
        }

        // Check to see if CapacityConfiguration property is set
        internal bool IsSetCapacityConfiguration()
        {
            return this._capacityConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A token that ensures idempotency. This token expires in 10 minutes.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=36)]
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
        /// Gets and sets the property ClusterDescription. 
        /// <para>
        /// A description of the cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public string ClusterDescription
        {
            get { return this._clusterDescription; }
            set { this._clusterDescription = value; }
        }

        // Check to see if ClusterDescription property is set
        internal bool IsSetClusterDescription()
        {
            return this._clusterDescription != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// A unique name for the cluster that you want to create.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=3, Max=63)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// Specifies the type of KDB database that is being created. The following types are
        /// available: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// HDB – A Historical Database. The data is only accessible with read-only permissions
        /// from one of the FinSpace managed kdb databases mounted to the cluster.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// RDB – A Realtime Database. This type of database captures all the data from a ticker
        /// plant and stores it in memory until the end of day, after which it writes all of its
        /// data to a disk and reloads the HDB. This cluster type requires local storage for temporary
        /// storage of data during the savedown process. If you specify this field in your request,
        /// you must provide the <c>savedownStorageConfiguration</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GATEWAY – A gateway cluster allows you to access data across processes in kdb systems.
        /// It allows you to create your own routing logic using the initialization scripts and
        /// custom code. This type of cluster does not require a writable local storage.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// GP – A general purpose cluster allows you to quickly iterate on code during development
        /// by granting greater access to system commands and enabling a fast reload of custom
        /// code. This cluster type can optionally mount databases including cache and savedown
        /// storage. For this cluster type, the node count is fixed at 1. It does not support
        /// autoscaling and supports only <c>SINGLE</c> AZ mode.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Tickerplant – A tickerplant cluster allows you to subscribe to feed handlers based
        /// on IAM permissions. It can publish to RDBs, other Tickerplants, and real-time subscribers
        /// (RTS). Tickerplants can persist messages to log, which is readable by any RDB environment.
        /// It supports only single-node that is only one kdb process.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public KxClusterType ClusterType
        {
            get { return this._clusterType; }
            set { this._clusterType = value; }
        }

        // Check to see if ClusterType property is set
        internal bool IsSetClusterType()
        {
            return this._clusterType != null;
        }

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The details of the custom code that you want to use inside a cluster when analyzing
        /// a data. It consists of the S3 source bucket, location, S3 object version, and the
        /// relative path from where the custom code is loaded into the cluster. 
        /// </para>
        /// </summary>
        public CodeConfiguration Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property CommandLineArguments. 
        /// <para>
        /// Defines the key-value pairs to make them available inside the cluster.
        /// </para>
        /// </summary>
        public List<KxCommandLineArgument> CommandLineArguments
        {
            get { return this._commandLineArguments; }
            set { this._commandLineArguments = value; }
        }

        // Check to see if CommandLineArguments property is set
        internal bool IsSetCommandLineArguments()
        {
            return this._commandLineArguments != null && (this._commandLineArguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Databases. 
        /// <para>
        /// A list of databases that will be available for querying.
        /// </para>
        /// </summary>
        public List<KxDatabaseConfiguration> Databases
        {
            get { return this._databases; }
            set { this._databases = value; }
        }

        // Check to see if Databases property is set
        internal bool IsSetDatabases()
        {
            return this._databases != null && (this._databases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EnvironmentId. 
        /// <para>
        /// A unique identifier for the kdb environment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string EnvironmentId
        {
            get { return this._environmentId; }
            set { this._environmentId = value; }
        }

        // Check to see if EnvironmentId property is set
        internal bool IsSetEnvironmentId()
        {
            return this._environmentId != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRole. 
        /// <para>
        /// An IAM role that defines a set of permissions associated with a cluster. These permissions
        /// are assumed when a cluster attempts to access another cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ExecutionRole
        {
            get { return this._executionRole; }
            set { this._executionRole = value; }
        }

        // Check to see if ExecutionRole property is set
        internal bool IsSetExecutionRole()
        {
            return this._executionRole != null;
        }

        /// <summary>
        /// Gets and sets the property InitializationScript. 
        /// <para>
        /// Specifies a Q program that will be run at launch of a cluster. It is a relative path
        /// within <i>.zip</i> file that contains the custom code, which will be loaded on the
        /// cluster. It must include the file name itself. For example, <c>somedir/init.q</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string InitializationScript
        {
            get { return this._initializationScript; }
            set { this._initializationScript = value; }
        }

        // Check to see if InitializationScript property is set
        internal bool IsSetInitializationScript()
        {
            return this._initializationScript != null;
        }

        /// <summary>
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The version of FinSpace managed kdb to run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16)]
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

        /// <summary>
        /// Gets and sets the property SavedownStorageConfiguration. 
        /// <para>
        /// The size and type of the temporary storage that is used to hold data during the savedown
        /// process. This parameter is required when you choose <c>clusterType</c> as RDB. All
        /// the data written to this storage space is lost when the cluster node is restarted.
        /// </para>
        /// </summary>
        public KxSavedownStorageConfiguration SavedownStorageConfiguration
        {
            get { return this._savedownStorageConfiguration; }
            set { this._savedownStorageConfiguration = value; }
        }

        // Check to see if SavedownStorageConfiguration property is set
        internal bool IsSetSavedownStorageConfiguration()
        {
            return this._savedownStorageConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ScalingGroupConfiguration. 
        /// <para>
        /// The structure that stores the configuration details of a scaling group.
        /// </para>
        /// </summary>
        public KxScalingGroupConfiguration ScalingGroupConfiguration
        {
            get { return this._scalingGroupConfiguration; }
            set { this._scalingGroupConfiguration = value; }
        }

        // Check to see if ScalingGroupConfiguration property is set
        internal bool IsSetScalingGroupConfiguration()
        {
            return this._scalingGroupConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to label the cluster. You can add up to 50 tags to a cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property TickerplantLogConfiguration. 
        /// <para>
        ///  A configuration to store Tickerplant logs. It consists of a list of volumes that
        /// will be mounted to your cluster. For the cluster type <c>Tickerplant</c>, the location
        /// of the TP volume on the cluster will be available by using the global variable <c>.aws.tp_log_path</c>.
        /// 
        /// </para>
        /// </summary>
        public TickerplantLogConfiguration TickerplantLogConfiguration
        {
            get { return this._tickerplantLogConfiguration; }
            set { this._tickerplantLogConfiguration = value; }
        }

        // Check to see if TickerplantLogConfiguration property is set
        internal bool IsSetTickerplantLogConfiguration()
        {
            return this._tickerplantLogConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfiguration. 
        /// <para>
        /// Configuration details about the network where the Privatelink endpoint of the cluster
        /// resides.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public VpcConfiguration VpcConfiguration
        {
            get { return this._vpcConfiguration; }
            set { this._vpcConfiguration = value; }
        }

        // Check to see if VpcConfiguration property is set
        internal bool IsSetVpcConfiguration()
        {
            return this._vpcConfiguration != null;
        }

    }
}