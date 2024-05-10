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
 * Do not modify this file. This file is generated from the acm-2015-12-08.normal.json service model.
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
namespace Amazon.CertificateManager.Model
{
    /// <summary>
    /// Contains information about the domain names that you want ACM to use to send you emails
    /// that enable you to validate domain ownership.
    /// </summary>
    public partial class DomainValidationOption
    {
        private string _domainName;
        private string _validationDomain;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// A fully qualified domain name (FQDN) in the certificate request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=253)]
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
        /// Gets and sets the property ValidationDomain. 
        /// <para>
        /// The domain name that you want ACM to use to send you validation emails. This domain
        /// name is the suffix of the email addresses that you want ACM to use. This must be the
        /// same as the <c>DomainName</c> value or a superdomain of the <c>DomainName</c> value.
        /// For example, if you request a certificate for <c>testing.example.com</c>, you can
        /// specify <c>example.com</c> for this value. In that case, ACM sends domain validation
        /// emails to the following five addresses:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// admin@example.com
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// administrator@example.com
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// hostmaster@example.com
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// postmaster@example.com
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// webmaster@example.com
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=253)]
        public string ValidationDomain
        {
            get { return this._validationDomain; }
            set { this._validationDomain = value; }
        }

        // Check to see if ValidationDomain property is set
        internal bool IsSetValidationDomain()
        {
            return this._validationDomain != null;
        }

    }
}