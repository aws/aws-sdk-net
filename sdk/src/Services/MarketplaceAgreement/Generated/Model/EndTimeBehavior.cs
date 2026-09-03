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
    /// The behavior of an agreement when it reaches its end date. For example, whether the
    /// agreement renews, and if it doesn't, the reason why.
    /// </summary>
    public partial class EndTimeBehavior
    {
        private EndTimeBehaviorReasonCode _reasonCode;
        private RenewalSummary _renewalSummary;
        private EndTimeBehaviorType _type;

        /// <summary>
        /// Gets and sets the property ReasonCode. 
        /// <para>
        /// The reason why the agreement doesn't renew at its end date. The field is <c>null</c>
        /// when the agreement renews.
        /// </para>
        ///  
        /// <para>
        /// More than one reason can apply to the same agreement. When that happens, the operation
        /// returns only one reason code, and <c>PROPOSER_RENEW_OPTED_OUT</c> takes precedence
        /// over all others.
        /// </para>
        ///  
        /// <para>
        /// The <c>EnableAutoRenew</c> field reflects only the acceptor's preference, and doesn't
        /// reflect the other reasons an agreement might not renew.
        /// </para>
        ///  
        /// <para>
        /// Reason codes include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROPOSER_RENEW_OPTED_OUT</c> – The proposer opted out of renewing the agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACCEPTOR_RENEW_OPTED_OUT</c> – The acceptor opted out of renewing the agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>NO_RENEWAL_TERM</c> – The accepted terms of the agreement don't include a renewal
        /// term, which is required for an agreement to renew.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>RENEWAL_LIMIT_EXHAUSTED</c> – The agreement reached the maximum number of renewals
        /// allowed by its renewal term.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public EndTimeBehaviorReasonCode ReasonCode
        {
            get { return this._reasonCode; }
            set { this._reasonCode = value; }
        }

        // Check to see if ReasonCode property is set
        internal bool IsSetReasonCode()
        {
            return this._reasonCode != null;
        }

        /// <summary>
        /// Gets and sets the property RenewalSummary. 
        /// <para>
        /// The details of the renewal that applies at the end date of the agreement. This field
        /// is present when <c>Type</c> is <c>RENEW</c>. It is also present when <c>ReasonCode</c>
        /// is <c>PROPOSER_RENEW_OPTED_OUT</c> or <c>ACCEPTOR_RENEW_OPTED_OUT</c>. In those cases,
        /// it identifies the offer that the agreement would otherwise have renewed from. The
        /// field is <c>null</c> in all other cases.
        /// </para>
        /// </summary>
        public RenewalSummary RenewalSummary
        {
            get { return this._renewalSummary; }
            set { this._renewalSummary = value; }
        }

        // Check to see if RenewalSummary property is set
        internal bool IsSetRenewalSummary()
        {
            return this._renewalSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The behavior of the agreement when it reaches its end date.
        /// </para>
        ///  
        /// <para>
        /// Types include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>RENEW</c> – A new agreement is created from the accepted terms of this agreement.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>REPLACE</c> – A new agreement is created from a different offer than the one this
        /// agreement was created from. This happens, for example, when a private offer reaches
        /// its end date and the acceptor transitions to the public offer for the product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPIRE</c> – The agreement ends and isn't renewed or replaced.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true)]
        public EndTimeBehaviorType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}