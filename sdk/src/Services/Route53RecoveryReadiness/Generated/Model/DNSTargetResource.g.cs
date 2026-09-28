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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// A component for DNS/routing control readiness checks and architecture checks.
    /// </summary>
    public partial class DNSTargetResource
    {
        /// <summary>
        /// Gets and sets the property DomainName. 
        /// <para>
        /// The domain name that acts as an ingress point to a portion of the customer application.
        /// </para>
        /// </summary>
        public string DomainName { get; set; }

        /// <summary>
        /// Checks to see if the DomainName property is set.
        /// </summary>
        internal bool IsSetDomainName() => this.DomainName != null;

        /// <summary>
        /// Gets and sets the property HostedZoneArn. 
        /// <para>
        /// The hosted zone Amazon Resource Name (ARN) that contains the DNS record with the provided
        /// name of the target resource.
        /// </para>
        /// </summary>
        public string HostedZoneArn { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneArn property is set.
        /// </summary>
        internal bool IsSetHostedZoneArn() => this.HostedZoneArn != null;

        /// <summary>
        /// Gets and sets the property RecordSetId. 
        /// <para>
        /// The Route 53 record set ID that uniquely identifies a DNS record, given a name and
        /// a type.
        /// </para>
        /// </summary>
        public string RecordSetId { get; set; }

        /// <summary>
        /// Checks to see if the RecordSetId property is set.
        /// </summary>
        internal bool IsSetRecordSetId() => this.RecordSetId != null;

        /// <summary>
        /// Gets and sets the property RecordType. 
        /// <para>
        /// The type of DNS record of the target resource.
        /// </para>
        /// </summary>
        public string RecordType { get; set; }

        /// <summary>
        /// Checks to see if the RecordType property is set.
        /// </summary>
        internal bool IsSetRecordType() => this.RecordType != null;

        /// <summary>
        /// Gets and sets the property TargetResource. 
        /// <para>
        /// The target resource of the DNS target resource.
        /// </para>
        /// </summary>
        public TargetResource TargetResource { get; set; }

        /// <summary>
        /// Checks to see if the TargetResource property is set.
        /// </summary>
        internal bool IsSetTargetResource() => this.TargetResource != null;
    }
}
