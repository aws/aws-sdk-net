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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// Details of the Amazon EC2 instance involved in a finding.
    /// </summary>
    public partial class AwsEc2InstanceDetails
    {
        private string _iamInstanceProfileArn;
        private string _imageId;
        private List<string> _ipv4Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _ipv6Addresses = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _keyName;
        private DateTime? _launchedAt;
        private string _platform;
        private string _subnetId;
        private string _type;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property IamInstanceProfileArn. 
        /// <para>
        /// The IAM instance profile ARN of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The image ID of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The IPv4 addresses of the Amazon EC2 instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpV4Addresses
        {
            get { return this._ipv4Addresses; }
            set { this._ipv4Addresses = value; }
        }

        // Check to see if IpV4Addresses property is set
        internal bool IsSetIpV4Addresses()
        {
            return this._ipv4Addresses != null && (this._ipv4Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IpV6Addresses. 
        /// <para>
        /// The IPv6 addresses of the Amazon EC2 instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> IpV6Addresses
        {
            get { return this._ipv6Addresses; }
            set { this._ipv6Addresses = value; }
        }

        // Check to see if IpV6Addresses property is set
        internal bool IsSetIpV6Addresses()
        {
            return this._ipv6Addresses != null && (this._ipv6Addresses.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KeyName. 
        /// <para>
        /// The name of the key pair used to launch the Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The date and time the Amazon EC2 instance was launched at.
        /// </para>
        /// </summary>
        public DateTime? LaunchedAt
        {
            get { return this._launchedAt; }
            set { this._launchedAt = value; }
        }

        // Check to see if LaunchedAt property is set
        internal bool IsSetLaunchedAt()
        {
            return this._launchedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Platform. 
        /// <para>
        /// The platform of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string Platform
        {
            get { return this._platform; }
            set { this._platform = value; }
        }

        // Check to see if Platform property is set
        internal bool IsSetPlatform()
        {
            return this._platform != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// The type of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID of the Amazon EC2 instance.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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