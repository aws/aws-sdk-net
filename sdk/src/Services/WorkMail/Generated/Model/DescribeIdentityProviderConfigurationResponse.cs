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
    /// This is the response object from the DescribeIdentityProviderConfiguration operation.
    /// </summary>
    public partial class DescribeIdentityProviderConfigurationResponse : AmazonWebServiceResponse
    {
        private IdentityProviderAuthenticationMode _authenticationMode;
        private IdentityCenterConfiguration _identityCenterConfiguration;
        private PersonalAccessTokenConfiguration _personalAccessTokenConfiguration;

        /// <summary>
        /// Gets and sets the property AuthenticationMode. 
        /// <para>
        ///  The authentication mode used in WorkMail.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property PersonalAccessTokenConfiguration. 
        /// <para>
        ///  The details of the Personal Access Token configuration. 
        /// </para>
        /// </summary>
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