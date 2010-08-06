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
 *  API Version: 2010-01-01
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.RDS.Model
{
    ///<summary>
    ///Information about the DB Snapshot.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class DBSnapshot
    {
        private string DBSnapshotIdentifierField;
        private string DBInstanceIdentifierField;
        private DateTime? snapshotCreateTimeField;
        private string engineField;
        private Decimal? allocatedStorageField;
        private string statusField;
        private Decimal? portField;
        private string availabilityZoneField;
        private DateTime? instanceCreateTimeField;
        private string masterUsernameField;

        /// <summary>
        /// Gets and sets the DBSnapshotIdentifier property.
        /// The identifier for the DB Snapshot.
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
        /// <param name="DBSnapshotIdentifier">The identifier for the DB Snapshot.</param>
        /// <returns>this instance</returns>
        public DBSnapshot WithDBSnapshotIdentifier(string DBSnapshotIdentifier)
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
        /// Gets and sets the DBInstanceIdentifier property.
        /// The DBInstanceIdentifier of the DB Instance this DB Snapshot was created from.
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
        /// <param name="DBInstanceIdentifier">The DBInstanceIdentifier of the DB Instance this DB Snapshot was created from.</param>
        /// <returns>this instance</returns>
        public DBSnapshot WithDBInstanceIdentifier(string DBInstanceIdentifier)
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
        /// Gets and sets the SnapshotCreateTime property.
        /// The time (UTC) when the snapshot was taken. Example: 2009-01-2009T23:50.000Z.
        /// </summary>
        [XmlElementAttribute(ElementName = "SnapshotCreateTime")]
        public DateTime SnapshotCreateTime
        {
            get { return this.snapshotCreateTimeField.GetValueOrDefault(); }
            set { this.snapshotCreateTimeField = value; }
        }

        /// <summary>
        /// Sets the SnapshotCreateTime property
        /// </summary>
        /// <param name="snapshotCreateTime">The time (UTC) when the snapshot was taken. Example: 2009-01-2009T23:50.000Z.</param>
        /// <returns>this instance</returns>
        public DBSnapshot WithSnapshotCreateTime(DateTime snapshotCreateTime)
        {
            this.snapshotCreateTimeField = snapshotCreateTime;
            return this;
        }

        /// <summary>
        /// Checks if SnapshotCreateTime property is set
        /// </summary>
        /// <returns>true if SnapshotCreateTime property is set</returns>
        public bool IsSetSnapshotCreateTime()
        {
            return this.snapshotCreateTimeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Engine property.
        /// Name of the database engine. Valid Values: MySQL5.1.
        /// </summary>
        [XmlElementAttribute(ElementName = "Engine")]
        public string Engine
        {
            get { return this.engineField; }
            set { this.engineField = value; }
        }

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">Name of the database engine. Valid Values: MySQL5.1.</param>
        /// <returns>this instance</returns>
        public DBSnapshot WithEngine(string engine)
        {
            this.engineField = engine;
            return this;
        }

        /// <summary>
        /// Checks if Engine property is set
        /// </summary>
        /// <returns>true if Engine property is set</returns>
        public bool IsSetEngine()
        {
            return this.engineField != null;
        }

        /// <summary>
        /// Gets and sets the AllocatedStorage property.
        /// Allocated storage size in gigabytes (GB).
        /// </summary>
        [XmlElementAttribute(ElementName = "AllocatedStorage")]
        public Decimal AllocatedStorage
        {
            get { return this.allocatedStorageField.GetValueOrDefault(); }
            set { this.allocatedStorageField = value; }
        }

        /// <summary>
        /// Sets the AllocatedStorage property
        /// </summary>
        /// <param name="allocatedStorage">Allocated storage size in gigabytes (GB).</param>
        /// <returns>this instance</returns>
        public DBSnapshot WithAllocatedStorage(Decimal allocatedStorage)
        {
            this.allocatedStorageField = allocatedStorage;
            return this;
        }

        /// <summary>
        /// Checks if AllocatedStorage property is set
        /// </summary>
        /// <returns>true if AllocatedStorage property is set</returns>
        public bool IsSetAllocatedStorage()
        {
            return this.allocatedStorageField.HasValue;
        }

        /// <summary>
        /// Gets and sets the Status property.
        /// The status of this DB Snapshot.
        /// </summary>
        [XmlElementAttribute(ElementName = "Status")]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The status of this DB Snapshot.</param>
        /// <returns>this instance</returns>
        public DBSnapshot WithStatus(string status)
        {
            this.statusField = status;
            return this;
        }

        /// <summary>
        /// Checks if Status property is set
        /// </summary>
        /// <returns>true if Status property is set</returns>
        public bool IsSetStatus()
        {
            return this.statusField != null;
        }

        /// <summary>
        /// Gets and sets the Port property.
        /// The port that the database engine was listening on at the time of the snapshot.
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
        /// <param name="port">The port that the database engine was listening on at the time of the snapshot.</param>
        /// <returns>this instance</returns>
        public DBSnapshot WithPort(Decimal port)
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
        /// The name of the Availability Zone the DB Instance was located in at the time of the DB Snapshot.
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
        /// <param name="availabilityZone">The name of the Availability Zone the DB Instance was located in at the time of the DB Snapshot.</param>
        /// <returns>this instance</returns>
        public DBSnapshot WithAvailabilityZone(string availabilityZone)
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

        /// <summary>
        /// Gets and sets the InstanceCreateTime property.
        /// Date and time the source DB Instance was created.
        /// Example: 2009-07-08T21:16:46Z.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceCreateTime")]
        public DateTime InstanceCreateTime
        {
            get { return this.instanceCreateTimeField.GetValueOrDefault(); }
            set { this.instanceCreateTimeField = value; }
        }

        /// <summary>
        /// Sets the InstanceCreateTime property
        /// </summary>
        /// <param name="instanceCreateTime">Date and time the source DB Instance was created.
        /// Example: 2009-07-08T21:16:46Z.</param>
        /// <returns>this instance</returns>
        public DBSnapshot WithInstanceCreateTime(DateTime instanceCreateTime)
        {
            this.instanceCreateTimeField = instanceCreateTime;
            return this;
        }

        /// <summary>
        /// Checks if InstanceCreateTime property is set
        /// </summary>
        /// <returns>true if InstanceCreateTime property is set</returns>
        public bool IsSetInstanceCreateTime()
        {
            return this.instanceCreateTimeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the MasterUsername property.
        /// The master username for the DB Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "MasterUsername")]
        public string MasterUsername
        {
            get { return this.masterUsernameField; }
            set { this.masterUsernameField = value; }
        }

        /// <summary>
        /// Sets the MasterUsername property
        /// </summary>
        /// <param name="masterUsername">The master username for the DB Instance.</param>
        /// <returns>this instance</returns>
        public DBSnapshot WithMasterUsername(string masterUsername)
        {
            this.masterUsernameField = masterUsername;
            return this;
        }

        /// <summary>
        /// Checks if MasterUsername property is set
        /// </summary>
        /// <returns>true if MasterUsername property is set</returns>
        public bool IsSetMasterUsername()
        {
            return this.masterUsernameField != null;
        }

    }
}
