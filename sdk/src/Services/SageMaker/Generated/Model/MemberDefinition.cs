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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Defines an Amazon Cognito or your own OIDC IdP user group that is part of a work team.
    /// </summary>
    public partial class MemberDefinition
    {
        private CognitoMemberDefinition _cognitoMemberDefinition;
        private OidcMemberDefinition _oidcMemberDefinition;

        /// <summary>
        /// Gets and sets the property CognitoMemberDefinition. 
        /// <para>
        /// The Amazon Cognito user group that is part of the work team.
        /// </para>
        /// </summary>
        public CognitoMemberDefinition CognitoMemberDefinition
        {
            get { return this._cognitoMemberDefinition; }
            set { this._cognitoMemberDefinition = value; }
        }

        // Check to see if CognitoMemberDefinition property is set
        internal bool IsSetCognitoMemberDefinition()
        {
            return this._cognitoMemberDefinition != null;
        }

        /// <summary>
        /// Gets and sets the property OidcMemberDefinition. 
        /// <para>
        /// A list user groups that exist in your OIDC Identity Provider (IdP). One to ten groups
        /// can be used to create a single private work team. When you add a user group to the
        /// list of <c>Groups</c>, you can add that user group to one or more private work teams.
        /// If you add a user group to a private work team, all workers in that user group are
        /// added to the work team.
        /// </para>
        /// </summary>
        public OidcMemberDefinition OidcMemberDefinition
        {
            get { return this._oidcMemberDefinition; }
            set { this._oidcMemberDefinition = value; }
        }

        // Check to see if OidcMemberDefinition property is set
        internal bool IsSetOidcMemberDefinition()
        {
            return this._oidcMemberDefinition != null;
        }

    }
}