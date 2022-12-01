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
 * Do not modify this file. This file is generated from the pipes-2015-10-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Pipes.Model
{
    /// <summary>
    /// The Secrets Manager secret that stores your stream credentials.
    /// </summary>
    public partial class MSKAccessCredentials
    {
        private string _clientCertificateTlsAuth;
        private string _saslScram512Auth;

        /// <summary>
        /// Gets and sets the property ClientCertificateTlsAuth. 
        /// <para>
        /// The ARN of the Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string ClientCertificateTlsAuth
        {
            get { return this._clientCertificateTlsAuth; }
            set { this._clientCertificateTlsAuth = value; }
        }

        // Check to see if ClientCertificateTlsAuth property is set
        internal bool IsSetClientCertificateTlsAuth()
        {
            return this._clientCertificateTlsAuth != null;
        }

        /// <summary>
        /// Gets and sets the property SaslScram512Auth. 
        /// <para>
        /// The ARN of the Secrets Manager secret.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1600)]
        public string SaslScram512Auth
        {
            get { return this._saslScram512Auth; }
            set { this._saslScram512Auth = value; }
        }

        // Check to see if SaslScram512Auth property is set
        internal bool IsSetSaslScram512Auth()
        {
            return this._saslScram512Auth != null;
        }

    }
}