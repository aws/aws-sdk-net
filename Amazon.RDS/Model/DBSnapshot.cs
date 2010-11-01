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
    public class DBSnapshot  
    {
        
        private string dBSnapshotIdentifier;
        private string dBInstanceIdentifier;
        private DateTime? snapshotCreateTime;
        private string engine;
        private int? allocatedStorage;
        private string status;
        private int? port;
        private string availabilityZone;
        private DateTime? instanceCreateTime;
        private string masterUsername;
        private string engineVersion;

        /// <summary>
        /// Specifies the identifier for the DB Snapshot.
        ///  
        /// </summary>
        public string DBSnapshotIdentifier
        {
            get { return this.dBSnapshotIdentifier; }
            set { this.dBSnapshotIdentifier = value; }
        }

        /// <summary>
        /// Sets the DBSnapshotIdentifier property
        /// </summary>
        /// <param name="dBSnapshotIdentifier">The value to set for the DBSnapshotIdentifier property </param>
        /// <returns>this instance</returns>
        public DBSnapshot WithDBSnapshotIdentifier(string dBSnapshotIdentifier)
        {
            this.dBSnapshotIdentifier = dBSnapshotIdentifier;
            return this;
        }
            
        // Check to see if DBSnapshotIdentifier property is set
        internal bool IsSetDBSnapshotIdentifier()
        {
            return this.dBSnapshotIdentifier != null;       
        }

        /// <summary>
        /// Specifies the the DBInstanceIdentifier of the DB Instance this DB
        /// Snapshot was created from.
        ///  
        /// </summary>
        public string DBInstanceIdentifier
        {
            get { return this.dBInstanceIdentifier; }
            set { this.dBInstanceIdentifier = value; }
        }

        /// <summary>
        /// Sets the DBInstanceIdentifier property
        /// </summary>
        /// <param name="dBInstanceIdentifier">The value to set for the DBInstanceIdentifier property </param>
        /// <returns>this instance</returns>
        public DBSnapshot WithDBInstanceIdentifier(string dBInstanceIdentifier)
        {
            this.dBInstanceIdentifier = dBInstanceIdentifier;
            return this;
        }
            
        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;       
        }

        /// <summary>
        /// Provides the time (UTC) when the snapshot was taken.
        ///  
        /// </summary>
        public DateTime SnapshotCreateTime
        {
            get { return this.snapshotCreateTime ?? default(DateTime); }
            set { this.snapshotCreateTime = value; }
        }

        /// <summary>
        /// Sets the SnapshotCreateTime property
        /// </summary>
        /// <param name="snapshotCreateTime">The value to set for the SnapshotCreateTime property </param>
        /// <returns>this instance</returns>
        public DBSnapshot WithSnapshotCreateTime(DateTime snapshotCreateTime)
        {
            this.snapshotCreateTime = snapshotCreateTime;
            return this;
        }
            
        // Check to see if SnapshotCreateTime property is set
        internal bool IsSetSnapshotCreateTime()
        {
            return this.snapshotCreateTime.HasValue;        
        }

        /// <summary>
        /// Specifies the name of the database engine.
        ///  
        /// </summary>
        public string Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        /// <summary>
        /// Sets the Engine property
        /// </summary>
        /// <param name="engine">The value to set for the Engine property </param>
        /// <returns>this instance</returns>
        public DBSnapshot WithEngine(string engine)
        {
            this.engine = engine;
            return this;
        }
            
        // Check to see if Engine property is set
        internal bool IsSetEngine()
        {
            return this.engine != null;         
        }

        /// <summary>
        /// Specifies the allocated storage size in gigabytes (GB).
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
        public DBSnapshot WithAllocatedStorage(int allocatedStorage)
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
        /// Specifies the status of this DB Snapshot.
        ///  
        /// </summary>
        public string Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        /// <summary>
        /// Sets the Status property
        /// </summary>
        /// <param name="status">The value to set for the Status property </param>
        /// <returns>this instance</returns>
        public DBSnapshot WithStatus(string status)
        {
            this.status = status;
            return this;
        }
            
        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;         
        }

        /// <summary>
        /// Specifies the port that the database engine was listening on at the
        /// time of the snapshot.
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
        public DBSnapshot WithPort(int port)
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
        /// Specifies the name of the Availability Zone the DB Instance was
        /// located in at the time of the DB Snapshot.
        ///  
        /// </summary>
        public string AvailabilityZone
        {
            get { return this.availabilityZone; }
            set { this.availabilityZone = value; }
        }

        /// <summary>
        /// Sets the AvailabilityZone property
        /// </summary>
        /// <param name="availabilityZone">The value to set for the AvailabilityZone property </param>
        /// <returns>this instance</returns>
        public DBSnapshot WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZone = availabilityZone;
            return this;
        }
            
        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;       
        }

        /// <summary>
        /// Specifies the time (UTC) when the snapshot was taken.
        ///  
        /// </summary>
        public DateTime InstanceCreateTime
        {
            get { return this.instanceCreateTime ?? default(DateTime); }
            set { this.instanceCreateTime = value; }
        }

        /// <summary>
        /// Sets the InstanceCreateTime property
        /// </summary>
        /// <param name="instanceCreateTime">The value to set for the InstanceCreateTime property </param>
        /// <returns>this instance</returns>
        public DBSnapshot WithInstanceCreateTime(DateTime instanceCreateTime)
        {
            this.instanceCreateTime = instanceCreateTime;
            return this;
        }
            
        // Check to see if InstanceCreateTime property is set
        internal bool IsSetInstanceCreateTime()
        {
            return this.instanceCreateTime.HasValue;        
        }

        /// <summary>
        /// Provides the master username for the DB Instance.
        ///  
        /// </summary>
        public string MasterUsername
        {
            get { return this.masterUsername; }
            set { this.masterUsername = value; }
        }

        /// <summary>
        /// Sets the MasterUsername property
        /// </summary>
        /// <param name="masterUsername">The value to set for the MasterUsername property </param>
        /// <returns>this instance</returns>
        public DBSnapshot WithMasterUsername(string masterUsername)
        {
            this.masterUsername = masterUsername;
            return this;
        }
            
        // Check to see if MasterUsername property is set
        internal bool IsSetMasterUsername()
        {
            return this.masterUsername != null;         
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
        public DBSnapshot WithEngineVersion(string engineVersion)
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
