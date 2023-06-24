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
 * Do not modify this file. This file is generated from the billingconductor-2021-07-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.BillingConductor.Model
{
    /// <summary>
    /// The set of accounts that will be under the billing group. The set of accounts resemble
    /// the linked accounts in a consolidated family.
    /// </summary>
    public partial class AccountGrouping
    {
        private List<string> _linkedAccountIds = new List<string>();

        /// <summary>
        /// Gets and sets the property LinkedAccountIds. 
        /// <para>
        ///  The account IDs that make up the billing group. Account IDs must be a part of the
        /// consolidated billing family, and not associated with another billing group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=30)]
        public List<string> LinkedAccountIds
        {
            get { return this._linkedAccountIds; }
            set { this._linkedAccountIds = value; }
        }

        // Check to see if LinkedAccountIds property is set
        internal bool IsSetLinkedAccountIds()
        {
            return this._linkedAccountIds != null && this._linkedAccountIds.Count > 0; 
        }

    }
}