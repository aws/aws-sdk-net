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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Container for the parameters to the EnableOrganizationAdminAccount operation. Designates
    /// an account as the delegated Amazon Macie administrator account for an organization
    /// in Organizations.
    /// </summary>
    public partial class EnableOrganizationAdminAccountRequest : AmazonMacie2Request
    {
        /// <summary>
        /// Gets and sets the property AdminAccountId. 
        /// <para>
        /// The Amazon Web Services account ID for the account to designate as the delegated Amazon
        /// Macie administrator account for the organization.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AdminAccountId { get; set; }

        /// <summary>
        /// Checks to see if the AdminAccountId property is set.
        /// </summary>
        internal bool IsSetAdminAccountId() => this.AdminAccountId != null;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive token that you provide to ensure the idempotency of the request.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;
    }
}
