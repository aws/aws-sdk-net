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

namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateAcmeEndpoint operation. Creates an ACME
    /// endpoint, which is a managed ACME server with a unique endpoint URL. After creation,
    /// ACME clients can use the endpoint URL to automate certificate issuance using the ACME
    /// protocol.
    /// </summary>
    public partial class CreateAcmeEndpointRequest : AmazonCertificateManagerRequest
    {
        /// <summary>
        /// Gets and sets the property AuthorizationBehavior. 
        /// <para>
        /// The authorization behavior for the ACME endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AcmeAuthorizationBehavior AuthorizationBehavior { get; set; }

        /// <summary>
        /// Checks to see if the AuthorizationBehavior property is set.
        /// </summary>
        internal bool IsSetAuthorizationBehavior() => this.AuthorizationBehavior != null;

        /// <summary>
        /// Gets and sets the property CertificateAuthority. 
        /// <para>
        /// The type of certificate authority to use for issuing certificates through this ACME
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public CertificateAuthority CertificateAuthority { get; set; }

        /// <summary>
        /// Checks to see if the CertificateAuthority property is set.
        /// </summary>
        internal bool IsSetCertificateAuthority() => this.CertificateAuthority != null;

        /// <summary>
        /// Gets and sets the property CertificateTags. 
        /// <para>
        /// Tags to apply to certificates issued through this ACME endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> CertificateTags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the CertificateTags property is set.
        /// </summary>
        internal bool IsSetCertificateTags() => this.CertificateTags != null && (this.CertificateTags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Contact. 
        /// <para>
        /// Specifies whether ACME clients must provide contact information during account registration.
        /// </para>
        /// </summary>
        public AcmeContact Contact { get; set; }

        /// <summary>
        /// Checks to see if the Contact property is set.
        /// </summary>
        internal bool IsSetContact() => this.Contact != null;

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        public string IdempotencyToken { get; set; }

        /// <summary>
        /// Checks to see if the IdempotencyToken property is set.
        /// </summary>
        internal bool IsSetIdempotencyToken() => this.IdempotencyToken != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to associate with the ACME endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
