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
    /// Additional tax information to specify for a TRN in Vietnam.
    /// </summary>
    public partial class VietnamAdditionalInfo
    {
        private string _electronicTransactionCodeNumber;
        private string _enterpriseIdentificationNumber;
        private string _paymentVoucherNumber;
        private string _paymentVoucherNumberDate;

        /// <summary>
        /// Gets and sets the property ElectronicTransactionCodeNumber. 
        /// <para>
        /// The electronic transaction code number on the tax return document. This field must
        /// be provided for successful API operation.
        /// </para>
        /// </summary>
        public string ElectronicTransactionCodeNumber
        {
            get { return this._electronicTransactionCodeNumber; }
            set { this._electronicTransactionCodeNumber = value; }
        }

        // Check to see if ElectronicTransactionCodeNumber property is set
        internal bool IsSetElectronicTransactionCodeNumber()
        {
            return this._electronicTransactionCodeNumber != null;
        }

        /// <summary>
        /// Gets and sets the property EnterpriseIdentificationNumber. 
        /// <para>
        /// The enterprise identification number for tax registration. This field must be provided
        /// for successful API operation.
        /// </para>
        /// </summary>
        public string EnterpriseIdentificationNumber
        {
            get { return this._enterpriseIdentificationNumber; }
            set { this._enterpriseIdentificationNumber = value; }
        }

        // Check to see if EnterpriseIdentificationNumber property is set
        internal bool IsSetEnterpriseIdentificationNumber()
        {
            return this._enterpriseIdentificationNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentVoucherNumber. 
        /// <para>
        /// The payment voucher number on the tax return payment document. This field must be
        /// provided for successful API operation.
        /// </para>
        /// </summary>
        public string PaymentVoucherNumber
        {
            get { return this._paymentVoucherNumber; }
            set { this._paymentVoucherNumber = value; }
        }

        // Check to see if PaymentVoucherNumber property is set
        internal bool IsSetPaymentVoucherNumber()
        {
            return this._paymentVoucherNumber != null;
        }

        /// <summary>
        /// Gets and sets the property PaymentVoucherNumberDate. 
        /// <para>
        /// The date on the tax return payment document. This field must be provided for successful
        /// API operation.
        /// </para>
        /// </summary>
        public string PaymentVoucherNumberDate
        {
            get { return this._paymentVoucherNumberDate; }
            set { this._paymentVoucherNumberDate = value; }
        }

        // Check to see if PaymentVoucherNumberDate property is set
        internal bool IsSetPaymentVoucherNumberDate()
        {
            return this._paymentVoucherNumberDate != null;
        }

    }
}