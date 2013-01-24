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
    /// Purchases a Reserved Instance for use with your account.
    /// </summary>
    /// <remarks>
    /// With Amazon EC2 Reserved Instances, you purchase the right
    /// to launch Amazon EC2 instances for a period of time (without
    /// getting insufficient capacity errors) and pay a lower usage rate for
    /// the actual time used.
    /// 
    /// For more information about Reserved Instances, go to the Amazon
    /// Elastic Compute Cloud Developer Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class PurchaseReservedInstancesOfferingRequest
    {    
        private string reservedInstancesOfferingIdField;
        private string instanceCountField;
        private ReservedInstanceLimitPrice limitPriceField;

        /// <summary>
        /// The offering ID of the Reserved Instance to purchase.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReservedInstancesOfferingId")]
        public string ReservedInstancesOfferingId
        {
            get { return this.reservedInstancesOfferingIdField; }
            set { this.reservedInstancesOfferingIdField = value; }
        }

        /// <summary>
        /// Sets the offering ID of the Reserved Instance to purchase.
        /// </summary>
        /// <param name="reservedInstancesOfferingId">The offering ID of the Reserved Instance to
        /// purchase.</param>
        /// <returns>this instance</returns>
        public PurchaseReservedInstancesOfferingRequest WithReservedInstancesOfferingId(string reservedInstancesOfferingId)
        {
            this.reservedInstancesOfferingIdField = reservedInstancesOfferingId;
            return this;
        }

        /// <summary>
        /// Checks if ReservedInstancesOfferingId property is set
        /// </summary>
        /// <returns>true if ReservedInstancesOfferingId property is set</returns>
        public bool IsSetReservedInstancesOfferingId()
        {
            return this.reservedInstancesOfferingIdField != null;
        }

        /// <summary>
        /// The number of Reserved Instances to purchase.
        /// Default: None
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceCount")]
        public string InstanceCount
        {
            get { return this.instanceCountField; }
            set { this.instanceCountField = value; }
        }

        /// <summary>
        /// Sets the number of Reserved Instances to purchase.
        /// </summary>
        /// <param name="instanceCount">The number of Reserved Instances to purchase.
        /// Default: None</param>
        /// <returns>this instance</returns>
        public PurchaseReservedInstancesOfferingRequest WithInstanceCount(string instanceCount)
        {
            this.instanceCountField = instanceCount;
            return this;
        }

        /// <summary>
        /// Checks if InstanceCount property is set
        /// </summary>
        /// <returns>true if InstanceCount property is set</returns>
        public bool IsSetInstanceCount()
        {
            return this.instanceCountField != null;
        }

        /// <summary>
        /// The limiting price for Reserved Instance Marketplace offerings.
        /// 
        /// This limits the total order and ensures that the Reserved 
        /// Instances are not purchased at unexpected prices.
        /// </summary>
        [XmlElementAttribute(ElementName = "LimitPrice")]
        public ReservedInstanceLimitPrice LimitPrice
        {
            get { return this.limitPriceField; }
            set { this.limitPriceField = value; }
        }

        /// <summary>
        /// Sets the limiting price for Reserved Instance Marketplace offerings.
        /// </summary>
        /// <param name="limitPrice">Price limit</param>
        /// <returns>this instance</returns>
        public PurchaseReservedInstancesOfferingRequest WithLimitPrice(ReservedInstanceLimitPrice limitPrice)
        {
            this.limitPriceField = limitPrice;
            return this;
        }

        /// <summary>
        /// Checks if the LimitPrice property is set.
        /// </summary>
        /// <returns>True if the property is set</returns>
        public bool IsSetLimitPrice()
        {
            return this.limitPriceField != null;
        }
    }
}
