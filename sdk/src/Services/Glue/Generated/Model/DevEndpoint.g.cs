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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> Arguments { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Arguments property is set.
        /// </summary>
        internal bool IsSetArguments() => this.Arguments != null && (this.Arguments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Amazon Web Services Availability Zone where this <c>DevEndpoint</c> is located.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The point in time at which this DevEndpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the CreatedTimestamp property is set.
        /// </summary>
        internal bool IsSetCreatedTimestamp() => this.CreatedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property EndpointName. 
        /// <para>
        /// The name of the <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string EndpointName { get; set; }

        /// <summary>
        /// Checks to see if the EndpointName property is set.
        /// </summary>
        internal bool IsSetEndpointName() => this.EndpointName != null;

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
        public string ExtraJarsS3Path { get; set; }

        /// <summary>
        /// Checks to see if the ExtraJarsS3Path property is set.
        /// </summary>
        internal bool IsSetExtraJarsS3Path() => this.ExtraJarsS3Path != null;

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
        public string ExtraPythonLibsS3Path { get; set; }

        /// <summary>
        /// Checks to see if the ExtraPythonLibsS3Path property is set.
        /// </summary>
        internal bool IsSetExtraPythonLibsS3Path() => this.ExtraPythonLibsS3Path != null;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason for a current failure in this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

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
        [AWSProperty(Min = 1, Max = 255)]
        public string GlueVersion { get; set; }

        /// <summary>
        /// Checks to see if the GlueVersion property is set.
        /// </summary>
        internal bool IsSetGlueVersion() => this.GlueVersion != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The point in time at which this <c>DevEndpoint</c> was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimestamp { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimestamp property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimestamp() => this.LastModifiedTimestamp.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdateStatus. 
        /// <para>
        /// The status of the last update.
        /// </para>
        /// </summary>
        public string LastUpdateStatus { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdateStatus property is set.
        /// </summary>
        internal bool IsSetLastUpdateStatus() => this.LastUpdateStatus != null;

        /// <summary>
        /// Gets and sets the property NumberOfNodes. 
        /// <para>
        /// The number of Glue Data Processing Units (DPUs) allocated to this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public int? NumberOfNodes { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfNodes property is set.
        /// </summary>
        internal bool IsSetNumberOfNodes() => this.NumberOfNodes.HasValue;

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
        public int? NumberOfWorkers { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfWorkers property is set.
        /// </summary>
        internal bool IsSetNumberOfWorkers() => this.NumberOfWorkers.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateAddress. 
        /// <para>
        /// A private IP address to access the <c>DevEndpoint</c> within a VPC if the <c>DevEndpoint</c>
        /// is created within one. The <c>PrivateAddress</c> field is present only when you create
        /// the <c>DevEndpoint</c> within your VPC.
        /// </para>
        /// </summary>
        public string PrivateAddress { get; set; }

        /// <summary>
        /// Checks to see if the PrivateAddress property is set.
        /// </summary>
        internal bool IsSetPrivateAddress() => this.PrivateAddress != null;

        /// <summary>
        /// Gets and sets the property PublicAddress. 
        /// <para>
        /// The public IP address used by this <c>DevEndpoint</c>. The <c>PublicAddress</c> field
        /// is present only when you create a non-virtual private cloud (VPC) <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string PublicAddress { get; set; }

        /// <summary>
        /// Checks to see if the PublicAddress property is set.
        /// </summary>
        internal bool IsSetPublicAddress() => this.PublicAddress != null;

        /// <summary>
        /// Gets and sets the property PublicKey. 
        /// <para>
        /// The public key to be used by this <c>DevEndpoint</c> for authentication. This attribute
        /// is provided for backward compatibility because the recommended attribute to use is
        /// public keys.
        /// </para>
        /// </summary>
        public string PublicKey { get; set; }

        /// <summary>
        /// Checks to see if the PublicKey property is set.
        /// </summary>
        internal bool IsSetPublicKey() => this.PublicKey != null;

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 5)]
        public List<string> PublicKeys { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PublicKeys property is set.
        /// </summary>
        internal bool IsSetPublicKeys() => this.PublicKeys != null && (this.PublicKeys.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used in this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property SecurityConfiguration. 
        /// <para>
        /// The name of the <c>SecurityConfiguration</c> structure to be used with this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string SecurityConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the SecurityConfiguration property is set.
        /// </summary>
        internal bool IsSetSecurityConfiguration() => this.SecurityConfiguration != null;

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security group identifiers used in this <c>DevEndpoint</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SecurityGroupIds property is set.
        /// </summary>
        internal bool IsSetSecurityGroupIds() => this.SecurityGroupIds != null && (this.SecurityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID for this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the virtual private cloud (VPC) used by this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;

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
        public WorkerType WorkerType { get; set; }

        /// <summary>
        /// Checks to see if the WorkerType property is set.
        /// </summary>
        internal bool IsSetWorkerType() => this.WorkerType != null;

        /// <summary>
        /// Gets and sets the property YarnEndpointAddress. 
        /// <para>
        /// The YARN endpoint address used by this <c>DevEndpoint</c>.
        /// </para>
        /// </summary>
        public string YarnEndpointAddress { get; set; }

        /// <summary>
        /// Checks to see if the YarnEndpointAddress property is set.
        /// </summary>
        internal bool IsSetYarnEndpointAddress() => this.YarnEndpointAddress != null;

        /// <summary>
        /// Gets and sets the property ZeppelinRemoteSparkInterpreterPort. 
        /// <para>
        /// The Apache Zeppelin port for the remote Apache Spark interpreter.
        /// </para>
        /// </summary>
        public int? ZeppelinRemoteSparkInterpreterPort { get; set; }

        /// <summary>
        /// Checks to see if the ZeppelinRemoteSparkInterpreterPort property is set.
        /// </summary>
        internal bool IsSetZeppelinRemoteSparkInterpreterPort() => this.ZeppelinRemoteSparkInterpreterPort.HasValue;
    }
}
