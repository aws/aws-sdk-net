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
    /// An optional input to the list API. If multiple filters are specified, the returned
    /// list will be a configuration that match all of the provided filters. Supported filter
    /// types are <c>InvoiceReceivers</c>, <c>Names</c>, and <c>Accounts</c>.
    /// </summary>
    public partial class Filters
    {
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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public List<string> Accounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Accounts property is set.
        /// </summary>
        internal bool IsSetAccounts() => this.Accounts != null && (this.Accounts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property BillSourceAccounts. 
        /// <para>
        ///  A list of Amazon Web Services account IDs used to filter invoice units. These are
        /// payer accounts from other Organizations that have delegated their billing responsibility
        /// to the receiver account through the billing transfer feature. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public List<string> BillSourceAccounts { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the BillSourceAccounts property is set.
        /// </summary>
        internal bool IsSetBillSourceAccounts() => this.BillSourceAccounts != null && (this.BillSourceAccounts.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000)]
        public List<string> InvoiceReceivers { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InvoiceReceivers property is set.
        /// </summary>
        internal bool IsSetInvoiceReceivers() => this.InvoiceReceivers != null && (this.InvoiceReceivers.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Names. 
        /// <para>
        ///  An optional input to the list API. You can specify a list of invoice unit names inside
        /// filters to return invoice units that match only the specified invoice unit names.
        /// If multiple names are provided, the result is an <c>OR</c> condition (match any) of
        /// the specified invoice unit names. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Names { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the Names property is set.
        /// </summary>
        internal bool IsSetNames() => this.Names != null && (this.Names.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
