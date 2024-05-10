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
 * Do not modify this file. This file is generated from the rolesanywhere-2018-05-10.normal.json service model.
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
namespace Amazon.IAMRolesAnywhere.Model
{
    /// <summary>
    /// The data field of the trust anchor depending on its type.
    /// </summary>
    public partial class SourceData
    {
        private string _acmPcaArn;
        private string _x509CertificateData;

        /// <summary>
        /// Gets and sets the property AcmPcaArn. 
        /// <para>
        ///  The root certificate of the Private Certificate Authority specified by this ARN is
        /// used in trust validation for temporary credential requests. Included for trust anchors
        /// of type <c>AWS_ACM_PCA</c>. 
        /// </para>
        /// </summary>
        public string AcmPcaArn
        {
            get { return this._acmPcaArn; }
            set { this._acmPcaArn = value; }
        }

        // Check to see if AcmPcaArn property is set
        internal bool IsSetAcmPcaArn()
        {
            return this._acmPcaArn != null;
        }

        /// <summary>
        /// Gets and sets the property X509CertificateData. 
        /// <para>
        /// The PEM-encoded data for the certificate anchor. Included for trust anchors of type
        /// <c>CERTIFICATE_BUNDLE</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=8000)]
        public string X509CertificateData
        {
            get { return this._x509CertificateData; }
            set { this._x509CertificateData = value; }
        }

        // Check to see if X509CertificateData property is set
        internal bool IsSetX509CertificateData()
        {
            return this._x509CertificateData != null;
        }

    }
}