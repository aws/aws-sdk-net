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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
    /// are valid for one hour.
    /// 
    ///  
    /// <para>
    /// The caller must be the organization's management account or a delegated administrator
    /// with access to the target space. The target account must be an active member of the
    /// same organization as the domain, and the space must already exist.
    /// </para>
    /// </summary>
    public partial class GetSpaceCredentialsForOrganizationRequest : AmazonCloudWatchOmniRequest
    {
        private SpaceCredentialRequestContext _context;
        private OrganizationCredentialType _credentialType;

        /// <summary>
        /// Gets and sets the property Context. 
        /// <para>
        /// Context for credential resolution.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SpaceCredentialRequestContext Context
        {
            get { return this._context; }
            set { this._context = value; }
        }

        // Check to see if Context property is set
        internal bool IsSetContext()
        {
            return this._context != null;
        }

        /// <summary>
        /// Gets and sets the property CredentialType. 
        /// <para>
        /// Selects which member-account credential to return. Set this to SPACE_OPERATION.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OrganizationCredentialType CredentialType
        {
            get { return this._credentialType; }
            set { this._credentialType = value; }
        }

        // Check to see if CredentialType property is set
        internal bool IsSetCredentialType()
        {
            return this._credentialType != null;
        }

    }
}