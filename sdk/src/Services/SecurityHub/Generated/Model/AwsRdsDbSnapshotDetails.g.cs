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
    /// Provides details about an Amazon RDS DB cluster snapshot.
    /// </summary>
    public partial class AwsRdsDbSnapshotDetails
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The amount of storage (in gigabytes) to be initially allocated for the database instance.
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// Specifies the name of the Availability Zone in which the DB instance was located at
        /// the time of the DB snapshot.
        /// </para>
        /// </summary>
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property DbInstanceIdentifier. 
        /// <para>
        /// A name for the DB instance.
        /// </para>
        /// </summary>
        public string DbInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDbInstanceIdentifier() => this.DbInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbSnapshotIdentifier. 
        /// <para>
        /// The name or ARN of the DB snapshot that is used to restore the DB instance.
        /// </para>
        /// </summary>
        public string DbSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetDbSnapshotIdentifier() => this.DbSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbiResourceId. 
        /// <para>
        /// The identifier for the source DB instance.
        /// </para>
        /// </summary>
        public string DbiResourceId { get; set; }

        /// <summary>
        /// Checks to see if the DbiResourceId property is set.
        /// </summary>
        internal bool IsSetDbiResourceId() => this.DbiResourceId != null;

        /// <summary>
        /// Gets and sets the property Encrypted. 
        /// <para>
        /// Whether the DB snapshot is encrypted.
        /// </para>
        /// </summary>
        public bool? Encrypted { get; set; }

        /// <summary>
        /// Checks to see if the Encrypted property is set.
        /// </summary>
        internal bool IsSetEncrypted() => this.Encrypted.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The name of the database engine to use for this DB instance. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>aurora</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>aurora-postgresql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>c</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mariadb</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>mysql</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>oracle-se2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ee</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-ex</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-se</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>sqlserver-web</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The version of the database engine.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property IamDatabaseAuthenticationEnabled. 
        /// <para>
        /// Whether mapping of IAM accounts to database accounts is enabled.
        /// </para>
        /// </summary>
        public bool? IamDatabaseAuthenticationEnabled { get; set; }

        /// <summary>
        /// Checks to see if the IamDatabaseAuthenticationEnabled property is set.
        /// </summary>
        internal bool IsSetIamDatabaseAuthenticationEnabled() => this.IamDatabaseAuthenticationEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property InstanceCreateTime. 
        /// <para>
        /// Specifies the time in Coordinated Universal Time (UTC) when the DB instance, from
        /// which the snapshot was taken, was created.
        /// </para>
        /// </summary>
        public string InstanceCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the InstanceCreateTime property is set.
        /// </summary>
        internal bool IsSetInstanceCreateTime() => this.InstanceCreateTime != null;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The provisioned IOPS (I/O operations per second) value of the DB instance at the time
        /// of the snapshot.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// If <c>Encrypted</c> is <c>true</c>, the KMS key identifier for the encrypted DB snapshot.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// License model information for the restored DB instance.
        /// </para>
        /// </summary>
        public string LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master user name for the DB snapshot.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The option group name for the DB snapshot.
        /// </para>
        /// </summary>
        public string OptionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the OptionGroupName property is set.
        /// </summary>
        internal bool IsSetOptionGroupName() => this.OptionGroupName != null;

        /// <summary>
        /// Gets and sets the property PercentProgress. 
        /// <para>
        /// The percentage of the estimated data that has been transferred.
        /// </para>
        /// </summary>
        public int? PercentProgress { get; set; }

        /// <summary>
        /// Checks to see if the PercentProgress property is set.
        /// </summary>
        internal bool IsSetPercentProgress() => this.PercentProgress.HasValue;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The port that the database engine was listening on at the time of the snapshot.
        /// </para>
        /// </summary>
        public int? Port { get; set; }

        /// <summary>
        /// Checks to see if the Port property is set.
        /// </summary>
        internal bool IsSetPort() => this.Port.HasValue;

        /// <summary>
        /// Gets and sets the property ProcessorFeatures. 
        /// <para>
        /// The number of CPU cores and the number of threads per core for the DB instance class
        /// of the DB instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AwsRdsDbProcessorFeature> ProcessorFeatures { get; set; } = AWSConfigs.InitializeCollections ? new List<AwsRdsDbProcessorFeature>() : null;

        /// <summary>
        /// Checks to see if the ProcessorFeatures property is set.
        /// </summary>
        internal bool IsSetProcessorFeatures() => this.ProcessorFeatures != null && (this.ProcessorFeatures.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SnapshotCreateTime. 
        /// <para>
        /// When the snapshot was taken in Coordinated Universal Time (UTC).
        /// </para>
        /// </summary>
        public string SnapshotCreateTime { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotCreateTime property is set.
        /// </summary>
        internal bool IsSetSnapshotCreateTime() => this.SnapshotCreateTime != null;

        /// <summary>
        /// Gets and sets the property SnapshotType. 
        /// <para>
        /// The type of the DB snapshot.
        /// </para>
        /// </summary>
        public string SnapshotType { get; set; }

        /// <summary>
        /// Checks to see if the SnapshotType property is set.
        /// </summary>
        internal bool IsSetSnapshotType() => this.SnapshotType != null;

        /// <summary>
        /// Gets and sets the property SourceDbSnapshotIdentifier. 
        /// <para>
        /// The DB snapshot ARN that the DB snapshot was copied from.
        /// </para>
        /// </summary>
        public string SourceDbSnapshotIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SourceDbSnapshotIdentifier property is set.
        /// </summary>
        internal bool IsSetSourceDbSnapshotIdentifier() => this.SourceDbSnapshotIdentifier != null;

        /// <summary>
        /// Gets and sets the property SourceRegion. 
        /// <para>
        /// The Amazon Web Services Region that the DB snapshot was created in or copied from.
        /// </para>
        /// </summary>
        public string SourceRegion { get; set; }

        /// <summary>
        /// Checks to see if the SourceRegion property is set.
        /// </summary>
        internal bool IsSetSourceRegion() => this.SourceRegion != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of this DB snapshot.
        /// </para>
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The storage type associated with the DB snapshot. Valid values are as follows:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>gp2</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>io1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>standard</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;

        /// <summary>
        /// Gets and sets the property TdeCredentialArn. 
        /// <para>
        /// The ARN from the key store with which to associate the instance for TDE encryption.
        /// </para>
        /// </summary>
        public string TdeCredentialArn { get; set; }

        /// <summary>
        /// Checks to see if the TdeCredentialArn property is set.
        /// </summary>
        internal bool IsSetTdeCredentialArn() => this.TdeCredentialArn != null;

        /// <summary>
        /// Gets and sets the property Timezone. 
        /// <para>
        /// The time zone of the DB snapshot.
        /// </para>
        /// </summary>
        public string Timezone { get; set; }

        /// <summary>
        /// Checks to see if the Timezone property is set.
        /// </summary>
        internal bool IsSetTimezone() => this.Timezone != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID associated with the DB snapshot.
        /// </para>
        /// </summary>
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
