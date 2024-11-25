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
 * Do not modify this file. This file is generated from the workmail-2017-10-01.normal.json service model.
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
namespace Amazon.WorkMail.Model
{
    /// <summary>
    /// Container for the parameters to the PutIdentityProviderConfiguration operation.
    /// Enables integration between IAM Identity Center (IdC) and WorkMail to proxy authentication
    /// requests for mailbox users. You can connect your IdC directory or your external directory
    /// to WorkMail through IdC and manage access to WorkMail mailboxes in a single place.
    /// For enhanced protection, you could enable Multifactor Authentication (MFA) and Personal
    /// Access Tokens.
    /// </summary>
    public partial class PutIdentityProviderConfigurationRequest : AmazonWorkMailRequest
    {
        private IdentityProviderAuthenticationMode _authenticationMode;
        private IdentityCenterConfiguration _identityCenterConfiguration;
        private string _organizationId;
        private PersonalAccessTokenConfiguration _personalAccessTokenConfiguration;

        /// <summary>
        /// Gets and sets the property AuthenticationMode. 
        /// <para>
        ///  The authentication mode used in WorkMail.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentityProviderAuthenticationMode AuthenticationMode
        {
            get { return this._authenticationMode; }
            set { this._authenticationMode = value; }
        }

        // Check to see if AuthenticationMode property is set
        internal bool IsSetAuthenticationMode()
        {
            return this._authenticationMode != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityCenterConfiguration. 
        /// <para>
        ///  The details of the IAM Identity Center configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public IdentityCenterConfiguration IdentityCenterConfiguration
        {
            get { return this._identityCenterConfiguration; }
            set { this._identityCenterConfiguration = value; }
        }

        // Check to see if IdentityCenterConfiguration property is set
        internal bool IsSetIdentityCenterConfiguration()
        {
            return this._identityCenterConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property OrganizationId. 
        /// <para>
        ///  The ID of the WorkMail Organization. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=34, Max=34)]
        public string OrganizationId
        {
            get { return this._organizationId; }
            set { this._organizationId = value; }
        }

        // Check to see if OrganizationId property is set
        internal bool IsSetOrganizationId()
        {
            return this._organizationId != null;
        }

        /// <summary>
        /// Gets and sets the property PersonalAccessTokenConfiguration. 
        /// <para>
        ///  The details of the Personal Access Token configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PersonalAccessTokenConfiguration PersonalAccessTokenConfiguration
        {
            get { return this._personalAccessTokenConfiguration; }
            set { this._personalAccessTokenConfiguration = value; }
        }

        // Check to see if PersonalAccessTokenConfiguration property is set
        internal bool IsSetPersonalAccessTokenConfiguration()
        {
            return this._personalAccessTokenConfiguration != null;
        }

    }
}