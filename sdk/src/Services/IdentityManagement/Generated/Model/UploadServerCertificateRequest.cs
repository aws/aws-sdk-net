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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UploadServerCertificate operation.
    /// Uploads a server certificate entity for the AWS account. The server certificate entity
    /// includes a public key certificate, a private key, and an optional certificate chain,
    /// which should all be PEM-encoded. 
    /// 
    ///  
    /// <para>
    /// For information about the number of server certificates you can upload, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/LimitationsOnEntities.html">Limitations
    /// on IAM Entities</a> in the <i>Using IAM</i> guide. 
    /// </para>
    ///  <note>Because the body of the public key certificate, private key, and the certificate
    /// chain can be large, you should use POST rather than GET when calling <code>UploadServerCertificate</code>.
    /// For information about setting up signatures and authorization through the API, go
    /// to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
    /// about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// Query Requests</a> in the <i>Using IAM</i> guide. </note>
    /// </summary>
    public partial class UploadServerCertificateRequest : AmazonIdentityManagementServiceRequest
    {
        private string _certificateBody;
        private string _certificateChain;
        private string _path;
        private string _privateKey;
        private string _serverCertificateName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UploadServerCertificateRequest() { }

        /// <summary>
        /// Instantiates UploadServerCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="serverCertificateName">The name for the server certificate. Do not include the path in this value. The name of the certificate cannot contain any spaces.</param>
        /// <param name="certificateBody">The contents of the public key certificate in PEM-encoded format.</param>
        /// <param name="privateKey">The contents of the private key in PEM-encoded format.</param>
        public UploadServerCertificateRequest(string serverCertificateName, string certificateBody, string privateKey)
        {
            _serverCertificateName = serverCertificateName;
            _certificateBody = certificateBody;
            _privateKey = privateKey;
        }

        /// <summary>
        /// Gets and sets the property CertificateBody. 
        /// <para>
        /// The contents of the public key certificate in PEM-encoded format.
        /// </para>
        /// </summary>
        public string CertificateBody
        {
            get { return this._certificateBody; }
            set { this._certificateBody = value; }
        }

        // Check to see if CertificateBody property is set
        internal bool IsSetCertificateBody()
        {
            return this._certificateBody != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateChain. 
        /// <para>
        /// The contents of the certificate chain. This is typically a concatenation of the PEM-encoded
        /// public key certificates of the chain. 
        /// </para>
        /// </summary>
        public string CertificateChain
        {
            get { return this._certificateChain; }
            set { this._certificateChain = value; }
        }

        // Check to see if CertificateChain property is set
        internal bool IsSetCertificateChain()
        {
            return this._certificateChain != null;
        }

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The path for the server certificate. For more information about paths, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// Identifiers</a> in the <i>Using IAM</i> guide. 
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/).
        /// </para>
        ///  <note> If you are uploading a server certificate specifically for use with Amazon
        /// CloudFront distributions, you must specify a path using the <code>--path</code> option.
        /// The path must begin with <code>/cloudfront</code> and must include a trailing slash
        /// (for example, <code>/cloudfront/test/</code>). </note>
        /// </summary>
        public string Path
        {
            get { return this._path; }
            set { this._path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this._path != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateKey. 
        /// <para>
        /// The contents of the private key in PEM-encoded format.
        /// </para>
        /// </summary>
        public string PrivateKey
        {
            get { return this._privateKey; }
            set { this._privateKey = value; }
        }

        // Check to see if PrivateKey property is set
        internal bool IsSetPrivateKey()
        {
            return this._privateKey != null;
        }

        /// <summary>
        /// Gets and sets the property ServerCertificateName. 
        /// <para>
        /// The name for the server certificate. Do not include the path in this value. The name
        /// of the certificate cannot contain any spaces.
        /// </para>
        /// </summary>
        public string ServerCertificateName
        {
            get { return this._serverCertificateName; }
            set { this._serverCertificateName = value; }
        }

        // Check to see if ServerCertificateName property is set
        internal bool IsSetServerCertificateName()
        {
            return this._serverCertificateName != null;
        }

    }
}