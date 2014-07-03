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
    /// Uploads an X.509 signing certificate and associates it with the specified user. Some
    /// AWS            services use X.509 signing certificates to validate requests that are signed
    /// with a            corresponding private key. When you upload the certificate, its default status
    /// is                <code>Active</code>.
    /// 
    ///         
    /// <para>
    /// If the <code>UserName</code> field is not specified, the user name is determined implicitly            based
    /// on the AWS access key ID used to sign the request. Because this action works for access            keys
    /// under the AWS account, this API can be used to manage root credentials even if the
    /// AWS            account has no associated users.
    /// </para>
    ///         <note>Because the body of a X.509 certificate can be large, you should use POST
    /// rather than GET            when calling <code>UploadSigningCertificate</code>. For information
    /// about setting up            signatures and authorization through the API, go to <a href="http://docs.aws.amazon.com/general/latest/gr/signing_aws_api_requests.html"
    /// target="_blank">Signing AWS API Requests</a> in the <i>AWS General Reference</i>.
    /// For general information            about using the Query API with IAM, go to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/IAM_UsingQueryAPI.html"
    /// target="_blank">Making                Query Requests</a> in <i>Using IAM</i>.</note>
    /// </summary>
    public partial class UploadSigningCertificateRequest : AmazonWebServiceRequest
    {
        private string _certificateBody;
        private string _userName;


        /// <summary>
        /// Gets and sets the property CertificateBody. 
        /// <para>
        /// The contents of the signing certificate.
        /// </para>
        /// </summary>
        public string CertificateBody
        {
            get { return this._certificateBody; }
            set { this._certificateBody = value; }
        }


        /// <summary>
        /// Sets the CertificateBody property
        /// </summary>
        /// <param name="certificateBody">The value to set for the CertificateBody property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadSigningCertificateRequest WithCertificateBody(string certificateBody)
        {
            this._certificateBody = certificateBody;
            return this;
        }

        // Check to see if CertificateBody property is set
        internal bool IsSetCertificateBody()
        {
            return this._certificateBody != null;
        }


        /// <summary>
        /// Gets and sets the property UserName. 
        /// <para>
        /// Name of the user the signing certificate is for.
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this._userName; }
            set { this._userName = value; }
        }


        /// <summary>
        /// Sets the UserName property
        /// </summary>
        /// <param name="userName">The value to set for the UserName property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadSigningCertificateRequest WithUserName(string userName)
        {
            this._userName = userName;
            return this;
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this._userName != null;
        }

    }
}