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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteHsmClientCertificate operation.
    /// <para>Deletes the specified HSM client certificate.</para>
    /// </summary>
    public partial class DeleteHsmClientCertificateRequest : AmazonRedshiftRequest
    {
        private string hsmClientCertificateIdentifier;


        /// <summary>
        /// The identifier of the HSM client certificate to be deleted.
        ///  
        /// </summary>
        public string HsmClientCertificateIdentifier
        {
            get { return this.hsmClientCertificateIdentifier; }
            set { this.hsmClientCertificateIdentifier = value; }
        }

        // Check to see if HsmClientCertificateIdentifier property is set
        internal bool IsSetHsmClientCertificateIdentifier()
        {
            return this.hsmClientCertificateIdentifier != null;
        }

    }
}
    
