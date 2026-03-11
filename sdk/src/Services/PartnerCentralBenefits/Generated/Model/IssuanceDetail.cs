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
    /// Represents detailed information about a specific issuance of benefit value.
    /// </summary>
    public partial class IssuanceDetail
    {
        private MonetaryValue _issuanceAmount;
        private string _issuanceId;
        private DateTime? _issuedAt;

        /// <summary>
        /// Gets and sets the property IssuanceAmount. 
        /// <para>
        /// The monetary amount or value that was issued in this specific issuance.
        /// </para>
        /// </summary>
        public MonetaryValue IssuanceAmount
        {
            get { return this._issuanceAmount; }
            set { this._issuanceAmount = value; }
        }

        // Check to see if IssuanceAmount property is set
        internal bool IsSetIssuanceAmount()
        {
            return this._issuanceAmount != null;
        }

        /// <summary>
        /// Gets and sets the property IssuanceId. 
        /// <para>
        /// The unique identifier for this specific issuance.
        /// </para>
        /// </summary>
        public string IssuanceId
        {
            get { return this._issuanceId; }
            set { this._issuanceId = value; }
        }

        // Check to see if IssuanceId property is set
        internal bool IsSetIssuanceId()
        {
            return this._issuanceId != null;
        }

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The timestamp when this specific issuance was processed.
        /// </para>
        /// </summary>
        public DateTime? IssuedAt
        {
            get { return this._issuedAt; }
            set { this._issuedAt = value; }
        }

        // Check to see if IssuedAt property is set
        internal bool IsSetIssuedAt()
        {
            return this._issuedAt.HasValue; 
        }

    }
}