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

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// <para>Contains the result of a successful invocation of the UploadServerCertificate action.</para>
    /// </summary>
    public partial class UploadServerCertificateResult : AmazonWebServiceResponse
    {
        
        private ServerCertificateMetadata serverCertificateMetadata;


        /// <summary>
        /// The meta information of the uploaded server certificate without its certificate body, certificate chain, and private key.
        ///  
        /// </summary>
        public ServerCertificateMetadata ServerCertificateMetadata
        {
            get { return this.serverCertificateMetadata; }
            set { this.serverCertificateMetadata = value; }
        }

        // Check to see if ServerCertificateMetadata property is set
        internal bool IsSetServerCertificateMetadata()
        {
            return this.serverCertificateMetadata != null;
        }
    }
}
