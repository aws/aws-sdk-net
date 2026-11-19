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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Contains the trusted identity propagation context provider configuration for a SAML
    /// or OpenID Connect (OIDC) identity provider. The context provider defines how the subject
    /// is derived and how keys from the external identity provider's assertion or token are
    /// mapped into trusted context keys.
    /// 
    ///  
    /// <para>
    /// This data type is used as a request parameter in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateOpenIDConnectProvider.html">CreateOpenIDConnectProvider</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateOpenIDConnectProvider.html">UpdateOpenIDConnectProvider</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_CreateSAMLProvider.html">CreateSAMLProvider</a>,
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateSAMLProvider.html">UpdateSAMLProvider</a>
    /// operations, and as a response element in the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetOpenIDConnectProvider.html">GetOpenIDConnectProvider</a>
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetSAMLProvider.html">GetSAMLProvider</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class ContextProvider
    {
        /// <summary>
        /// Gets and sets the property KeyDefinitionList. 
        /// <para>
        /// A list of source-to-target key mappings that define how keys from the external identity
        /// provider's assertion or token are mapped into trusted context keys. You can specify
        /// from 0 to 10 mappings.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<ContextProviderKeyDefinition> KeyDefinitionList { get; set; } = AWSConfigs.InitializeCollections ? new List<ContextProviderKeyDefinition>() : null;

        /// <summary>
        /// Checks to see if the KeyDefinitionList property is set.
        /// </summary>
        internal bool IsSetKeyDefinitionList() => this.KeyDefinitionList != null && (this.KeyDefinitionList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SubjectSourceKey. 
        /// <para>
        /// The source key that is used to derive the subject for the injected trusted context.
        /// This value identifies the claim or attribute in the external identity provider's assertion
        /// or token that supplies the subject.
        /// </para>
        ///  
        /// <para>
        /// The key can contain only ASCII letters (A-Z, a-z), numbers (0-9), single spaces, and
        /// the following characters: <c>_ . : / = + - @ #</c>. It can't start or end with a space
        /// or contain two spaces in a row.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string SubjectSourceKey { get; set; }

        /// <summary>
        /// Checks to see if the SubjectSourceKey property is set.
        /// </summary>
        internal bool IsSetSubjectSourceKey() => this.SubjectSourceKey != null;

        /// <summary>
        /// Gets and sets the property SubjectTypeSourceKey. 
        /// <para>
        /// The source key that supplies the subject type from the external identity provider's
        /// assertion or token.
        /// </para>
        ///  
        /// <para>
        /// The key can contain only ASCII letters (A-Z, a-z), numbers (0-9), single spaces, and
        /// the following characters: <c>_ . : / = + - @ #</c>. It can't start or end with a space
        /// or contain two spaces in a row.
        /// </para>
        ///  
        /// <para>
        /// This parameter is mutually exclusive with <c>SubjectTypeValue</c>. Specify either
        /// <c>SubjectTypeSourceKey</c> or <c>SubjectTypeValue</c>, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 128)]
        public string SubjectTypeSourceKey { get; set; }

        /// <summary>
        /// Checks to see if the SubjectTypeSourceKey property is set.
        /// </summary>
        internal bool IsSetSubjectTypeSourceKey() => this.SubjectTypeSourceKey != null;

        /// <summary>
        /// Gets and sets the property SubjectTypeValue. 
        /// <para>
        /// A static value for the subject type, such as <c>user</c> or <c>workload</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional and is mutually exclusive with <c>SubjectTypeSourceKey</c>.
        /// Specify either <c>SubjectTypeValue</c> or <c>SubjectTypeSourceKey</c>, but not both.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 128)]
        public string SubjectTypeValue { get; set; }

        /// <summary>
        /// Checks to see if the SubjectTypeValue property is set.
        /// </summary>
        internal bool IsSetSubjectTypeValue() => this.SubjectTypeValue != null;
    }
}
