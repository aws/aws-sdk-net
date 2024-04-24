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
 * Do not modify this file. This file is generated from the route53-2013-04-01.normal.json service model.
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
namespace Amazon.Route53.Model
{
    /// <summary>
    /// In the response to a <c>ListHostedZonesByVPC</c> request, the <c>HostedZoneSummaries</c>
    /// element contains one <c>HostedZoneSummary</c> element for each hosted zone that the
    /// specified Amazon VPC is associated with. Each <c>HostedZoneSummary</c> element contains
    /// the hosted zone name and ID, and information about who owns the hosted zone.
    /// </summary>
    public partial class HostedZoneSummary
    {
        private string _hostedZoneId;
        private string _name;
        private HostedZoneOwner _owner;

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// The Route 53 hosted zone ID of a private hosted zone that the specified VPC is associated
        /// with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=32)]
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
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the private hosted zone, such as <c>example.com</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Owner. 
        /// <para>
        /// The owner of a private hosted zone that the specified VPC is associated with. The
        /// owner can be either an Amazon Web Services account or an Amazon Web Services service.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public HostedZoneOwner Owner
        {
            get { return this._owner; }
            set { this._owner = value; }
        }

        // Check to see if Owner property is set
        internal bool IsSetOwner()
        {
            return this._owner != null;
        }

    }
}