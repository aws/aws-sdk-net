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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
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
namespace Amazon.IoT.Model
{
    /// <summary>
    /// This is the response object from the CreateCertificateProvider operation.
    /// </summary>
    public partial class CreateCertificateProviderResponse : AmazonWebServiceResponse
    {
        private string _certificateProviderArn;
        private string _certificateProviderName;

        /// <summary>
        /// Gets and sets the property CertificateProviderArn. 
        /// <para>
        /// The ARN of the certificate provider.
        /// </para>
        /// </summary>
        [AWSProperty(Max=2048)]
        public string CertificateProviderArn
        {
            get { return this._certificateProviderArn; }
            set { this._certificateProviderArn = value; }
        }

        // Check to see if CertificateProviderArn property is set
        internal bool IsSetCertificateProviderArn()
        {
            return this._certificateProviderArn != null;
        }

        /// <summary>
        /// Gets and sets the property CertificateProviderName. 
        /// <para>
        /// The name of the certificate provider.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string CertificateProviderName
        {
            get { return this._certificateProviderName; }
            set { this._certificateProviderName = value; }
        }

        // Check to see if CertificateProviderName property is set
        internal bool IsSetCertificateProviderName()
        {
            return this._certificateProviderName != null;
        }

    }
}