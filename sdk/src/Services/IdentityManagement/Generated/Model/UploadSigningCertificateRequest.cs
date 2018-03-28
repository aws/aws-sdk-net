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
    /// Container for the parameters to the UploadSigningCertificate operation.
    /// Uploads an X.509 signing certificate and associates it with the specified IAM user.
    /// Some AWS services use X.509 signing certificates to validate requests that are signed
    /// with a corresponding private key. When you upload the certificate, its default status
    /// is <code>Active</code>.
    /// 
    ///  
    /// <para>
    /// If the <code>UserName</code> field is not specified, the IAM user name is determined
    /// implicitly based on the AWS access key ID used to sign the request. Because this operation
    /// works for access keys under the AWS account, you can use this operation to manage
    /// AWS account root user credentials even if the AWS account has no associated users.
    /// </para>
    ///  <note> 
    /// <para>
    /// Because the body of an X.509 certificate can be large, you should use POST rather
    /// than GET when calling <code>UploadSigningCertificate</code>. For information about
    /// setting up signatures and authorization through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html">Signing
    /// AWS API Requests</a> in the <i>AWS General Reference</i>. For general information
    /// about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html">Making
    /// Query Requests</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UploadSigningCertificateRequest : AmazonIdentityManagementServiceRequest
    {
        private string _certificateBody;
        private string _userName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public UploadSigningCertificateRequest() { }

        /// <summary>
        /// Instantiates UploadSigningCertificateRequest with the parameterized properties
        /// </summary>
        /// <param name="certificateBody">The contents of the signing certificate. The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this parameter is a string of characters consisting of the following: <ul> <li> Any printable ASCII character ranging from the space character (\u0020) through the end of the ASCII character range </li> <li> The printable characters in the Basic Latin and Latin-1 Supplement character set (through \u00FF) </li> <li> The special characters tab (\u0009), line feed (\u000A), and carriage return (\u000D) </li> </ul></param>
        public UploadSigningCertificateRequest(string certificateBody)
        {
            _certificateBody = certificateBody;
        }

        /// <summary>
        /// Gets and sets the property CertificateBody. 
        /// <para>
        /// The contents of the signing certificate.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> used to validate this
        /// parameter is a string of characters consisting of the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Any printable ASCII character ranging from the space character (\u0020) through the
        /// end of the ASCII character range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The printable characters in the Basic Latin and Latin-1 Supplement character set (through
        /// \u00FF)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The special characters tab (\u0009), line feed (\u000A), and carriage return (\u000D)
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property UserName. 
        /// <para>
        /// The name of the user the signing certificate is for.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}