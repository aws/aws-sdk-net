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

namespace Amazon.Route53RecoveryReadiness.Model
{
    /// <summary>
    /// A component for DNS/Routing Control Readiness Checks
    /// </summary>
    public partial class DNSTargetResource
    {
        private string _domainName;
        private string _hostedZoneArn;
        private string _recordSetId;
        private string _recordType;
        private TargetResource _targetResource;

        /// <summary>
        /// Gets and sets the property DomainName. The DNS Name that acts as ingress point to
        /// a portion of application
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
        /// Gets and sets the property HostedZoneArn. The Hosted Zone ARN that contains the DNS
        /// record with the provided name of target resource.
        /// </summary>
        public string HostedZoneArn
        {
            get { return this._hostedZoneArn; }
            set { this._hostedZoneArn = value; }
        }

        // Check to see if HostedZoneArn property is set
        internal bool IsSetHostedZoneArn()
        {
            return this._hostedZoneArn != null;
        }

        /// <summary>
        /// Gets and sets the property RecordSetId. The R53 Set Id to uniquely identify a record
        /// given a Name and a Type
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

        /// <summary>
        /// Gets and sets the property RecordType. The Type of DNS Record of target resource
        /// </summary>
        public string RecordType
        {
            get { return this._recordType; }
            set { this._recordType = value; }
        }

        // Check to see if RecordType property is set
        internal bool IsSetRecordType()
        {
            return this._recordType != null;
        }

        /// <summary>
        /// Gets and sets the property TargetResource.
        /// </summary>
        public TargetResource TargetResource
        {
            get { return this._targetResource; }
            set { this._targetResource = value; }
        }

        // Check to see if TargetResource property is set
        internal bool IsSetTargetResource()
        {
            return this._targetResource != null;
        }

    }
}