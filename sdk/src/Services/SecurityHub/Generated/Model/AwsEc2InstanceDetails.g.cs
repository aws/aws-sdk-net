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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The details of an Amazon EC2 instance.
    /// </summary>
    public partial class AwsEc2InstanceDetails
    {
        /// <summary>
        /// Gets and sets the property IamInstanceProfileArn. 
        /// <para>
        /// The IAM profile ARN of the instance.
        /// </para>
        /// </summary>
        public string IamInstanceProfileArn { get; set; }

        /// <summary>
        /// Checks to see if the IamInstanceProfileArn property is set.
        /// </summary>
        internal bool IsSetIamInstanceProfileArn() => this.IamInstanceProfileArn != null;

        /// <summary>
        /// Gets and sets the property ImageId. 
        /// <para>
        /// The Amazon Machine Image (AMI) ID of the instance.
        /// </para>
        /// </summary>
        public string ImageId { get; set; }

        /// <summary>
        /// Checks to see if the ImageId property is set.
        /// </summary>
        internal bool IsSetImageId() => this.ImageId != null;

        /// <summary>
        /// Gets and sets the property IpV4Addresses. 
        /// <para>
        /// The IPv4 addresses associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpV4Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IpV4Addresses property is set.
        /// </summary>
        internal bool IsSetIpV4Addresses() => this.IpV4Addresses != null && (this.IpV4Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property IpV6Addresses. 
        /// <para>
        /// The IPv6 addresses associated with the instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpV6Addresses { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the IpV6Addresses property is set.
        /// </summary>
        internal bool IsSetIpV6Addresses() => this.IpV6Addresses != null && (this.IpV6Addresses.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The key name associated with the instance.
        /// </para>
        /// </summary>
        public string KeyName { get; set; }

        /// <summary>
        /// Checks to see if the KeyName property is set.
        /// </summary>
        internal bool IsSetKeyName() => this.KeyName != null;

        /// <summary>
        /// Gets and sets the property LaunchedAt. 
        /// <para>
        /// Indicates when the instance was launched.
        /// </para>
        ///  
        /// <para>
        /// For more information about the validation and formatting of timestamp fields in Security
        /// Hub CSPM, see <a href="https://docs.aws.amazon.com/securityhub/1.0/APIReference/Welcome.html#timestamps">Timestamps</a>.
        /// </para>
        /// </summary>
        public string LaunchedAt { get; set; }

        /// <summary>
        /// Checks to see if the LaunchedAt property is set.
        /// </summary>
        internal bool IsSetLaunchedAt() => this.LaunchedAt != null;

        /// <summary>
        /// Gets and sets the property MetadataOptions. 
        /// <para>
        /// Details about the metadata options for the Amazon EC2 instance. 
        /// </para>
        /// </summary>
        public AwsEc2InstanceMetadataOptions MetadataOptions { get; set; }

        /// <summary>
        /// Checks to see if the MetadataOptions property is set.
        /// </summary>
        internal bool IsSetMetadataOptions() => this.MetadataOptions != null;

        /// <summary>
        /// Gets and sets the property Monitoring. 
        /// <para>
        ///  Describes the type of monitoring that’s turned on for an instance. 
        /// </para>
        /// </summary>
        public AwsEc2InstanceMonitoringDetails Monitoring { get; set; }

        /// <summary>
        /// Checks to see if the Monitoring property is set.
        /// </summary>
        internal bool IsSetMonitoring() => this.Monitoring != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaces. 
        /// <para>
        /// The identifiers of the network interfaces for the EC2 instance. The details for each
        /// network interface are in a corresponding <c>AwsEc2NetworkInterfacesDetails</c> object.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsEc2InstanceNetworkInterfacesDetails> NetworkInterfaces { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsEc2InstanceNetworkInterfacesDetails>() : null;

        /// <summary>
        /// Checks to see if the NetworkInterfaces property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaces() => this.NetworkInterfaces != null && (this.NetworkInterfaces.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The identifier of the subnet that the instance was launched in.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The instance type of the instance. 
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;

        /// <summary>
        /// Gets and sets the property VirtualizationType. 
        /// <para>
        /// The virtualization type of the Amazon Machine Image (AMI) required to launch the instance.
        /// 
        /// </para>
        /// </summary>
        public string VirtualizationType { get; set; }

        /// <summary>
        /// Checks to see if the VirtualizationType property is set.
        /// </summary>
        internal bool IsSetVirtualizationType() => this.VirtualizationType != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The identifier of the VPC that the instance was launched in.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
