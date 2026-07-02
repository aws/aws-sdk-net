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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
    /// Container for the parameters to the CreateAcmeEndpoint operation.
    /// Creates an ACME endpoint, which is a managed ACME server with a unique endpoint URL.
    /// After creation, ACME clients can use the endpoint URL to automate certificate issuance
    /// using the ACME protocol.
    /// </summary>
    public partial class CreateAcmeEndpointRequest : AmazonCertificateManagerRequest
    {
        private AcmeAuthorizationBehavior _authorizationBehavior;
        private CertificateAuthority _certificateAuthority;
        private List<Tag> _certificateTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private AcmeContact _contact;
        private string _idempotencyToken;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AuthorizationBehavior. 
        /// <para>
        /// The authorization behavior for the ACME endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AcmeAuthorizationBehavior AuthorizationBehavior
        {
            get { return this._authorizationBehavior; }
            set { this._authorizationBehavior = value; }
        }

        // Check to see if AuthorizationBehavior property is set
        internal bool IsSetAuthorizationBehavior()
        {
            return this._authorizationBehavior != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateAuthority. 
        /// <para>
        /// The type of certificate authority to use for issuing certificates through this ACME
        /// endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CertificateAuthority CertificateAuthority
        {
            get { return this._certificateAuthority; }
            set { this._certificateAuthority = value; }
        }

        // Check to see if CertificateAuthority property is set
        internal bool IsSetCertificateAuthority()
        {
            return this._certificateAuthority != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateTags. 
        /// <para>
        /// Tags to apply to certificates issued through this ACME endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public List<Tag> CertificateTags
        {
            get { return this._certificateTags; }
            set { this._certificateTags = value; }
        }

        // Check to see if CertificateTags property is set
        internal bool IsSetCertificateTags()
        {
            return this._certificateTags != null && (this._certificateTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Contact. 
        /// <para>
        /// Specifies whether ACME clients must provide contact information during account registration.
        /// </para>
        /// </summary>
        public AcmeContact Contact
        {
            get { return this._contact; }
            set { this._contact = value; }
        }

        // Check to see if Contact property is set
        internal bool IsSetContact()
        {
            return this._contact != null;
        }

        /// <summary>
        /// Gets and sets the property IdempotencyToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure idempotency of the request.
        /// </para>
        /// </summary>
        public string IdempotencyToken
        {
            get { return this._idempotencyToken; }
            set { this._idempotencyToken = value; }
        }

        // Check to see if IdempotencyToken property is set
        internal bool IsSetIdempotencyToken()
        {
            return this._idempotencyToken != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// One or more tags to associate with the ACME endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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