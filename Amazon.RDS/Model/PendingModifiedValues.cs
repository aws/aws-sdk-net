/*
 * Copyright 2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> </para>
    /// </summary>
    public class PendingModifiedValues  
    {
        
        private string dBInstanceClass;
        private int? allocatedStorage;
        private string masterUserPassword;
        private int? port;
        private int? backupRetentionPeriod;
        private bool? multiAZ;
        private string engineVersion;

        /// <summary>
        /// Contains the new <i>DBInstanceClass</i> for the DB Instance that will
        /// be applied or is in progress.
        ///  
        /// </summary>
        public string DBInstanceClass
        {
            get { return this.dBInstanceClass; }
            set { this.dBInstanceClass = value; }
        }

        /// <summary>
        /// Sets the DBInstanceClass property
        /// </summary>
        /// <param name="dBInstanceClass">The value to set for the DBInstanceClass property </param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithDBInstanceClass(string dBInstanceClass)
        {
            this.dBInstanceClass = dBInstanceClass;
            return this;
        }
            
        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this.dBInstanceClass != null;        
        }

        /// <summary>
        /// Contains the new <i>AllocatedStorage</i> size for the DB Instance that
        /// will be applied or is in progress.
        ///  
        /// </summary>
        public int AllocatedStorage
        {
            get { return this.allocatedStorage ?? default(int); }
            set { this.allocatedStorage = value; }
        }

        /// <summary>
        /// Sets the AllocatedStorage property
        /// </summary>
        /// <param name="allocatedStorage">The value to set for the AllocatedStorage property </param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithAllocatedStorage(int allocatedStorage)
        {
            this.allocatedStorage = allocatedStorage;
            return this;
        }
            
        // Check to see if AllocatedStorage property is set
        internal bool IsSetAllocatedStorage()
        {
            return this.allocatedStorage.HasValue;      
        }

        /// <summary>
        /// Contains the pending or in-progress change of the master credentials
        /// for the DB Instance.
        ///  
        /// </summary>
        public string MasterUserPassword
        {
            get { return this.masterUserPassword; }
            set { this.masterUserPassword = value; }
        }

        /// <summary>
        /// Sets the MasterUserPassword property
        /// </summary>
        /// <param name="masterUserPassword">The value to set for the MasterUserPassword property </param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithMasterUserPassword(string masterUserPassword)
        {
            this.masterUserPassword = masterUserPassword;
            return this;
        }
            
        // Check to see if MasterUserPassword property is set
        internal bool IsSetMasterUserPassword()
        {
            return this.masterUserPassword != null;         
        }

        /// <summary>
        /// Specifies the pending port for the DB Instance.
        ///  
        /// </summary>
        public int Port
        {
            get { return this.port ?? default(int); }
            set { this.port = value; }
        }

        /// <summary>
        /// Sets the Port property
        /// </summary>
        /// <param name="port">The value to set for the Port property </param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithPort(int port)
        {
            this.port = port;
            return this;
        }
            
        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;      
        }

        /// <summary>
        /// Specifies the pending number of days for which automated backups are
        /// retained.
        ///  
        /// </summary>
        public int BackupRetentionPeriod
        {
            get { return this.backupRetentionPeriod ?? default(int); }
            set { this.backupRetentionPeriod = value; }
        }

        /// <summary>
        /// Sets the BackupRetentionPeriod property
        /// </summary>
        /// <param name="backupRetentionPeriod">The value to set for the BackupRetentionPeriod property </param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithBackupRetentionPeriod(int backupRetentionPeriod)
        {
            this.backupRetentionPeriod = backupRetentionPeriod;
            return this;
        }
            
        // Check to see if BackupRetentionPeriod property is set
        internal bool IsSetBackupRetentionPeriod()
        {
            return this.backupRetentionPeriod.HasValue;         
        }
        public bool MultiAZ
        {
            get { return this.multiAZ ?? default(bool); }
            set { this.multiAZ = value; }
        }

        /// <summary>
        /// Sets the MultiAZ property
        /// </summary>
        /// <param name="multiAZ">The value to set for the MultiAZ property </param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithMultiAZ(bool multiAZ)
        {
            this.multiAZ = multiAZ;
            return this;
        }
            
        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this.multiAZ.HasValue;       
        }
        public string EngineVersion
        {
            get { return this.engineVersion; }
            set { this.engineVersion = value; }
        }

        /// <summary>
        /// Sets the EngineVersion property
        /// </summary>
        /// <param name="engineVersion">The value to set for the EngineVersion property </param>
        /// <returns>this instance</returns>
        public PendingModifiedValues WithEngineVersion(string engineVersion)
        {
            this.engineVersion = engineVersion;
            return this;
        }
            
        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;      
        }
    }
}
