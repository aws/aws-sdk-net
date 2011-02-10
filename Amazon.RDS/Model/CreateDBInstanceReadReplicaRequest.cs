/*
 * Copyright 2010-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Container for the parameters to the CreateDBInstanceReadReplica operation.
    /// 
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.CreateDBInstanceReadReplica"/>
    public class CreateDBInstanceReadReplicaRequest : AmazonWebServiceRequest
    {
        private string dBInstanceIdentifier;
        private string sourceDBInstanceIdentifier;
        private string dBInstanceClass;
        private string availabilityZone;
        private int? port;
        private bool? autoMinorVersionUpgrade;
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
        public CreateDBInstanceReadReplicaRequest WithDBInstanceIdentifier(string dBInstanceIdentifier)
        {
            this.dBInstanceIdentifier = dBInstanceIdentifier;
            return this;
        }
            
        // Check to see if DBInstanceIdentifier property is set
        internal bool IsSetDBInstanceIdentifier()
        {
            return this.dBInstanceIdentifier != null;       
        }
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
        public CreateDBInstanceReadReplicaRequest WithSourceDBInstanceIdentifier(string sourceDBInstanceIdentifier)
        {
            this.sourceDBInstanceIdentifier = sourceDBInstanceIdentifier;
            return this;
        }
            
        // Check to see if SourceDBInstanceIdentifier property is set
        internal bool IsSetSourceDBInstanceIdentifier()
        {
            return this.sourceDBInstanceIdentifier != null;         
        }
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
        public CreateDBInstanceReadReplicaRequest WithDBInstanceClass(string dBInstanceClass)
        {
            this.dBInstanceClass = dBInstanceClass;
            return this;
        }
            
        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this.dBInstanceClass != null;        
        }
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
        public CreateDBInstanceReadReplicaRequest WithAvailabilityZone(string availabilityZone)
        {
            this.availabilityZone = availabilityZone;
            return this;
        }
            
        // Check to see if AvailabilityZone property is set
        internal bool IsSetAvailabilityZone()
        {
            return this.availabilityZone != null;       
        }
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
        public CreateDBInstanceReadReplicaRequest WithPort(int port)
        {
            this.port = port;
            return this;
        }
            
        // Check to see if Port property is set
        internal bool IsSetPort()
        {
            return this.port.HasValue;      
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
        public CreateDBInstanceReadReplicaRequest WithAutoMinorVersionUpgrade(bool autoMinorVersionUpgrade)
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
    
