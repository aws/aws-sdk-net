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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedInstancesOffering operation.
    /// <para> The PurchaseReservedInstancesOffering operation purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved
    /// Instances, you purchase the right to launch Amazon EC2 instances for a period of time (without getting insufficient capacity errors) and pay
    /// a lower usage rate for the actual time used. </para>
    /// </summary>
    public partial class PurchaseReservedInstancesOfferingRequest : AmazonEC2Request
    {
        private string reservedInstancesOfferingId;
        private int? instanceCount;
        private ReservedInstanceLimitPrice limitPrice;


        /// <summary>
        /// The unique ID of the Reserved Instances offering being purchased.
        ///  
        /// </summary>
        public string ReservedInstancesOfferingId
        {
            get { return this.reservedInstancesOfferingId; }
            set { this.reservedInstancesOfferingId = value; }
        }

        // Check to see if ReservedInstancesOfferingId property is set
        internal bool IsSetReservedInstancesOfferingId()
        {
            return this.reservedInstancesOfferingId != null;
        }

        /// <summary>
        /// The number of Reserved Instances to purchase.
        ///  
        /// </summary>
        public int InstanceCount
        {
            get { return this.instanceCount ?? default(int); }
            set { this.instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this.instanceCount.HasValue;
        }
        public ReservedInstanceLimitPrice LimitPrice
        {
            get { return this.limitPrice; }
            set { this.limitPrice = value; }
        }

        // Check to see if LimitPrice property is set
        internal bool IsSetLimitPrice()
        {
            return this.limitPrice != null;
        }

    }
}
    
