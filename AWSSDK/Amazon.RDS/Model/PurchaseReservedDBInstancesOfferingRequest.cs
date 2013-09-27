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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.RDS.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedDBInstancesOffering operation.
    /// <para> Purchases a reserved DB Instance offering. </para>
    /// </summary>
    /// <seealso cref="Amazon.RDS.AmazonRDS.PurchaseReservedDBInstancesOffering"/>
    public class PurchaseReservedDBInstancesOfferingRequest : AmazonWebServiceRequest
    {
        private string reservedDBInstancesOfferingId;
        private string reservedDBInstanceId;
        private int? dBInstanceCount;

        /// <summary>
        /// The ID of the Reserved DB Instance offering to purchase. Example: 438012d3-4052-4cc7-b2e3-8d3372e0e706
        ///  
        /// </summary>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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

        /// <summary>
        /// Customer-specified identifier to track this reservation. Example: myreservationID
        ///  
        /// </summary>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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

        /// <summary>
        /// The number of instances to reserve. Default: <c>1</c>
        ///  
        /// </summary>
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
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
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
    
