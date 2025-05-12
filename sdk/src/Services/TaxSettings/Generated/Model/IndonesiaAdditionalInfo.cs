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
 * Do not modify this file. This file is generated from the taxsettings-2018-05-10.normal.json service model.
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
        private string _decisionNumber;
        private string _ppnExceptionDesignationCode;
        private IndonesiaTaxRegistrationNumberType _taxRegistrationNumberType;

        /// <summary>
        /// Gets and sets the property DecisionNumber. 
        /// <para>
        /// VAT-exempt customers have a Directorate General of Taxation (DGT) exemption letter
        /// or certificate (Surat Keterangan Bebas) decision number. Non-collected VAT have a
        /// DGT letter or certificate (Surat Keterangan Tidak Dipungut).
        /// </para>
        /// </summary>
        public string DecisionNumber
        {
            get { return this._decisionNumber; }
            set { this._decisionNumber = value; }
        }

        // Check to see if DecisionNumber property is set
        internal bool IsSetDecisionNumber()
        {
            return this._decisionNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PpnExceptionDesignationCode. 
        /// <para>
        /// Exception code if you are designated by Directorate General of Taxation (DGT) as a
        /// VAT collector, non-collected VAT, or VAT-exempt customer.
        /// </para>
        /// </summary>
        public string PpnExceptionDesignationCode
        {
            get { return this._ppnExceptionDesignationCode; }
            set { this._ppnExceptionDesignationCode = value; }
        }

        // Check to see if PpnExceptionDesignationCode property is set
        internal bool IsSetPpnExceptionDesignationCode()
        {
            return this._ppnExceptionDesignationCode != null;
        }

        /// <summary>
        /// Gets and sets the property TaxRegistrationNumberType. 
        /// <para>
        /// The tax registration number type.
        /// </para>
        /// </summary>
        public IndonesiaTaxRegistrationNumberType TaxRegistrationNumberType
        {
            get { return this._taxRegistrationNumberType; }
            set { this._taxRegistrationNumberType = value; }
        }

        // Check to see if TaxRegistrationNumberType property is set
        internal bool IsSetTaxRegistrationNumberType()
        {
            return this._taxRegistrationNumberType != null;
        }

    }
}