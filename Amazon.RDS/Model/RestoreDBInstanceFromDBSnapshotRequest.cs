/*******************************************************************************
 * Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2009-10-16
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Creates a new DB Instance from a DB Snapshot. The source DB Snapshot must be in the available state. The new DB
    /// Instance is created with the default DB Security Group.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class RestoreDBInstanceFromDBSnapshotRequest
    {
        private string DBInstanceIdentifierField;
        private string DBSnapshotIdentifierField;
        private string DBInstanceClassField;
        private Decimal? portField;
        private string availabilityZoneField;

        /// <summary>
        /// Gets and sets the DBInstanceIdentifier property.
        /// Name of the DB Instance to create from the DB Snapshot. This parameter isn't case sensitive.
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBInstanceIdentifier")]
        public string DBInstanceIdentifier
        {
            get { return this.DBInstanceIdentifierField; }
            set { this.DBInstanceIdentifierField = value; }
        }

        /// <summary>
        /// Sets the DBInstanceIdentifier property
        /// </summary>
        /// <param name="DBInstanceIdentifier">Name of the DB Instance to create from the DB Snapshot. This parameter isn't case sensitive.
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// Cannot end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceFromDBSnapshotRequest WithDBInstanceIdentifier(string DBInstanceIdentifier)
        {
            this.DBInstanceIdentifierField = DBInstanceIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if DBInstanceIdentifier property is set
        /// </summary>
        /// <returns>true if DBInstanceIdentifier property is set</returns>
        public bool IsSetDBInstanceIdentifier()
        {
            return this.DBInstanceIdentifierField != null;
        }

        /// <summary>
        /// Gets and sets the DBSnapshotIdentifier property.
        /// The identifier for the DB Snapshot to restore from.
        /// Cannot be null, empty, or blank. Cannot be a word reserved by the database engine.
        /// Must contain from 1 to 255 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBSnapshotIdentifier")]
        public string DBSnapshotIdentifier
        {
            get { return this.DBSnapshotIdentifierField; }
            set { this.DBSnapshotIdentifierField = value; }
        }

        /// <summary>
        /// Sets the DBSnapshotIdentifier property
        /// </summary>
        /// <param name="DBSnapshotIdentifier">The identifier for the DB Snapshot to restore from.
        /// Cannot be null, empty, or blank. Cannot be a word reserved by the database engine.
        /// Must contain from 1 to 255 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// Cannot end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceFromDBSnapshotRequest WithDBSnapshotIdentifier(string DBSnapshotIdentifier)
        {
            this.DBSnapshotIdentifierField = DBSnapshotIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if DBSnapshotIdentifier property is set
        /// </summary>
        /// <returns>true if DBSnapshotIdentifier property is set</returns>
        public bool IsSetDBSnapshotIdentifier()
        {
            return this.DBSnapshotIdentifierField != null;
        }

        /// <summary>
        /// Gets and sets the DBInstanceClass property.
        /// Contains the compute and memory capacity of the Amazon RDS DB instance.
        /// Valid values: db.m1.small | db.m1.large | db.m1.xlarge | db.m2.2xlarge | db.m2.4xlarge
        /// </summary>
        [XmlElementAttribute(ElementName = "DBInstanceClass")]
        public string DBInstanceClass
        {
            get { return this.DBInstanceClassField; }
            set { this.DBInstanceClassField = value; }
        }

        /// <summary>
        /// Sets the DBInstanceClass property
        /// </summary>
        /// <param name="DBInstanceClass">Contains the compute and memory capacity of the Amazon RDS DB instance.
        /// Valid values: db.m1.small | db.m1.large | db.m1.xlarge | db.m2.2xlarge | db.m2.4xlarge</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceFromDBSnapshotRequest WithDBInstanceClass(string DBInstanceClass)
        {
            this.DBInstanceClassField = DBInstanceClass;
            return this;
        }

        /// <summary>
        /// Checks if DBInstanceClass property is set
        /// </summary>
        /// <returns>true if DBInstanceClass property is set</returns>
        public bool IsSetDBInstanceClass()
        {
            return this.DBInstanceClassField != null;
        }

        /// <summary>
        /// Gets and sets the Port property.
        /// Port number on which the database accepts connections. Value must be 1115-65535.
        /// </summary>
        [XmlElementAttribute(ElementName = "Port")]
        public Decimal Port
        {
            get { return this.portField.GetValueOrDefault(); }
            set { this.portField = value; }
        }

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">Port number on which the database accepts connections. Value must be 1115-65535.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceFromDBSnapshotRequest WithPort(Decimal port)
        {
            this.portField = port;
            return this;
        }

        /// <summary>
        /// Checks if Port property is set
        /// </summary>
        /// <returns>true if Port property is set</returns>
        public bool IsSetPort()
        {
            return this.portField.HasValue;
        }

        /// <summary>
        /// Gets and sets the AvailabilityZone property.
        /// The EC2 Availability Zone that the database instance will be created in. Default is a random, system-chosen Availability Zone.
        /// </summary>
        [XmlElementAttribute(ElementName = "AvailabilityZone")]
        public string AvailabilityZone
        {
            get { return this.availabilityZoneField; }
            set { this.availabilityZoneField = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The EC2 Availability Zone that the database instance will be created in. Default is a random, system-chosen Availability Zone.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceFromDBSnapshotRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZoneField = availabilityZone;
            return this;
        }

        /// <summary>
        /// Checks if AvailabilityZone property is set
        /// </summary>
        /// <returns>true if AvailabilityZone property is set</returns>
        public bool IsSetAvailabilityZone()
        {
            return this.availabilityZoneField != null;
        }

    }
}
