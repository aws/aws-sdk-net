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
    /// Describes the creation state of the canonical name (CNAME) records that are automatically
    /// added by Amazon Lightsail to the DNS of a domain to validate domain ownership for
    /// an SSL/TLS certificate.
    /// 
    ///  
    /// <para>
    /// When you create an SSL/TLS certificate for a Lightsail resource, you must add a set
    /// of CNAME records to the DNS of the domains for the certificate to validate that you
    /// own the domains. Lightsail can automatically add the CNAME records to the DNS of the
    /// domain if the DNS zone for the domain exists within your Lightsail account. If automatic
    /// record addition fails, or if you manage the DNS of your domain using a third-party
    /// service, then you must manually add the CNAME records to the DNS of your domain. For
    /// more information, see <a href="https://docs.aws.amazon.com/lightsail/latest/userguide/verify-tls-ssl-certificate-using-dns-cname-https">Verify
    /// an SSL/TLS certificate in Amazon Lightsail</a> in the <i>Amazon Lightsail Developer
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class DnsRecordCreationState
    {
        private DnsRecordCreationStateCode _code;
        private string _message;

        /// <summary>
        /// Gets and sets the property Code. 
        /// <para>
        /// The status code for the automated DNS record creation.
        /// </para>
        ///  
        /// <para>
        /// Following are the possible values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>SUCCEEDED</c> - The validation records were successfully added to the domain.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>STARTED</c> - The automatic DNS record creation has started.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c> - The validation records failed to be added to the domain.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DnsRecordCreationStateCode Code
        {
            get { return this._code; }
            set { this._code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this._code != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// The message that describes the reason for the status code.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}