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
    /// An object representing a certificate authority (CA) for an Amazon EKS cluster.
    /// </summary>
    public partial class CertificateAuthority
    {
        private DateTime? _activatedAt;
        private CertificateAuthorityActivatedBy _activatedBy;
        private DateTime? _createdAt;
        private CertificateAuthorityCreatedBy _createdBy;
        private string _data;
        private CertificateAuthorityDistributionStatus _distributionStatus;
        private string _id;
        private bool? _rollbackAvailable;
        private CertificateAuthorityScheduledEvents _scheduledEvents;
        private CertificateAuthoritySigningStatus _signingStatus;
        private CertificateAuthorityValidity _validity;

        /// <summary>
        /// Gets and sets the property ActivatedAt. 
        /// <para>
        /// The Unix epoch timestamp in seconds for when the certificate authority was last activated
        /// as the cluster's signer. This value is absent if the certificate authority has never
        /// been activated.
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
        /// The entity that most recently activated the certificate authority. A value of <c>EKS</c>
        /// indicates that Amazon EKS activated it automatically; <c>CUSTOMER</c> indicates that
        /// you activated it.
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
        /// The entity that created the certificate authority. Certificate authorities that you
        /// create are <c>CUSTOMER</c>; those that Amazon EKS provisions on your behalf, such
        /// as a cluster's initial certificate authority, are <c>EKS</c>.
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
        /// Gets and sets the property Data. 
        /// <para>
        /// The Base64-encoded public certificate of the certificate authority.
        /// </para>
        /// </summary>
        public string Data
        {
            get { return this._data; }
            set { this._data = value; }
        }

        // Check to see if Data property is set
        internal bool IsSetData()
        {
            return this._data != null;
        }

        /// <summary>
        /// Gets and sets the property DistributionStatus. 
        /// <para>
        /// The distribution status of the certificate authority, which tracks whether Amazon
        /// EKS has distributed its trust to the Amazon Web Services managed components in your
        /// cluster (the control plane, Amazon EKS Auto Mode instances, and Amazon Web Services
        /// Fargate nodes). Valid values are <c>IN_PROGRESS</c>, <c>COMPLETE</c>, <c>FAILED</c>,
        /// and <c>DELETING</c>. A successor CA can only be activated after its distribution status
        /// is <c>COMPLETE</c>.
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
        /// Gets and sets the property RollbackAvailable. 
        /// <para>
        /// Indicates whether CA rollback is still available for this certificate authority. After
        /// you activate a successor CA, rollback lets you revert to the outgoing CA for a limited
        /// period while you finish updating any worker nodes or clients that were missed.
        /// </para>
        /// </summary>
        public bool? RollbackAvailable
        {
            get { return this._rollbackAvailable; }
            set { this._rollbackAvailable = value; }
        }

        // Check to see if RollbackAvailable property is set
        internal bool IsSetRollbackAvailable()
        {
            return this._rollbackAvailable.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ScheduledEvents. 
        /// <para>
        /// The scheduled auto-activation events for the certificate authority, computed from
        /// its validity period.
        /// </para>
        /// </summary>
        public CertificateAuthorityScheduledEvents ScheduledEvents
        {
            get { return this._scheduledEvents; }
            set { this._scheduledEvents = value; }
        }

        // Check to see if ScheduledEvents property is set
        internal bool IsSetScheduledEvents()
        {
            return this._scheduledEvents != null;
        }

        /// <summary>
        /// Gets and sets the property SigningStatus. 
        /// <para>
        /// The signing status of the certificate authority. <c>IN_USE</c> means the certificate
        /// authority is currently signing certificates for the cluster, <c>ACTIVATING</c> means
        /// it's being promoted to the signer, and <c>NOT_USED</c> means it's trusted by the cluster
        /// (for example, a successor CA during a rotation, or a retired outgoing CA) but isn't
        /// the signer.
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

        /// <summary>
        /// Gets and sets the property Validity. 
        /// <para>
        /// The validity period of the certificate authority's certificate.
        /// </para>
        /// </summary>
        public CertificateAuthorityValidity Validity
        {
            get { return this._validity; }
            set { this._validity = value; }
        }

        // Check to see if Validity property is set
        internal bool IsSetValidity()
        {
            return this._validity != null;
        }

    }
}