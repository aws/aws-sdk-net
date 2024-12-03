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
    /// Additional tax information associated with your TRN in Canada .
    /// </summary>
    public partial class CanadaAdditionalInfo
    {
        private string _canadaQuebecSalesTaxNumber;
        private string _canadaRetailSalesTaxNumber;
        private bool? _isResellerAccount;
        private string _provincialSalesTaxId;

        /// <summary>
        /// Gets and sets the property CanadaQuebecSalesTaxNumber. 
        /// <para>
        ///  The Quebec Sales Tax ID number. Leave blank if you do not have a Quebec Sales Tax
        /// ID number. 
        /// </para>
        /// </summary>
        public string CanadaQuebecSalesTaxNumber
        {
            get { return this._canadaQuebecSalesTaxNumber; }
            set { this._canadaQuebecSalesTaxNumber = value; }
        }

        // Check to see if CanadaQuebecSalesTaxNumber property is set
        internal bool IsSetCanadaQuebecSalesTaxNumber()
        {
            return this._canadaQuebecSalesTaxNumber != null;
        }

        /// <summary>
        /// Gets and sets the property CanadaRetailSalesTaxNumber. 
        /// <para>
        ///  Manitoba Retail Sales Tax ID number. Customers purchasing Amazon Web Services services
        /// for resale in Manitoba must provide a valid Retail Sales Tax ID number for Manitoba.
        /// Leave this blank if you do not have a Retail Sales Tax ID number in Manitoba or are
        /// not purchasing Amazon Web Services services for resale. 
        /// </para>
        /// </summary>
        public string CanadaRetailSalesTaxNumber
        {
            get { return this._canadaRetailSalesTaxNumber; }
            set { this._canadaRetailSalesTaxNumber = value; }
        }

        // Check to see if CanadaRetailSalesTaxNumber property is set
        internal bool IsSetCanadaRetailSalesTaxNumber()
        {
            return this._canadaRetailSalesTaxNumber != null;
        }

        /// <summary>
        /// Gets and sets the property IsResellerAccount. 
        /// <para>
        ///  The value for this parameter must be <c>true</c> if the <c>provincialSalesTaxId</c>
        /// value is provided for a TRN in British Columbia, Saskatchewan, or Manitoba provinces.
        /// 
        /// </para>
        ///  
        /// <para>
        /// To claim a provincial sales tax (PST) and retail sales tax (RST) reseller exemption,
        /// you must confirm that purchases from this account were made for resale. Otherwise,
        /// remove the PST or RST number from the <c>provincialSalesTaxId</c> parameter from your
        /// request.
        /// </para>
        /// </summary>
        public bool? IsResellerAccount
        {
            get { return this._isResellerAccount; }
            set { this._isResellerAccount = value; }
        }

        // Check to see if IsResellerAccount property is set
        internal bool IsSetIsResellerAccount()
        {
            return this._isResellerAccount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProvincialSalesTaxId. 
        /// <para>
        ///  The provincial sales tax ID for your TRN in Canada. This parameter can represent
        /// the following: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Provincial sales tax ID number for British Columbia and Saskatchewan provinces
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Manitoba retail sales tax ID number for Manitoba province
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Quebec sales tax ID number for Quebec province
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The Tax Setting API only accepts this parameter if the TRN is specified for the previous
        /// provinces. For other provinces, the Tax Settings API doesn't accept this parameter.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=7, Max=16)]
        public string ProvincialSalesTaxId
        {
            get { return this._provincialSalesTaxId; }
            set { this._provincialSalesTaxId = value; }
        }

        // Check to see if ProvincialSalesTaxId property is set
        internal bool IsSetProvincialSalesTaxId()
        {
            return this._provincialSalesTaxId != null;
        }

    }
}