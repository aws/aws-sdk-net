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
    /// Container for the parameters to the UploadServerCertificate operation.
    /// <para>Uploads a server certificate entity for the AWS account. The server certificate entity includes a public key certificate, a private
    /// key, and an optional certificate chain, which should all be PEM-encoded.</para> <para>For information about the number of server
    /// certificates you can upload, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?LimitationsOnEntities.html"
    /// >Limitations on IAM Entities</a> in <i>Using AWS Identity and Access Management</i> .</para> <para><b>NOTE:</b>Because the body of the
    /// public key certificate, private key, and the certificate chain can be large, you should use POST rather than GET when calling
    /// UploadServerCertificate. For information about setting up signatures and authorization through the API, go to Signing AWS API Requests in
    /// the AWS General Reference. For general information about using the Query API with IAM, go to Making Query Requests in Using IAM.</para>
    /// </summary>
    public partial class UploadServerCertificateRequest : AmazonIdentityManagementServiceRequest
    {
        private string path;
        private string serverCertificateName;
        private string certificateBody;
        private string privateKey;
        private string certificateChain;


        /// <summary>
        /// The path for the server certificate. For more information about paths, see <a
        /// href="http://docs.aws.amazon.com/IAM/latest/UserGuide/index.html?Using_Identifiers.html" target="_blank">Identifiers for IAM Entities</a> in
        /// <i>Using AWS Identity and Access Management</i>. This parameter is optional. If it is not included, it defaults to a slash (/).
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 512</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>(\u002F)|(\u002F[\u0021-\u007F]+\u002F)</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string Path
        {
            get { return this.path; }
            set { this.path = value; }
        }

        // Check to see if Path property is set
        internal bool IsSetPath()
        {
            return this.path != null;
        }

        /// <summary>
        /// The name for the server certificate. Do not include the path in this value.
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
        public string ServerCertificateName
        {
            get { return this.serverCertificateName; }
            set { this.serverCertificateName = value; }
        }

        // Check to see if ServerCertificateName property is set
        internal bool IsSetServerCertificateName()
        {
            return this.serverCertificateName != null;
        }

        /// <summary>
        /// The contents of the public key certificate in PEM-encoded format.
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

        /// <summary>
        /// The contents of the private key in PEM-encoded format.
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
        ///         <description>[\u0009\u000A\u000D\u0020-\u00FF]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string PrivateKey
        {
            get { return this.privateKey; }
            set { this.privateKey = value; }
        }

        // Check to see if PrivateKey property is set
        internal bool IsSetPrivateKey()
        {
            return this.privateKey != null;
        }

        /// <summary>
        /// The contents of the certificate chain. This is typically a concatenation of the PEM-encoded public key certificates of the chain.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Length</term>
        ///         <description>1 - 2097152</description>
        ///     </item>
        ///     <item>
        ///         <term>Pattern</term>
        ///         <description>[\u0009\u000A\u000D\u0020-\u00FF]*</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public string CertificateChain
        {
            get { return this.certificateChain; }
            set { this.certificateChain = value; }
        }

        // Check to see if CertificateChain property is set
        internal bool IsSetCertificateChain()
        {
            return this.certificateChain != null;
        }

    }
}
    
