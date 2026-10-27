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
    /// Contains one or more certificates or a certificate signing request (CSR).
    /// </summary>
    public partial class Certificates
    {
        /// <summary>
        /// Gets and sets the property AwsHardwareCertificate. 
        /// <para>
        /// The HSM hardware certificate issued (signed) by CloudHSM.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20000)]
        public string AwsHardwareCertificate { get; set; }

        /// <summary>
        /// Checks to see if the AwsHardwareCertificate property is set.
        /// </summary>
        internal bool IsSetAwsHardwareCertificate() => this.AwsHardwareCertificate != null;

        /// <summary>
        /// Gets and sets the property ClusterCertificate. 
        /// <para>
        /// The cluster certificate issued (signed) by the issuing certificate authority (CA)
        /// of the cluster's owner.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20000)]
        public string ClusterCertificate { get; set; }

        /// <summary>
        /// Checks to see if the ClusterCertificate property is set.
        /// </summary>
        internal bool IsSetClusterCertificate() => this.ClusterCertificate != null;

        /// <summary>
        /// Gets and sets the property ClusterCsr. 
        /// <para>
        /// The cluster's certificate signing request (CSR). The CSR exists only when the cluster's
        /// state is <c>UNINITIALIZED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20000)]
        public string ClusterCsr { get; set; }

        /// <summary>
        /// Checks to see if the ClusterCsr property is set.
        /// </summary>
        internal bool IsSetClusterCsr() => this.ClusterCsr != null;

        /// <summary>
        /// Gets and sets the property HsmCertificate. 
        /// <para>
        /// The HSM certificate issued (signed) by the HSM hardware.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20000)]
        public string HsmCertificate { get; set; }

        /// <summary>
        /// Checks to see if the HsmCertificate property is set.
        /// </summary>
        internal bool IsSetHsmCertificate() => this.HsmCertificate != null;

        /// <summary>
        /// Gets and sets the property ManufacturerHardwareCertificate. 
        /// <para>
        /// The HSM hardware certificate issued (signed) by the hardware manufacturer.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 20000)]
        public string ManufacturerHardwareCertificate { get; set; }

        /// <summary>
        /// Checks to see if the ManufacturerHardwareCertificate property is set.
        /// </summary>
        internal bool IsSetManufacturerHardwareCertificate() => this.ManufacturerHardwareCertificate != null;
    }
}
