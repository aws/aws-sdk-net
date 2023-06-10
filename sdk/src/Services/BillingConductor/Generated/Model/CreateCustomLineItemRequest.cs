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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCustomLineItem operation.
    /// Creates a custom line item that can be used to create a one-time fixed charge that
    /// can be applied to a single billing group for the current or previous billing period.
    /// The one-time fixed charge is either a fee or discount.
    /// </summary>
    public partial class CreateCustomLineItemRequest : AmazonBillingConductorRequest
    {
        private string _billingGroupArn;
        private CustomLineItemBillingPeriodRange _billingPeriodRange;
        private CustomLineItemChargeDetails _chargeDetails;
        private string _clientToken;
        private string _description;
        private string _name;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property BillingGroupArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) that references the billing group where the custom
        /// line item applies to. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BillingGroupArn
        {
            get { return this._billingGroupArn; }
            set { this._billingGroupArn = value; }
        }

        // Check to see if BillingGroupArn property is set
        internal bool IsSetBillingGroupArn()
        {
            return this._billingGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property BillingPeriodRange. 
        /// <para>
        ///  A time range for which the custom line item is effective. 
        /// </para>
        /// </summary>
        public CustomLineItemBillingPeriodRange BillingPeriodRange
        {
            get { return this._billingPeriodRange; }
            set { this._billingPeriodRange = value; }
        }

        // Check to see if BillingPeriodRange property is set
        internal bool IsSetBillingPeriodRange()
        {
            return this._billingPeriodRange != null;
        }

        /// <summary>
        /// Gets and sets the property ChargeDetails. 
        /// <para>
        ///  A <code>CustomLineItemChargeDetails</code> that describes the charge details for
        /// a custom line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomLineItemChargeDetails ChargeDetails
        {
            get { return this._chargeDetails; }
            set { this._chargeDetails = value; }
        }

        // Check to see if ChargeDetails property is set
        internal bool IsSetChargeDetails()
        {
            return this._chargeDetails != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        ///  The token that is needed to support idempotency. Idempotency isn't currently supported,
        /// but will be implemented in a future update. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the custom line item. This is shown on the Bills page in association
        /// with the charge value. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of the custom line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  A map that contains tag keys and tag values that are attached to a custom line item.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}