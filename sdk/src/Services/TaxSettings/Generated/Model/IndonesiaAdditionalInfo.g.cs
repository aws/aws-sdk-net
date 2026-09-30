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
    /// Additional tax information associated with your TRN in Indonesia.
    /// </summary>
    public partial class IndonesiaAdditionalInfo
    {
        /// <summary>
        /// Gets and sets the property DecisionNumber. 
        /// <para>
        /// VAT-exempt customers have a Directorate General of Taxation (DGT) exemption letter
        /// or certificate (Surat Keterangan Bebas) decision number. Non-collected VAT have a
        /// DGT letter or certificate (Surat Keterangan Tidak Dipungut).
        /// </para>
        /// </summary>
        public string DecisionNumber { get; set; }

        /// <summary>
        /// Checks to see if the DecisionNumber property is set.
        /// </summary>
        internal bool IsSetDecisionNumber() => this.DecisionNumber != null;

        /// <summary>
        /// Gets and sets the property PpnExceptionDesignationCode. 
        /// <para>
        /// Exception code if you are designated by Directorate General of Taxation (DGT) as a
        /// VAT collector, non-collected VAT, or VAT-exempt customer.
        /// </para>
        /// </summary>
        public string PpnExceptionDesignationCode { get; set; }

        /// <summary>
        /// Checks to see if the PpnExceptionDesignationCode property is set.
        /// </summary>
        internal bool IsSetPpnExceptionDesignationCode() => this.PpnExceptionDesignationCode != null;

        /// <summary>
        /// Gets and sets the property TaxRegistrationNumberType. 
        /// <para>
        /// The tax registration number type.
        /// </para>
        /// </summary>
        public IndonesiaTaxRegistrationNumberType TaxRegistrationNumberType { get; set; }

        /// <summary>
        /// Checks to see if the TaxRegistrationNumberType property is set.
        /// </summary>
        internal bool IsSetTaxRegistrationNumberType() => this.TaxRegistrationNumberType != null;
    }
}
