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
    /// <para> Contains a list of available options for a DB Instance </para> <para> This data type is used as a response element in the
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
        /// The engine type of the orderable DB Instance.
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableDBInstanceOption WithEngine(string engine)
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
        /// The engine version of the orderable DB Instance.
        ///  
        /// </summary>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableDBInstanceOption WithEngineVersion(string engineVersion)
        {
            this.engineVersion = engineVersion;
            return this;
        }
            

        // Check to see if EngineVersion property is set
        internal bool IsSetEngineVersion()
        {
            return this.engineVersion != null;
        }

        /// <summary>
        /// The DB Instance Class for the orderable DB Instance
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableDBInstanceOption WithDBInstanceClass(string dBInstanceClass)
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
        /// The license model for the orderable DB Instance.
        ///  
        /// </summary>
        public string LicenseModel
        {
            get { return this.licenseModel; }
            set { this.licenseModel = value; }
        }

        /// <summary>
        /// Sets the LicenseModel property
        /// </summary>
        /// <param name="licenseModel">The value to set for the LicenseModel property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableDBInstanceOption WithLicenseModel(string licenseModel)
        {
            this.licenseModel = licenseModel;
            return this;
        }
            

        // Check to see if LicenseModel property is set
        internal bool IsSetLicenseModel()
        {
            return this.licenseModel != null;
        }

        /// <summary>
        /// A list of availability zones for the orderable DB Instance.
        ///  
        /// </summary>
        public List<AvailabilityZone> AvailabilityZones
        {
            get { return this.availabilityZones; }
            set { this.availabilityZones = value; }
        }
        /// <summary>
        /// Adds elements to the AvailabilityZones collection
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableDBInstanceOption WithAvailabilityZones(params AvailabilityZone[] availabilityZones)
        {
            foreach (AvailabilityZone element in availabilityZones)
            {
                this.availabilityZones.Add(element);
            }

            return this;
        }

        /// <summary>
        /// Adds elements to the AvailabilityZones collection
        /// </summary>
        /// <param name="availabilityZones">The values to add to the AvailabilityZones collection </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableDBInstanceOption WithAvailabilityZones(IEnumerable<AvailabilityZone> availabilityZones)
        {
            foreach (AvailabilityZone element in availabilityZones)
            {
                this.availabilityZones.Add(element);
            }

            return this;
        }

        // Check to see if AvailabilityZones property is set
        internal bool IsSetAvailabilityZones()
        {
            return this.availabilityZones.Count > 0;
        }

        /// <summary>
        /// Indicates whether this orderable DB Instance is multi-AZ capable.
        ///  
        /// </summary>
        public bool MultiAZCapable
        {
            get { return this.multiAZCapable ?? default(bool); }
            set { this.multiAZCapable = value; }
        }

        /// <summary>
        /// Sets the MultiAZCapable property
        /// </summary>
        /// <param name="multiAZCapable">The value to set for the MultiAZCapable property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableDBInstanceOption WithMultiAZCapable(bool multiAZCapable)
        {
            this.multiAZCapable = multiAZCapable;
            return this;
        }
            

        // Check to see if MultiAZCapable property is set
        internal bool IsSetMultiAZCapable()
        {
            return this.multiAZCapable.HasValue;
        }

        /// <summary>
        /// Indicates whether this orderable DB Instance can have a read replica.
        ///  
        /// </summary>
        public bool ReadReplicaCapable
        {
            get { return this.readReplicaCapable ?? default(bool); }
            set { this.readReplicaCapable = value; }
        }

        /// <summary>
        /// Sets the ReadReplicaCapable property
        /// </summary>
        /// <param name="readReplicaCapable">The value to set for the ReadReplicaCapable property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableDBInstanceOption WithReadReplicaCapable(bool readReplicaCapable)
        {
            this.readReplicaCapable = readReplicaCapable;
            return this;
        }
            

        // Check to see if ReadReplicaCapable property is set
        internal bool IsSetReadReplicaCapable()
        {
            return this.readReplicaCapable.HasValue;
        }

        /// <summary>
        /// Indicates whether this is a VPC orderable DB Instance.
        ///  
        /// </summary>
        public bool Vpc
        {
            get { return this.vpc ?? default(bool); }
            set { this.vpc = value; }
        }

        /// <summary>
        /// Sets the Vpc property
        /// </summary>
        /// <param name="vpc">The value to set for the Vpc property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public OrderableDBInstanceOption WithVpc(bool vpc)
        {
            this.vpc = vpc;
            return this;
        }
            

        // Check to see if Vpc property is set
        internal bool IsSetVpc()
        {
            return this.vpc.HasValue;
        }
    }
}
