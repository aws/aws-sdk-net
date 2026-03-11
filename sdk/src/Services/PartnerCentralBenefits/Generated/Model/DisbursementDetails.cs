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
 * Do not modify this file. This file is generated from the partnercentral-benefits-2018-05-10.normal.json service model.
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
namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Contains information about disbursement-based benefit fulfillment, such as direct
    /// payments or reimbursements.
    /// </summary>
    public partial class DisbursementDetails
    {
        private MonetaryValue _disbursedAmount;
        private IssuanceDetail _issuanceDetails;

        /// <summary>
        /// Gets and sets the property DisbursedAmount. 
        /// <para>
        /// The total amount that has been disbursed for this benefit allocation.
        /// </para>
        /// </summary>
        public MonetaryValue DisbursedAmount
        {
            get { return this._disbursedAmount; }
            set { this._disbursedAmount = value; }
        }

        // Check to see if DisbursedAmount property is set
        internal bool IsSetDisbursedAmount()
        {
            return this._disbursedAmount != null;
        }

        /// <summary>
        /// Gets and sets the property IssuanceDetails. 
        /// <para>
        /// Detailed information about how the disbursement was issued and processed.
        /// </para>
        /// </summary>
        public IssuanceDetail IssuanceDetails
        {
            get { return this._issuanceDetails; }
            set { this._issuanceDetails = value; }
        }

        // Check to see if IssuanceDetails property is set
        internal bool IsSetIssuanceDetails()
        {
            return this._issuanceDetails != null;
        }

    }
}