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
    /// Contains the response to a successful <a href="https://docs.aws.amazon.com/IAM/latest/APIReference/API_GetSAMLProvider.html">GetSAMLProvider</a>
    /// request.
    /// </summary>
    public partial class GetSAMLProviderResponse : AmazonWebServiceResponse
    {
        private AssertionEncryptionModeType _assertionEncryptionMode;
        private DateTime? _createDate;
        private List<SAMLPrivateKey> _privateKeyList = AWSConfigs.InitializeCollections ? new List<SAMLPrivateKey>() : null;
        private string _samlMetadataDocument;
        private string _samlProviderUUID;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _validUntil;

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
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time when the SAML provider was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate
        {
            get { return this._createDate; }
            set { this._createDate = value; }
        }

        // Check to see if CreateDate property is set
        internal bool IsSetCreateDate()
        {
            return this._createDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PrivateKeyList. 
        /// <para>
        /// The private key metadata for the SAML provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Max=2)]
        public List<SAMLPrivateKey> PrivateKeyList
        {
            get { return this._privateKeyList; }
            set { this._privateKeyList = value; }
        }

        // Check to see if PrivateKeyList property is set
        internal bool IsSetPrivateKeyList()
        {
            return this._privateKeyList != null && (this._privateKeyList.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SAMLMetadataDocument. 
        /// <para>
        /// The XML metadata document that includes information about an identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1000, Max=10000000)]
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
        /// Gets and sets the property SAMLProviderUUID. 
        /// <para>
        /// The unique identifier assigned to the SAML provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=64)]
        public string SAMLProviderUUID
        {
            get { return this._samlProviderUUID; }
            set { this._samlProviderUUID = value; }
        }

        // Check to see if SAMLProviderUUID property is set
        internal bool IsSetSAMLProviderUUID()
        {
            return this._samlProviderUUID != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that are attached to the specified IAM SAML provider. The returned
        /// list of tags is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property ValidUntil. 
        /// <para>
        /// The expiration date and time for the SAML provider.
        /// </para>
        /// </summary>
        public DateTime? ValidUntil
        {
            get { return this._validUntil; }
            set { this._validUntil = value; }
        }

        // Check to see if ValidUntil property is set
        internal bool IsSetValidUntil()
        {
            return this._validUntil.HasValue; 
        }

    }
}