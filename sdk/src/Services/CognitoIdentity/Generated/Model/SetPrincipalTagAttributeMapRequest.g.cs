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

namespace Amazon.CognitoIdentity.Model
{
    /// <summary>
    /// Container for the parameters to the SetPrincipalTagAttributeMap operation. You can
    /// use this operation to use default (username and clientID) attribute or custom attribute
    /// mappings.
    /// </summary>
    public partial class SetPrincipalTagAttributeMapRequest : AmazonCognitoIdentityRequest
    {
        /// <summary>
        /// Gets and sets the property IdentityPoolId. 
        /// <para>
        /// The ID of the Identity Pool you want to set attribute mappings for.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 55)]
        public string IdentityPoolId { get; set; }

        /// <summary>
        /// Checks to see if the IdentityPoolId property is set.
        /// </summary>
        internal bool IsSetIdentityPoolId() => this.IdentityPoolId != null;

        /// <summary>
        /// Gets and sets the property IdentityProviderName. 
        /// <para>
        /// The provider name you want to use for attribute mappings.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string IdentityProviderName { get; set; }

        /// <summary>
        /// Checks to see if the IdentityProviderName property is set.
        /// </summary>
        internal bool IsSetIdentityProviderName() => this.IdentityProviderName != null;

        /// <summary>
        /// Gets and sets the property PrincipalTags. 
        /// <para>
        /// You can use this operation to add principal tags.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> PrincipalTags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the PrincipalTags property is set.
        /// </summary>
        internal bool IsSetPrincipalTags() => this.PrincipalTags != null && (this.PrincipalTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UseDefaults. 
        /// <para>
        /// You can use this operation to use default (username and clientID) attribute mappings.
        /// </para>
        /// </summary>
        public bool? UseDefaults { get; set; }

        /// <summary>
        /// Checks to see if the UseDefaults property is set.
        /// </summary>
        internal bool IsSetUseDefaults() => this.UseDefaults.HasValue;
    }
}
