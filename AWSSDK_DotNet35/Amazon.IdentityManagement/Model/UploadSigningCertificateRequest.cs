/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// <para>Uploads an X.509 signing certificate and associates it with the specified user. Some AWS services use X.509 signing certificates to
    /// validate requests that are signed with a corresponding private key. When you upload the certificate, its default status is <c>Active</c>
    /// .</para> <para>If the <c>UserName</c> field is not specified, the user name is determined implicitly based on the AWS access key ID used to
    /// sign the request. Because this action works for access keys under the AWS account, this API can be used to manage root credentials even if
    /// the AWS account has no associated users.</para> <para><b>NOTE:</b>Because the body of a X.509 certificate can be large, you should use POST
    /// rather than GET when calling UploadSigningCertificate. For information about setting up signatures and authorization through the API, go to
    /// Signing AWS API Requests in the AWS General Reference. For general information about using the Query API with IAM, go to Making Query
    /// Requests in Using IAM.</para>
    /// </summary>
    public partial class UploadSigningCertificateRequest : AmazonIdentityManagementServiceRequest
    {
        private string userName;
        private string certificateBody;


        /// <summary>
        /// Name of the user the signing certificate is for.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 128</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\w+=,.@-]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string UserName
        {
            get { return this.userName; }
            set { this.userName = value; }
        }

        // Check to see if UserName property is set
        internal bool IsSetUserName()
        {
            return this.userName != null;
        }

        /// <summary>
        /// The contents of the signing certificate.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 16384</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0009\u000A\u000D\u0020-\u00FF]+</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CertificateBody
        {
            get { return this.certificateBody; }
            set { this.certificateBody = value; }
        }

        // Check to see if CertificateBody property is set
        internal bool IsSetCertificateBody()
        {
            return this.certificateBody != null;
        }

    }
}
    
