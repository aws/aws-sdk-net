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
    /// Specifies criteria for selecting which invoices should be processed using a particular
    /// procurement portal preference.
    /// </summary>
    public partial class ProcurementPortalPreferenceSelector
    {
        private List<string> _invoiceUnitArns = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _sellerOfRecords = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property InvoiceUnitArns. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of invoice unit identifiers to which this preference
        /// applies. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public List<string> InvoiceUnitArns
        {
            get { return this._invoiceUnitArns; }
            set { this._invoiceUnitArns = value; }
        }

        // Check to see if InvoiceUnitArns property is set
        internal bool IsSetInvoiceUnitArns()
        {
            return this._invoiceUnitArns != null && (this._invoiceUnitArns.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SellerOfRecords. 
        /// <para>
        ///  The list of seller of record IDs to which this preference applies. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public List<string> SellerOfRecords
        {
            get { return this._sellerOfRecords; }
            set { this._sellerOfRecords = value; }
        }

        // Check to see if SellerOfRecords property is set
        internal bool IsSetSellerOfRecords()
        {
            return this._sellerOfRecords != null && (this._sellerOfRecords.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}