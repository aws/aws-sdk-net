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
    /// A development endpoint where a developer can remotely debug extract, transform, and
    /// load (ETL) scripts.
    /// </summary>
    public partial class DevEndpoint
    {
        private Dictionary<string, string> _arguments = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _availabilityZone;
        private DateTime? _createdTimestamp;
        private string _endpointName;
        private string _extraJarsS3Path;
        private string _extraPythonLibsS3Path;
        private string _failureReason;
        private string _glueVersion;
        private DateTime? _lastModifiedTimestamp;
        private string _lastUpdateStatus;
        private int? _numberOfNodes;
        private int? _numberOfWorkers;
        private string _privateAddress;
        private string _publicAddress;
        private string _publicKey;
        private List<string> _publicKeys = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _roleArn;
        private string _securityConfiguration;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _status;
        private string _subnetId;
        private string _vpcId;
        private WorkerType _workerType;
        private string _yarnEndpointAddress;
        private int? _zeppelinRemoteSparkInterpreterPort;

        /// <summary>
        /// Gets and sets the property Arguments. 
        /// <para>
        /// A map of arguments used to configure the <c>DevEndpoint</c>.
        /// </para>
        ///  
        /// <para>
        /// Valid arguments are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>"--enable-glue-datacatalog": ""</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can specify a version of Python support for development endpoints by using the
        /// <c>Arguments</c> parameter in the <c>CreateDevEndpoint</c> or <c>UpdateDevEndpoint</c>
        /// APIs. If no arguments are provided, the version defaults to Python 2.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> Arguments
        {
            get { return this._arguments; }
            set { this._arguments = value; }
        }

        // Check to see if Arguments property is set
        internal bool IsSetArguments()
        {
            return this._arguments != null && (this._arguments.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Amazon Web Services Availability Zone where this <c>DevEndpoint</c> is located.
        /// </para>
        /// </summary>
        public string AvailabilityZone
        {
            get { return this._availabilityZone; }
            set { this._availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this._availabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The point in time at which this DevEndpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string EndpointName
        {
            get { return this._endpointName; }
            set { this._endpointName = value; }
        }

        // Check to see if EndpointName property is set
        internal bool IsSetEndpointName()
        {
            return this._endpointName != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraJarsS3Path. 
        /// <para>
        /// The path to one or more Java <c>.jar</c> files in an S3 bucket that should be loaded
        /// in your <c>DevEndpoint</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only use pure Java/Scala libraries with a <c>DevEndpoint</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public string ExtraJarsS3Path
        {
            get { return this._extraJarsS3Path; }
            set { this._extraJarsS3Path = value; }
        }

        // Check to see if ExtraJarsS3Path property is set
        internal bool IsSetExtraJarsS3Path()
        {
            return this._extraJarsS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property ExtraPythonLibsS3Path. 
        /// <para>
        /// The paths to one or more Python libraries in an Amazon S3 bucket that should be loaded
        /// in your <c>DevEndpoint</c>. Multiple values must be complete paths separated by a
        /// comma.
        /// </para>
        ///  <note> 
        /// <para>
        /// You can only use pure Python libraries with a <c>DevEndpoint</c>. Libraries that rely
        /// on C extensions, such as the <a href="http://pandas.pydata.org/">pandas</a> Python
        /// data analysis library, are not currently supported.
        /// </para>
        ///  </note>
        /// </summary>
        public string ExtraPythonLibsS3Path
        {
            get { return this._extraPythonLibsS3Path; }
            set { this._extraPythonLibsS3Path = value; }
        }

        // Check to see if ExtraPythonLibsS3Path property is set
        internal bool IsSetExtraPythonLibsS3Path()
        {
            return this._extraPythonLibsS3Path != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for a current failure in this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property GlueVersion. 
        /// <para>
        /// Glue version determines the versions of Apache Spark and Python that Glue supports.
        /// The Python version indicates the version supported for running your ETL scripts on
        /// development endpoints. 
        /// </para>
        ///  
        /// <para>
        /// For more information about the available Glue versions and corresponding Spark and
        /// Python versions, see <a href="https://docs.aws.amazon.com/glue/latest/dg/add-job.html">Glue
        /// version</a> in the developer guide.
        /// </para>
        ///  
        /// <para>
        /// Development endpoints that are created without specifying a Glue version default to
        /// Glue 0.9.
        /// </para>
        ///  
        /// <para>
        /// You can specify a version of Python support for development endpoints by using the
        /// <c>Arguments</c> parameter in the <c>CreateDevEndpoint</c> or <c>UpdateDevEndpoint</c>
        /// APIs. If no arguments are provided, the version defaults to Python 2.
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
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The point in time at which this <c>DevEndpoint</c> was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp; }
            set { this._lastModifiedTimestamp = value; }
        }

        // Check to see if LastModifiedTimestamp property is set
        internal bool IsSetLastModifiedTimestamp()
        {
            return this._lastModifiedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdateStatus. 
        /// <para>
        /// The status of the last update.
        /// </para>
        /// </summary>
        public string LastUpdateStatus
        {
            get { return this._lastUpdateStatus; }
            set { this._lastUpdateStatus = value; }
        }

        // Check to see if LastUpdateStatus property is set
        internal bool IsSetLastUpdateStatus()
        {
            return this._lastUpdateStatus != null;
        }

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The number of Glue Data Processing Units (DPUs) allocated to this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public int? NumberOfNodes
        {
            get { return this._numberOfNodes; }
            set { this._numberOfNodes = value; }
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfWorkers. 
        /// <para>
        /// The number of workers of a defined <c>workerType</c> that are allocated to the development
        /// endpoint.
        /// </para>
        ///  
        /// <para>
        /// The maximum number of workers you can define are 299 for <c>G.1X</c>, and 149 for
        /// <c>G.2X</c>. 
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
        /// Gets and sets the property PrivateAddress. 
        /// <para>
        /// A private IP address to access the <c>DevEndpoint</c> within a VPC if the <c>DevEndpoint</c>
        /// is created within one. The <c>PrivateAddress</c> field is present only when you create
        /// the <c>DevEndpoint</c> within your VPC.
        /// </para>
        /// </summary>
        public string PrivateAddress
        {
            get { return this._privateAddress; }
            set { this._privateAddress = value; }
        }

        // Check to see if PrivateAddress property is set
        internal bool IsSetPrivateAddress()
        {
            return this._privateAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PublicAddress. 
        /// <para>
        /// The public IP address used by this <c>DevEndpoint</c>. The <c>PublicAddress</c> field
        /// is present only when you create a non-virtual private cloud (VPC) <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string PublicAddress
        {
            get { return this._publicAddress; }
            set { this._publicAddress = value; }
        }

        // Check to see if PublicAddress property is set
        internal bool IsSetPublicAddress()
        {
            return this._publicAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key to be used by this <c>DevEndpoint</c> for authentication. This attribute
        /// is provided for backward compatibility because the recommended attribute to use is
        /// public keys.
        /// </para>
        /// </summary>
        public string PublicKey
        {
            get { return this._publicKey; }
            set { this._publicKey = value; }
        }

        // Check to see if PublicKey property is set
        internal bool IsSetPublicKey()
        {
            return this._publicKey != null;
        }

        /// <summary>
        /// Gets and sets the property PublicKeys. 
        /// <para>
        /// A list of public keys to be used by the <c>DevEndpoints</c> for authentication. Using
        /// this attribute is preferred over a single public key because the public keys allow
        /// you to have a different private key per client.
        /// </para>
        ///  <note> 
        /// <para>
        /// If you previously created an endpoint with a public key, you must remove that key
        /// to be able to set a list of public keys. Call the <c>UpdateDevEndpoint</c> API operation
        /// with the public key content in the <c>deletePublicKeys</c> attribute, and the list
        /// of new keys in the <c>addPublicKeys</c> attribute.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=5)]
        public List<string> PublicKeys
        {
            get { return this._publicKeys; }
            set { this._publicKeys = value; }
        }

        // Check to see if PublicKeys property is set
        internal bool IsSetPublicKeys()
        {
            return this._publicKeys != null && (this._publicKeys.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used in this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the <c>SecurityConfiguration</c> structure to be used with this <c>DevEndpoint</c>.
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security group identifiers used in this <c>DevEndpoint</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string Status
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
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID for this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the virtual private cloud (VPC) used by this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

        /// <summary>
        /// Gets and sets the property WorkerType. 
        /// <para>
        /// The type of predefined worker that is allocated to the development endpoint. Accepts
        /// a value of Standard, G.1X, or G.2X.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For the <c>Standard</c> worker type, each worker provides 4 vCPU, 16 GB of memory
        /// and a 50GB disk, and 2 executors per worker.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.1X</c> worker type, each worker maps to 1 DPU (4 vCPU, 16 GB of memory,
        /// 64 GB disk), and provides 1 executor per worker. We recommend this worker type for
        /// memory-intensive jobs.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For the <c>G.2X</c> worker type, each worker maps to 2 DPU (8 vCPU, 32 GB of memory,
        /// 128 GB disk), and provides 1 executor per worker. We recommend this worker type for
        /// memory-intensive jobs.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Known issue: when a development endpoint is created with the <c>G.2X</c> <c>WorkerType</c>
        /// configuration, the Spark drivers for the development endpoint will run on 4 vCPU,
        /// 16 GB of memory, and a 64 GB disk. 
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

        /// <summary>
        /// Gets and sets the property YarnEndpointAddress. 
        /// <para>
        /// The YARN endpoint address used by this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string YarnEndpointAddress
        {
            get { return this._yarnEndpointAddress; }
            set { this._yarnEndpointAddress = value; }
        }

        // Check to see if YarnEndpointAddress property is set
        internal bool IsSetYarnEndpointAddress()
        {
            return this._yarnEndpointAddress != null;
        }

        /// <summary>
        /// Gets and sets the property ZeppelinRemoteSparkInterpreterPort. 
        /// <para>
        /// The Apache Zeppelin port for the remote Apache Spark interpreter.
        /// </para>
        /// </summary>
        public int? ZeppelinRemoteSparkInterpreterPort
        {
            get { return this._zeppelinRemoteSparkInterpreterPort; }
            set { this._zeppelinRemoteSparkInterpreterPort = value; }
        }

        // Check to see if ZeppelinRemoteSparkInterpreterPort property is set
        internal bool IsSetZeppelinRemoteSparkInterpreterPort()
        {
            return this._zeppelinRemoteSparkInterpreterPort.HasValue; 
        }

    }
}