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
    /// The details of the renewal that applies at the end date of an agreement.
    /// </summary>
    public partial class RenewalSummary
    {
        private string _offerId;

        /// <summary>
        /// Gets and sets the property OfferId. 
        /// <para>
        /// The unique identifier of the offer that provides the terms for the next renewal cycle.
        /// For most renewals, this is the same offer that the agreement was created from.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string OfferId
        {
            get { return this._offerId; }
            set { this._offerId = value; }
        }

        // Check to see if OfferId property is set
        internal bool IsSetOfferId()
        {
            return this._offerId != null;
        }

    }
}