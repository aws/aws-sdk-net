/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para> Restores a DB instance to an arbitrary point-in-time. Users can restore to any point in time before the latestRestorableTime for up
    /// to backupRetentionPeriod days. The target database is created from the source database with the same configuration as the original database
    /// except that the DB instance is created with the default DB security group. </para>
    /// </summary>
    public partial class RestoreDBInstanceToPointInTimeRequest : AmazonRDSRequest
    {
        private string sourceDBInstanceIdentifier;
        private string targetDBInstanceIdentifier;
        private DateTime? restoreTime;
        private bool? useLatestRestorableTime;
        private string dBInstanceClass;
        private int? port;
        private string availabilityZone;
        private string dBSubnetGroupName;
        private bool? multiAZ;
        private bool? publiclyAccessible;
        private bool? autoMinorVersionUpgrade;
        private string licenseModel;
        private string dBName;
        private string engine;
        private int? iops;
        private string optionGroupName;
        private List<Tag> tags = new List<Tag>();


        /// <summary>
        /// The identifier of the source DB instance from which to restore. Constraints: <ul> <li>Must be the identifier of an existing database
        /// instance</li> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li> <li>First character must be a letter</li> <li>Cannot end
        /// with a hyphen or contain two consecutive hyphens</li> </ul>
        ///  
        /// </summary>
        public string SourceDBInstanceIdentifier
        {
            get { return this.sourceDBInstanceIdentifier; }
            set { this.sourceDBInstanceIdentifier = value; }
        }

        // Check to see if SourceDBInstanceIdentifier property is set
        internal bool IsSetSourceDBInstanceIdentifier()
        {
            return this.sourceDBInstanceIdentifier != null;
        }

        /// <summary>
        /// The name of the new database instance to be created. Constraints: <ul> <li>Must contain from 1 to 63 alphanumeric characters or hyphens</li>
        /// <li>First character must be a letter</li> <li>Cannot end with a hyphen or contain two consecutive hyphens</li> </ul>
        ///  
        /// </summary>
        public string TargetDBInstanceIdentifier
        {
            get { return this.targetDBInstanceIdentifier; }
            set { this.targetDBInstanceIdentifier = value; }
        }

        // Check to see if TargetDBInstanceIdentifier property is set
        internal bool IsSetTargetDBInstanceIdentifier()
        {
            return this.targetDBInstanceIdentifier != null;
        }

        /// <summary>
        /// The date and time to restore from. Valid Values: Value must be a UTC time Constraints: <ul> <li>Must be before the latest restorable time
        /// for the DB instance</li> <li>Cannot be specified if UseLatestRestorableTime parameter is true</li> </ul> Example:
        /// <c>2009-09-07T23:45:00Z</c>
        ///  
        /// </summary>
        public DateTime RestoreTime
        {
            get { return this.restoreTime ?? default(DateTime); }
            set { this.restoreTime = value; }
        }

        // Check to see if RestoreTime property is set
        internal bool IsSetRestoreTime()
        {
            return this.restoreTime.HasValue;
        }

        /// <summary>
        /// Specifies whether (<c>true</c>) or not (<c>false</c>) the DB instance is restored from the latest backup time. Default: <c>false</c>
        /// Constraints: Cannot be specified if RestoreTime parameter is provided.
        ///  
        /// </summary>
        public bool UseLatestRestorableTime
        {
            get { return this.useLatestRestorableTime ?? default(bool); }
            set { this.useLatestRestorableTime = value; }
        }

        // Check to see if UseLatestRestorableTime property is set
        internal bool IsSetUseLatestRestorableTime()
        {
            return this.useLatestRestorableTime.HasValue;
        }

        /// <summary>
        /// The compute and memory capacity of the Amazon RDS DB instance. Valid Values: <c>db.t1.micro | db.m1.small | db.m1.medium | db.m1.large |
        /// db.m1.xlarge | db.m2.2xlarge | db.m2.4xlarge</c> Default: The same DBInstanceClass as the original DB instance.
        ///  
        /// </summary>
        public string DBInstanceClass
        {
            get { return this.dBInstanceClass; }
            set { this.dBInstanceClass = value; }
        }

        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this.dBInstanceClass != null;
        }

        /// <summary>
        /// The port number on which the database accepts connections. Constraints: Value must be <c>1150-65535</c> Default: The same port as the
        /// original DB instance.
        ///  
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;
        }

        /// <summary>
        /// The EC2 Availability Zone that the database instance will be created in. Default: A random, system-chosen Availability Zone. Constraint: You
        /// cannot specify the AvailabilityZone parameter if the MultiAZ parameter is set to true. Example: <c>us-east-1a</c>
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;
        }

        /// <summary>
        /// The DB subnet group name to use for the new instance.
        ///  
        /// </summary>
        public string DBSubnetGroupName
        {
            get { return this.dBSubnetGroupName; }
            set { this.dBSubnetGroupName = value; }
        }

        // Check to see if DBSubnetGroupName property is set
        internal bool IsSetDBSubnetGroupName()
        {
            return this.dBSubnetGroupName != null;
        }

        /// <summary>
        /// Specifies if the DB instance is a Multi-AZ deployment. Constraint: You cannot specify the AvailabilityZone parameter if the MultiAZ
        /// parameter is set to <c>true</c>.
        ///  
        /// </summary>
        public bool MultiAZ
        {
            get { return this.multiAZ ?? default(bool); }
            set { this.multiAZ = value; }
        }

        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this.multiAZ.HasValue;
        }

        /// <summary>
        /// Specifies the accessibility options for the DB instance. A value of true specifies an Internet-facing instance with a publicly resolvable
        /// DNS name, which resolves to a public IP address. A value of false specifies an internal instance with a DNS name that resolves to a private
        /// IP address. Default: The default behavior varies depending on whether a VPC has been requested or not. The following list shows the default
        /// behavior in each case. <ul> <li><b>Default VPC:</b>true</li> <li><b>VPC:</b>false</li> </ul> If no DB subnet group has been specified as
        /// part of the request and the PubliclyAccessible value has not been set, the DB instance will be publicly accessible. If a specific DB subnet
        /// group has been specified as part of the request and the PubliclyAccessible value has not been set, the DB instance will be private.
        ///  
        /// </summary>
        public bool PubliclyAccessible
        {
            get { return this.publiclyAccessible ?? default(bool); }
            set { this.publiclyAccessible = value; }
        }

        // Check to see if PubliclyAccessible property is set
        internal bool IsSetPubliclyAccessible()
        {
            return this.publiclyAccessible.HasValue;
        }

        /// <summary>
        /// Indicates that minor version upgrades will be applied automatically to the DB instance during the maintenance window.
        ///  
        /// </summary>
        public bool AutoMinorVersionUpgrade
        {
            get { return this.autoMinorVersionUpgrade ?? default(bool); }
            set { this.autoMinorVersionUpgrade = value; }
        }

        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this.autoMinorVersionUpgrade.HasValue;
        }

        /// <summary>
        /// License model information for the restored DB instance. Default: Same as source. Valid values: <c>license-included</c> |
        /// <c>bring-your-own-license</c> | <c>general-public-license</c>
        ///  
        /// </summary>
        public string LicenseModel
        {
            get { return this.licenseModel; }
            set { this.licenseModel = value; }
        }

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this.licenseModel != null;
        }

        /// <summary>
        /// The database name for the restored DB instance. <note> This parameter is not used for the MySQL engine. </note>
        ///  
        /// </summary>
        public string DBName
        {
            get { return this.dBName; }
            set { this.dBName = value; }
        }

        // Check to see if DBName property is set
        internal bool IsSetDBName()
        {
            return this.dBName != null;
        }

        /// <summary>
        /// The database engine to use for the new instance. Default: The same as source Constraint: Must be compatible with the engine of the source
        /// Example: <c>oracle-ee</c>
        ///  
        /// </summary>
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this.engine != null;
        }

        /// <summary>
        /// The amount of Provisioned IOPS (input/output operations per second) to be initially allocated for the DB instance. Constraints: Must be an
        /// integer greater than 1000.
        ///  
        /// </summary>
        public int Iops
        {
            get { return this.iops ?? default(int); }
            set { this.iops = value; }
        }

        // Check to see if Iops property is set
        internal bool IsSetIops()
        {
            return this.iops.HasValue;
        }

        /// <summary>
        /// The name of the option group to be used for the restored DB instance. <!-- Note that persistent options, such as the TDE_SQLServer option
        /// for Microsoft SQL Server, cannot be removed from an option group while DB instances are associated with the option group. --> Permanent
        /// options, such as the TDE option for Oracle Advanced Security TDE, cannot be removed from an option group, and that option group cannot be
        /// removed from a DB instance once it is associated with a DB instance
        ///  
        /// </summary>
        public string OptionGroupName
        {
            get { return this.optionGroupName; }
            set { this.optionGroupName = value; }
        }

        // Check to see if OptionGroupName property is set
        internal bool IsSetOptionGroupName()
        {
            return this.optionGroupName != null;
        }

        /// <summary>
        /// A list of tags.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

    }
}
    
