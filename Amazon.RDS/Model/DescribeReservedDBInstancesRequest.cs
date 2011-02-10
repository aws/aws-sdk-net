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
    /// Container for the parameters to the DescribeReservedDBInstances operation.
    /// 
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.DescribeReservedDBInstances"/>
    public class DescribeReservedDBInstancesRequest : AmazonWebServiceRequest
    {
        private string reservedDBInstanceId;
        private string reservedDBInstancesOfferingId;
        private string dBInstanceClass;
        private string duration;
        private string productDescription;
        private bool? multiAZ;
        private int? maxRecords;
        private string marker;
        public string ReservedDBInstanceId
        {
            get { return this.reservedDBInstanceId; }
            set { this.reservedDBInstanceId = value; }
        }

        /// <summary>
        /// Sets the ReservedDBInstanceId property
        /// </summary>
        /// <param name="reservedDBInstanceId">The value to set for the ReservedDBInstanceId property </param>
        /// <returns>this instance</returns>
        public DescribeReservedDBInstancesRequest WithReservedDBInstanceId(string reservedDBInstanceId)
        {
            this.reservedDBInstanceId = reservedDBInstanceId;
            return this;
        }
            
        // Check to see if ReservedDBInstanceId property is set
        internal bool IsSetReservedDBInstanceId()
        {
            return this.reservedDBInstanceId != null;       
        }
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
        public DescribeReservedDBInstancesRequest WithReservedDBInstancesOfferingId(string reservedDBInstancesOfferingId)
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
        public DescribeReservedDBInstancesRequest WithDBInstanceClass(string dBInstanceClass)
        {
            this.dBInstanceClass = dBInstanceClass;
            return this;
        }
            
        // Check to see if DBInstanceClass property is set
        internal bool IsSetDBInstanceClass()
        {
            return this.dBInstanceClass != null;        
        }
        public string Duration
        {
            get { return this.duration; }
            set { this.duration = value; }
        }

        /// <summary>
        /// Sets the Duration property
        /// </summary>
        /// <param name="duration">The value to set for the Duration property </param>
        /// <returns>this instance</returns>
        public DescribeReservedDBInstancesRequest WithDuration(string duration)
        {
            this.duration = duration;
            return this;
        }
            
        // Check to see if Duration property is set
        internal bool IsSetDuration()
        {
            return this.duration != null;       
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
        public DescribeReservedDBInstancesRequest WithProductDescription(string productDescription)
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
        public DescribeReservedDBInstancesRequest WithMultiAZ(bool multiAZ)
        {
            this.multiAZ = multiAZ;
            return this;
        }
            
        // Check to see if MultiAZ property is set
        internal bool IsSetMultiAZ()
        {
            return this.multiAZ.HasValue;       
        }
        public int MaxRecords
        {
            get { return this.maxRecords ?? default(int); }
            set { this.maxRecords = value; }
        }

        /// <summary>
        /// Sets the MaxRecords property
        /// </summary>
        /// <param name="maxRecords">The value to set for the MaxRecords property </param>
        /// <returns>this instance</returns>
        public DescribeReservedDBInstancesRequest WithMaxRecords(int maxRecords)
        {
            this.maxRecords = maxRecords;
            return this;
        }
            
        // Check to see if MaxRecords property is set
        internal bool IsSetMaxRecords()
        {
            return this.maxRecords.HasValue;        
        }
        public string Marker
        {
            get { return this.marker; }
            set { this.marker = value; }
        }

        /// <summary>
        /// Sets the Marker property
        /// </summary>
        /// <param name="marker">The value to set for the Marker property </param>
        /// <returns>this instance</returns>
        public DescribeReservedDBInstancesRequest WithMarker(string marker)
        {
            this.marker = marker;
            return this;
        }
            
        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this.marker != null;         
        }
    }
}
    
