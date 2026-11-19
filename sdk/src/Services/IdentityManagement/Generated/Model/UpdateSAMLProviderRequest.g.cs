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
    /// Container for the parameters to the UpdateSAMLProvider operation. Updates the metadata
    /// document, SAML encryption settings, and private keys for an existing SAML provider.
    /// To rotate private keys, add your new private key and then remove the old key in a
    /// separate request. <para> You can also use this operation to set, change, or remove
    /// the trusted identity propagation context provider, and to associate or disassociate
    /// an IAM Identity Center instance with the provider. To remove a configuration rather
    /// than replace it, use the <c>RemoveContextProvider</c> and <c>RemoveIdentityCenterInstance</c>
    /// parameters. For each configuration, provide either the new value or the corresponding
    /// <c>Remove</c> flag in a single request, but not both. </para> <para> A single request
    /// can change either the context provider or the provider metadata, but not both. Provider
    /// metadata includes the SAML metadata document, assertion encryption mode, private keys,
    /// and IAM Identity Center association. To change both, make separate <c>UpdateSAMLProvider</c>
    /// requests. To remove the context provider, first remove the IAM Identity Center association
    /// in a separate request. </para> <para> To control who can configure trusted identity
    /// propagation on a SAML provider, use the <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_EnableIdentityPropagation">iam:EnableIdentityPropagation</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_EnableIdentityCenterAssociation">iam:EnableIdentityCenterAssociation</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_RequestIdentityProviderIssuers">iam:RequestIdentityProviderIssuers</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_ResourceIdentityProviderIssuers">iam:ResourceIdentityProviderIssuers</a>,
    /// <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_RequestIdentityCenterInstanceArn">iam:RequestIdentityCenterInstanceArn</a>,
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_policies_iam-condition-keys.html#ck_ResourceIdentityCenterInstanceArn">iam:ResourceIdentityCenterInstanceArn</a>
    /// condition keys in IAM policies. The <c>Request</c> keys contain the values in the
    /// request. The <c>Resource</c> keys contain the values stored on the provider. </para>
    /// </summary>
    public partial class UpdateSAMLProviderRequest : AmazonIdentityManagementServiceRequest
    {
        /// <summary>
        /// Gets and sets the property AddPrivateKey. 
        /// <para>
        /// Specifies the new private key from your external identity provider. The private key
        /// must be a .pem file that uses AES-GCM or AES-CBC encryption algorithm to decrypt SAML
        /// assertions.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 16384)]
        public string AddPrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the AddPrivateKey property is set.
        /// </summary>
        internal bool IsSetAddPrivateKey() => this.AddPrivateKey != null;

        /// <summary>
        /// Gets and sets the property AssertionEncryptionMode. 
        /// <para>
        /// Specifies the encryption setting for the SAML provider.
        /// </para>
        /// </summary>
        public AssertionEncryptionModeType AssertionEncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the AssertionEncryptionMode property is set.
        /// </summary>
        internal bool IsSetAssertionEncryptionMode() => this.AssertionEncryptionMode != null;

        /// <summary>
        /// Gets and sets the property ContextProvider. 
        /// <para>
        /// The trusted identity propagation context provider configuration to associate with
        /// the SAML provider. This replaces the existing context provider configuration. For
        /// more information, see <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_ContextProvider.html">ContextProvider</a>.
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
        /// the SAML provider.
        /// </para>
        ///  
        /// <para>
        /// For the format, see <a href="https://docs.aws.amazon.com/singlesignon/latest/APIReference/API_InstanceMetadata.html">InstanceMetadata</a>
        /// in the <i>IAM Identity Center API Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1224)]
        public string IdentityCenterInstanceArn { get; set; }

        /// <summary>
        /// Checks to see if the IdentityCenterInstanceArn property is set.
        /// </summary>
        internal bool IsSetIdentityCenterInstanceArn() => this.IdentityCenterInstanceArn != null;

        /// <summary>
        /// Gets and sets the property RemoveContextProvider. 
        /// <para>
        /// Specifies whether to remove the existing trusted identity propagation context provider
        /// configuration from the SAML provider. When set to <c>true</c>, the context provider
        /// is removed. This parameter is mutually exclusive with <c>ContextProvider</c>.
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
        /// Specifies whether to disassociate the IAM Identity Center instance from the SAML provider.
        /// When set to <c>true</c>, the instance is disassociated. This parameter is mutually
        /// exclusive with <c>IdentityCenterInstanceArn</c>.
        /// </para>
        /// </summary>
        public bool? RemoveIdentityCenterInstance { get; set; }

        /// <summary>
        /// Checks to see if the RemoveIdentityCenterInstance property is set.
        /// </summary>
        internal bool IsSetRemoveIdentityCenterInstance() => this.RemoveIdentityCenterInstance.HasValue;

        /// <summary>
        /// Gets and sets the property RemovePrivateKey. 
        /// <para>
        /// The Key ID of the private key to remove.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 64)]
        public string RemovePrivateKey { get; set; }

        /// <summary>
        /// Checks to see if the RemovePrivateKey property is set.
        /// </summary>
        internal bool IsSetRemovePrivateKey() => this.RemovePrivateKey != null;

        /// <summary>
        /// Gets and sets the property SAMLMetadataDocument. 
        /// <para>
        /// An XML document generated by an identity provider (IdP) that supports SAML 2.0. The
        /// document includes the issuer's name, expiration information, and keys that can be
        /// used to validate the SAML authentication response (assertions) that are received from
        /// the IdP. You must generate the metadata document using the identity management software
        /// that is used as your IdP.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1000, Max = 10000000)]
        public string SAMLMetadataDocument { get; set; }

        /// <summary>
        /// Checks to see if the SAMLMetadataDocument property is set.
        /// </summary>
        internal bool IsSetSAMLMetadataDocument() => this.SAMLMetadataDocument != null;

        /// <summary>
        /// Gets and sets the property SAMLProviderArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the SAML provider to update.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="https://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs)</a> in the <i>Amazon Web Services General Reference</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string SAMLProviderArn { get; set; }

        /// <summary>
        /// Checks to see if the SAMLProviderArn property is set.
        /// </summary>
        internal bool IsSetSAMLProviderArn() => this.SAMLProviderArn != null;
    }
}
