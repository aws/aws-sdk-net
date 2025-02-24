/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseReservedInstancesOffering operation.
    /// Purchases a Reserved Instance for use with your account. With Reserved Instances,
    /// you pay a lower hourly rate compared to On-Demand instance pricing.
    /// 
    ///  
    /// <para>
    /// Use <a>DescribeReservedInstancesOfferings</a> to get a list of Reserved Instance offerings
    /// that match your specifications. After you've purchased a Reserved Instance, you can
    /// check for your new Reserved Instance with <a>DescribeReservedInstances</a>.
    /// </para>
    ///  
    /// <para>
    /// To queue a purchase for a future date and time, specify a purchase time. If you do
    /// not specify a purchase time, the default is the current time.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
    /// Instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Sell
    /// in the Reserved Instance Marketplace</a> in the <i>Amazon EC2 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PurchaseReservedInstancesOfferingRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private int? _instanceCount;
        private ReservedInstanceLimitPrice _limitPrice;
        private DateTime? _purchaseTime;
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
        public PurchaseReservedInstancesOfferingRequest(string reservedInstancesOfferingId, int? instanceCount)
        {
            _reservedInstancesOfferingId = reservedInstancesOfferingId;
            _instanceCount = instanceCount;
        }

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of Reserved Instances to purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? InstanceCount
        {
            get { return this._instanceCount; }
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
        /// Gets and sets the property PurchaseTime. 
        /// <para>
        /// The time at which to purchase the Reserved Instance, in UTC format (for example, <i>YYYY</i>-<i>MM</i>-<i>DD</i>T<i>HH</i>:<i>MM</i>:<i>SS</i>Z).
        /// </para>
        /// </summary>
        public DateTime? PurchaseTime
        {
            get { return this._purchaseTime; }
            set { this._purchaseTime = value; }
        }

        // Check to see if PurchaseTime property is set
        internal bool IsSetPurchaseTime()
        {
            return this._purchaseTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesOfferingId. 
        /// <para>
        /// The ID of the Reserved Instance offering to purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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