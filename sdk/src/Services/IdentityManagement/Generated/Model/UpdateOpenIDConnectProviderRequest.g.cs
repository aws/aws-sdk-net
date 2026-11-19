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
    /// Container for the parameters to the UpdateOpenIDConnectProvider operation. Updates
    /// the configuration of an existing IAM OpenID Connect (OIDC) identity provider resource
    /// object. Use this operation to set, change, or remove the trusted identity propagation
    /// context provider, and to associate or disassociate an IAM Identity Center instance
    /// with the provider. <note> <para> This operation does not update the OIDC provider's
    /// server certificate thumbprints. Thumbprints are managed only by the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_UpdateOpenIDConnectProviderThumbprint.html">UpdateOpenIDConnectProviderThumbprint</a>
    /// operation. To change a provider's thumbprints, call that operation instead. </para>
    /// </note> <para> To remove a configuration rather than replace it, use the <c>RemoveContextProvider</c>
    /// and <c>RemoveIdentityCenterInstance</c> parameters. For each configuration, provide
    /// either the new value or the corresponding <c>Remove</c> flag in a single request,
    /// but not both. For example, specifying both <c>ContextProvider</c> and <c>RemoveContextProvider</c>
    /// in the same request is not allowed. </para> <para> A single request can change either
    /// the context provider or the IAM Identity Center association, but not both. To change
    /// both, make separate <c>UpdateOpenIDConnectProvider</c> requests. To remove the context
    /// provider, first remove the IAM Identity Center association in a separate request.
    /// </para> <para> To control who can configure trusted identity propagation on an OIDC
    /// provider, use the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_EnableIdentityPropagation">iam:EnableIdentityPropagation</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_EnableIdentityCenterAssociation">iam:EnableIdentityCenterAssociation</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_ResourceIdentityProviderIssuers">iam:ResourceIdentityProviderIssuers</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_RequestIdentityCenterInstanceArn">iam:RequestIdentityCenterInstanceArn</a>,
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_ResourceIdentityCenterInstanceArn">iam:ResourceIdentityCenterInstanceArn</a>
    /// condition keys in IAM policies. The <c>Request</c> keys contain the values in the
    /// request. The <c>Resource</c> keys contain the values stored on the provider. </para>
    /// </summary>
    public partial class UpdateOpenIDConnectProviderRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ContextProvider. 
        /// <para>
        /// The trusted identity propagation context provider configuration to set on the OIDC
        /// provider. This configuration defines the subject mapping and the source-to-target
        /// key mappings that are used when trusted context is injected. For more information,
        /// see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ContextProvider.html">ContextProvider</a>.
        /// </para>
        ///  
        /// <para>
        /// To remove the existing context provider instead of replacing it, use <c>RemoveContextProvider</c>.
        /// Do not specify both <c>ContextProvider</c> and <c>RemoveContextProvider</c> in the
        /// same request.
        /// </para>
        /// </summary>
        public ContextProvider ContextProvider { get; set; }

        /// <summary>
        /// Checks to see if the ContextProvider property is set.
        /// </summary>
        internal bool IsSetContextProvider() => this.ContextProvider != null;

        /// <summary>
        /// Gets and sets the property IdentityCenterInstanceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM Identity Center instance to associate with
        /// the OIDC provider.
        /// </para>
        ///  
        /// <para>
        /// For the format, see <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_InstanceMetadata.html">InstanceMetadata</a>
        /// in the <i>IAM Identity Center API Reference</i>.
        /// </para>
        ///  
        /// <para>
        /// To disassociate the currently associated instance instead of changing it, use <c>RemoveIdentityCenterInstance</c>.
        /// Do not specify both <c>IdentityCenterInstanceArn</c> and <c>RemoveIdentityCenterInstance</c>
        /// in the same request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string IdentityCenterInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdentityCenterInstanceArn() => this.IdentityCenterInstanceArn != null;

        /// <summary>
        /// Gets and sets the property OpenIDConnectProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM OIDC provider resource object to update.
        /// You can get a list of OIDC provider resource ARNs by using the <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ListOpenIDConnectProviders.html">ListOpenIDConnectProviders</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string OpenIDConnectProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the OpenIDConnectProviderArn property is set.
        /// </summary>
        internal bool IsSetOpenIDConnectProviderArn() => this.OpenIDConnectProviderArn != null;

        /// <summary>
        /// Gets and sets the property RemoveContextProvider. 
        /// <para>
        /// Specifies whether to remove the existing context provider configuration from the OIDC
        /// provider. Set this value to <c>true</c> to remove the context provider.
        /// </para>
        ///  
        /// <para>
        /// This parameter is mutually exclusive with <c>ContextProvider</c>. In a single request,
        /// specify either a new <c>ContextProvider</c> value or <c>RemoveContextProvider</c>,
        /// but not both.
        /// </para>
        /// </summary>
        public bool? RemoveContextProvider { get; set; }

        /// <summary>
        /// Checks to see if the RemoveContextProvider property is set.
        /// </summary>
        internal bool IsSetRemoveContextProvider() => this.RemoveContextProvider.HasValue;

        /// <summary>
        /// Gets and sets the property RemoveIdentityCenterInstance. 
        /// <para>
        /// Specifies whether to disassociate the IAM Identity Center instance from the OIDC provider.
        /// Set this value to <c>true</c> to remove the association.
        /// </para>
        ///  
        /// <para>
        /// This parameter is mutually exclusive with <c>IdentityCenterInstanceArn</c>. In a single
        /// request, specify either a new <c>IdentityCenterInstanceArn</c> value or <c>RemoveIdentityCenterInstance</c>,
        /// but not both.
        /// </para>
        /// </summary>
        public bool? RemoveIdentityCenterInstance { get; set; }

        /// <summary>
        /// Checks to see if the RemoveIdentityCenterInstance property is set.
        /// </summary>
        internal bool IsSetRemoveIdentityCenterInstance() => this.RemoveIdentityCenterInstance.HasValue;
    }
}
