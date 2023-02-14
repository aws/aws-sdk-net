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
    /// Container for the parameters to the UpdateCustomLineItem operation.
    /// Update an existing custom line item in the current or previous billing period.
    /// </summary>
    public partial class UpdateCustomLineItemRequest : AmazonBillingConductorRequest
    {
        private string _arn;
        private CustomLineItemBillingPeriodRange _billingPeriodRange;
        private UpdateCustomLineItemChargeDetails _chargeDetails;
        private string _description;
        private string _name;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        ///  The ARN of the custom line item to be updated. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property BillingPeriodRange.
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
        ///  A <code>ListCustomLineItemChargeDetails</code> containing the new charge details
        /// for the custom line item. 
        /// </para>
        /// </summary>
        public UpdateCustomLineItemChargeDetails ChargeDetails
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
        /// Gets and sets the property Description. 
        /// <para>
        ///  The new line item description of the custom line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=255)]
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
        ///  The new name for the custom line item. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=128)]
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

    }
}