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
    /// An optional input to the list API. If multiple filters are specified, the returned
    /// list will be a configuration that match all of the provided filters. Supported filter
    /// types are <c>InvoiceReceivers</c>, <c>Names</c>, and <c>Accounts</c>.
    /// </summary>
    public partial class Filters
    {
        private List<string> _accounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _invoiceReceivers = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _names = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Accounts. 
        /// <para>
        ///  You can specify a list of Amazon Web Services account IDs inside filters to return
        /// invoice units that match only the specified accounts. If multiple accounts are provided,
        /// the result is an <c>OR</c> condition (match any) of the specified accounts. The specified
        /// account IDs are matched with either the receiver or the linked accounts in the rules.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<string> Accounts
        {
            get { return this._accounts; }
            set { this._accounts = value; }
        }

        // Check to see if Accounts property is set
        internal bool IsSetAccounts()
        {
            return this._accounts != null && (this._accounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InvoiceReceivers. 
        /// <para>
        ///  You can specify a list of Amazon Web Services account IDs inside filters to return
        /// invoice units that match only the specified accounts. If multiple accounts are provided,
        /// the result is an <c>OR</c> condition (match any) of the specified accounts. This filter
        /// only matches the specified accounts on the invoice receivers of the invoice units.
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public List<string> InvoiceReceivers
        {
            get { return this._invoiceReceivers; }
            set { this._invoiceReceivers = value; }
        }

        // Check to see if InvoiceReceivers property is set
        internal bool IsSetInvoiceReceivers()
        {
            return this._invoiceReceivers != null && (this._invoiceReceivers.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        ///  An optional input to the list API. You can specify a list of invoice unit names inside
        /// filters to return invoice units that match only the specified invoice unit names.
        /// If multiple names are provided, the result is an <c>OR</c> condition (match any) of
        /// the specified invoice unit names. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Names
        {
            get { return this._names; }
            set { this._names = value; }
        }

        // Check to see if Names property is set
        internal bool IsSetNames()
        {
            return this._names != null && (this._names.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}