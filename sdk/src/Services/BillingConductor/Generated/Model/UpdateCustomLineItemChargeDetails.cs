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
    /// A representation of the new charge details of a custom line item. This should contain
    /// only one of <code>Flat</code> or <code>Percentage</code>.
    /// </summary>
    public partial class UpdateCustomLineItemChargeDetails
    {
        private UpdateCustomLineItemFlatChargeDetails _flat;
        private UpdateCustomLineItemPercentageChargeDetails _percentage;

        /// <summary>
        /// Gets and sets the property Flat. 
        /// <para>
        ///  An <code>UpdateCustomLineItemFlatChargeDetails</code> that describes the new charge
        /// details of a flat custom line item. 
        /// </para>
        /// </summary>
        public UpdateCustomLineItemFlatChargeDetails Flat
        {
            get { return this._flat; }
            set { this._flat = value; }
        }

        // Check to see if Flat property is set
        internal bool IsSetFlat()
        {
            return this._flat != null;
        }

        /// <summary>
        /// Gets and sets the property Percentage. 
        /// <para>
        ///  An <code>UpdateCustomLineItemPercentageChargeDetails</code> that describes the new
        /// charge details of a percentage custom line item. 
        /// </para>
        /// </summary>
        public UpdateCustomLineItemPercentageChargeDetails Percentage
        {
            get { return this._percentage; }
            set { this._percentage = value; }
        }

        // Check to see if Percentage property is set
        internal bool IsSetPercentage()
        {
            return this._percentage != null;
        }

    }
}