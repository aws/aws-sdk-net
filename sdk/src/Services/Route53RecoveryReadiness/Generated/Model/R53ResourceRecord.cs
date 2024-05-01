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
 * Do not modify this file. This file is generated from the route53-recovery-readiness-2019-12-02.normal.json service model.
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
namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// The Route 53 resource that a DNS target resource record points to.
    /// </summary>
    public partial class R53ResourceRecord
    {
        private string _domainName;
        private string _recordSetId;

        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The DNS target domain name.
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
        /// Gets and sets the property RecordSetId. 
        /// <para>
        /// The Route 53 Resource Record Set ID.
        /// </para>
        /// </summary>
        public string RecordSetId
        {
            get { return this._recordSetId; }
            set { this._recordSetId = value; }
        }

        // Check to see if RecordSetId property is set
        internal bool IsSetRecordSetId()
        {
            return this._recordSetId != null;
        }

    }
}