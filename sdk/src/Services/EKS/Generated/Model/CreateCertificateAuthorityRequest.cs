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
    /// Container for the parameters to the CreateCertificateAuthority operation.
    /// Appends a successor certificate authority (CA) to your cluster, beginning the CA rotation
    /// process.
    /// 
    ///  
    /// <para>
    /// A cluster certificate authority is the root of trust for your cluster's control plane.
    /// It signs the certificates that secure communication between the Kubernetes API server
    /// and its clients, and its public certificate is distributed to your cluster's trust
    /// bundle so that worker nodes and clients can verify the API server's identity. Each
    /// cluster can have at most two certificate authorities at a time: the outgoing CA that's
    /// currently signing (its <c>signingStatus</c> is <c>IN_USE</c>) and one successor CA
    /// (<c>signingStatus</c> of <c>NOT_USED</c>) that you can later activate to complete
    /// the rotation.
    /// </para>
    ///  
    /// <para>
    /// Appending a successor CA adds its public certificate to the cluster's trust bundle
    /// so that the cluster trusts both CAs simultaneously (the dual trust period), but it
    /// doesn't begin signing certificates. Amazon EKS then distributes the successor CA to
    /// the Amazon Web Services managed components in your cluster; you can track this through
    /// the CA's <c>distributionStatus</c>. The successor CA can't be activated until its
    /// <c>distributionStatus</c> is <c>COMPLETE</c>. To activate it as the cluster's signer,
    /// use <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_ActivateCertificateAuthority.html">
    /// <c>ActivateCertificateAuthority</c> </a>. This is an asynchronous operation that returns
    /// an <c>update</c> object. If you don't append a successor CA yourself, Amazon EKS appends
    /// one automatically before the outgoing CA approaches expiration.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/eks/latest/userguide/certificate-authority-rotation.html">Rotate
    /// the Amazon EKS cluster certificate authority</a> in the <i>Amazon EKS User Guide</i>.
    /// </para>
    /// </summary>
    public partial class CreateCertificateAuthorityRequest : AmazonEKSRequest
    {
        private string _clientRequestToken;
        private string _clusterName;

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