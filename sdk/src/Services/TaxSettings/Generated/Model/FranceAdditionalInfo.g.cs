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

namespace Amazon.TaxSettings.Model
{
    /// <summary>
    /// Additional tax information associated with your TRN in France.
    /// </summary>
    public partial class FranceAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property EInvoiceRoutingCode. 
        /// <para>
        /// The routing code used for electronic invoicing (e-invoicing) for the company in France.
        /// </para>
        /// </summary>
        public string EInvoiceRoutingCode { get; set; }

        /// <summary>
        /// Checks to see if the EInvoiceRoutingCode property is set.
        /// </summary>
        internal bool IsSetEInvoiceRoutingCode() => this.EInvoiceRoutingCode != null;

        /// <summary>
        /// Gets and sets the property SirenNumber. 
        /// <para>
        /// The SIREN number for the company in France. Must be a 9-digit number.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SirenNumber { get; set; }

        /// <summary>
        /// Checks to see if the SirenNumber property is set.
        /// </summary>
        internal bool IsSetSirenNumber() => this.SirenNumber != null;
    }
}
