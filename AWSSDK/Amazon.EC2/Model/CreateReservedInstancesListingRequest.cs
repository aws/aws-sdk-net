/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Creates a new listing for Amazon EC2 Reserved Instances that will be sold in
    /// the Reserved Instance Marketplace. You can submit one Reserved Instance listing
    /// at a time.
    /// </summary>
    /// <remarks>
    /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
    /// capacity that they no longer need with buyers who want to purchase additional capacity.
    /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
    /// like any other Reserved Instances.
    /// 
    /// If you want to sell your Reserved Instances, you must first register as a Seller in
    /// the Reserved Instance Marketplace. After completing the registration process, you can
    /// create a Reserved Instance Marketplace listing of some or all of your Reserved Instances,
    /// and specify the upfront price you want to receive for them.
    /// Your Reserved Instance listings then become available for purchase.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateReservedInstancesListingRequest
    {
        private string reservedInstancesIdField;
        private int? instanceCountField;
        private List<PricingSchedule> pricingSchedulesField;
        private string clientTokenField;

        /// <summary>
        /// The ID of the Reserved Instance that will be listed.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesId")]
        public string ReservedInstancesId
        {
            get { return this.reservedInstancesIdField; }
            set { this.reservedInstancesIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the Reserved Instance that will be listed.
        /// </summary>
        /// <param name="reservedInstancesId">Id of the ReservedInstance</param>
        /// <returns>this instance</returns>
        public CreateReservedInstancesListingRequest WithReservedInstancesId(string reservedInstancesId)
        {
            this.reservedInstancesIdField = reservedInstancesId;
            return this;
        }

        /// <summary>
        /// Checks if the ReservedInstancesId property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetReservedInstancesId()
        {
            return !string.IsNullOrEmpty(this.reservedInstancesIdField);
        }

        /// <summary>
        /// The number of instances that are a part of a Reserved Instance account
        /// that will be listed in the Reserved Instance Marketplace.
        /// </summary>
        /// <remarks>
        /// This number should be less or equal to the instance count 
        /// associated with the Reserved Instance ID specified in the
        /// request.
        /// </remarks>
        [XmlElementAttribute(ElementName = "InstanceCount")]
        public int InstanceCount
        {
            get { return this.instanceCountField.GetValueOrDefault(); }
            set { this.instanceCountField = value; }
        }

        /// <summary>
        /// Sets the number of instances that are a part of a Reserved 
        /// Instance account that will be listed in the Reserved Instance 
        /// Marketplace. 
        /// </summary>
        /// <param name="instanceCount">Number of instances to list</param>
        /// <returns>this instance</returns>
        /// <remarks>
        /// This number should be less or equal to the instance count 
        /// associated with the Reserved Instance ID specified in the
        /// request.
        /// </remarks>
        public CreateReservedInstancesListingRequest WithInstanceCount(int instanceCount)
        {
            this.instanceCountField = instanceCount;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceCount property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetInstanceCount()
        {
            return this.instanceCountField != null;
        }

        /// <summary>
        /// A list specifying the price of the Reserved Instance for each
        /// month remaining in the Reserved Instance term.
        /// </summary>
        [XmlElementAttribute(ElementName = "PricingSchedules")]
        public List<PricingSchedule> PricingSchedules
        {
            get
            {
                if (this.pricingSchedulesField == null)
                    this.pricingSchedulesField = new List<PricingSchedule>();
                return this.pricingSchedulesField;
            }
            set { this.pricingSchedulesField = value; }
        }

        /// <summary>
        /// Sets the price listed for the Reserved Instance.
        /// </summary>
        /// <param name="list">Price to be listed</param>
        /// <returns>this instance</returns>
        public CreateReservedInstancesListingRequest WithPricingSchedules(params PricingSchedule[] list)
        {
            foreach (PricingSchedule item in list)
            {
                this.PricingSchedules.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if the PricingSchedules property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetPricingSchedules()
        {
            return (this.PricingSchedules.Count > 0);
        }

        /// <summary>
        /// A unique, case-sensitive identifier you provide to ensure
        /// idempotency of your listings. 
        /// </summary>
        /// <remarks>
        /// This helps avoid duplicate listings. For more information, see 
        /// 'Ensuring Idempotency' in the Amazon Elastic Compute Cloud User Guide.
        /// </remarks>
        [XmlElementAttribute(ElementName = "ClientToken")]
        public string ClientToken
        {
            get { return this.clientTokenField; }
            set { this.clientTokenField = value; }
        }

        /// <summary>
        /// Sets a unique, case-sensitive identifier you provide 
        /// to ensure idempotency of your listings. 
        /// </summary>
        /// <param name="clientToken">Identifier</param>
        /// <returns>this instance</returns>
        /// <remarks>
        /// This helps avoid duplicate listings. For more information, see 
        /// 'Ensuring Idempotency' in the Amazon Elastic Compute Cloud User Guide.
        /// </remarks>
        public CreateReservedInstancesListingRequest WithClientToken(string clientToken)
        {
            this.clientTokenField = clientToken;
            return this;
        }

        /// <summary>
        /// Checks if the ClientToken property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetClientToken()
        {
            return !string.IsNullOrEmpty(this.clientTokenField);
        }
    }
}
