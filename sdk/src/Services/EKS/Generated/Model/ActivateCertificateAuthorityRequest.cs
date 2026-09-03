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
    /// Container for the parameters to the ActivateCertificateAuthority operation.
    /// Activates a successor certificate authority (CA) as the signing certificate authority
    /// for your cluster, completing a CA rotation.
    /// 
    ///  
    /// <para>
    /// When you activate a successor CA, Amazon EKS promotes it to be the cluster's signer
    /// (its <c>signingStatus</c> becomes <c>IN_USE</c>) and the outgoing CA is retired (<c>NOT_USED</c>).
    /// The outgoing CA remains in the cluster's trust bundle but no longer signs certificates.
    /// The successor CA you activate must already be present on the cluster and fully distributed
    /// (its <c>distributionStatus</c> must be <c>COMPLETE</c>). This is an asynchronous operation
    /// that returns an <c>update</c> object you can track with <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_DescribeUpdate.html">
    /// <c>DescribeUpdate</c> </a>.
    /// </para>
    ///  
    /// <para>
    /// Before you activate the successor CA, make sure the worker nodes you manage and your
    /// external clients have been updated to trust it, so they maintain connectivity to the
    /// API server after activation. For a limited period after activation, CA rollback is
    /// available to revert to the outgoing CA if needed. If you don't activate the successor
    /// CA yourself, Amazon EKS activates it automatically as the expiration deadline approaches.
    /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/certificate-authority-rotation.html">Rotate
    /// the Amazon EKS cluster certificate authority</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class ActivateCertificateAuthorityRequest : AmazonEKSRequest
    {
        private string _certificateAuthorityId;
        private string _clientRequestToken;
        private string _clusterName;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityId. 
        /// <para>
        /// The ID of the certificate authority to activate as the cluster's signing certificate
        /// authority. This certificate authority must already exist on the cluster and have a
        /// <c>distributionStatus</c> of <c>COMPLETE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CertificateAuthorityId
        {
            get { return this._certificateAuthorityId; }
            set { this._certificateAuthorityId = value; }
        }

        // Check to see if CertificateAuthorityId property is set
        internal bool IsSetCertificateAuthorityId()
        {
            return this._certificateAuthorityId != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request.
        /// </para>
        /// </summary>
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterName. 
        /// <para>
        /// The name of your cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ClusterName
        {
            get { return this._clusterName; }
            set { this._clusterName = value; }
        }

        // Check to see if ClusterName property is set
        internal bool IsSetClusterName()
        {
            return this._clusterName != null;
        }

    }
}