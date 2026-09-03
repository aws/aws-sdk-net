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
 * Do not modify this file. This file is generated from the eks-2017-11-01.normal.json service model.
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
namespace Amazon.EKS.Model
{
    /// <summary>
    /// Summary information about a certificate authority (CA) for an Amazon EKS cluster,
    /// returned by <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_ListCertificateAuthorities.html">
    /// <c>ListCertificateAuthorities</c> </a> and the certificate-authority write operations.
    /// </summary>
    public partial class CertificateAuthoritySummary
    {
        private DateTime? _activatedAt;
        private CertificateAuthorityActivatedBy _activatedBy;
        private DateTime? _createdAt;
        private CertificateAuthorityCreatedBy _createdBy;
        private CertificateAuthorityDistributionStatus _distributionStatus;
        private string _id;
        private CertificateAuthoritySigningStatus _signingStatus;

        /// <summary>
        /// Gets and sets the property ActivatedAt. 
        /// <para>
        /// The Unix epoch timestamp in seconds for when the certificate authority was last activated.
        /// This value is absent if the certificate authority has never been activated.
        /// </para>
        /// </summary>
        public DateTime? ActivatedAt
        {
            get { return this._activatedAt; }
            set { this._activatedAt = value; }
        }

        // Check to see if ActivatedAt property is set
        internal bool IsSetActivatedAt()
        {
            return this._activatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActivatedBy. 
        /// <para>
        /// The entity that most recently activated the certificate authority, either <c>CUSTOMER</c>
        /// or <c>EKS</c>.
        /// </para>
        /// </summary>
        public CertificateAuthorityActivatedBy ActivatedBy
        {
            get { return this._activatedBy; }
            set { this._activatedBy = value; }
        }

        // Check to see if ActivatedBy property is set
        internal bool IsSetActivatedBy()
        {
            return this._activatedBy != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp in seconds for when the certificate authority was created.
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
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The entity that created the certificate authority, either <c>CUSTOMER</c> or <c>EKS</c>.
        /// </para>
        /// </summary>
        public CertificateAuthorityCreatedBy CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionStatus. 
        /// <para>
        /// The distribution status of the certificate authority: <c>IN_PROGRESS</c>, <c>COMPLETE</c>,
        /// <c>FAILED</c>, or <c>DELETING</c>.
        /// </para>
        /// </summary>
        public CertificateAuthorityDistributionStatus DistributionStatus
        {
            get { return this._distributionStatus; }
            set { this._distributionStatus = value; }
        }

        // Check to see if DistributionStatus property is set
        internal bool IsSetDistributionStatus()
        {
            return this._distributionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the certificate authority.
        /// </para>
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property SigningStatus. 
        /// <para>
        /// The signing status of the certificate authority: <c>IN_USE</c>, <c>ACTIVATING</c>,
        /// or <c>NOT_USED</c>.
        /// </para>
        /// </summary>
        public CertificateAuthoritySigningStatus SigningStatus
        {
            get { return this._signingStatus; }
            set { this._signingStatus = value; }
        }

        // Check to see if SigningStatus property is set
        internal bool IsSetSigningStatus()
        {
            return this._signingStatus != null;
        }

    }
}