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
 * Do not modify this file. This file is generated from the route53domains-2014-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53Domains.Model
{
    /// <summary>
    /// Container for the parameters to the CheckDomainTransferability operation.
    /// Checks whether a domain name can be transferred to Amazon Route 53.
    /// </summary>
    public partial class CheckDomainTransferabilityRequest : AmazonRoute53DomainsRequest
    {
        private string _authCode;
        private string _domainName;

        /// <summary>
        /// Gets and sets the property AuthCode. 
        /// <para>
        /// If the registrar for the top-level domain (TLD) requires an authorization code to
        /// transfer the domain, the code that you got from the current registrar for the domain.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Max=1024)]
        public string AuthCode
        {
            get { return this._authCode; }
            set { this._authCode = value; }
        }

        // Check to see if AuthCode property is set
        internal bool IsSetAuthCode()
        {
            return this._authCode != null;
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The name of the domain that you want to transfer to Route 53. The top-level domain
        /// (TLD), such as .com, must be a TLD that Route 53 supports. For a list of supported
        /// TLDs, see <a href="https://docs.aws.amazon.com/Route53/latest/DeveloperGuide/registrar-tld-list.html">Domains
        /// that You Can Register with Amazon Route 53</a> in the <i>Amazon Route 53 Developer
        /// Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// The domain name can contain only the following characters:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Letters a through z. Domain names are not case sensitive.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Numbers 0 through 9.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Hyphen (-). You can't specify a hyphen at the beginning or end of a label. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Period (.) to separate the labels in the name, such as the <code>.</code> in <code>example.com</code>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
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

    }
}