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

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the CreateCertificateFromCsr operation.
    /// Creates an X.509 certificate using the specified certificate signing request. 
    /// 
    ///  
    /// <para>
    /// Requires permission to access the <a href="https://docs.aws.amazon.com/service-authorization/latest/reference/list_awsiot.html#awsiot-actions-as-permissions">CreateCertificateFromCsr</a>
    /// action. 
    /// </para>
    ///  <note> 
    /// <para>
    /// The CSR must include a public key that is either an RSA key with a length of at least
    /// 2048 bits or an ECC key from NIST P-25 or NIST P-384 curves. For supported certificates,
    /// consult <a href="https://docs.aws.amazon.com/iot/latest/developerguide/x509-client-certs.html#x509-cert-algorithms">
    /// Certificate signing algorithms supported by IoT</a>. 
    /// </para>
    ///  </note> <note> 
    /// <para>
    /// Reusing the same certificate signing request (CSR) results in a distinct certificate.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can create multiple certificates in a batch by creating a directory, copying multiple
    /// <code>.csr</code> files into that directory, and then specifying that directory on
    /// the command line. The following commands show how to create a batch of certificates
    /// given a batch of CSRs. In the following commands, we assume that a set of CSRs are
    /// located inside of the directory my-csr-directory:
    /// </para>
    ///  
    /// <para>
    /// On Linux and OS X, the command is: 
    /// </para>
    ///  
    /// <para>
    ///  <code>$ ls my-csr-directory/ | xargs -I {} aws iot create-certificate-from-csr --certificate-signing-request
    /// file://my-csr-directory/{}</code> 
    /// </para>
    ///  
    /// <para>
    /// This command lists all of the CSRs in my-csr-directory and pipes each CSR file name
    /// to the <code>aws iot create-certificate-from-csr</code> Amazon Web Services CLI command
    /// to create a certificate for the corresponding CSR. 
    /// </para>
    ///  
    /// <para>
    /// You can also run the <code>aws iot create-certificate-from-csr</code> part of the
    /// command in parallel to speed up the certificate creation process:
    /// </para>
    ///  
    /// <para>
    ///  <code>$ ls my-csr-directory/ | xargs -P 10 -I {} aws iot create-certificate-from-csr
    /// --certificate-signing-request file://my-csr-directory/{} </code> 
    /// </para>
    ///  
    /// <para>
    /// On Windows PowerShell, the command to create certificates for all CSRs in my-csr-directory
    /// is:
    /// </para>
    ///  
    /// <para>
    ///  <code>&gt; ls -Name my-csr-directory | %{aws iot create-certificate-from-csr --certificate-signing-request
    /// file://my-csr-directory/$_} </code> 
    /// </para>
    ///  
    /// <para>
    /// On a Windows command prompt, the command to create certificates for all CSRs in my-csr-directory
    /// is:
    /// </para>
    ///  
    /// <para>
    ///  <code>&gt; forfiles /p my-csr-directory /c "cmd /c aws iot create-certificate-from-csr
    /// --certificate-signing-request file://@path" </code> 
    /// </para>
    /// </summary>
    public partial class CreateCertificateFromCsrRequest : AmazonIoTRequest
    {
        private string _certificateSigningRequest;
        private bool? _setAsActive;

        /// <summary>
        /// Gets and sets the property CertificateSigningRequest. 
        /// <para>
        /// The certificate signing request (CSR).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=4096)]
        public string CertificateSigningRequest
        {
            get { return this._certificateSigningRequest; }
            set { this._certificateSigningRequest = value; }
        }

        // Check to see if CertificateSigningRequest property is set
        internal bool IsSetCertificateSigningRequest()
        {
            return this._certificateSigningRequest != null;
        }

        /// <summary>
        /// Gets and sets the property SetAsActive. 
        /// <para>
        /// Specifies whether the certificate is active.
        /// </para>
        /// </summary>
        public bool SetAsActive
        {
            get { return this._setAsActive.GetValueOrDefault(); }
            set { this._setAsActive = value; }
        }

        // Check to see if SetAsActive property is set
        internal bool IsSetSetAsActive()
        {
            return this._setAsActive.HasValue; 
        }

    }
}