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
 * Do not modify this file. This file is generated from the rds-2014-10-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreDBInstanceToPointInTime operation.
    /// Restores a DB instance to an arbitrary point-in-time. Users can restore to any point
    /// in time before the LatestRestorableTime for up to BackupRetentionPeriod days. The
    /// target database is created with the most of original configuration, but in a system
    /// chosen availability zone with the default security group, the default subnet group,
    /// and the default DB parameter group. By default, the new DB instance is created as
    /// a single-AZ deployment except when the instance is a SQL Server instance that has
    /// an option group that is associated with mirroring; in this case, the instance becomes
    /// a mirrored deployment and not a single-AZ deployment.
    /// </summary>
    public partial class RestoreDBInstanceToPointInTimeRequest : AmazonRDSRequest
    {
        private bool? _autoMinorVersionUpgrade;
        private string _availabilityZone;
        private bool? _copyTagsToSnapshot;
        private string _dbInstanceClass;
        private string _dbName;
        private string _dbSubnetGroupName;
        private string _engine;
        private int? _iops;
        private string _licenseModel;
        private bool? _multiAZ;
        private string _optionGroupName;
        private int? _port;
        private bool? _publiclyAccessible;
        private DateTime? _restoreTime;
        private string _sourceDBInstanceIdentifier;
        private string _storageType;
        private List<Tag> _tags = new List<Tag>();
        private string _targetDBInstanceIdentifier;
        private string _tdeCredentialArn;
        private string _tdeCredentialPassword;
        private bool? _useLatestRestorableTime;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RestoreDBInstanceToPointInTimeRequest() { }

        /// <summary>
        /// Instantiates RestoreDBInstanceToPointInTimeRequest with the parameterized properties
        /// </summary>
        /// <param name="sourceDBInstanceIdentifier"> The identifier of the source DB instance from which to restore.  Constraints: <ul> <li>Must be the identifier of an existing database instance</li> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul></param>
        /// <param name="targetDBInstanceIdentifier"> The name of the new database instance to be created.  Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul></param>
        public RestoreDBInstanceToPointInTimeRequest(string sourceDBInstanceIdentifier, string targetDBInstanceIdentifier)
        {
            _sourceDBInstanceIdentifier = sourceDBInstanceIdentifier;
            _targetDBInstanceIdentifier = targetDBInstanceIdentifier;
        }

        /// <summary>
        /// Gets and sets the property AutoMinorVersionUpgrade. 
        /// <para>
        ///  Indicates that minor version upgrades will be applied automatically to the DB instance
        /// during the maintenance window. 
        /// </para>
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this._autoMinorVersionUpgrade.GetValueOrDefault(); }
            set { this._autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this._autoMinorVersionUpgrade.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        ///  The EC2 Availability Zone that the database instance will be created in. 
        /// </para>
        ///  
        /// <para>
        /// Default: A random, system-chosen Availability Zone.
        /// </para>
        ///  
        /// <para>
        /// Constraint: You cannot specify the AvailabilityZone parameter if the MultiAZ parameter
        /// is set to true.
        /// </para>
        ///  
        /// <para>
        /// Example: <code>us-east-1a</code>
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
        /// Gets and sets the property CopyTagsToSnapshot. 
        /// <para>
        /// True to copy all tags from the restored DB instance to snapshots of the DB instance;
        /// otherwise false. The default is false.
        /// </para>
        /// </summary>
        public bool CopyTagsToSnapshot
        {
            get { return this._copyTagsToSnapshot.GetValueOrDefault(); }
            set { this._copyTagsToSnapshot = value; }
        }

        // Check to see if CopyTagsToSnapshot property is set
        internal bool IsSetCopyTagsToSnapshot()
        {
            return this._copyTagsToSnapshot.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DBInstanceClass. 
        /// <para>
        ///  The compute and memory capacity of the Amazon RDS DB instance. 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: <code>db.t1.micro | db.m1.small | db.m1.medium | db.m1.large | db.m1.xlarge
        /// | db.m2.2xlarge | db.m2.4xlarge | db.m3.medium | db.m3.large | db.m3.xlarge | db.m3.2xlarge
        /// | db.m4.large | db.m4.xlarge | db.m4.2xlarge | db.m4.4xlarge | db.m4.10xlarge | db.r3.large
        /// | db.r3.xlarge | db.r3.2xlarge | db.r3.4xlarge | db.r3.8xlarge | db.t2.micro | db.t2.small
        /// | db.t2.medium | db.t2.large</code>
        /// </para>
        ///  
        /// <para>
        /// Default: The same DBInstanceClass as the original DB instance.
        /// </para>
        /// </summary>
        public string DBInstanceClass
        {
            get { return this._dbInstanceClass; }
            set { this._dbInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this._dbInstanceClass != null;
        }

        /// <summary>
        /// Gets and sets the property DBName. 
        /// <para>
        ///  The database name for the restored DB instance. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This parameter is not used for the MySQL or MariaDB engines.
        /// </para>
        ///  </note>
        /// </summary>
        public string DBName
        {
            get { return this._dbName; }
            set { this._dbName = value; }
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this._dbName != null;
        }

        /// <summary>
        /// Gets and sets the property DBSubnetGroupName. 
        /// <para>
        ///  The DB subnet group name to use for the new instance. 
        /// </para>
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this._dbSubnetGroupName; }
            set { this._dbSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this._dbSubnetGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Engine. 
        /// <para>
        ///  The database engine to use for the new instance. 
        /// </para>
        ///  
        /// <para>
        /// Default: The same as source
        /// </para>
        ///  
        /// <para>
        /// Constraint: Must be compatible with the engine of the source
        /// </para>
        ///  
        /// <para>
        ///  Valid Values: <code>MySQL</code> | <code>mariadb</code> | <code>oracle-se1</code>
        /// | <code>oracle-se</code> | <code>oracle-ee</code> | <code>sqlserver-ee</code> | <code>sqlserver-se</code>
        /// | <code>sqlserver-ex</code> | <code>sqlserver-web</code> | <code>postgres</code>
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
        /// Gets and sets the property Iops. 
        /// <para>
        ///  The amount of Provisioned IOPS (input/output operations per second) to be initially
        /// allocated for the DB instance. 
        /// </para>
        ///  
        /// <para>
        ///  Constraints: Must be an integer greater than 1000.
        /// </para>
        ///  
        /// <para>
        ///  <b>SQL Server</b> 
        /// </para>
        ///  
        /// <para>
        /// Setting the IOPS value for the SQL Server database engine is not supported.
        /// </para>
        /// </summary>
        public int Iops
        {
            get { return this._iops.GetValueOrDefault(); }
            set { this._iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this._iops.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LicenseModel. 
        /// <para>
        ///  License model information for the restored DB instance. 
        /// </para>
        ///  
        /// <para>
        ///  Default: Same as source. 
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>license-included</code> | <code>bring-your-own-license</code>
        /// | <code>general-public-license</code>
        /// </para>
        /// </summary>
        public string LicenseModel
        {
            get { return this._licenseModel; }
            set { this._licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this._licenseModel != null;
        }

        /// <summary>
        /// Gets and sets the property MultiAZ. 
        /// <para>
        ///  Specifies if the DB instance is a Multi-AZ deployment. 
        /// </para>
        ///  
        /// <para>
        /// Constraint: You cannot specify the AvailabilityZone parameter if the MultiAZ parameter
        /// is set to <code>true</code>.
        /// </para>
        /// </summary>
        public bool MultiAZ
        {
            get { return this._multiAZ.GetValueOrDefault(); }
            set { this._multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this._multiAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptionGroupName. 
        /// <para>
        /// The name of the option group to be used for the restored DB instance.
        /// </para>
        ///  
        /// <para>
        /// Permanent options, such as the TDE option for Oracle Advanced Security TDE, cannot
        /// be removed from an option group, and that option group cannot be removed from a DB
        /// instance once it is associated with a DB instance 
        /// </para>
        /// </summary>
        public string OptionGroupName
        {
            get { return this._optionGroupName; }
            set { this._optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this._optionGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property Port. 
        /// <para>
        ///  The port number on which the database accepts connections. 
        /// </para>
        ///  
        /// <para>
        /// Constraints: Value must be <code>1150-65535</code>
        /// </para>
        ///  
        /// <para>
        /// Default: The same port as the original DB instance.
        /// </para>
        /// </summary>
        public int Port
        {
            get { return this._port.GetValueOrDefault(); }
            set { this._port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this._port.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PubliclyAccessible. 
        /// <para>
        ///  Specifies the accessibility options for the DB instance. A value of true specifies
        /// an Internet-facing instance with a publicly resolvable DNS name, which resolves to
        /// a public IP address. A value of false specifies an internal instance with a DNS name
        /// that resolves to a private IP address. 
        /// </para>
        ///  
        /// <para>
        ///  Default: The default behavior varies depending on whether a VPC has been requested
        /// or not. The following list shows the default behavior in each case. 
        /// </para>
        ///  <ul> <li> <b>Default VPC:</b>true</li> <li> <b>VPC:</b>false</li> </ul> 
        /// <para>
        ///  If no DB subnet group has been specified as part of the request and the PubliclyAccessible
        /// value has not been set, the DB instance will be publicly accessible. If a specific
        /// DB subnet group has been specified as part of the request and the PubliclyAccessible
        /// value has not been set, the DB instance will be private. 
        /// </para>
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this._publiclyAccessible.GetValueOrDefault(); }
            set { this._publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this._publiclyAccessible.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestoreTime. 
        /// <para>
        ///  The date and time to restore from. 
        /// </para>
        ///  
        /// <para>
        /// Valid Values: Value must be a time in Universal Coordinated Time (UTC) format
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be before the latest restorable time for the DB instance</li> <li>Cannot
        /// be specified if UseLatestRestorableTime parameter is true</li> </ul> 
        /// <para>
        /// Example: <code>2009-09-07T23:45:00Z</code>
        /// </para>
        /// </summary>
        public DateTime RestoreTime
        {
            get { return this._restoreTime.GetValueOrDefault(); }
            set { this._restoreTime = value; }
        }

        // Check to see if RestoreTime property is set
        internal bool IsSetRestoreTime()
        {
            return this._restoreTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceDBInstanceIdentifier. 
        /// <para>
        ///  The identifier of the source DB instance from which to restore. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must be the identifier of an existing database instance</li> <li>Must contain
        /// from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a
        /// letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul>
        /// </summary>
        public string SourceDBInstanceIdentifier
        {
            get { return this._sourceDBInstanceIdentifier; }
            set { this._sourceDBInstanceIdentifier = value; }
        }

        // Check to see if SourceDBInstanceIdentifier property is set
        internal bool IsSetSourceDBInstanceIdentifier()
        {
            return this._sourceDBInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property StorageType. 
        /// <para>
        ///  Specifies the storage type to be associated with the DB instance. 
        /// </para>
        ///  
        /// <para>
        ///  Valid values: <code>standard | gp2 | io1</code>
        /// </para>
        ///  
        /// <para>
        ///  If you specify <code>io1</code>, you must also include a value for the <code>Iops</code>
        /// parameter. 
        /// </para>
        ///  
        /// <para>
        ///  Default: <code>io1</code> if the <code>Iops</code> parameter is specified; otherwise
        /// <code>standard</code>
        /// </para>
        /// </summary>
        public string StorageType
        {
            get { return this._storageType; }
            set { this._storageType = value; }
        }

        // Check to see if StorageType property is set
        internal bool IsSetStorageType()
        {
            return this._storageType != null;
        }

        /// <summary>
        /// Gets and sets the property Tags.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TargetDBInstanceIdentifier. 
        /// <para>
        ///  The name of the new database instance to be created. 
        /// </para>
        ///  
        /// <para>
        /// Constraints:
        /// </para>
        ///  <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First
        /// character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive
        /// hyphens</li> </ul>
        /// </summary>
        public string TargetDBInstanceIdentifier
        {
            get { return this._targetDBInstanceIdentifier; }
            set { this._targetDBInstanceIdentifier = value; }
        }

        // Check to see if TargetDBInstanceIdentifier property is set
        internal bool IsSetTargetDBInstanceIdentifier()
        {
            return this._targetDBInstanceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property TdeCredentialArn. 
        /// <para>
        ///  The ARN from the Key Store with which to associate the instance for TDE encryption.
        /// 
        /// </para>
        /// </summary>
        public string TdeCredentialArn
        {
            get { return this._tdeCredentialArn; }
            set { this._tdeCredentialArn = value; }
        }

        // Check to see if TdeCredentialArn property is set
        internal bool IsSetTdeCredentialArn()
        {
            return this._tdeCredentialArn != null;
        }

        /// <summary>
        /// Gets and sets the property TdeCredentialPassword. 
        /// <para>
        ///  The password for the given ARN from the Key Store in order to access the device.
        /// 
        /// </para>
        /// </summary>
        public string TdeCredentialPassword
        {
            get { return this._tdeCredentialPassword; }
            set { this._tdeCredentialPassword = value; }
        }

        // Check to see if TdeCredentialPassword property is set
        internal bool IsSetTdeCredentialPassword()
        {
            return this._tdeCredentialPassword != null;
        }

        /// <summary>
        /// Gets and sets the property UseLatestRestorableTime. 
        /// <para>
        ///  Specifies whether (<code>true</code>) or not (<code>false</code>) the DB instance
        /// is restored from the latest backup time. 
        /// </para>
        ///  
        /// <para>
        /// Default: <code>false</code>
        /// </para>
        ///  
        /// <para>
        /// Constraints: Cannot be specified if RestoreTime parameter is provided.
        /// </para>
        /// </summary>
        public bool UseLatestRestorableTime
        {
            get { return this._useLatestRestorableTime.GetValueOrDefault(); }
            set { this._useLatestRestorableTime = value; }
        }

        // Check to see if UseLatestRestorableTime property is set
        internal bool IsSetUseLatestRestorableTime()
        {
            return this._useLatestRestorableTime.HasValue; 
        }

    }
}