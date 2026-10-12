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

namespace Amazon.PartnerCentralBenefits.Model
{
    /// <summary>
    /// Represents detailed information about a specific issuance of benefit value.
    /// </summary>
    public partial class IssuanceDetail
    {
        /// <summary>
        /// Gets and sets the property IssuanceAmount. 
        /// <para>
        /// The monetary amount or value that was issued in this specific issuance.
        /// </para>
        /// </summary>
        public MonetaryValue IssuanceAmount { get; set; }

        /// <summary>
        /// Checks to see if the IssuanceAmount property is set.
        /// </summary>
        internal bool IsSetIssuanceAmount() => this.IssuanceAmount != null;

        /// <summary>
        /// Gets and sets the property IssuanceId. 
        /// <para>
        /// The unique identifier for this specific issuance.
        /// </para>
        /// </summary>
        public string IssuanceId { get; set; }

        /// <summary>
        /// Checks to see if the IssuanceId property is set.
        /// </summary>
        internal bool IsSetIssuanceId() => this.IssuanceId != null;

        /// <summary>
        /// Gets and sets the property IssuedAt. 
        /// <para>
        /// The timestamp when this specific issuance was processed.
        /// </para>
        /// </summary>
        public DateTime? IssuedAt { get; set; }

        /// <summary>
        /// Checks to see if the IssuedAt property is set.
        /// </summary>
        internal bool IsSetIssuedAt() => this.IssuedAt.HasValue;
    }
}
