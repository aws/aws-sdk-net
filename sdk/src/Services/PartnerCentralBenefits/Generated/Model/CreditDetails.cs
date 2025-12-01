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
    /// Contains information about credit-based benefit fulfillment, including AWS promotional
    /// credits.
    /// </summary>
    public partial class CreditDetails
    {
        private MonetaryValue _allocatedAmount;
        private List<CreditCode> _codes = AWSConfigs.InitializeCollections ? new List<CreditCode>() : null;
        private MonetaryValue _issuedAmount;

        /// <summary>
        /// Gets and sets the property AllocatedAmount. 
        /// <para>
        /// The total amount of credits that have been allocated for this benefit.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonetaryValue AllocatedAmount
        {
            get { return this._allocatedAmount; }
            set { this._allocatedAmount = value; }
        }

        // Check to see if AllocatedAmount property is set
        internal bool IsSetAllocatedAmount()
        {
            return this._allocatedAmount != null;
        }

        /// <summary>
        /// Gets and sets the property Codes. 
        /// <para>
        /// A list of credit codes that have been generated for this benefit allocation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<CreditCode> Codes
        {
            get { return this._codes; }
            set { this._codes = value; }
        }

        // Check to see if Codes property is set
        internal bool IsSetCodes()
        {
            return this._codes != null && (this._codes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property IssuedAmount. 
        /// <para>
        /// The amount of credits that have actually been issued and are available for use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MonetaryValue IssuedAmount
        {
            get { return this._issuedAmount; }
            set { this._issuedAmount = value; }
        }

        // Check to see if IssuedAmount property is set
        internal bool IsSetIssuedAmount()
        {
            return this._issuedAmount != null;
        }

    }
}