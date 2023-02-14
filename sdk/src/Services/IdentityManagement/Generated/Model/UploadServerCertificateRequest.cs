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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the UploadServerCertificate operation.
    /// Uploads a server certificate entity for the Amazon Web Services account. The server
    /// certificate entity includes a public key certificate, a private key, and an optional
    /// certificate chain, which should all be PEM-encoded.
    /// 
    ///  
    /// <para>
    /// We recommend that you use <a href="https://docs.aws.amazon.com/acm/">Certificate Manager</a>
    /// to provision, manage, and deploy your server certificates. With ACM you can request
    /// a certificate, deploy it to Amazon Web Services resources, and let ACM handle certificate
    /// renewals for you. Certificates provided by ACM are free. For more information about
    /// using ACM, see the <a href="https://docs.aws.amazon.com/acm/latest/userguide/">Certificate
    /// Manager User Guide</a>.
    /// </para>
    ///  
    /// <para>
    /// For more information about working with server certificates, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_credentials_server-certs.html">Working
    /// with server certificates</a> in the <i>IAM User Guide</i>. This topic includes a list
    /// of Amazon Web Services services that can use the server certificates that you manage
    /// with IAM.
    /// </para>
    ///  
    /// <para>
    /// For information about the number of server certificates you can upload, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/reference_iam-quotas.html">IAM
    /// and STS quotas</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Because the body of the public key certificate, private key, and the certificate chain
    /// can be large, you should use POST rather than GET when calling <code>UploadServerCertificate</code>.
    /// For information about setting up signatures and authorization through the API, see
    /// <a href="https://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// Amazon Web Services API requests</a> in the <i>Amazon Web Services General Reference</i>.
    /// For general information about using the Query API with IAM, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/programming.html">Calling
    /// the API by making HTTP query requests</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UploadServerCertificateRequest : AmazonIdentityManagementServiceRequest
    {
        private string _certificateBody;
        private string _certificateChain;
        private string _path;
        private string _privateKey;
        private string _serverCertificateName;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UploadServerCertificateRequest() { }

        /// <summary>
        /// Instantiates UploadServerCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="serverCertificateName">The name for the server certificate. Do not include the path in this value. The name of the certificate cannot contain any spaces. This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        /// <param name="certificateBody">The contents of the public key certificate in PEM-encoded format. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<code>\u0020</code>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <code>\u00FF</code>) </li> <li> The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) </li> </ul></param>
        /// <param name="privateKey">The contents of the private key in PEM-encoded format. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (<code>\u0020</code>) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through <code>\u00FF</code>) </li> <li> The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>), and carriage return (<code>\u000D</code>) </li> </ul></param>
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
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<code>\u0020</code>)
        /// through the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <code>\u00FF</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>),
        /// and carriage return (<code>\u000D</code>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=16384)]
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
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<code>\u0020</code>)
        /// through the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <code>\u00FF</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>),
        /// and carriage return (<code>\u000D</code>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=1, Max=2097152)]
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
        /// The path for the server certificate. For more information about paths, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/Using_Identifiers.html">IAM
        /// identifiers</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, it defaults to a slash (/). This
        /// parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of either a forward slash (/) by itself or a string
        /// that must begin and end with forward slashes. In addition, it can contain any ASCII
        /// character from the ! (<code>\u0021</code>) through the DEL character (<code>\u007F</code>),
        /// including most punctuation characters, digits, and upper and lowercased letters.
        /// </para>
        ///  <note> 
        /// <para>
        ///  If you are uploading a server certificate specifically for use with Amazon CloudFront
        /// distributions, you must specify a path using the <code>path</code> parameter. The
        /// path must begin with <code>/cloudfront</code> and must include a trailing slash (for
        /// example, <code>/cloudfront/test/</code>).
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (<code>\u0020</code>)
        /// through the end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// <code>\u00FF</code>)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (<code>\u0009</code>), line feed (<code>\u000A</code>),
        /// and carriage return (<code>\u000D</code>)
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=16384)]
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
        ///  
        /// <para>
        /// This parameter allows (through its <a href="http://wikipedia.org/wiki/regex">regex
        /// pattern</a>) a string of characters consisting of upper and lowercase alphanumeric
        /// characters with no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of tags that you want to attach to the new IAM server certificate resource.
        /// Each tag consists of a key name and an associated value. For more information about
        /// tagging, see <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/id_tags.html">Tagging
        /// IAM resources</a> in the <i>IAM User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// If any one of the tags is invalid or if you exceed the allowed maximum number of tags,
        /// then the entire request fails and the resource is not created.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=50)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}