/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the InitializeCluster operation.
    /// Claims an AWS CloudHSM cluster by submitting the cluster certificate issued by your
    /// issuing certificate authority (CA) and the CA's root certificate. Before you can claim
    /// a cluster, you must sign the cluster's certificate signing request (CSR) with your
    /// issuing CA. To get the cluster's CSR, use <a>DescribeClusters</a>.
    /// </summary>
    public partial class InitializeClusterRequest : AmazonCloudHSMV2Request
    {
        private string _clusterId;
        private string _signedCert;
        private string _trustAnchor;

        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier (ID) of the cluster that you are claiming. To find the cluster ID,
        /// use <a>DescribeClusters</a>.
        /// </para>
        /// </summary>
        public string ClusterId
        {
            get { return this._clusterId; }
            set { this._clusterId = value; }
        }

        // Check to see if ClusterId property is set
        internal bool IsSetClusterId()
        {
            return this._clusterId != null;
        }

        /// <summary>
        /// Gets and sets the property SignedCert. 
        /// <para>
        /// The cluster certificate issued (signed) by your issuing certificate authority (CA).
        /// The certificate must be in PEM format and can contain a maximum of 5000 characters.
        /// </para>
        /// </summary>
        public string SignedCert
        {
            get { return this._signedCert; }
            set { this._signedCert = value; }
        }

        // Check to see if SignedCert property is set
        internal bool IsSetSignedCert()
        {
            return this._signedCert != null;
        }

        /// <summary>
        /// Gets and sets the property TrustAnchor. 
        /// <para>
        /// The issuing certificate of the issuing certificate authority (CA) that issued (signed)
        /// the cluster certificate. This can be a root (self-signed) certificate or a certificate
        /// chain that begins with the certificate that issued the cluster certificate and ends
        /// with a root certificate. The certificate or certificate chain must be in PEM format
        /// and can contain a maximum of 5000 characters.
        /// </para>
        /// </summary>
        public string TrustAnchor
        {
            get { return this._trustAnchor; }
            set { this._trustAnchor = value; }
        }

        // Check to see if TrustAnchor property is set
        internal bool IsSetTrustAnchor()
        {
            return this._trustAnchor != null;
        }

    }
}