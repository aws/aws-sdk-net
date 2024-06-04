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
    /// Additional tax information associated with your TRN in Italy.
    /// </summary>
    public partial class ItalyAdditionalInfo
    {
        private string _cigNumber;
        private string _cupNumber;
        private string _sdiAccountId;
        private string _taxCode;

        /// <summary>
        /// Gets and sets the property CigNumber. 
        /// <para>
        ///  The tender procedure identification code. 
        /// </para>
        /// </summary>
        public string CigNumber
        {
            get { return this._cigNumber; }
            set { this._cigNumber = value; }
        }

        // Check to see if CigNumber property is set
        internal bool IsSetCigNumber()
        {
            return this._cigNumber != null;
        }

        /// <summary>
        /// Gets and sets the property CupNumber. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Italy. This is managed by the
        /// Interministerial Committee for Economic Planning (CIPE) which characterizes every
        /// public investment project (Individual Project Code). 
        /// </para>
        /// </summary>
        public string CupNumber
        {
            get { return this._cupNumber; }
            set { this._cupNumber = value; }
        }

        // Check to see if CupNumber property is set
        internal bool IsSetCupNumber()
        {
            return this._cupNumber != null;
        }

        /// <summary>
        /// Gets and sets the property SdiAccountId. 
        /// <para>
        ///  Additional tax information to specify for a TRN in Italy. Use CodiceDestinatario
        /// to receive your invoices via web service (API) or FTP. 
        /// </para>
        /// </summary>
        public string SdiAccountId
        {
            get { return this._sdiAccountId; }
            set { this._sdiAccountId = value; }
        }

        // Check to see if SdiAccountId property is set
        internal bool IsSetSdiAccountId()
        {
            return this._sdiAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property TaxCode. 
        /// <para>
        /// List of service tax codes for your TRN in Italy. You can use your customer tax code
        /// as part of a VAT Group. 
        /// </para>
        /// </summary>
        public string TaxCode
        {
            get { return this._taxCode; }
            set { this._taxCode = value; }
        }

        // Check to see if TaxCode property is set
        internal bool IsSetTaxCode()
        {
            return this._taxCode != null;
        }

    }
}