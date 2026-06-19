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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePrivateConnectionCertificate operation.
    /// Updates the certificate associated with a private connection. Certificates can be
    /// added or replaced but not removed.
    /// </summary>
    public partial class UpdatePrivateConnectionCertificateRequest : AmazonSecurityAgentRequest
    {
        private string _certificate;
        private string _privateConnectionName;

        /// <summary>
        /// Gets and sets the property Certificate. 
        /// <para>
        /// The PEM-encoded certificate chain for the private connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string Certificate
        {
            get { return this._certificate; }
            set { this._certificate = value; }
        }

        // Check to see if Certificate property is set
        internal bool IsSetCertificate()
        {
            return this._certificate != null;
        }

        /// <summary>
        /// Gets and sets the property PrivateConnectionName. 
        /// <para>
        /// The name of the private connection to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string PrivateConnectionName
        {
            get { return this._privateConnectionName; }
            set { this._privateConnectionName = value; }
        }

        // Check to see if PrivateConnectionName property is set
        internal bool IsSetPrivateConnectionName()
        {
            return this._privateConnectionName != null;
        }

    }
}