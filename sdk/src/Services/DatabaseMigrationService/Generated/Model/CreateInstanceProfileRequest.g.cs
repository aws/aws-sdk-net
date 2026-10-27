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

namespace Amazon.DatabaseMigrationService.Model
{
    /// <summary>
    /// Container for the parameters to the CreateInstanceProfile operation. Creates the instance
    /// profile using the specified parameters. <para> <b>Required permissions:</b> <c>dms:CreateInstanceProfile</c>.
    /// For more information, see <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsdatabasemigrationservice.html">Actions,
    /// resources, and condition keys for Database Migration Service</a>. </para>
    /// </summary>
    public partial class CreateInstanceProfileRequest : AmazonDatabaseMigrationServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone where the instance profile will be created. The default value
        /// is a random, system-chosen Availability Zone in the Amazon Web Services Region where
        /// your data provider is created, for examplem <c>us-east-1d</c>.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A user-friendly description of the instance profile.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property InstanceProfileName. 
        /// <para>
        /// A user-friendly name for the instance profile.
        /// </para>
        /// </summary>
        public string InstanceProfileName { get; set; }

        /// <summary>
        /// Checks to see if the InstanceProfileName property is set.
        /// </summary>
        internal bool IsSetInstanceProfileName() => this.InstanceProfileName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key that is used to encrypt the connection
        /// parameters for the instance profile.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a value for the <c>KmsKeyArn</c> parameter, then DMS uses an
        /// Amazon Web Services owned encryption key to encrypt your resources.
        /// </para>
        /// </summary>
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

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
        public string NetworkType { get; set; }

        /// <summary>
        /// Checks to see if the NetworkType property is set.
        /// </summary>
        internal bool IsSetNetworkType() => this.NetworkType != null;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// Specifies the accessibility options for the instance profile. A value of <c>true</c>
        /// represents an instance profile with a public IP address. A value of <c>false</c> represents
        /// an instance profile with a private IP address. The default value is <c>true</c>.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property SubnetGroupIdentifier. 
        /// <para>
        /// A subnet group to associate with the instance profile.
        /// </para>
        /// </summary>
        public string SubnetGroupIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SubnetGroupIdentifier property is set.
        /// </summary>
        internal bool IsSetSubnetGroupIdentifier() => this.SubnetGroupIdentifier != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to be assigned to the instance profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcSecurityGroups. 
        /// <para>
        /// Specifies the VPC security group names to be used with the instance profile. The VPC
        /// security group must work with the VPC containing the instance profile.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpcSecurityGroups { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpcSecurityGroups property is set.
        /// </summary>
        internal bool IsSetVpcSecurityGroups() => this.VpcSecurityGroups != null && (this.VpcSecurityGroups.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
