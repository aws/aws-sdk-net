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
 * Do not modify this file. This file is generated from the invoicing-2024-12-01.normal.json service model.
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
namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Contains metadata for a supplier configured within a procurement portal.
    /// </summary>
    public partial class ProcurementPortalSupplier
    {
        private string _countryCode;
        private ProcurementPortalEnv _environment;
        private string _sellerOfRecord;
        private string _supplierIdentifier;

        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The two-letter ISO 3166-1 alpha-2 country code associated with the supplier.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=2)]
        public string CountryCode
        {
            get { return this._countryCode; }
            set { this._countryCode = value; }
        }

        // Check to see if CountryCode property is set
        internal bool IsSetCountryCode()
        {
            return this._countryCode != null;
        }

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment identifier for the supplier in the procurement portal. PROD for production
        /// env, or TEST for sandbox/test env.
        /// </para>
        /// </summary>
        public ProcurementPortalEnv Environment
        {
            get { return this._environment; }
            set { this._environment = value; }
        }

        // Check to see if Environment property is set
        internal bool IsSetEnvironment()
        {
            return this._environment != null;
        }

        /// <summary>
        /// Gets and sets the property SellerOfRecord. 
        /// <para>
        /// The Amazon Web Services seller of record associated with the supplier—the Amazon Web
        /// Services legal entity that issues invoices for the account (for example, <c>AWS_INC</c>
        /// or <c>AWS_EUROPE</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SellerOfRecord
        {
            get { return this._sellerOfRecord; }
            set { this._sellerOfRecord = value; }
        }

        // Check to see if SellerOfRecord property is set
        internal bool IsSetSellerOfRecord()
        {
            return this._sellerOfRecord != null;
        }

        /// <summary>
        /// Gets and sets the property SupplierIdentifier. 
        /// <para>
        /// The unique identifier of the supplier within the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string SupplierIdentifier
        {
            get { return this._supplierIdentifier; }
            set { this._supplierIdentifier = value; }
        }

        // Check to see if SupplierIdentifier property is set
        internal bool IsSetSupplierIdentifier()
        {
            return this._supplierIdentifier != null;
        }

    }
}