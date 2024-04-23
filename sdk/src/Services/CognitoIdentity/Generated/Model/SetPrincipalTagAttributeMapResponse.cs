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
 * Do not modify this file. This file is generated from the cognito-identity-2014-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// This is the response object from the SetPrincipalTagAttributeMap operation.
    /// </summary>
    public partial class SetPrincipalTagAttributeMapResponse : AmazonWebServiceResponse
    {
        private string _identityPoolId;
        private string _identityProviderName;
        private Dictionary<string, string> _principalTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private bool? _useDefaults;

        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// The ID of the Identity Pool you want to set attribute mappings for.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=55)]
        public string IdentityPoolId
        {
            get { return this._identityPoolId; }
            set { this._identityPoolId = value; }
        }

        // Check to see if IdentityPoolId property is set
        internal bool IsSetIdentityPoolId()
        {
            return this._identityPoolId != null;
        }

        /// <summary>
        /// Gets and sets the property IdentityProviderName. 
        /// <para>
        /// The provider name you want to use for attribute mappings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string IdentityProviderName
        {
            get { return this._identityProviderName; }
            set { this._identityProviderName = value; }
        }

        // Check to see if IdentityProviderName property is set
        internal bool IsSetIdentityProviderName()
        {
            return this._identityProviderName != null;
        }

        /// <summary>
        /// Gets and sets the property PrincipalTags. 
        /// <para>
        /// You can use this operation to add principal tags. The <c>PrincipalTags</c>operation
        /// enables you to reference user attributes in your IAM permissions policy.
        /// </para>
        /// </summary>
        [AWSProperty(Max=50)]
        public Dictionary<string, string> PrincipalTags
        {
            get { return this._principalTags; }
            set { this._principalTags = value; }
        }

        // Check to see if PrincipalTags property is set
        internal bool IsSetPrincipalTags()
        {
            return this._principalTags != null && (this._principalTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UseDefaults. 
        /// <para>
        /// You can use this operation to select default (username and clientID) attribute mappings.
        /// </para>
        /// </summary>
        public bool UseDefaults
        {
            get { return this._useDefaults.GetValueOrDefault(); }
            set { this._useDefaults = value; }
        }

        // Check to see if UseDefaults property is set
        internal bool IsSetUseDefaults()
        {
            return this._useDefaults.HasValue; 
        }

    }
}