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
 * Do not modify this file. This file is generated from the detective-2018-10-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Detective.Model
{
    /// <summary>
    /// Container for the parameters to the EnableOrganizationAdminAccount operation.
    /// Designates the Detective administrator account for the organization in the current
    /// Region.
    /// 
    ///  
    /// <para>
    /// If the account does not have Detective enabled, then enables Detective for that account
    /// and creates a new behavior graph.
    /// </para>
    ///  
    /// <para>
    /// Can only be called by the organization management account.
    /// </para>
    ///  
    /// <para>
    /// The Detective administrator account for an organization must be the same in all Regions.
    /// If you already designated a Detective administrator account in another Region, then
    /// you must designate the same account.
    /// </para>
    /// </summary>
    public partial class EnableOrganizationAdminAccountRequest : AmazonDetectiveRequest
    {
        private string _accountId;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The Amazon Web Services account identifier of the account to designate as the Detective
        /// administrator account for the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

    }
}