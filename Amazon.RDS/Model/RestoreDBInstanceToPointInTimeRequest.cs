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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the RestoreDBInstanceToPointInTime operation.
    /// <para> This API creates a new RDS instance from a point-in-time system
    /// snapshot. The target database is created from the source database
    /// restore point with the same configuration as the original source
    /// database, except that the new RDS instance is created with the default
    /// security group. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.RestoreDBInstanceToPointInTime"/>
    public class RestoreDBInstanceToPointInTimeRequest : AmazonWebServiceRequest
    {
        private string sourceDBInstanceIdentifier;
        private string targetDBInstanceIdentifier;
        private DateTime? restoreTime;
        private bool? useLatestRestorableTime;
        private string dBInstanceClass;
        private int? port;
        private string availabilityZone;
        private bool? multiAZ;
        private bool? autoMinorVersionUpgrade;

        /// <summary>
        /// The identifier of the source DB Instance from which to restore.
        ///  
        /// </summary>
        public string SourceDBInstanceIdentifier
        {
            get { return this.sourceDBInstanceIdentifier; }
            set { this.sourceDBInstanceIdentifier = value; }
        }

        /// <summary>
        /// Sets the SourceDBInstanceIdentifier property
        /// </summary>
        /// <param name="sourceDBInstanceIdentifier">The value to set for the SourceDBInstanceIdentifier property </param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithSourceDBInstanceIdentifier(string sourceDBInstanceIdentifier)
        {
            this.sourceDBInstanceIdentifier = sourceDBInstanceIdentifier;
            return this;
        }
            
        // Check to see if SourceDBInstanceIdentifier property is set
        internal bool IsSetSourceDBInstanceIdentifier()
        {
            return this.sourceDBInstanceIdentifier != null;         
        }

        /// <summary>
        /// The name of the new database instance to be created.
        ///  
        /// </summary>
        public string TargetDBInstanceIdentifier
        {
            get { return this.targetDBInstanceIdentifier; }
            set { this.targetDBInstanceIdentifier = value; }
        }

        /// <summary>
        /// Sets the TargetDBInstanceIdentifier property
        /// </summary>
        /// <param name="targetDBInstanceIdentifier">The value to set for the TargetDBInstanceIdentifier property </param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithTargetDBInstanceIdentifier(string targetDBInstanceIdentifier)
        {
            this.targetDBInstanceIdentifier = targetDBInstanceIdentifier;
            return this;
        }
            
        // Check to see if TargetDBInstanceIdentifier property is set
        internal bool IsSetTargetDBInstanceIdentifier()
        {
            return this.targetDBInstanceIdentifier != null;         
        }

        /// <summary>
        /// The date and time from to restore from.
        ///  
        /// </summary>
        public DateTime RestoreTime
        {
            get { return this.restoreTime ?? default(DateTime); }
            set { this.restoreTime = value; }
        }

        /// <summary>
        /// Sets the RestoreTime property
        /// </summary>
        /// <param name="restoreTime">The value to set for the RestoreTime property </param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithRestoreTime(DateTime restoreTime)
        {
            this.restoreTime = restoreTime;
            return this;
        }
            
        // Check to see if RestoreTime property is set
        internal bool IsSetRestoreTime()
        {
            return this.restoreTime.HasValue;       
        }

        /// <summary>
        /// Specifies whether (<i>true</i>) or not (<i>false</i>) the DB Instance
        /// is restored from the latest backup time.
        ///  
        /// </summary>
        public bool UseLatestRestorableTime
        {
            get { return this.useLatestRestorableTime ?? default(bool); }
            set { this.useLatestRestorableTime = value; }
        }

        /// <summary>
        /// Sets the UseLatestRestorableTime property
        /// </summary>
        /// <param name="useLatestRestorableTime">The value to set for the UseLatestRestorableTime property </param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithUseLatestRestorableTime(bool useLatestRestorableTime)
        {
            this.useLatestRestorableTime = useLatestRestorableTime;
            return this;
        }
            
        // Check to see if UseLatestRestorableTime property is set
        internal bool IsSetUseLatestRestorableTime()
        {
            return this.useLatestRestorableTime.HasValue;       
        }

        /// <summary>
        /// The compute and memory capacity of the Amazon RDS DB instance.
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
        public RestoreDBInstanceToPointInTimeRequest WithDBInstanceClass(string dBInstanceClass)
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
        /// The port number on which the database accepts connections.
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
        public RestoreDBInstanceToPointInTimeRequest WithPort(int port)
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
        /// The EC2 Availability Zone that the database instance will be created
        /// in.
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
        public RestoreDBInstanceToPointInTimeRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZone = availabilityZone;
            return this;
        }
            
        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;       
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
        public RestoreDBInstanceToPointInTimeRequest WithMultiAZ(bool multiAZ)
        {
            this.multiAZ = multiAZ;
            return this;
        }
            
        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this.multiAZ.HasValue;       
        }
        public bool AutoMinorVersionUpgrade
        {
            get { return this.autoMinorVersionUpgrade ?? default(bool); }
            set { this.autoMinorVersionUpgrade = value; }
        }

        /// <summary>
        /// Sets the AutoMinorVersionUpgrade property
        /// </summary>
        /// <param name="autoMinorVersionUpgrade">The value to set for the AutoMinorVersionUpgrade property </param>
        /// <returns>this instance</returns>
        public RestoreDBInstanceToPointInTimeRequest WithAutoMinorVersionUpgrade(bool autoMinorVersionUpgrade)
        {
            this.autoMinorVersionUpgrade = autoMinorVersionUpgrade;
            return this;
        }
            
        // Check to see if AutoMinorVersionUpgrade property is set
        internal bool IsSetAutoMinorVersionUpgrade()
        {
            return this.autoMinorVersionUpgrade.HasValue;       
        }
    }
}
    
