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
    /// <para>Contains the result of a successful invocation of the UploadSigningCertificate action.</para>
    /// </summary>
    public class UploadSigningCertificateResult  
    {
        
        private SigningCertificate certificate;

        /// <summary>
        /// Information about the certificate.
        ///  
        /// </summary>
        public SigningCertificate Certificate
        {
            get { return this.certificate; }
            set { this.certificate = value; }
        }

        /// <summary>
        /// Sets the Certificate property
        /// </summary>
        /// <param name="certificate">The value to set for the Certificate property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadSigningCertificateResult WithCertificate(SigningCertificate certificate)
        {
            this.certificate = certificate;
            return this;
        }
            

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this.certificate != null;       
        }
    }
}
