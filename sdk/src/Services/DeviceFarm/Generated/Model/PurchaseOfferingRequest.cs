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
 * Do not modify this file. This file is generated from the devicefarm-2015-06-23.normal.json service model.
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
namespace Amazon.DeviceFarm.Model
{
    /// <summary>
    /// Container for the parameters to the PurchaseOffering operation.
    /// Immediately purchases offerings for an AWS account. Offerings renew with the latest
    /// total purchased quantity for an offering, unless the renewal was overridden. The API
    /// returns a <c>NotEligible</c> error if the user is not permitted to invoke the operation.
    /// If you must be able to invoke this operation, contact <a href="mailto:aws-devicefarm-support@amazon.com">aws-devicefarm-support@amazon.com</a>.
    /// </summary>
    public partial class PurchaseOfferingRequest : AmazonDeviceFarmRequest
    {
        private string _offeringId;
        private string _offeringPromotionId;
        private int? _quantity;

        /// <summary>
        /// Gets and sets the property OfferingId. 
        /// <para>
        /// The ID of the offering.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=32)]
        public string OfferingId
        {
            get { return this._offeringId; }
            set { this._offeringId = value; }
        }

        // Check to see if OfferingId property is set
        internal bool IsSetOfferingId()
        {
            return this._offeringId != null;
        }

        /// <summary>
        /// Gets and sets the property OfferingPromotionId. 
        /// <para>
        /// The ID of the offering promotion to be applied to the purchase.
        /// </para>
        /// </summary>
        [AWSProperty(Min=4)]
        public string OfferingPromotionId
        {
            get { return this._offeringPromotionId; }
            set { this._offeringPromotionId = value; }
        }

        // Check to see if OfferingPromotionId property is set
        internal bool IsSetOfferingPromotionId()
        {
            return this._offeringPromotionId != null;
        }

        /// <summary>
        /// Gets and sets the property Quantity. 
        /// <para>
        /// The number of device slots to purchase in an offering request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public int? Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        // Check to see if Quantity property is set
        internal bool IsSetQuantity()
        {
            return this._quantity.HasValue; 
        }

    }
}