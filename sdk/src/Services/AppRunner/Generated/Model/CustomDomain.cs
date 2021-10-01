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
 * Do not modify this file. This file is generated from the apprunner-2020-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.AppRunner.Model
{
    /// <summary>
    /// Describes a custom domain that's associated with an App Runner service.
    /// </summary>
    public partial class CustomDomain
    {
        private List<CertificateValidationRecord> _certificateValidationRecords = new List<CertificateValidationRecord>();
        private string _domainName;
        private bool? _enableWWWSubdomain;
        private CustomDomainAssociationStatus _status;

        /// <summary>
        /// Gets and sets the property CertificateValidationRecords. 
        /// <para>
        /// A list of certificate CNAME records that's used for this domain name.
        /// </para>
        /// </summary>
        public List<CertificateValidationRecord> CertificateValidationRecords
        {
            get { return this._certificateValidationRecords; }
            set { this._certificateValidationRecords = value; }
        }

        // Check to see if CertificateValidationRecords property is set
        internal bool IsSetCertificateValidationRecords()
        {
            return this._certificateValidationRecords != null && this._certificateValidationRecords.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// An associated custom domain endpoint. It can be a root domain (for example, <code>example.com</code>),
        /// a subdomain (for example, <code>login.example.com</code> or <code>admin.login.example.com</code>),
        /// or a wildcard (for example, <code>*.example.com</code>).
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property EnableWWWSubdomain. 
        /// <para>
        /// When <code>true</code>, the subdomain <code>www.<i>DomainName</i> </code> is associated
        /// with the App Runner service in addition to the base domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool EnableWWWSubdomain
        {
            get { return this._enableWWWSubdomain.GetValueOrDefault(); }
            set { this._enableWWWSubdomain = value; }
        }

        // Check to see if EnableWWWSubdomain property is set
        internal bool IsSetEnableWWWSubdomain()
        {
            return this._enableWWWSubdomain.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the domain name association.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CustomDomainAssociationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}