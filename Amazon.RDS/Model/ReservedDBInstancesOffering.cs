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
    /// <summary>Reserved D B Instances Offering
    /// </summary>
    public class ReservedDBInstancesOffering  
    {
        
        private string reservedDBInstancesOfferingId;
        private string dBInstanceClass;
        private int? duration;
        private double? fixedPrice;
        private double? usagePrice;
        private string productDescription;
        private bool? multiAZ;
        public string ReservedDBInstancesOfferingId
        {
            get { return this.reservedDBInstancesOfferingId; }
            set { this.reservedDBInstancesOfferingId = value; }
        }

        /// <summary>
        /// Sets the ReservedDBInstancesOfferingId property
        /// </summary>
        /// <param name="reservedDBInstancesOfferingId">The value to set for the ReservedDBInstancesOfferingId property </param>
        /// <returns>this instance</returns>
        public ReservedDBInstancesOffering WithReservedDBInstancesOfferingId(string reservedDBInstancesOfferingId)
        {
            this.reservedDBInstancesOfferingId = reservedDBInstancesOfferingId;
            return this;
        }
            
        // Check to see if ReservedDBInstancesOfferingId property is set
        internal bool IsSetReservedDBInstancesOfferingId()
        {
            return this.reservedDBInstancesOfferingId != null;      
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
        public ReservedDBInstancesOffering WithDBInstanceClass(string dBInstanceClass)
        {
            this.dBInstanceClass = dBInstanceClass;
            return this;
        }
            
        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this.dBInstanceClass != null;        
        }
        public int Duration
        {
            get { return this.duration ?? default(int); }
            set { this.duration = value; }
        }

        /// <summary>
        /// Sets the Duration property
        /// </summary>
        /// <param name="duration">The value to set for the Duration property </param>
        /// <returns>this instance</returns>
        public ReservedDBInstancesOffering WithDuration(int duration)
        {
            this.duration = duration;
            return this;
        }
            
        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this.duration.HasValue;      
        }
        public double FixedPrice
        {
            get { return this.fixedPrice ?? default(double); }
            set { this.fixedPrice = value; }
        }

        /// <summary>
        /// Sets the FixedPrice property
        /// </summary>
        /// <param name="fixedPrice">The value to set for the FixedPrice property </param>
        /// <returns>this instance</returns>
        public ReservedDBInstancesOffering WithFixedPrice(double fixedPrice)
        {
            this.fixedPrice = fixedPrice;
            return this;
        }
            
        // Check to see if FixedPrice property is set
        internal bool IsSetFixedPrice()
        {
            return this.fixedPrice.HasValue;        
        }
        public double UsagePrice
        {
            get { return this.usagePrice ?? default(double); }
            set { this.usagePrice = value; }
        }

        /// <summary>
        /// Sets the UsagePrice property
        /// </summary>
        /// <param name="usagePrice">The value to set for the UsagePrice property </param>
        /// <returns>this instance</returns>
        public ReservedDBInstancesOffering WithUsagePrice(double usagePrice)
        {
            this.usagePrice = usagePrice;
            return this;
        }
            
        // Check to see if UsagePrice property is set
        internal bool IsSetUsagePrice()
        {
            return this.usagePrice.HasValue;        
        }
        public string ProductDescription
        {
            get { return this.productDescription; }
            set { this.productDescription = value; }
        }

        /// <summary>
        /// Sets the ProductDescription property
        /// </summary>
        /// <param name="productDescription">The value to set for the ProductDescription property </param>
        /// <returns>this instance</returns>
        public ReservedDBInstancesOffering WithProductDescription(string productDescription)
        {
            this.productDescription = productDescription;
            return this;
        }
            
        // Check to see if ProductDescription property is set
        internal bool IsSetProductDescription()
        {
            return this.productDescription != null;         
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
        public ReservedDBInstancesOffering WithMultiAZ(bool multiAZ)
        {
            this.multiAZ = multiAZ;
            return this;
        }
            
        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this.multiAZ.HasValue;       
        }
    }
}
