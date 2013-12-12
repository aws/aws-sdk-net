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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// <para> Contains a list of available options for a DB instance </para> <para> This data type is used as a response element in the
    /// DescribeOrderableDBInstanceOptions action. </para>
    /// </summary>
    public class OrderableDBInstanceOption
    {
        
        private string engine;
        private string engineVersion;
        private string dBInstanceClass;
        private string licenseModel;
        private List<AvailabilityZone> availabilityZones = new List<AvailabilityZone>();
        private bool? multiAZCapable;
        private bool? readReplicaCapable;
        private bool? vpc;


        /// <summary>
        /// The engine type of the orderable DB instance.
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
        /// The engine version of the orderable DB instance.
        ///  
        /// </summary>
        public string EngineVersion
        {
            get { return this.engineVersion; }
            set { this.engineVersion = value; }
        }

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;
        }

        /// <summary>
        /// The DB instance Class for the orderable DB instance
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
        /// The license model for the orderable DB instance.
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
        /// A list of availability zones for the orderable DB instance.
        ///  
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones
        {
            get { return this.availabilityZones; }
            set { this.availabilityZones = value; }
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this.availabilityZones.Count > 0;
        }

        /// <summary>
        /// Indicates whether this orderable DB instance is multi-AZ capable.
        ///  
        /// </summary>
        public bool MultiAZCapable
        {
            get { return this.multiAZCapable ?? default(bool); }
            set { this.multiAZCapable = value; }
        }

        // Check to see if MultiAZCapable property is set
        internal bool IsSetMultiAZCapable()
        {
            return this.multiAZCapable.HasValue;
        }

        /// <summary>
        /// Indicates whether this orderable DB instance can have a read replica.
        ///  
        /// </summary>
        public bool ReadReplicaCapable
        {
            get { return this.readReplicaCapable ?? default(bool); }
            set { this.readReplicaCapable = value; }
        }

        // Check to see if ReadReplicaCapable property is set
        internal bool IsSetReadReplicaCapable()
        {
            return this.readReplicaCapable.HasValue;
        }

        /// <summary>
        /// Indicates whether this is a VPC orderable DB instance.
        ///  
        /// </summary>
        public bool Vpc
        {
            get { return this.vpc ?? default(bool); }
            set { this.vpc = value; }
        }

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this.vpc.HasValue;
        }
    }
}
