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
    /// A quantity-based attestation value, such as a count of workloads migrated.
    /// </summary>
    public partial class AttestationQuantity
    {
        /// <summary>
        /// Gets and sets the property AttestationUnit. 
        /// <para>
        /// The unit of the attestation, such as <c>workloads migrated</c>. This value is 1–1000
        /// characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string AttestationUnit { get; set; }

        /// <summary>
        /// Checks to see if the AttestationUnit property is set.
        /// </summary>
        internal bool IsSetAttestationUnit() => this.AttestationUnit != null;

        /// <summary>
        /// Gets and sets the property AttestationVolume. 
        /// <para>
        /// The number of units being attested, expressed as a decimal string to preserve precision.
        /// The value is digits with an optional decimal point and is 1–1000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1000)]
        public string AttestationVolume { get; set; }

        /// <summary>
        /// Checks to see if the AttestationVolume property is set.
        /// </summary>
        internal bool IsSetAttestationVolume() => this.AttestationVolume != null;
    }
}
