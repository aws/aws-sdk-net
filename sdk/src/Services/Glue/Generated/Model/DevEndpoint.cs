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
    /// A development endpoint where a developer can remotely debug ETL scripts.
    /// </summary>
    public partial class DevEndpoint
    {
        private string _availabilityZone;
        private DateTime? _createdTimestamp;
        private string _endpointName;
        private string _extraJarsS3Path;
        private string _extraPythonLibsS3Path;
        private string _failureReason;
        private DateTime? _lastModifiedTimestamp;
        private string _lastUpdateStatus;
        private int? _numberOfNodes;
        private string _privateAddress;
        private string _publicAddress;
        private string _publicKey;
        private string _roleArn;
        private List<string> _securityGroupIds = new List<string>();
        private string _status;
        private string _subnetId;
        private string _vpcId;
        private string _yarnEndpointAddress;
        private int? _zeppelinRemoteSparkInterpreterPort;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The AWS availability zone where this DevEndpoint is located.
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
        public DateTime CreatedTimestamp
        {
            get { return this._createdTimestamp.GetValueOrDefault(); }
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
        /// The name of the DevEndpoint.
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
        /// Path to one or more Java Jars in an S3 bucket that should be loaded in your DevEndpoint.
        /// </para>
        ///  
        /// <para>
        /// Please note that only pure Java/Scala libraries can currently be used on a DevEndpoint.
        /// </para>
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
        /// Path(s) to one or more Python libraries in an S3 bucket that should be loaded in your
        /// DevEndpoint. Multiple values must be complete paths separated by a comma.
        /// </para>
        ///  
        /// <para>
        /// Please note that only pure Python libraries can currently be used on a DevEndpoint.
        /// Libraries that rely on C extensions, such as the <a href="http://pandas.pydata.org/">pandas</a>
        /// Python data analysis library, are not yet supported.
        /// </para>
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
        /// The reason for a current failure in this DevEndpoint.
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
        /// Gets and sets the property LastModifiedTimestamp. 
        /// <para>
        /// The point in time at which this DevEndpoint was last modified.
        /// </para>
        /// </summary>
        public DateTime LastModifiedTimestamp
        {
            get { return this._lastModifiedTimestamp.GetValueOrDefault(); }
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
        /// The number of AWS Glue Data Processing Units (DPUs) allocated to this DevEndpoint.
        /// </para>
        /// </summary>
        public int NumberOfNodes
        {
            get { return this._numberOfNodes.GetValueOrDefault(); }
            set { this._numberOfNodes = value; }
        }

        // Check to see if NumberOfNodes property is set
        internal bool IsSetNumberOfNodes()
        {
            return this._numberOfNodes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateAddress. 
        /// <para>
        /// The private address used by this DevEndpoint.
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
        /// The public VPC address used by this DevEndpoint.
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
        /// The public key to be used by this DevEndpoint for authentication.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The AWS ARN of the IAM role used in this DevEndpoint.
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
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// A list of security group identifiers used in this DevEndpoint.
        /// </para>
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && this._securityGroupIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of this DevEndpoint.
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
        /// The subnet ID for this DevEndpoint.
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
        /// The ID of the virtual private cloud (VPC) used by this DevEndpoint.
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
        /// Gets and sets the property YarnEndpointAddress. 
        /// <para>
        /// The YARN endpoint address used by this DevEndpoint.
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
        public int ZeppelinRemoteSparkInterpreterPort
        {
            get { return this._zeppelinRemoteSparkInterpreterPort.GetValueOrDefault(); }
            set { this._zeppelinRemoteSparkInterpreterPort = value; }
        }

        // Check to see if ZeppelinRemoteSparkInterpreterPort property is set
        internal bool IsSetZeppelinRemoteSparkInterpreterPort()
        {
            return this._zeppelinRemoteSparkInterpreterPort.HasValue; 
        }

    }
}