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

namespace Amazon.Billing.Model
{
    /// <summary>
    /// The details of a contract returned by <c>GetContractInformation</c>. This is a union
    /// in which exactly one member is set, corresponding to the contract type. For a private
    /// pricing addendum, the <c>privatePricingAddendum</c> member is set. Check which member
    /// is present to determine the contract type.
    /// </summary>
    public partial class ContractDetails
    {
        /// <summary>
        /// Gets and sets the property PrivatePricingAddendum. 
        /// <para>
        /// The details of a private pricing addendum contract. This member is set when the contract
        /// is a private pricing addendum.
        /// </para>
        /// </summary>
        public PrivatePricingAddendum PrivatePricingAddendum { get; set; }

        /// <summary>
        /// Checks to see if the PrivatePricingAddendum property is set.
        /// </summary>
        internal bool IsSetPrivatePricingAddendum() => this.PrivatePricingAddendum != null;
    }
}
