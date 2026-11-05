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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes a database.
    /// </summary>
    public partial class RelationalDatabase
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database.
        /// </para>
        /// </summary>
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property BackupRetentionEnabled. 
        /// <para>
        /// A Boolean value indicating whether automated backup retention is enabled for the database.
        /// </para>
        /// </summary>
        public bool? BackupRetentionEnabled { get; set; }

        /// <summary>
        /// Checks to see if the BackupRetentionEnabled property is set.
        /// </summary>
        internal bool IsSetBackupRetentionEnabled() => this.BackupRetentionEnabled.HasValue;

        /// <summary>
        /// Gets and sets the property CaCertificateIdentifier. 
        /// <para>
        /// The certificate associated with the database.
        /// </para>
        /// </summary>
        public string CaCertificateIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the CaCertificateIdentifier property is set.
        /// </summary>
        internal bool IsSetCaCertificateIdentifier() => this.CaCertificateIdentifier != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the database was created. Formatted in Unix time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database software (for example, <c>MySQL</c>).
        /// </para>
        /// </summary>
        public string Engine { get; set; }

        /// <summary>
        /// Checks to see if the Engine property is set.
        /// </summary>
        internal bool IsSetEngine() => this.Engine != null;

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version (for example, <c>5.7.23</c>).
        /// </para>
        /// </summary>
        public string EngineVersion { get; set; }

        /// <summary>
        /// Checks to see if the EngineVersion property is set.
        /// </summary>
        internal bool IsSetEngineVersion() => this.EngineVersion != null;

        /// <summary>
        /// Gets and sets the property Hardware. 
        /// <para>
        /// Describes the hardware of the database.
        /// </para>
        /// </summary>
        public RelationalDatabaseHardware Hardware { get; set; }

        /// <summary>
        /// Checks to see if the Hardware property is set.
        /// </summary>
        internal bool IsSetHardware() => this.Hardware != null;

        /// <summary>
        /// Gets and sets the property LatestRestorableTime. 
        /// <para>
        /// The latest point in time to which the database can be restored. Formatted in Unix
        /// time.
        /// </para>
        /// </summary>
        public DateTime? LatestRestorableTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestRestorableTime property is set.
        /// </summary>
        internal bool IsSetLatestRestorableTime() => this.LatestRestorableTime.HasValue;

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Region name and Availability Zone where the database is located.
        /// </para>
        /// </summary>
        public ResourceLocation Location { get; set; }

        /// <summary>
        /// Checks to see if the Location property is set.
        /// </summary>
        internal bool IsSetLocation() => this.Location != null;

        /// <summary>
        /// Gets and sets the property MasterDatabaseName. 
        /// <para>
        /// The name of the master database created when the Lightsail database resource is created.
        /// </para>
        /// </summary>
        public string MasterDatabaseName { get; set; }

        /// <summary>
        /// Checks to see if the MasterDatabaseName property is set.
        /// </summary>
        internal bool IsSetMasterDatabaseName() => this.MasterDatabaseName != null;

        /// <summary>
        /// Gets and sets the property MasterEndpoint. 
        /// <para>
        /// The master endpoint for the database.
        /// </para>
        /// </summary>
        public RelationalDatabaseEndpoint MasterEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the MasterEndpoint property is set.
        /// </summary>
        internal bool IsSetMasterEndpoint() => this.MasterEndpoint != null;

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master user name of the database.
        /// </para>
        /// </summary>
        public string MasterUsername { get; set; }

        /// <summary>
        /// Checks to see if the MasterUsername property is set.
        /// </summary>
        internal bool IsSetMasterUsername() => this.MasterUsername != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the database resource in Lightsail.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParameterApplyStatus. 
        /// <para>
        /// The status of parameter updates for the database.
        /// </para>
        /// </summary>
        public string ParameterApplyStatus { get; set; }

        /// <summary>
        /// Checks to see if the ParameterApplyStatus property is set.
        /// </summary>
        internal bool IsSetParameterApplyStatus() => this.ParameterApplyStatus != null;

        /// <summary>
        /// Gets and sets the property PendingMaintenanceActions. 
        /// <para>
        /// Describes the pending maintenance actions for the database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PendingMaintenanceAction> PendingMaintenanceActions { get; set; } = AWSConfigs.InitializeCollections ? new List<PendingMaintenanceAction>() : null;

        /// <summary>
        /// Checks to see if the PendingMaintenanceActions property is set.
        /// </summary>
        internal bool IsSetPendingMaintenanceActions() => this.PendingMaintenanceActions != null && (this.PendingMaintenanceActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Describes pending database value modifications.
        /// </para>
        /// </summary>
        public PendingModifiedRelationalDatabaseValues PendingModifiedValues { get; set; }

        /// <summary>
        /// Checks to see if the PendingModifiedValues property is set.
        /// </summary>
        internal bool IsSetPendingModifiedValues() => this.PendingModifiedValues != null;

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The daily time range during which automated backups are created for the database (for
        /// example, <c>16:00-16:30</c>).
        /// </para>
        /// </summary>
        public string PreferredBackupWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredBackupWindow property is set.
        /// </summary>
        internal bool IsSetPreferredBackupWindow() => this.PreferredBackupWindow != null;

        /// <summary>
        /// Gets and sets the property PreferredMaintenanceWindow. 
        /// <para>
        /// The weekly time range during which system maintenance can occur on the database.
        /// </para>
        ///  
        /// <para>
        /// In the format <c>ddd:hh24:mi-ddd:hh24:mi</c>. For example, <c>Tue:17:00-Tue:17:30</c>.
        /// </para>
        /// </summary>
        public string PreferredMaintenanceWindow { get; set; }

        /// <summary>
        /// Checks to see if the PreferredMaintenanceWindow property is set.
        /// </summary>
        internal bool IsSetPreferredMaintenanceWindow() => this.PreferredMaintenanceWindow != null;

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// A Boolean value indicating whether the database is publicly accessible.
        /// </para>
        /// </summary>
        public bool? PubliclyAccessible { get; set; }

        /// <summary>
        /// Checks to see if the PubliclyAccessible property is set.
        /// </summary>
        internal bool IsSetPubliclyAccessible() => this.PubliclyAccessible.HasValue;

        /// <summary>
        /// Gets and sets the property RelationalDatabaseBlueprintId. 
        /// <para>
        /// The blueprint ID for the database. A blueprint describes the major engine version
        /// of a database.
        /// </para>
        /// </summary>
        public string RelationalDatabaseBlueprintId { get; set; }

        /// <summary>
        /// Checks to see if the RelationalDatabaseBlueprintId property is set.
        /// </summary>
        internal bool IsSetRelationalDatabaseBlueprintId() => this.RelationalDatabaseBlueprintId != null;

        /// <summary>
        /// Gets and sets the property RelationalDatabaseBundleId. 
        /// <para>
        /// The bundle ID for the database. A bundle describes the performance specifications
        /// for your database.
        /// </para>
        /// </summary>
        public string RelationalDatabaseBundleId { get; set; }

        /// <summary>
        /// Checks to see if the RelationalDatabaseBundleId property is set.
        /// </summary>
        internal bool IsSetRelationalDatabaseBundleId() => this.RelationalDatabaseBundleId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type for the database (for example, <c>RelationalDatabase</c>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SecondaryAvailabilityZone. 
        /// <para>
        /// Describes the secondary Availability Zone of a high availability database.
        /// </para>
        ///  
        /// <para>
        /// The secondary database is used for failover support of a high availability database.
        /// </para>
        /// </summary>
        public string SecondaryAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SecondaryAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSecondaryAvailabilityZone() => this.SecondaryAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Describes the current state of the database.
        /// </para>
        /// </summary>
        public string State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code for the database. Include this code in your email to support when
        /// you have questions about a database in Lightsail. This code enables our support team
        /// to look up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode { get; set; }

        /// <summary>
        /// Checks to see if the SupportCode property is set.
        /// </summary>
        internal bool IsSetSupportCode() => this.SupportCode != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
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
    }
}
