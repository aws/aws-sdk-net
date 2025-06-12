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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
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
        private string _arn;
        private bool? _backupRetentionEnabled;
        private string _caCertificateIdentifier;
        private DateTime? _createdAt;
        private string _engine;
        private string _engineVersion;
        private RelationalDatabaseHardware _hardware;
        private DateTime? _latestRestorableTime;
        private ResourceLocation _location;
        private string _masterDatabaseName;
        private RelationalDatabaseEndpoint _masterEndpoint;
        private string _masterUsername;
        private string _name;
        private string _parameterApplyStatus;
        private List<PendingMaintenanceAction> _pendingMaintenanceActions = AWSConfigs.InitializeCollections ? new List<PendingMaintenanceAction>() : null;
        private PendingModifiedRelationalDatabaseValues _pendingModifiedValues;
        private string _preferredBackupWindow;
        private string _preferredMaintenanceWindow;
        private bool? _publiclyAccessible;
        private string _relationalDatabaseBlueprintId;
        private string _relationalDatabaseBundleId;
        private ResourceType _resourceType;
        private string _secondaryAvailabilityZone;
        private string _state;
        private string _supportCode;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the database.
        /// </para>
        /// </summary>
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BackupRetentionEnabled. 
        /// <para>
        /// A Boolean value indicating whether automated backup retention is enabled for the database.
        /// </para>
        /// </summary>
        public bool? BackupRetentionEnabled
        {
            get { return this._backupRetentionEnabled; }
            set { this._backupRetentionEnabled = value; }
        }

        // Check to see if BackupRetentionEnabled property is set
        internal bool IsSetBackupRetentionEnabled()
        {
            return this._backupRetentionEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CaCertificateIdentifier. 
        /// <para>
        /// The certificate associated with the database.
        /// </para>
        /// </summary>
        public string CaCertificateIdentifier
        {
            get { return this._caCertificateIdentifier; }
            set { this._caCertificateIdentifier = value; }
        }

        // Check to see if CaCertificateIdentifier property is set
        internal bool IsSetCaCertificateIdentifier()
        {
            return this._caCertificateIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the database was created. Formatted in Unix time.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        /// The database software (for example, <c>MySQL</c>).
        /// </para>
        /// </summary>
        public string Engine
        {
            get { return this._engine; }
            set { this._engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this._engine != null;
        }

        /// <summary>
        /// Gets and sets the property EngineVersion. 
        /// <para>
        /// The database engine version (for example, <c>5.7.23</c>).
        /// </para>
        /// </summary>
        public string EngineVersion
        {
            get { return this._engineVersion; }
            set { this._engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this._engineVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Hardware. 
        /// <para>
        /// Describes the hardware of the database.
        /// </para>
        /// </summary>
        public RelationalDatabaseHardware Hardware
        {
            get { return this._hardware; }
            set { this._hardware = value; }
        }

        // Check to see if Hardware property is set
        internal bool IsSetHardware()
        {
            return this._hardware != null;
        }

        /// <summary>
        /// Gets and sets the property LatestRestorableTime. 
        /// <para>
        /// The latest point in time to which the database can be restored. Formatted in Unix
        /// time.
        /// </para>
        /// </summary>
        public DateTime? LatestRestorableTime
        {
            get { return this._latestRestorableTime; }
            set { this._latestRestorableTime = value; }
        }

        // Check to see if LatestRestorableTime property is set
        internal bool IsSetLatestRestorableTime()
        {
            return this._latestRestorableTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The Region name and Availability Zone where the database is located.
        /// </para>
        /// </summary>
        public ResourceLocation Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property MasterDatabaseName. 
        /// <para>
        /// The name of the master database created when the Lightsail database resource is created.
        /// </para>
        /// </summary>
        public string MasterDatabaseName
        {
            get { return this._masterDatabaseName; }
            set { this._masterDatabaseName = value; }
        }

        // Check to see if MasterDatabaseName property is set
        internal bool IsSetMasterDatabaseName()
        {
            return this._masterDatabaseName != null;
        }

        /// <summary>
        /// Gets and sets the property MasterEndpoint. 
        /// <para>
        /// The master endpoint for the database.
        /// </para>
        /// </summary>
        public RelationalDatabaseEndpoint MasterEndpoint
        {
            get { return this._masterEndpoint; }
            set { this._masterEndpoint = value; }
        }

        // Check to see if MasterEndpoint property is set
        internal bool IsSetMasterEndpoint()
        {
            return this._masterEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property MasterUsername. 
        /// <para>
        /// The master user name of the database.
        /// </para>
        /// </summary>
        public string MasterUsername
        {
            get { return this._masterUsername; }
            set { this._masterUsername = value; }
        }

        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this._masterUsername != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The unique name of the database resource in Lightsail.
        /// </para>
        /// </summary>
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ParameterApplyStatus. 
        /// <para>
        /// The status of parameter updates for the database.
        /// </para>
        /// </summary>
        public string ParameterApplyStatus
        {
            get { return this._parameterApplyStatus; }
            set { this._parameterApplyStatus = value; }
        }

        // Check to see if ParameterApplyStatus property is set
        internal bool IsSetParameterApplyStatus()
        {
            return this._parameterApplyStatus != null;
        }

        /// <summary>
        /// Gets and sets the property PendingMaintenanceActions. 
        /// <para>
        /// Describes the pending maintenance actions for the database.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PendingMaintenanceAction> PendingMaintenanceActions
        {
            get { return this._pendingMaintenanceActions; }
            set { this._pendingMaintenanceActions = value; }
        }

        // Check to see if PendingMaintenanceActions property is set
        internal bool IsSetPendingMaintenanceActions()
        {
            return this._pendingMaintenanceActions != null && (this._pendingMaintenanceActions.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PendingModifiedValues. 
        /// <para>
        /// Describes pending database value modifications.
        /// </para>
        /// </summary>
        public PendingModifiedRelationalDatabaseValues PendingModifiedValues
        {
            get { return this._pendingModifiedValues; }
            set { this._pendingModifiedValues = value; }
        }

        // Check to see if PendingModifiedValues property is set
        internal bool IsSetPendingModifiedValues()
        {
            return this._pendingModifiedValues != null;
        }

        /// <summary>
        /// Gets and sets the property PreferredBackupWindow. 
        /// <para>
        /// The daily time range during which automated backups are created for the database (for
        /// example, <c>16:00-16:30</c>).
        /// </para>
        /// </summary>
        public string PreferredBackupWindow
        {
            get { return this._preferredBackupWindow; }
            set { this._preferredBackupWindow = value; }
        }

        // Check to see if PreferredBackupWindow property is set
        internal bool IsSetPreferredBackupWindow()
        {
            return this._preferredBackupWindow != null;
        }

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
        public string PreferredMaintenanceWindow
        {
            get { return this._preferredMaintenanceWindow; }
            set { this._preferredMaintenanceWindow = value; }
        }

        // Check to see if PreferredMaintenanceWindow property is set
        internal bool IsSetPreferredMaintenanceWindow()
        {
            return this._preferredMaintenanceWindow != null;
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        /// A Boolean value indicating whether the database is publicly accessible.
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
        /// Gets and sets the property RelationalDatabaseBlueprintId. 
        /// <para>
        /// The blueprint ID for the database. A blueprint describes the major engine version
        /// of a database.
        /// </para>
        /// </summary>
        public string RelationalDatabaseBlueprintId
        {
            get { return this._relationalDatabaseBlueprintId; }
            set { this._relationalDatabaseBlueprintId = value; }
        }

        // Check to see if RelationalDatabaseBlueprintId property is set
        internal bool IsSetRelationalDatabaseBlueprintId()
        {
            return this._relationalDatabaseBlueprintId != null;
        }

        /// <summary>
        /// Gets and sets the property RelationalDatabaseBundleId. 
        /// <para>
        /// The bundle ID for the database. A bundle describes the performance specifications
        /// for your database.
        /// </para>
        /// </summary>
        public string RelationalDatabaseBundleId
        {
            get { return this._relationalDatabaseBundleId; }
            set { this._relationalDatabaseBundleId = value; }
        }

        // Check to see if RelationalDatabaseBundleId property is set
        internal bool IsSetRelationalDatabaseBundleId()
        {
            return this._relationalDatabaseBundleId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The Lightsail resource type for the database (for example, <c>RelationalDatabase</c>).
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

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
        public string SecondaryAvailabilityZone
        {
            get { return this._secondaryAvailabilityZone; }
            set { this._secondaryAvailabilityZone = value; }
        }

        // Check to see if SecondaryAvailabilityZone property is set
        internal bool IsSetSecondaryAvailabilityZone()
        {
            return this._secondaryAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// Describes the current state of the database.
        /// </para>
        /// </summary>
        public string State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property SupportCode. 
        /// <para>
        /// The support code for the database. Include this code in your email to support when
        /// you have questions about a database in Lightsail. This code enables our support team
        /// to look up your Lightsail information more easily.
        /// </para>
        /// </summary>
        public string SupportCode
        {
            get { return this._supportCode; }
            set { this._supportCode = value; }
        }

        // Check to see if SupportCode property is set
        internal bool IsSetSupportCode()
        {
            return this._supportCode != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tag keys and optional values for the resource. For more information about tags
        /// in Lightsail, see the <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/amazon-lightsail-tags">Amazon
        /// Lightsail Developer Guide</a>.
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

    }
}