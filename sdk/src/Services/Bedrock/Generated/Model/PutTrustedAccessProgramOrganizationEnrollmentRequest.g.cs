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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the PutTrustedAccessProgramOrganizationEnrollment
    /// operation. Sets the current organization's enrollment preference for a trusted access
    /// program. The organization and payer account are derived from the authenticated context.
    /// Every write requires operation permission and management-account or Bedrock-specific
    /// delegated-administrator authority. Enabling requires approval and no revocation for
    /// the organization, including when repeating an enabled setting; otherwise returns ConflictException
    /// and preserves the stored setting. Account approval alone is insufficient. If you have
    /// the required permissions, you can set the enrollment preference to <c>disabled</c>
    /// or <c>inherit</c> even if your organization is ineligible or its eligibility is revoked.
    /// </summary>
    public partial class PutTrustedAccessProgramOrganizationEnrollmentRequest : AmazonBedrockRequest
    {
        /// <summary>
        /// Gets and sets the property OptIn. 
        /// <para>
        /// The enrollment preference to store for the organization. A transition to enabled accepts
        /// the program's terms. Changing the preference records a new updatedAt. Repeating the
        /// same stored preference preserves updatedAt.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrustedAccessProgramOptIn OptIn { get; set; }

        /// <summary>
        /// Checks to see if the OptIn property is set.
        /// </summary>
        internal bool IsSetOptIn() => this.OptIn != null;

        /// <summary>
        /// Gets and sets the property ProgramIdentifier. 
        /// <para>
        /// The identifier of the trusted access program.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 3, Max = 115)]
        public string ProgramIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ProgramIdentifier property is set.
        /// </summary>
        internal bool IsSetProgramIdentifier() => this.ProgramIdentifier != null;
    }
}
