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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCertificateProvider operation.
    /// Deletes a certificate provider.
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">DeleteCertificateProvider</a>
    /// action. 
    /// </para>
    ///  
    /// <para>
    /// If you delete the certificate provider resource, the behavior of <c>CreateCertificateFromCsr</c>
    /// will resume, and IoT will create certificates signed by IoT from a certificate signing
    /// request (CSR).
    /// </para>
    /// </summary>
    public partial class DeleteCertificateProviderRequest : AmazonIoTRequest
    {
        private string _certificateProviderName;

        /// <summary>
        /// Gets and sets the property CertificateProviderName. 
        /// <para>
        /// The name of the certificate provider.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public string CertificateProviderName
        {
            get { return this._certificateProviderName; }
            set { this._certificateProviderName = value; }
        }

        // Check to see if CertificateProviderName property is set
        internal bool IsSetCertificateProviderName()
        {
            return this._certificateProviderName != null;
        }

    }
}