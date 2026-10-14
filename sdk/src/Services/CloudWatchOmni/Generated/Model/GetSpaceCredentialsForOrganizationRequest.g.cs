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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Container for the parameters to the GetSpaceCredentialsForOrganization operation.
    /// Returns temporary credentials for a space in an organization member account. The credentials
    /// are valid for one hour. The caller must be the organization's management account or
    /// a delegated administrator with access to the target space. The target account must
    /// be an active member of the same organization as the domain, and the space must already
    /// exist.
    /// </summary>
    public partial class GetSpaceCredentialsForOrganizationRequest : AmazonCloudWatchOmniRequest
    {
        /// <summary>
        /// Gets and sets the property Context. Context for credential resolution.
        /// </summary>
        [AWSProperty(Required = true)]
        public SpaceCredentialRequestContext Context { get; set; }

        /// <summary>
        /// Checks to see if the Context property is set.
        /// </summary>
        internal bool IsSetContext() => this.Context != null;

        /// <summary>
        /// Gets and sets the property CredentialType. Selects which member-account credential
        /// to return. Set this to SPACE_OPERATION.
        /// </summary>
        [AWSProperty(Required = true)]
        public OrganizationCredentialType CredentialType { get; set; }

        /// <summary>
        /// Checks to see if the CredentialType property is set.
        /// </summary>
        internal bool IsSetCredentialType() => this.CredentialType != null;
    }
}
