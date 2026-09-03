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
    /// Container for the parameters to the DeleteCertificateAuthority operation.
    /// Deletes a certificate authority (CA) from your cluster.
    /// 
    ///  
    /// <para>
    /// Deleting a certificate authority removes its public certificate from the cluster's
    /// trust bundle. You can't delete the certificate authority that's currently signing
    /// certificates for the cluster (its <c>signingStatus</c> is <c>IN_USE</c>) — to remove
    /// the outgoing CA, first activate the successor CA with <a href="https://docs.aws.amazon.com/eks/latest/APIReference/API_ActivateCertificateAuthority.html">
    /// <c>ActivateCertificateAuthority</c> </a>. Amazon EKS also protects a successor CA
    /// from deletion in certain cases to keep a valid rotation path — for example, a successor
    /// that Amazon EKS appended can't be deleted while it's the only successor on the cluster.
    /// This is an asynchronous operation that returns an <c>update</c> object.
    /// </para>
    /// </summary>
    public partial class DeleteCertificateAuthorityRequest : AmazonEKSRequest
    {
        private string _certificateAuthorityId;
        private string _clientRequestToken;
        private string _clusterName;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityId. 
        /// <para>
        /// The ID of the certificate authority to delete. You can't delete the certificate authority
        /// that's currently signing certificates for the cluster.
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