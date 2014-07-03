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

namespace Amazon.Redshift.Model
{
    /// <summary>
    /// Returns information about an HSM client certificate. The certificate is stored in
    /// a secure            Hardware Storage Module (HSM), and used by the Amazon Redshift
    /// cluster to            encrypt data files.
    /// </summary>
    public partial class CreateHsmClientCertificateResult : AmazonWebServiceResponse
    {
        private HsmClientCertificate _response;

        public HsmClientCertificate HsmClientCertificate
        {
            get { return this._response; }
            set { this._response = value; }
        }
    }
}