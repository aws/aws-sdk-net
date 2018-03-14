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

/*
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// This is the response object from the GetLoadBalancerTlsCertificates operation.
    /// </summary>
    public partial class GetLoadBalancerTlsCertificatesResponse : AmazonWebServiceResponse
    {
        private List<LoadBalancerTlsCertificate> _tlsCertificates = new List<LoadBalancerTlsCertificate>();

        /// <summary>
        /// Gets and sets the property TlsCertificates. 
        /// <para>
        /// An array of LoadBalancerTlsCertificate objects describing your SSL/TLS certificates.
        /// </para>
        /// </summary>
        public List<LoadBalancerTlsCertificate> TlsCertificates
        {
            get { return this._tlsCertificates; }
            set { this._tlsCertificates = value; }
        }

        // Check to see if TlsCertificates property is set
        internal bool IsSetTlsCertificates()
        {
            return this._tlsCertificates != null && this._tlsCertificates.Count > 0; 
        }

    }
}