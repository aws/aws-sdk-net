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
 * Do not modify this file. This file is generated from the marketplace-agreement-2020-03-01.normal.json service model.
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
namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// An individual installment of the payment that includes the date and amount of the
    /// charge.
    /// </summary>
    public partial class ScheduleItem
    {
        private string _chargeAmount;
        private DateTime? _chargeDate;

        /// <summary>
        /// Gets and sets the property ChargeAmount. 
        /// <para>
        /// The price that the customer would pay on the scheduled date (chargeDate).
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
        public string ChargeAmount
        {
            get { return this._chargeAmount; }
            set { this._chargeAmount = value; }
        }

        // Check to see if ChargeAmount property is set
        internal bool IsSetChargeAmount()
        {
            return this._chargeAmount != null;
        }

        /// <summary>
        /// Gets and sets the property ChargeDate. 
        /// <para>
        /// The date that the customer would pay the price defined in this payment schedule term.
        /// Invoices are generated on the date provided.
        /// </para>
        /// </summary>
        public DateTime? ChargeDate
        {
            get { return this._chargeDate; }
            set { this._chargeDate = value; }
        }

        // Check to see if ChargeDate property is set
        internal bool IsSetChargeDate()
        {
            return this._chargeDate.HasValue; 
        }

    }
}