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
    /// Contains the result of a successful invocation of the <a>UploadServerCertificate</a>            action.
    /// </summary>
    public partial class UploadServerCertificateResult
    {
        private ServerCertificateMetadata _serverCertificateMetadata;


        /// <summary>
        /// Gets and sets the property ServerCertificateMetadata. 
        /// <para>
        /// The meta information of the uploaded server certificate without its certificate body,            certificate
        /// chain, and private key.
        /// </para>
        /// </summary>
        public ServerCertificateMetadata ServerCertificateMetadata
        {
            get { return this._serverCertificateMetadata; }
            set { this._serverCertificateMetadata = value; }
        }


        /// <summary>
        /// Sets the ServerCertificateMetadata property
        /// </summary>
        /// <param name="serverCertificateMetadata">The value to set for the ServerCertificateMetadata property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public UploadServerCertificateResult WithServerCertificateMetadata(ServerCertificateMetadata serverCertificateMetadata)
        {
            this._serverCertificateMetadata = serverCertificateMetadata;
            return this;
        }

        // Check to see if ServerCertificateMetadata property is set
        internal bool IsSetServerCertificateMetadata()
        {
            return this._serverCertificateMetadata != null;
        }

    }
}