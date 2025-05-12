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
    /// Additional tax information to specify for a TRN in Uzbekistan.
    /// </summary>
    public partial class UzbekistanAdditionalInfo
    {
        private UzbekistanTaxRegistrationNumberType _taxRegistrationNumberType;
        private string _vatRegistrationNumber;

        /// <summary>
        /// Gets and sets the property TaxRegistrationNumberType. 
        /// <para>
        ///  The tax registration number type. The tax registration number type valid values are
        /// <c>Business</c> and <c>Individual</c>. 
        /// </para>
        /// </summary>
        public UzbekistanTaxRegistrationNumberType TaxRegistrationNumberType
        {
            get { return this._taxRegistrationNumberType; }
            set { this._taxRegistrationNumberType = value; }
        }

        // Check to see if TaxRegistrationNumberType property is set
        internal bool IsSetTaxRegistrationNumberType()
        {
            return this._taxRegistrationNumberType != null;
        }

        /// <summary>
        /// Gets and sets the property VatRegistrationNumber. 
        /// <para>
        ///  The unique 12-digit number issued to identify VAT-registered identities in Uzbekistan.
        /// 
        /// </para>
        /// </summary>
        public string VatRegistrationNumber
        {
            get { return this._vatRegistrationNumber; }
            set { this._vatRegistrationNumber = value; }
        }

        // Check to see if VatRegistrationNumber property is set
        internal bool IsSetVatRegistrationNumber()
        {
            return this._vatRegistrationNumber != null;
        }

    }
}