/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved
    /// Instances, you obtain a capacity reservation for a certain instance configuration
    /// over a specified period of time. You pay a lower usage rate than with On-Demand instances
    /// for the time that you actually use the capacity reservation.
    /// 
    ///  
    /// <para>
    /// Use <a>DescribeReservedInstancesOfferings</a> to get a list of Reserved Instance offerings
    /// that match your specifications. After you've purchased a Reserved Instance, you can
    /// check for your new Reserved Instance with <a>DescribeReservedInstances</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
    /// Instances</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
    /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class PurchaseReservedInstancesOfferingRequest : AmazonEC2Request
    {
        private int? _instanceCount;
        private ReservedInstanceLimitPrice _limitPrice;
        private string _reservedInstancesOfferingId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public PurchaseReservedInstancesOfferingRequest() { }

        /// <summary>
        /// Instantiates PurchaseReservedInstancesOfferingRequest with the parameterized properties
        /// </summary>
        /// <param name="reservedInstancesOfferingId">The ID of the Reserved Instance offering to purchase.</param>
        /// <param name="instanceCount">The number of Reserved Instances to purchase.</param>
        public PurchaseReservedInstancesOfferingRequest(string reservedInstancesOfferingId, int instanceCount)
        {
            _reservedInstancesOfferingId = reservedInstancesOfferingId;
            _instanceCount = instanceCount;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of Reserved Instances to purchase.
        /// </para>
        /// </summary>
        public int InstanceCount
        {
            get { return this._instanceCount.GetValueOrDefault(); }
            set { this._instanceCount = value; }
        }

        // Check to see if InstanceCount property is set
        internal bool IsSetInstanceCount()
        {
            return this._instanceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LimitPrice. 
        /// <para>
        /// Specified for Reserved Instance Marketplace offerings to limit the total order and
        /// ensure that the Reserved Instances are not purchased at unexpected prices.
        /// </para>
        /// </summary>
        public ReservedInstanceLimitPrice LimitPrice
        {
            get { return this._limitPrice; }
            set { this._limitPrice = value; }
        }

        // Check to see if LimitPrice property is set
        internal bool IsSetLimitPrice()
        {
            return this._limitPrice != null;
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesOfferingId. 
        /// <para>
        /// The ID of the Reserved Instance offering to purchase.
        /// </para>
        /// </summary>
        public string ReservedInstancesOfferingId
        {
            get { return this._reservedInstancesOfferingId; }
            set { this._reservedInstancesOfferingId = value; }
        }

        // Check to see if ReservedInstancesOfferingId property is set
        internal bool IsSetReservedInstancesOfferingId()
        {
            return this._reservedInstancesOfferingId != null;
        }

    }
}