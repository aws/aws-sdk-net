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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>The ServerCertificate data type contains information about a server certificate.</para> <para>This data type is used as a response
    /// element in the action GetServerCertificate.</para>
    /// </summary>
    public class ServerCertificate  
    {
        
        private ServerCertificateMetadata serverCertificateMetadata;
        private string certificateBody;
        private string certificateChain;

        /// <summary>
        /// The meta information of the server certificate, such as its name, path, ID, and ARN.
        ///  
        /// </summary>
        public ServerCertificateMetadata ServerCertificateMetadata
        {
            get { return this.serverCertificateMetadata; }
            set { this.serverCertificateMetadata = value; }
        }

        /// <summary>
        /// Sets the ServerCertificateMetadata property
        /// </summary>
        /// <param name="serverCertificateMetadata">The value to set for the ServerCertificateMetadata property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificate WithServerCertificateMetadata(ServerCertificateMetadata serverCertificateMetadata)
        {
            this.serverCertificateMetadata = serverCertificateMetadata;
            return this;
        }
            

        // Check to see if ServerCertificateMetadata property is set
        internal bool IsSetServerCertificateMetadata()
        {
            return this.serverCertificateMetadata != null;       
        }

        /// <summary>
        /// The contents of the public key certificate.
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

        /// <summary>
        /// Sets the CertificateBody property
        /// </summary>
        /// <param name="certificateBody">The value to set for the CertificateBody property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificate WithCertificateBody(string certificateBody)
        {
            this.certificateBody = certificateBody;
            return this;
        }
            

        // Check to see if CertificateBody property is set
        internal bool IsSetCertificateBody()
        {
            return this.certificateBody != null;       
        }

        /// <summary>
        /// The contents of the public key certificate chain.
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

        /// <summary>
        /// Sets the CertificateChain property
        /// </summary>
        /// <param name="certificateChain">The value to set for the CertificateChain property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ServerCertificate WithCertificateChain(string certificateChain)
        {
            this.certificateChain = certificateChain;
            return this;
        }
            

        // Check to see if CertificateChain property is set
        internal bool IsSetCertificateChain()
        {
            return this.certificateChain != null;       
        }
    }
}
