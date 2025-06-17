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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Container for the parameters to the EnableOrganizationAdminAccount operation.
    /// Designates the Security Hub administrator account for an organization. Can only be
    /// called by the organization management account.
    /// </summary>
    public partial class EnableOrganizationAdminAccountRequest : AmazonSecurityHubRequest
    {
        private string _adminAccountId;
        private SecurityHubFeature _feature;

        /// <summary>
        /// Gets and sets the property AdminAccountId. 
        /// <para>
        /// The Amazon Web Services account identifier of the account to designate as the Security
        /// Hub administrator account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AdminAccountId
        {
            get { return this._adminAccountId; }
            set { this._adminAccountId = value; }
        }

        // Check to see if AdminAccountId property is set
        internal bool IsSetAdminAccountId()
        {
            return this._adminAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property Feature. 
        /// <para>
        /// The feature for which the delegated admin account is enabled. Defaults to Security
        /// Hub if not specified.
        /// </para>
        /// </summary>
        public SecurityHubFeature Feature
        {
            get { return this._feature; }
            set { this._feature = value; }
        }

        // Check to see if Feature property is set
        internal bool IsSetFeature()
        {
            return this._feature != null;
        }

    }
}