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

namespace Amazon.MarketplaceAgreement.Model
{
    /// <summary>
    /// Defines the net payment due period for the agreement, specifying when payment is due
    /// after an invoice is issued.
    /// </summary>
    public partial class NetPaymentTerm
    {
        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier for the term.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property PaymentDuePeriod. 
        /// <para>
        /// The duration after an invoice is issued within which the payment is due. The duration
        /// is represented in the ISO 8601 format (for example, <c>P30D</c> for 30 days or <c>P60D</c>
        /// for 60 days).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string PaymentDuePeriod { get; set; }

        /// <summary>
        /// Checks to see if the PaymentDuePeriod property is set.
        /// </summary>
        internal bool IsSetPaymentDuePeriod() => this.PaymentDuePeriod != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Type of the term being updated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4096)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
