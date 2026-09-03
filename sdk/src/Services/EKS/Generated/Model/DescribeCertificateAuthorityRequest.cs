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
    /// Container for the parameters to the DescribeCertificateAuthority operation.
    /// Returns detailed information about a certificate authority (CA) in your cluster, including
    /// its validity period, signing and distribution status, provenance, scheduled auto-activation
    /// events, and public certificate data.
    /// </summary>
    public partial class DescribeCertificateAuthorityRequest : AmazonEKSRequest
    {
        private string _certificateAuthorityId;
        private string _clusterName;

        /// <summary>
        /// Gets and sets the property CertificateAuthorityId. 
        /// <para>
        /// The ID of the certificate authority to describe.
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