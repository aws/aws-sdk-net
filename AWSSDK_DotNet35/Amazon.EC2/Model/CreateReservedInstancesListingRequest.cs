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
    /// Container for the parameters to the CreateReservedInstancesListing operation.
    /// Creates a listing for Amazon EC2 Reserved Instances to be sold in the Reserved Instance
    /// Marketplace. You can submit one Reserved Instance listing at a time. To get a list
    /// of your Reserved Instances, you can use the <a>DescribeReservedInstances</a> operation.
    /// 
    ///  
    /// <para>
    /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
    /// capacity that they no longer need with buyers who want to purchase additional capacity.
    /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
    /// like any other Reserved Instances. 
    /// </para>
    ///  
    /// <para>
    /// To sell your Reserved Instances, you must first register as a Seller in the Reserved
    /// Instance Marketplace. After completing the registration process, you can create a
    /// Reserved Instance Marketplace listing of some or all of your Reserved Instances, and
    /// specify the upfront price to receive for them. Your Reserved Instance listings then
    /// become available for purchase. To view the details of your Reserved Instance listing,
    /// you can use the <a>DescribeReservedInstancesListings</a> operation.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
    /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
    /// </para>
    /// </summary>
    public partial class CreateReservedInstancesListingRequest : AmazonEC2Request
    {
        private string _clientToken;
        private int? _instanceCount;
        private List<PriceScheduleSpecification> _priceSchedules = new List<PriceScheduleSpecification>();
        private string _reservedInstancesId;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier you provide to ensure idempotency of your listings.
        /// This helps avoid duplicate listings. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Run_Instance_Idempotency.html">Ensuring
        /// Idempotency</a> in the <i>Amazon Elastic Compute Cloud User Guide for Linux</i>.
        /// </para>
        /// </summary>
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property InstanceCount. 
        /// <para>
        /// The number of instances that are a part of a Reserved Instance account to be listed
        /// in the Reserved Instance Marketplace. This number should be less than or equal to
        /// the instance count associated with the Reserved Instance ID specified in this call.
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
        /// Gets and sets the property PriceSchedules. 
        /// <para>
        /// A list specifying the price of the Reserved Instance for each month remaining in the
        /// Reserved Instance term.
        /// </para>
        /// </summary>
        public List<PriceScheduleSpecification> PriceSchedules
        {
            get { return this._priceSchedules; }
            set { this._priceSchedules = value; }
        }

        // Check to see if PriceSchedules property is set
        internal bool IsSetPriceSchedules()
        {
            return this._priceSchedules != null && this._priceSchedules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ReservedInstancesId. 
        /// <para>
        /// The ID of the active Reserved Instance.
        /// </para>
        /// </summary>
        public string ReservedInstancesId
        {
            get { return this._reservedInstancesId; }
            set { this._reservedInstancesId = value; }
        }

        // Check to see if ReservedInstancesId property is set
        internal bool IsSetReservedInstancesId()
        {
            return this._reservedInstancesId != null;
        }

    }
}