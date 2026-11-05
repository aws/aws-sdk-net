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
    /// This is the response object from the GetSAMLProvider operation.
    /// </summary>
    public partial class GetSAMLProviderResponse : AmazonWebServiceResponse
    {
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
        /// Gets and sets the property CreateDate. 
        /// <para>
        /// The date and time when the SAML provider was created.
        /// </para>
        /// </summary>
        public DateTime? CreateDate { get; set; }

        /// <summary>
        /// Checks to see if the CreateDate property is set.
        /// </summary>
        internal bool IsSetCreateDate() => this.CreateDate.HasValue;

        /// <summary>
        /// Gets and sets the property PrivateKeyList. 
        /// <para>
        /// The private key metadata for the SAML provider.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 2)]
        public List<SAMLPrivateKey> PrivateKeyList { get; set; } = AWSConfigs.InitializeCollections ? new List<SAMLPrivateKey>() : null;

        /// <summary>
        /// Checks to see if the PrivateKeyList property is set.
        /// </summary>
        internal bool IsSetPrivateKeyList() => this.PrivateKeyList != null && (this.PrivateKeyList.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SAMLMetadataDocument. 
        /// <para>
        /// The XML metadata document that includes information about an identity provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1000, Max = 10000000)]
        public string SAMLMetadataDocument { get; set; }

        /// <summary>
        /// Checks to see if the SAMLMetadataDocument property is set.
        /// </summary>
        internal bool IsSetSAMLMetadataDocument() => this.SAMLMetadataDocument != null;

        /// <summary>
        /// Gets and sets the property SAMLProviderUUID. 
        /// <para>
        /// The unique identifier assigned to the SAML provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 22, Max = 64)]
        public string SAMLProviderUUID { get; set; }

        /// <summary>
        /// Checks to see if the SAMLProviderUUID property is set.
        /// </summary>
        internal bool IsSetSAMLProviderUUID() => this.SAMLProviderUUID != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that are attached to the specified IAM SAML provider. The returned
        /// list of tags is sorted by tag key. For more information about tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ValidUntil. 
        /// <para>
        /// The expiration date and time for the SAML provider.
        /// </para>
        /// </summary>
        public DateTime? ValidUntil { get; set; }

        /// <summary>
        /// Checks to see if the ValidUntil property is set.
        /// </summary>
        internal bool IsSetValidUntil() => this.ValidUntil.HasValue;
    }
}
