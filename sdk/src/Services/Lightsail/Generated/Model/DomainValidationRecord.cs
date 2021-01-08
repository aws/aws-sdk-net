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

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the domain validation records of an Amazon Lightsail SSL/TLS certificate.
    /// </summary>
    public partial class DomainValidationRecord
    {
        private string _domainName;
        private ResourceRecord _resourceRecord;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name of the certificate validation record. For example, <code>example.com</code>
        /// or <code>www.example.com</code>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ResourceRecord. 
        /// <para>
        /// An object that describes the DNS records to add to your domain's DNS to validate it
        /// for the certificate.
        /// </para>
        /// </summary>
        public ResourceRecord ResourceRecord
        {
            get { return this._resourceRecord; }
            set { this._resourceRecord = value; }
        }

        // Check to see if ResourceRecord property is set
        internal bool IsSetResourceRecord()
        {
            return this._resourceRecord != null;
        }

    }
}