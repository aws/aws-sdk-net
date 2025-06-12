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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The details of an Amazon EC2 instance.
    /// </summary>
    public partial class AwsEc2InstanceDetails
    {
        private string _iamInstanceProfileArn;
        private string _imageId;
        private List<string> _ipV4Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _ipV6Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyName;
        private string _launchedAt;
        private AwsEc2InstanceMetadataOptions _metadataOptions;
        private AwsEc2InstanceMonitoringDetails _monitoring;
        private List<AwsEc2InstanceNetworkInterfacesDetails> _networkInterfaces = AWSConfigs.InitializeCollections ? new List<AwsEc2InstanceNetworkInterfacesDetails>() : null;
        private string _subnetId;
        private string _type;
        private string _virtualizationType;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property IamInstanceProfileArn. 
        /// <para>
        /// The IAM profile ARN of the instance.
        /// </para>
        /// </summary>
        public string IamInstanceProfileArn
        {
            get { return this._iamInstanceProfileArn; }
            set { this._iamInstanceProfileArn = value; }
        }

        // Check to see if IamInstanceProfileArn property is set
        internal bool IsSetIamInstanceProfileArn()
        {
            return this._iamInstanceProfileArn != null;
        }

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The Amazon Machine Image (AMI) ID of the instance.
        /// </para>
        /// </summary>
        public string ImageId
        {
            get { return this._imageId; }
            set { this._imageId = value; }
        }

        // Check to see if ImageId property is set
        internal bool IsSetImageId()
        {
            return this._imageId != null;
        }

        /// <summary>
        /// Gets and sets the property IpV4Addresses. 
        /// <para>
        /// The IPv4 addresses associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpV4Addresses
        {
            get { return this._ipV4Addresses; }
            set { this._ipV4Addresses = value; }
        }

        // Check to see if IpV4Addresses property is set
        internal bool IsSetIpV4Addresses()
        {
            return this._ipV4Addresses != null && (this._ipV4Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpV6Addresses. 
        /// <para>
        /// The IPv6 addresses associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpV6Addresses
        {
            get { return this._ipV6Addresses; }
            set { this._ipV6Addresses = value; }
        }

        // Check to see if IpV6Addresses property is set
        internal bool IsSetIpV6Addresses()
        {
            return this._ipV6Addresses != null && (this._ipV6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The key name associated with the instance.
        /// </para>
        /// </summary>
        public string KeyName
        {
            get { return this._keyName; }
            set { this._keyName = value; }
        }

        // Check to see if KeyName property is set
        internal bool IsSetKeyName()
        {
            return this._keyName != null;
        }

        /// <summary>
        /// Gets and sets the property LaunchedAt. 
        /// <para>
        /// Indicates when the instance was launched.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LaunchedAt
        {
            get { return this._launchedAt; }
            set { this._launchedAt = value; }
        }

        // Check to see if LaunchedAt property is set
        internal bool IsSetLaunchedAt()
        {
            return this._launchedAt != null;
        }

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// Details about the metadata options for the Amazon EC2 instance. 
        /// </para>
        /// </summary>
        public AwsEc2InstanceMetadataOptions MetadataOptions
        {
            get { return this._metadataOptions; }
            set { this._metadataOptions = value; }
        }

        // Check to see if MetadataOptions property is set
        internal bool IsSetMetadataOptions()
        {
            return this._metadataOptions != null;
        }

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        ///  Describes the type of monitoring that’s turned on for an instance. 
        /// </para>
        /// </summary>
        public AwsEc2InstanceMonitoringDetails Monitoring
        {
            get { return this._monitoring; }
            set { this._monitoring = value; }
        }

        // Check to see if Monitoring property is set
        internal bool IsSetMonitoring()
        {
            return this._monitoring != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The identifiers of the network interfaces for the EC2 instance. The details for each
        /// network interface are in a corresponding <c>AwsEc2NetworkInterfacesDetails</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2InstanceNetworkInterfacesDetails> NetworkInterfaces
        {
            get { return this._networkInterfaces; }
            set { this._networkInterfaces = value; }
        }

        // Check to see if NetworkInterfaces property is set
        internal bool IsSetNetworkInterfaces()
        {
            return this._networkInterfaces != null && (this._networkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The identifier of the subnet that the instance was launched in.
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
        /// Gets and sets the property Type. 
        /// <para>
        /// The instance type of the instance. 
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VirtualizationType. 
        /// <para>
        /// The virtualization type of the Amazon Machine Image (AMI) required to launch the instance.
        /// 
        /// </para>
        /// </summary>
        public string VirtualizationType
        {
            get { return this._virtualizationType; }
            set { this._virtualizationType = value; }
        }

        // Check to see if VirtualizationType property is set
        internal bool IsSetVirtualizationType()
        {
            return this._virtualizationType != null;
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that the instance was launched in.
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

    }
}