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
    /// <para>Purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved Instances, you obtain a capacity reservation for a
    /// certain instance configuration over a specified period of time. You pay a lower usage rate than with On-Demand instances for the time that
    /// you actually use the capacity reservation.</para> <para>For more information, see <a
    /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
    /// Compute Cloud User Guide</i> .</para>
    /// </summary>
    public partial class PurchaseReservedInstancesOfferingRequest : AmazonEC2Request
    {
        private string reservedInstancesOfferingId;
        private int? instanceCount;
        private ReservedInstanceLimitPrice limitPrice;


        /// <summary>
        /// The ID of the Reserved Instance offering to purchase.
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

        /// <summary>
        /// Specified for Reserved Instance Marketplace offerings to limit the total order and ensure that the Reserved Instances are not purchased at
        /// unexpected prices.
        ///  
        /// </summary>
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
    
