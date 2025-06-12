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
 * Do not modify this file. This file is generated from the dms-2016-01-01.normal.json service model.
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
namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstanceProfile operation.
    /// Creates the instance profile using the specified parameters.
    /// </summary>
    public partial class CreateInstanceProfileRequest : AmazonDatabaseMigrationServiceRequest
    {
        private string _availabilityZone;
        private string _description;
        private string _instanceProfileName;
        private string _kmsKeyArn;
        private string _networkType;
        private bool? _publiclyAccessible;
        private string _subnetGroupIdentifier;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private List<string> _vpcSecurityGroups = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the instance profile will be created. The default value
        /// is a random, system-chosen Availability Zone in the Amazon Web Services Region where
        /// your data provider is created, for examplem <c>us-east-1d</c>.
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
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-friendly description of the instance profile.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// A user-friendly name for the instance profile.
        /// </para>
        /// </summary>
        public string InstanceProfileName
        {
            get { return this._instanceProfileName; }
            set { this._instanceProfileName = value; }
        }

        // Check to see if InstanceProfileName property is set
        internal bool IsSetInstanceProfileName()
        {
            return this._instanceProfileName != null;
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key that is used to encrypt the connection
        /// parameters for the instance profile.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <c>KmsKeyArn</c> parameter, then DMS uses your
        /// default encryption key.
        /// </para>
        ///  
        /// <para>
        /// KMS creates the default encryption key for your Amazon Web Services account. Your
        /// Amazon Web Services account has a different default encryption key for each Amazon
        /// Web Services Region.
        /// </para>
        /// </summary>
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property NetworkType. 
        /// <para>
        /// Specifies the network type for the instance profile. A value of <c>IPV4</c> represents
        /// an instance profile with IPv4 network type and only supports IPv4 addressing. A value
        /// of <c>IPV6</c> represents an instance profile with IPv6 network type and only supports
        /// IPv6 addressing. A value of <c>DUAL</c> represents an instance profile with dual network
        /// type that supports IPv4 and IPv6 addressing.
        /// </para>
        /// </summary>
        public string NetworkType
        {
            get { return this._networkType; }
            set { this._networkType = value; }
        }

        // Check to see if NetworkType property is set
        internal bool IsSetNetworkType()
        {
            return this._networkType != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies the accessibility options for the instance profile. A value of <c>true</c>
        /// represents an instance profile with a public IP address. A value of <c>false</c> represents
        /// an instance profile with a private IP address. The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible
        {
            get { return this._publiclyAccessible; }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SubnetGroupIdentifier. 
        /// <para>
        /// A subnet group to associate with the instance profile.
        /// </para>
        /// </summary>
        public string SubnetGroupIdentifier
        {
            get { return this._subnetGroupIdentifier; }
            set { this._subnetGroupIdentifier = value; }
        }

        // Check to see if SubnetGroupIdentifier property is set
        internal bool IsSetSubnetGroupIdentifier()
        {
            return this._subnetGroupIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the instance profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
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
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// Specifies the VPC security group names to be used with the instance profile. The VPC
        /// security group must work with the VPC containing the instance profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroups
        {
            get { return this._vpcSecurityGroups; }
            set { this._vpcSecurityGroups = value; }
        }

        // Check to see if VpcSecurityGroups property is set
        internal bool IsSetVpcSecurityGroups()
        {
            return this._vpcSecurityGroups != null && (this._vpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}