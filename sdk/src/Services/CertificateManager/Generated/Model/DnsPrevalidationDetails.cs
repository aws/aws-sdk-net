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
    /// DNS prevalidation details including the resource record for validation.
    /// </summary>
    public partial class DnsPrevalidationDetails
    {
        private DomainScope _domainScope;
        private string _hostedZoneId;
        private ResourceRecord _resourceRecord;

        /// <summary>
        /// Gets and sets the property DomainScope. 
        /// <para>
        /// The scope of domains covered by this prevalidation.
        /// </para>
        /// </summary>
        public DomainScope DomainScope
        {
            get { return this._domainScope; }
            set { this._domainScope = value; }
        }

        // Check to see if DomainScope property is set
        internal bool IsSetDomainScope()
        {
            return this._domainScope != null;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The Route 53 hosted zone ID for DNS validation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=32)]
        public string HostedZoneId
        {
            get { return this._hostedZoneId; }
            set { this._hostedZoneId = value; }
        }

        // Check to see if HostedZoneId property is set
        internal bool IsSetHostedZoneId()
        {
            return this._hostedZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceRecord. 
        /// <para>
        /// The DNS resource record to create for domain validation.
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