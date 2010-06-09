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
    ///<summary>
    ///Information about the DB Instance that will be applied or is in progress.
    ///</summary>
    [XmlRootAttribute(Namespace = "http://rds.amazonaws.com/admin/2009-10-16/", IsNullable = false)]
    public class PendingModifiedValues
    {
        private string DBInstanceClassField;
        private Decimal? allocatedStorageField;
        private string masterUserPasswordField;
        private Decimal? portField;
        private Decimal? backupRetentionPeriodField;

        /// <summary>
        /// Gets and sets the DBInstanceClass property.
        /// When this element is present it identifies the new DBInstanceClass for the DB
        /// Instance that will be applied or is in progress.
        /// </summary>
        [XmlElementAttribute(ElementName = "DBInstanceClass")]
        public string DBInstanceClass
        {
            get { return this.DBInstanceClassField ; }
            set { this.DBInstanceClassField= value; }
        }

        /// <summary>
        /// Sets the DBInstanceClass property
        /// </summary>
        /// <param name="DBInstanceClass">When this element is present it identifies the new DBInstanceClass for the DB
        /// Instance that will be applied or is in progress.</param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithDBInstanceClass(string DBInstanceClass)
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
            return  this.DBInstanceClassField != null;
        }

        /// <summary>
        /// Gets and sets the AllocatedStorage property.
        /// When this element is present it identifies the new AllocatedStorage size for the DB Instance
        /// that will be applied or is in progress.
        /// </summary>
        [XmlElementAttribute(ElementName = "AllocatedStorage")]
        public Decimal AllocatedStorage
        {
            get { return this.allocatedStorageField.GetValueOrDefault() ; }
            set { this.allocatedStorageField= value; }
        }

        /// <summary>
        /// Sets the AllocatedStorage property
        /// </summary>
        /// <param name="allocatedStorage">When this element is present it identifies the new AllocatedStorage size for the DB Instance
        /// that will be applied or is in progress.</param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithAllocatedStorage(Decimal allocatedStorage)
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
            return  this.allocatedStorageField.HasValue;
        }

        /// <summary>
        /// Gets and sets the MasterUserPassword property.
        /// When this element is present it conveys the pending or in-progress change of the master credentials for the
        /// DB Instance. This element always contains "****" because the API never returns a password in clear text.
        /// </summary>
        [XmlElementAttribute(ElementName = "MasterUserPassword")]
        public string MasterUserPassword
        {
            get { return this.masterUserPasswordField ; }
            set { this.masterUserPasswordField= value; }
        }

        /// <summary>
        /// Sets the MasterUserPassword property
        /// </summary>
        /// <param name="masterUserPassword">When this element is present it conveys the pending or in-progress change of the master credentials for the
        /// DB Instance. This element always contains "****" because the API never returns a password in clear text.</param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithMasterUserPassword(string masterUserPassword)
        {
            this.masterUserPasswordField = masterUserPassword;
            return this;
        }

        /// <summary>
        /// Checks if MasterUserPassword property is set
        /// </summary>
        /// <returns>true if MasterUserPassword property is set</returns>
        public bool IsSetMasterUserPassword()
        {
            return  this.masterUserPasswordField != null;
        }

        /// <summary>
        /// Gets and sets the Port property.
        /// Port number on which the database accepts connections. Value must be 1115-65535.
        /// </summary>
        [XmlElementAttribute(ElementName = "Port")]
        public Decimal Port
        {
            get { return this.portField.GetValueOrDefault() ; }
            set { this.portField= value; }
        }

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">Port number on which the database accepts connections. Value must be 1115-65535.</param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithPort(Decimal port)
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
            return  this.portField.HasValue;
        }

        /// <summary>
        /// Gets and sets the BackupRetentionPeriod property.
        /// The number of days for which automated backups are retained. Setting this parameter to a positive number enables
        /// backups. Setting this parameter to 0 disables automated backups.
        /// </summary>
        [XmlElementAttribute(ElementName = "BackupRetentionPeriod")]
        public Decimal BackupRetentionPeriod
        {
            get { return this.backupRetentionPeriodField.GetValueOrDefault() ; }
            set { this.backupRetentionPeriodField= value; }
        }

        /// <summary>
        /// Sets the BackupRetentionPeriod property
        /// </summary>
        /// <param name="backupRetentionPeriod">The number of days for which automated backups are retained. Setting this parameter to a positive number enables
        /// backups. Setting this parameter to 0 disables automated backups.</param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithBackupRetentionPeriod(Decimal backupRetentionPeriod)
        {
            this.backupRetentionPeriodField = backupRetentionPeriod;
            return this;
        }

        /// <summary>
        /// Checks if BackupRetentionPeriod property is set
        /// </summary>
        /// <returns>true if BackupRetentionPeriod property is set</returns>
        public bool IsSetBackupRetentionPeriod()
        {
            return  this.backupRetentionPeriodField.HasValue;
        }

    }
}
