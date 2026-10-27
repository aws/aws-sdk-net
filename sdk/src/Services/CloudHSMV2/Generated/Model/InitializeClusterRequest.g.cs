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

namespace Amazon.CloudHSMV2.Model
{
    /// <summary>
    /// Container for the parameters to the InitializeCluster operation. Claims an CloudHSM
    /// cluster by submitting the cluster certificate issued by your issuing certificate authority
    /// (CA) and the CA's root certificate. Before you can claim a cluster, you must sign
    /// the cluster's certificate signing request (CSR) with your issuing CA. To get the cluster's
    /// CSR, use <a>DescribeClusters</a>. <para> <b>Cross-account use:</b> No. You cannot
    /// perform this operation on an CloudHSM cluster in a different Amazon Web Services account.
    /// </para>
    /// </summary>
    public partial class InitializeClusterRequest : AmazonCloudHSMV2Request
    {
        /// <summary>
        /// Gets and sets the property ClusterId. 
        /// <para>
        /// The identifier (ID) of the cluster that you are claiming. To find the cluster ID,
        /// use <a>DescribeClusters</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClusterId { get; set; }

        /// <summary>
        /// Checks to see if the ClusterId property is set.
        /// </summary>
        internal bool IsSetClusterId() => this.ClusterId != null;

        /// <summary>
        /// Gets and sets the property SignedCert. 
        /// <para>
        /// The cluster certificate issued (signed) by your issuing certificate authority (CA).
        /// The certificate must be in PEM format and can contain a maximum of 5000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 20000)]
        public string SignedCert { get; set; }

        /// <summary>
        /// Checks to see if the SignedCert property is set.
        /// </summary>
        internal bool IsSetSignedCert() => this.SignedCert != null;

        /// <summary>
        /// Gets and sets the property TrustAnchor. 
        /// <para>
        /// The issuing certificate of the issuing certificate authority (CA) that issued (signed)
        /// the cluster certificate. You must use a self-signed certificate. The certificate used
        /// to sign the HSM CSR must be directly available, and thus must be the root certificate.
        /// The certificate must be in PEM format and can contain a maximum of 5000 characters.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 20000)]
        public string TrustAnchor { get; set; }

        /// <summary>
        /// Checks to see if the TrustAnchor property is set.
        /// </summary>
        internal bool IsSetTrustAnchor() => this.TrustAnchor != null;
    }
}
