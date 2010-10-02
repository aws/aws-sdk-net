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
    /// <summary>
    /// Restores a DB Instance to a specified time, creating a new DB Instance. Some characteristics of the new DB Instance
    /// can be modified using optional parameters. If these options are omitted, the new DB Instance defaults to the characteristics
    /// of the DB Instance from which the DB Snapshot was created.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/doc/2010-01-01/", IsNullable = false)]
    public class RestoreDBInstanceToPointInTimeRequest
    {
        private string sourceDBInstanceIdentifierField;
        private string targetDBInstanceIdentifierField;
        private DateTime? restoreTimeField;
        private bool? useLatestRestorableTimeField;
        private string DBInstanceClassField;
        private Decimal? portField;
        private string availabilityZoneField;
        private bool? multiAZField;

        /// <summary>
        /// Gets and sets the SourceDBInstanceIdentifier property.
        /// The identifier of the source DB Instance from which to restore.
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "SourceDBInstanceIdentifier")]
        public string SourceDBInstanceIdentifier
        {
            get { return this.sourceDBInstanceIdentifierField; }
            set { this.sourceDBInstanceIdentifierField = value; }
        }

        /// <summary>
        /// Sets the SourceDBInstanceIdentifier property
        /// </summary>
        /// <param name="sourceDBInstanceIdentifier">The identifier of the source DB Instance from which to restore.
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// Cannot end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithSourceDBInstanceIdentifier(string sourceDBInstanceIdentifier)
        {
            this.sourceDBInstanceIdentifierField = sourceDBInstanceIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if SourceDBInstanceIdentifier property is set
        /// </summary>
        /// <returns>true if SourceDBInstanceIdentifier property is set</returns>
        public bool IsSetSourceDBInstanceIdentifier()
        {
            return this.sourceDBInstanceIdentifierField != null;
        }

        /// <summary>
        /// Gets and sets the TargetDBInstanceIdentifier property.
        /// The name of the new database instance to be created.
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// Cannot end with a hyphen or contain two consecutive hyphens.
        /// </summary>
        [XmlElementAttribute(ElementName = "TargetDBInstanceIdentifier")]
        public string TargetDBInstanceIdentifier
        {
            get { return this.targetDBInstanceIdentifierField; }
            set { this.targetDBInstanceIdentifierField = value; }
        }

        /// <summary>
        /// Sets the TargetDBInstanceIdentifier property
        /// </summary>
        /// <param name="targetDBInstanceIdentifier">The name of the new database instance to be created.
        /// Must contain from 1 to 63 alphanumeric characters or hyphens.
        /// First character must be a letter.
        /// Cannot end with a hyphen or contain two consecutive hyphens.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithTargetDBInstanceIdentifier(string targetDBInstanceIdentifier)
        {
            this.targetDBInstanceIdentifierField = targetDBInstanceIdentifier;
            return this;
        }

        /// <summary>
        /// Checks if TargetDBInstanceIdentifier property is set
        /// </summary>
        /// <returns>true if TargetDBInstanceIdentifier property is set</returns>
        public bool IsSetTargetDBInstanceIdentifier()
        {
            return this.targetDBInstanceIdentifierField != null;
        }

        /// <summary>
        /// Gets and sets the RestoreTime property.
        /// The date and time from to restore from. Valid Values: Value must be a UTC time.
        /// Time specified must be after the creation of the oldest system snapshot available for SourceDBInstanceIdentifier.
        /// Cannot be after the latest restorable time for the DB Instance.
        /// Cannot be specified if UseLatestRestorableTime parameter is true.
        /// </summary>
        [XmlElementAttribute(ElementName = "RestoreTime")]
        public DateTime RestoreTime
        {
            get { return this.restoreTimeField.GetValueOrDefault(); }
            set
            {
                this.restoreTimeField = DateTime.ParseExact(
                    value.ToString(),
                    Amazon.Util.AWSSDKUtils.ISO8601DateFormat,
                    System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        /// <summary>
        /// Sets the RestoreTime property
        /// </summary>
        /// <param name="restoreTime">The date and time from to restore from. Valid Values: Value must be a UTC time.
        /// Time specified must be after the creation of the oldest system snapshot available for SourceDBInstanceIdentifier.
        /// Cannot be after the latest restorable time for the DB Instance.
        /// Cannot be specified if UseLatestRestorableTime parameter is true.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithRestoreTime(DateTime restoreTime)
        {
            this.restoreTimeField = restoreTime;
            return this;
        }

        /// <summary>
        /// Checks if RestoreTime property is set
        /// </summary>
        /// <returns>true if RestoreTime property is set</returns>
        public bool IsSetRestoreTime()
        {
            return this.restoreTimeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the UseLatestRestorableTime property.
        /// Specifies that the DB Instance is restored from the latest backup time.
        /// </summary>
        [XmlElementAttribute(ElementName = "UseLatestRestorableTime")]
        public bool UseLatestRestorableTime
        {
            get { return this.useLatestRestorableTimeField.GetValueOrDefault(); }
            set { this.useLatestRestorableTimeField = value; }
        }

        /// <summary>
        /// Sets the UseLatestRestorableTime property
        /// </summary>
        /// <param name="useLatestRestorableTime">Specifies that the DB Instance is restored from the latest backup time.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithUseLatestRestorableTime(bool useLatestRestorableTime)
        {
            this.useLatestRestorableTimeField = useLatestRestorableTime;
            return this;
        }

        /// <summary>
        /// Checks if UseLatestRestorableTime property is set
        /// </summary>
        /// <returns>true if UseLatestRestorableTime property is set</returns>
        public bool IsSetUseLatestRestorableTime()
        {
            return this.useLatestRestorableTimeField.HasValue;
        }

        /// <summary>
        /// Gets and sets the DBInstanceClass property.
        /// Contains the compute and memory capacity of the Amazon RDS DB instance.
        /// db.m1.small | db.m1.large | db.m1.xlarge | db.m2.2xlarge | db.m2.4xlarge
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
        /// db.m1.small | db.m1.large | db.m1.xlarge | db.m2.2xlarge | db.m2.4xlarge</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithDBInstanceClass(string DBInstanceClass)
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
        /// Port number on which the database accepts connections. The same port as the original DB Instance.
        /// Constraints: Value must be 1115-65535.
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
        /// <param name="port">Port number on which the database accepts connections. The same port as the original DB Instance.
        /// Constraints: Value must be 1115-65535.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithPort(Decimal port)
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
        /// The EC2 Availability Zone that the database instance will be created in. Default: A random, system-chosen Availability Zone.
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
        /// <param name="availabilityZone">The EC2 Availability Zone that the database instance will be created in. Default: A random, system-chosen Availability Zone.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithAvailabilityZone(string availabilityZone)
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
        /// Gets and sets the MultiAZ property.
        /// Specifies if the DB Instance is a Multi-AZ DB Instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "MultiAZ")]
        public bool MultiAZ
        {
            get { return this.multiAZField.GetValueOrDefault(); }
            set { this.multiAZField = value; }
        }

        /// <summary>
        /// Sets the MultiAZ property
        /// </summary>
        /// <param name="multiAZ">Specifies if the DB Instance is a Multi-AZ DB Instance.</param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithMultiAZ(bool multiAZ)
        {
            this.multiAZField = multiAZ;
            return this;
        }

        /// <summary>
        /// Checks if MultiAZ property is set
        /// </summary>
        /// <returns>true if MultiAZ property is set</returns>
        public bool IsSetMultiAZ()
        {
            return this.multiAZField.HasValue;
        }

    }
}
