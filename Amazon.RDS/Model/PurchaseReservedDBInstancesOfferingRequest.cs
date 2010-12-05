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
    /// Container for the parameters to the PurchaseReservedDBInstancesOffering operation.
    /// 
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.PurchaseReservedDBInstancesOffering"/>
    public class PurchaseReservedDBInstancesOfferingRequest : AmazonWebServiceRequest
    {
        private string reservedDBInstancesOfferingId;
        private string reservedDBInstanceId;
        private int? dBInstanceCount;
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
        public PurchaseReservedDBInstancesOfferingRequest WithReservedDBInstancesOfferingId(string reservedDBInstancesOfferingId)
        {
            this.reservedDBInstancesOfferingId = reservedDBInstancesOfferingId;
            return this;
        }
            
        // Check to see if ReservedDBInstancesOfferingId property is set
        internal bool IsSetReservedDBInstancesOfferingId()
        {
            return this.reservedDBInstancesOfferingId != null;      
        }
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
        public PurchaseReservedDBInstancesOfferingRequest WithReservedDBInstanceId(string reservedDBInstanceId)
        {
            this.reservedDBInstanceId = reservedDBInstanceId;
            return this;
        }
            
        // Check to see if ReservedDBInstanceId property is set
        internal bool IsSetReservedDBInstanceId()
        {
            return this.reservedDBInstanceId != null;       
        }
        public int DBInstanceCount
        {
            get { return this.dBInstanceCount ?? default(int); }
            set { this.dBInstanceCount = value; }
        }

        /// <summary>
        /// Sets the DBInstanceCount property
        /// </summary>
        /// <param name="dBInstanceCount">The value to set for the DBInstanceCount property </param>
        /// <returns>this instance</returns>
        public PurchaseReservedDBInstancesOfferingRequest WithDBInstanceCount(int dBInstanceCount)
        {
            this.dBInstanceCount = dBInstanceCount;
            return this;
        }
            
        // Check to see if DBInstanceCount property is set
        internal bool IsSetDBInstanceCount()
        {
            return this.dBInstanceCount.HasValue;       
        }
    }
}
    
