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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
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
    /// Container for the parameters to the CreateSAMLProvider operation.
    /// Creates an IAM resource that describes an identity provider (IdP) that supports SAML
    /// 2.0.
    /// 
    ///  
    /// <para>
    /// The SAML provider resource that you create with this operation can be used as a principal
    /// in an IAM role's trust policy. Such a policy can enable federated users who sign in
    /// using the SAML IdP to assume the role. You can create an IAM role that supports Web-based
    /// single sign-on (SSO) to the Amazon Web Services Management Console or one that supports
    /// API access to Amazon Web Services.
    /// </para>
    ///  
    /// <para>
    /// When you create the SAML provider resource, you upload a SAML metadata document that
    /// you get from your IdP. That document includes the issuer's name, expiration information,
    /// and keys that can be used to validate the SAML authentication response (assertions)
    /// that the IdP sends. You must generate the metadata document using the identity management
    /// software that is used as your organization's IdP.
    /// </para>
    ///  <note> 
    /// <para>
    ///  This operation requires <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
    /// Version 4</a>.
    /// </para>
    ///  </note> 
    /// <para>
    ///  For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_enable-console-saml.html">Enabling
    /// SAML 2.0 federated users to access the Amazon Web Services Management Console</a>
    /// and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
    /// SAML 2.0-based federation</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateSAMLProviderRequest : AmazonIdentityManagementServiceRequest
    {
        private string _addPrivateKey;
        private AssertionEncryptionModeType _assertionEncryptionMode;
        private string _name;
        private string _samlMetadataDocument;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AddPrivateKey. 
        /// <para>
        /// The private key generated from your external identity provider. The private key must
        /// be a .pem file that uses AES-GCM or AES-CBC encryption algorithm to decrypt SAML assertions.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=16384)]
        public string AddPrivateKey
        {
            get { return this._addPrivateKey; }
            set { this._addPrivateKey = value; }
        }

        // Check to see if AddPrivateKey property is set
        internal bool IsSetAddPrivateKey()
        {
            return this._addPrivateKey != null;
        }

        /// <summary>
        /// Gets and sets the property AssertionEncryptionMode. 
        /// <para>
        /// Specifies the encryption setting for the SAML provider.
        /// </para>
        /// </summary>
        public AssertionEncryptionModeType AssertionEncryptionMode
        {
            get { return this._assertionEncryptionMode; }
            set { this._assertionEncryptionMode = value; }
        }

        // Check to see if AssertionEncryptionMode property is set
        internal bool IsSetAssertionEncryptionMode()
        {
            return this._assertionEncryptionMode != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the provider to create.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property SAMLMetadataDocument. 
        /// <para>
        /// An XML document generated by an identity provider (IdP) that supports SAML 2.0. The
        /// document includes the issuer's name, expiration information, and keys that can be
        /// used to validate the SAML authentication response (assertions) that are received from
        /// the IdP. You must generate the metadata document using the identity management software
        /// that is used as your organization's IdP.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_roles_providers_saml.html">About
        /// SAML 2.0-based federation</a> in the <i>IAM User Guide</i> 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1000, Max=10000000)]
        public string SAMLMetadataDocument
        {
            get { return this._samlMetadataDocument; }
            set { this._samlMetadataDocument = value; }
        }

        // Check to see if SAMLMetadataDocument property is set
        internal bool IsSetSAMLMetadataDocument()
        {
            return this._samlMetadataDocument != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that you want to attach to the new IAM SAML provider. Each tag consists
        /// of a key name and an associated value. For more information about tagging, see <a
        /// href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging IAM resources</a>
        /// in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created.
        /// </para>
        ///  </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}