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
    /// This is used to categorize the invoice unit. Values are Amazon Web Services account
    /// IDs. Currently, the only supported rule is <c>LINKED_ACCOUNT</c>.
    /// </summary>
    public partial class InvoiceUnitRule
    {
        private List<string> _billSourceAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _linkedAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property BillSourceAccounts. 
        /// <para>
        ///  A list of Amazon Web Services account account IDs that have delegated their billing
        /// responsibility to the receiver account through transfer billing. Unlike linked accounts,
        /// these bill source accounts can be payer accounts from other organizations that have
        /// authorized billing transfer to this account. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> BillSourceAccounts
        {
            get { return this._billSourceAccounts; }
            set { this._billSourceAccounts = value; }
        }

        // Check to see if BillSourceAccounts property is set
        internal bool IsSetBillSourceAccounts()
        {
            return this._billSourceAccounts != null && (this._billSourceAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property LinkedAccounts. 
        /// <para>
        /// The list of <c>LINKED_ACCOUNT</c> IDs where charges are included within the invoice
        /// unit. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1000)]
        public List<string> LinkedAccounts
        {
            get { return this._linkedAccounts; }
            set { this._linkedAccounts = value; }
        }

        // Check to see if LinkedAccounts property is set
        internal bool IsSetLinkedAccounts()
        {
            return this._linkedAccounts != null && (this._linkedAccounts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}