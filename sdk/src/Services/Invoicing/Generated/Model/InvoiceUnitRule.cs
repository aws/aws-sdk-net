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
        private List<string> _linkedAccounts = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property LinkedAccounts. 
        /// <para>
        /// The list of <c>LINKED_ACCOUNT</c> IDs where charges are included within the invoice
        /// unit. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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