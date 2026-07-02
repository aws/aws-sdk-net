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
    /// Contains detailed information about an ACME endpoint.
    /// </summary>
    public partial class AcmeEndpoint
    {
        private string _acmeEndpointArn;
        private AcmeAuthorizationBehavior _authorizationBehavior;
        private CertificateAuthority _certificateAuthority;
        private List<Tag> _certificateTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private AcmeContact _contact;
        private DateTime? _createdAt;
        private string _endpointUrl;
        private string _failureReason;
        private AcmeEndpointStatus _status;
        private DateTime? _updatedAt;

        /// <summary>
        /// Gets and sets the property AcmeEndpointArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the ACME endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string AcmeEndpointArn
        {
            get { return this._acmeEndpointArn; }
            set { this._acmeEndpointArn = value; }
        }

        // Check to see if AcmeEndpointArn property is set
        internal bool IsSetAcmeEndpointArn()
        {
            return this._acmeEndpointArn != null;
        }

        /// <summary>
        /// Gets and sets the property AuthorizationBehavior. 
        /// <para>
        /// The authorization behavior of the ACME endpoint.
        /// </para>
        /// </summary>
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
        /// The certificate authority configuration for the ACME endpoint.
        /// </para>
        /// </summary>
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
        /// Tags applied to certificates issued through this ACME endpoint.
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
        /// Whether ACME clients must provide contact information during account registration.
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the ACME endpoint was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndpointUrl. 
        /// <para>
        /// The URL of the ACME endpoint.
        /// </para>
        /// </summary>
        public string EndpointUrl
        {
            get { return this._endpointUrl; }
            set { this._endpointUrl = value; }
        }

        // Check to see if EndpointUrl property is set
        internal bool IsSetEndpointUrl()
        {
            return this._endpointUrl != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reason the ACME endpoint failed, if applicable.
        /// </para>
        /// </summary>
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the ACME endpoint.
        /// </para>
        /// </summary>
        public AcmeEndpointStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The time at which the ACME endpoint was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

    }
}