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
    /// Additional tax information associated with your TRN in Italy.
    /// </summary>
    public partial class ItalyAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property CigNumber. 
        /// <para>
        ///  The tender procedure identification code. 
        /// </para>
        /// </summary>
        public string CigNumber { get; set; }

        /// <summary>
        /// Checks to see if the CigNumber property is set.
        /// </summary>
        internal bool IsSetCigNumber() => this.CigNumber != null;

        /// <summary>
        /// Gets and sets the property CupNumber. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Italy. This is managed by the
        /// Interministerial Committee for Economic Planning (CIPE) which characterizes every
        /// public investment project (Individual Project Code). 
        /// </para>
        /// </summary>
        public string CupNumber { get; set; }

        /// <summary>
        /// Checks to see if the CupNumber property is set.
        /// </summary>
        internal bool IsSetCupNumber() => this.CupNumber != null;

        /// <summary>
        /// Gets and sets the property CustomerType. 
        /// <para>
        /// The customer type for tax registration in Italy. Valid values are <c>Business</c>
        /// or <c>Individual</c>.
        /// </para>
        /// </summary>
        public CustomerType CustomerType { get; set; }

        /// <summary>
        /// Checks to see if the CustomerType property is set.
        /// </summary>
        internal bool IsSetCustomerType() => this.CustomerType != null;

        /// <summary>
        /// Gets and sets the property SdiAccountId. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Italy. Use CodiceDestinatario
        /// to receive your invoices via web service (API) or FTP. 
        /// </para>
        /// </summary>
        public string SdiAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SdiAccountId property is set.
        /// </summary>
        internal bool IsSetSdiAccountId() => this.SdiAccountId != null;

        /// <summary>
        /// Gets and sets the property TaxCode. 
        /// <para>
        /// List of service tax codes for your TRN in Italy. You can use your customer tax code
        /// as part of a VAT Group. 
        /// </para>
        /// </summary>
        public string TaxCode { get; set; }

        /// <summary>
        /// Checks to see if the TaxCode property is set.
        /// </summary>
        internal bool IsSetTaxCode() => this.TaxCode != null;
    }
}
