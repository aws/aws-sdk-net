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
 * Do not modify this file. This file is generated from the cloudhsmv2-2017-04-28.normal.json service model.
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
        private string _awsHardwareCertificate;
        private string _clusterCertificate;
        private string _clusterCsr;
        private string _hsmCertificate;
        private string _manufacturerHardwareCertificate;

        /// <summary>
        /// Gets and sets the property AwsHardwareCertificate. 
        /// <para>
        /// The HSM hardware certificate issued (signed) by CloudHSM.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20000)]
        public string AwsHardwareCertificate
        {
            get { return this._awsHardwareCertificate; }
            set { this._awsHardwareCertificate = value; }
        }

        // Check to see if AwsHardwareCertificate property is set
        internal bool IsSetAwsHardwareCertificate()
        {
            return this._awsHardwareCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterCertificate. 
        /// <para>
        /// The cluster certificate issued (signed) by the issuing certificate authority (CA)
        /// of the cluster's owner.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20000)]
        public string ClusterCertificate
        {
            get { return this._clusterCertificate; }
            set { this._clusterCertificate = value; }
        }

        // Check to see if ClusterCertificate property is set
        internal bool IsSetClusterCertificate()
        {
            return this._clusterCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property ClusterCsr. 
        /// <para>
        /// The cluster's certificate signing request (CSR). The CSR exists only when the cluster's
        /// state is <c>UNINITIALIZED</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20000)]
        public string ClusterCsr
        {
            get { return this._clusterCsr; }
            set { this._clusterCsr = value; }
        }

        // Check to see if ClusterCsr property is set
        internal bool IsSetClusterCsr()
        {
            return this._clusterCsr != null;
        }

        /// <summary>
        /// Gets and sets the property HsmCertificate. 
        /// <para>
        /// The HSM certificate issued (signed) by the HSM hardware.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20000)]
        public string HsmCertificate
        {
            get { return this._hsmCertificate; }
            set { this._hsmCertificate = value; }
        }

        // Check to see if HsmCertificate property is set
        internal bool IsSetHsmCertificate()
        {
            return this._hsmCertificate != null;
        }

        /// <summary>
        /// Gets and sets the property ManufacturerHardwareCertificate. 
        /// <para>
        /// The HSM hardware certificate issued (signed) by the hardware manufacturer.
        /// </para>
        /// </summary>
        [AWSProperty(Max=20000)]
        public string ManufacturerHardwareCertificate
        {
            get { return this._manufacturerHardwareCertificate; }
            set { this._manufacturerHardwareCertificate = value; }
        }

        // Check to see if ManufacturerHardwareCertificate property is set
        internal bool IsSetManufacturerHardwareCertificate()
        {
            return this._manufacturerHardwareCertificate != null;
        }

    }
}