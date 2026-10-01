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
    /// Changes to a DB instance that are currently pending.
    /// </summary>
    public partial class AwsRdsDbPendingModifiedValues
    {
        /// <summary>
        /// Gets and sets the property AllocatedStorage. 
        /// <para>
        /// The new value of the allocated storage for the DB instance.
        /// </para>
        /// </summary>
        public int? AllocatedStorage { get; set; }

        /// <summary>
        /// Checks to see if the AllocatedStorage property is set.
        /// </summary>
        internal bool IsSetAllocatedStorage() => this.AllocatedStorage.HasValue;

        /// <summary>
        /// Gets and sets the property BackupRetentionPeriod. 
        /// <para>
        /// The new backup retention period for the DB instance.
        /// </para>
        /// </summary>
        public int? BackupRetentionPeriod { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionPeriod property is set.
        /// </summary>
        internal bool IsSetBackupRetentionPeriod() => this.BackupRetentionPeriod.HasValue;

        /// <summary>
        /// Gets and sets the property CaCertificateIdentifier. 
        /// <para>
        /// The new CA certificate identifier for the DB instance.
        /// </para>
        /// </summary>
        public string CaCertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CaCertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCaCertificateIdentifier() => this.CaCertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbInstanceClass. 
        /// <para>
        /// The new DB instance class for the DB instance.
        /// </para>
        /// </summary>
        public string DbInstanceClass { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceClass property is set.
        /// </summary>
        internal bool IsSetDbInstanceClass() => this.DbInstanceClass != null;

        /// <summary>
        /// Gets and sets the property DbInstanceIdentifier. 
        /// <para>
        /// The new DB instance identifier for the DB instance.
        /// </para>
        /// </summary>
        public string DbInstanceIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DbInstanceIdentifier property is set.
        /// </summary>
        internal bool IsSetDbInstanceIdentifier() => this.DbInstanceIdentifier != null;

        /// <summary>
        /// Gets and sets the property DbSubnetGroupName. 
        /// <para>
        /// The name of the new subnet group for the DB instance.
        /// </para>
        /// </summary>
        public string DbSubnetGroupName { get; set; }

        /// <summary>
        /// Checks to see if the DbSubnetGroupName property is set.
        /// </summary>
        internal bool IsSetDbSubnetGroupName() => this.DbSubnetGroupName != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The new engine version for the DB instance.
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property Iops. 
        /// <para>
        /// The new provisioned IOPS value for the DB instance.
        /// </para>
        /// </summary>
        public int? Iops { get; set; }

        /// <summary>
        /// Checks to see if the Iops property is set.
        /// </summary>
        internal bool IsSetIops() => this.Iops.HasValue;

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        /// The new license model value for the DB instance.
        /// </para>
        /// </summary>
        public string LicenseModel { get; set; }

        /// <summary>
        /// Checks to see if the LicenseModel property is set.
        /// </summary>
        internal bool IsSetLicenseModel() => this.LicenseModel != null;

        /// <summary>
        /// Gets and sets the property MasterUserPassword. 
        /// <para>
        /// The new master user password for the DB instance.
        /// </para>
        /// </summary>
        public string MasterUserPassword { get; set; }

        /// <summary>
        /// Checks to see if the MasterUserPassword property is set.
        /// </summary>
        internal bool IsSetMasterUserPassword() => this.MasterUserPassword != null;

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        /// Indicates that a single Availability Zone DB instance is changing to a multiple Availability
        /// Zone deployment.
        /// </para>
        /// </summary>
        public bool? MultiAZ { get; set; }

        /// <summary>
        /// Checks to see if the MultiAZ property is set.
        /// </summary>
        internal bool IsSetMultiAZ() => this.MultiAZ.HasValue;

        /// <summary>
        /// Gets and sets the property PendingCloudWatchLogsExports. 
        /// <para>
        /// A list of log types that are being enabled or disabled.
        /// </para>
        /// </summary>
        public AwsRdsPendingCloudWatchLogsExports PendingCloudWatchLogsExports { get; set; }

        /// <summary>
        /// Checks to see if the PendingCloudWatchLogsExports property is set.
        /// </summary>
        internal bool IsSetPendingCloudWatchLogsExports() => this.PendingCloudWatchLogsExports != null;

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        /// The new port for the DB instance.
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
        /// Processor features that are being updated.
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
        /// Gets and sets the property StorageType. 
        /// <para>
        /// The new storage type for the DB instance.
        /// </para>
        /// </summary>
        public string StorageType { get; set; }

        /// <summary>
        /// Checks to see if the StorageType property is set.
        /// </summary>
        internal bool IsSetStorageType() => this.StorageType != null;
    }
}
