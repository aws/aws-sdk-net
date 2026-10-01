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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// An object representing a certificate authority (CA) for an Amazon EKS cluster.
    /// </summary>
    public partial class CertificateAuthority
    {
        /// <summary>
        /// Gets and sets the property ActivatedAt. 
        /// <para>
        /// The Unix epoch timestamp in seconds for when the certificate authority was last activated
        /// as the cluster's signer. This value is absent if the certificate authority has never
        /// been activated.
        /// </para>
        /// </summary>
        public DateTime? ActivatedAt { get; set; }

        /// <summary>
        /// Checks to see if the ActivatedAt property is set.
        /// </summary>
        internal bool IsSetActivatedAt() => this.ActivatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property ActivatedBy. 
        /// <para>
        /// The entity that most recently activated the certificate authority. A value of <c>EKS</c>
        /// indicates that Amazon EKS activated it automatically; <c>CUSTOMER</c> indicates that
        /// you activated it.
        /// </para>
        /// </summary>
        public CertificateAuthorityActivatedBy ActivatedBy { get; set; }

        /// <summary>
        /// Checks to see if the ActivatedBy property is set.
        /// </summary>
        internal bool IsSetActivatedBy() => this.ActivatedBy != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The Unix epoch timestamp in seconds for when the certificate authority was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The entity that created the certificate authority. Certificate authorities that you
        /// create are <c>CUSTOMER</c>; those that Amazon EKS provisions on your behalf, such
        /// as a cluster's initial certificate authority, are <c>EKS</c>.
        /// </para>
        /// </summary>
        public CertificateAuthorityCreatedBy CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property Data. 
        /// <para>
        /// The Base64-encoded public certificate of the certificate authority.
        /// </para>
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        /// Checks to see if the Data property is set.
        /// </summary>
        internal bool IsSetData() => this.Data != null;

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
        public CertificateAuthorityDistributionStatus DistributionStatus { get; set; }

        /// <summary>
        /// Checks to see if the DistributionStatus property is set.
        /// </summary>
        internal bool IsSetDistributionStatus() => this.DistributionStatus != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The unique identifier of the certificate authority.
        /// </para>
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property RollbackAvailable. 
        /// <para>
        /// Indicates whether CA rollback is still available for this certificate authority. After
        /// you activate a successor CA, rollback lets you revert to the outgoing CA for a limited
        /// period while you finish updating any worker nodes or clients that were missed.
        /// </para>
        /// </summary>
        public bool? RollbackAvailable { get; set; }

        /// <summary>
        /// Checks to see if the RollbackAvailable property is set.
        /// </summary>
        internal bool IsSetRollbackAvailable() => this.RollbackAvailable.HasValue;

        /// <summary>
        /// Gets and sets the property ScheduledEvents. 
        /// <para>
        /// The scheduled auto-activation events for the certificate authority, computed from
        /// its validity period.
        /// </para>
        /// </summary>
        public CertificateAuthorityScheduledEvents ScheduledEvents { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledEvents property is set.
        /// </summary>
        internal bool IsSetScheduledEvents() => this.ScheduledEvents != null;

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
        public CertificateAuthoritySigningStatus SigningStatus { get; set; }

        /// <summary>
        /// Checks to see if the SigningStatus property is set.
        /// </summary>
        internal bool IsSetSigningStatus() => this.SigningStatus != null;

        /// <summary>
        /// Gets and sets the property Validity. 
        /// <para>
        /// The validity period of the certificate authority's certificate.
        /// </para>
        /// </summary>
        public CertificateAuthorityValidity Validity { get; set; }

        /// <summary>
        /// Checks to see if the Validity property is set.
        /// </summary>
        internal bool IsSetValidity() => this.Validity != null;
    }
}
