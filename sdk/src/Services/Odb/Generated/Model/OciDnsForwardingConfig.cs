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
 * Do not modify this file. This file is generated from the odb-2024-08-20.normal.json service model.
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
namespace Amazon.Odb.Model
{
    /// <summary>
    /// DNS configuration to forward DNS resolver endpoints to your OCI Private Zone.
    /// </summary>
    public partial class OciDnsForwardingConfig
    {
        private string _domainName;
        private string _ociDnsListenerIp;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// Domain name to which DNS resolver forwards to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string DomainName
        {
            get { return this._domainName; }
            set { this._domainName = value; }
        }

        // Check to see if DomainName property is set
        internal bool IsSetDomainName()
        {
            return this._domainName != null;
        }

        /// <summary>
        /// Gets and sets the property OciDnsListenerIp. 
        /// <para>
        /// OCI DNS listener IP for custom DNS setup.
        /// </para>
        /// </summary>
        public string OciDnsListenerIp
        {
            get { return this._ociDnsListenerIp; }
            set { this._ociDnsListenerIp = value; }
        }

        // Check to see if OciDnsListenerIp property is set
        internal bool IsSetOciDnsListenerIp()
        {
            return this._ociDnsListenerIp != null;
        }

    }
}