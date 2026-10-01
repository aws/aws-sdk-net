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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Outposts.Model
{
    /// <summary>
    /// A requirement that must be met before an order can be submitted for a quote.
    /// </summary>
    public partial class OrderingRequirement
    {
        /// <summary>
        /// Gets and sets the property OrderingRequirementType. 
        /// <para>
        /// The type of ordering requirement. Indicates which check failed or passed.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>OUTPOST_ACTIVE_CHECK_ERROR</c> - The Outpost must be in an active state.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>MAXIMUM_ALLOWED_ORDERS_CHECK_ERROR</c> - The maximum number of allowed orders
        /// has been reached.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VALID_ZIP_CODE_CHECK_ERROR</c> - The site address must have a valid zip code.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RACK_PHYSICAL_PROPERTIES_CHECK_ERROR</c> - The rack physical properties do not
        /// meet requirements.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OPERATING_ADDRESS_EXISTENCE_CHECK_ERROR</c> - The site must have an operating
        /// address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SHIPPING_ADDRESS_EXISTENCE_CHECK_ERROR</c> - The site must have a shipping address.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>COUNTRY_CODE_MISMATCH_CHECK_ERROR</c> - The country code on the quote does not
        /// match the Outpost site country.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUTPOST_GENERATION_MISMATCH_ERROR</c> - The Outpost generation does not match
        /// the requested configuration.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUTPOST_ID_MISSING_ON_QUOTE_ERROR</c> - The quote must be associated with an Outpost
        /// before submitting an order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ENTERPRISE_SUPPORT_ERROR</c> - Enterprise Support is required.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SHIPPING_ADDRESS_MISSING_CONTACT_NAME_ERROR</c> - The shipping address must have
        /// a contact name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SHIPPING_ADDRESS_MISSING_CONTACT_NUMBER_ERROR</c> - The shipping address must
        /// have a contact phone number.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SHIPPING_ADDRESS_MISSING_CONTACT_INFO_ERROR</c> - The shipping address must have
        /// contact information.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUTPOST_STATE_CHANGED_ERROR</c> - The Outpost state has changed since the quote
        /// was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUTPOST_NOT_FOUND_ERROR</c> - The Outpost associated with the quote was not found.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>OUTPOST_RENEWAL_REQUIRED_ERROR</c> - The Outpost requires a renewal before a new
        /// order can be submitted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>UNSUPPORTED</c> - The requirement type is not recognized.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public OrderingRequirementType OrderingRequirementType { get; set; }

        /// <summary>
        /// Checks to see if the OrderingRequirementType property is set.
        /// </summary>
        internal bool IsSetOrderingRequirementType() => this.OrderingRequirementType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ordering requirement. Valid values are <c>PASS</c>, <c>FAIL</c>,
        /// and <c>EXEMPT</c>.
        /// </para>
        /// </summary>
        public OrderingRequirementStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// A message about the ordering requirement.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
