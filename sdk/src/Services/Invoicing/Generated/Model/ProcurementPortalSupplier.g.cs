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

namespace Amazon.Invoicing.Model
{
    /// <summary>
    /// Contains metadata for a supplier configured within a procurement portal.
    /// </summary>
    public partial class ProcurementPortalSupplier
    {
        /// <summary>
        /// Gets and sets the property CountryCode. 
        /// <para>
        /// The two-letter ISO 3166-1 alpha-2 country code associated with the supplier.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 2)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Checks to see if the CountryCode property is set.
        /// </summary>
        internal bool IsSetCountryCode() => this.CountryCode != null;

        /// <summary>
        /// Gets and sets the property Environment. 
        /// <para>
        /// The environment identifier for the supplier in the procurement portal. PROD for production
        /// env, or TEST for sandbox/test env.
        /// </para>
        /// </summary>
        public ProcurementPortalEnv Environment { get; set; }

        /// <summary>
        /// Checks to see if the Environment property is set.
        /// </summary>
        internal bool IsSetEnvironment() => this.Environment != null;

        /// <summary>
        /// Gets and sets the property SellerOfRecord. 
        /// <para>
        /// The Amazon Web Services seller of record associated with the supplier—the Amazon Web
        /// Services legal entity that issues invoices for the account (for example, <c>AWS_INC</c>
        /// or <c>AWS_EUROPE</c>).
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SellerOfRecord { get; set; }

        /// <summary>
        /// Checks to see if the SellerOfRecord property is set.
        /// </summary>
        internal bool IsSetSellerOfRecord() => this.SellerOfRecord != null;

        /// <summary>
        /// Gets and sets the property SupplierIdentifier. 
        /// <para>
        /// The unique identifier of the supplier within the procurement portal.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public string SupplierIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SupplierIdentifier property is set.
        /// </summary>
        internal bool IsSetSupplierIdentifier() => this.SupplierIdentifier != null;
    }
}
