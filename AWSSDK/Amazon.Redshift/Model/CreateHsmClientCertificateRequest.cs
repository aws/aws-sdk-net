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
    /// Container for the parameters to the CreateHsmClientCertificate operation.
    /// <para>Creates an HSM client certificate that an Amazon Redshift cluster will use to connect to the client's HSM in order to store and
    /// retrieve the keys used to encrypt the cluster databases.</para> <para>The command returns a public key, which you must store in the HSM.
    /// After creating the HSM certificate, you must create an Amazon Redshift HSM configuration that provides a cluster the information needed to
    /// store and retrieve database encryption keys in the HSM. For more information, go to aLinkToHSMTopic in the Amazon Redshift Management
    /// Guide.</para>
    /// </summary>
    /// <seealso cref="Amazon.Redshift.AmazonRedshift.CreateHsmClientCertificate"/>
    public class CreateHsmClientCertificateRequest : AmazonWebServiceRequest
    {
        private string hsmClientCertificateIdentifier;

        /// <summary>
        /// The identifier to be assigned to the new HSM client certificate that the cluster will use to connect to the HSM to retrieve the database
        /// encryption keys.
        ///  
        /// </summary>
        public string HsmClientCertificateIdentifier
        {
            get { return this.hsmClientCertificateIdentifier; }
            set { this.hsmClientCertificateIdentifier = value; }
        }

        /// <summary>
        /// Sets the HsmClientCertificateIdentifier property
        /// </summary>
        /// <param name="hsmClientCertificateIdentifier">The value to set for the HsmClientCertificateIdentifier property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateHsmClientCertificateRequest WithHsmClientCertificateIdentifier(string hsmClientCertificateIdentifier)
        {
            this.hsmClientCertificateIdentifier = hsmClientCertificateIdentifier;
            return this;
        }
            

        // Check to see if HsmClientCertificateIdentifier property is set
        internal bool IsSetHsmClientCertificateIdentifier()
        {
            return this.hsmClientCertificateIdentifier != null;
        }
    }
}
    
