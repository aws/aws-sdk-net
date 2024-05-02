/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteCertificate operation.
    /// Deletes an SSL/TLS certificate for your Amazon Lightsail content delivery network
    /// (CDN) distribution.
    /// 
    ///  
    /// <para>
    /// Certificates that are currently attached to a distribution cannot be deleted. Use
    /// the <c>DetachCertificateFromDistribution</c> action to detach a certificate from a
    /// distribution.
    /// </para>
    /// </summary>
    public partial class DeleteCertificateRequest : AmazonLightsailRequest
    {
        private string _certificateName;

        /// <summary>
        /// Gets and sets the property CertificateName. 
        /// <para>
        /// The name of the certificate to delete.
        /// </para>
        ///  
        /// <para>
        /// Use the <c>GetCertificates</c> action to get a list of certificate names that you
        /// can specify.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CertificateName
        {
            get { return this._certificateName; }
            set { this._certificateName = value; }
        }

        // Check to see if CertificateName property is set
        internal bool IsSetCertificateName()
        {
            return this._certificateName != null;
        }

    }
}