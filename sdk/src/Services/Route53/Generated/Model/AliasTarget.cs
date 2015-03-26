/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Route53.Model
{
    /// <summary>
    /// <i>Alias resource record sets only:</i> Information about the domain to which you
    /// are redirecting traffic.
    /// 
    ///  
    /// <para>
    /// For more information and an example, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/CreatingAliasRRSets.html">Creating
    /// Alias Resource Record Sets</a> in the <i>Amazon Route 53 Developer Guide</i>
    /// </para>
    /// .
    /// </summary>
    public partial class AliasTarget
    {
        private string _hostedZoneId;
        private string _dnsName;
        private bool? _evaluateTargetHealth;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public AliasTarget() { }

        /// <summary>
        /// Instantiates AliasTarget with the parameterized properties
        /// </summary>
        /// <param name="hostedZoneId"><i>Alias resource record sets only:</i> The value of the hosted zone ID for the AWS resource. For more information and an example, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/CreatingAliasRRSets.html">Creating Alias Resource Record Sets</a> in the <i>Amazon Route 53 Developer Guide</i>.</param>
        /// <param name="dnsName"><i>Alias resource record sets only:</i> The external DNS name associated with the AWS Resource. For more information and an example, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/CreatingAliasRRSets.html">Creating Alias Resource Record Sets</a> in the <i>Amazon Route 53 Developer Guide</i>.</param>
        public AliasTarget(string hostedZoneId, string dnsName)
        {
            _hostedZoneId = hostedZoneId;
            _dnsName = dnsName;
        }

        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// <i>Alias resource record sets only:</i> The value of the hosted zone ID for the AWS
        /// resource.
        /// </para>
        ///  
        /// <para>
        /// For more information and an example, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/CreatingAliasRRSets.html">Creating
        /// Alias Resource Record Sets</a> in the <i>Amazon Route 53 Developer Guide</i>
        /// </para>
        /// .
        /// </summary>
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
        /// Gets and sets the property DNSName. 
        /// <para>
        /// <i>Alias resource record sets only:</i> The external DNS name associated with the
        /// AWS Resource.
        /// </para>
        ///  
        /// <para>
        /// For more information and an example, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/CreatingAliasRRSets.html">Creating
        /// Alias Resource Record Sets</a> in the <i>Amazon Route 53 Developer Guide</i>
        /// </para>
        /// .
        /// </summary>
        public string DNSName
        {
            get { return this._dnsName; }
            set { this._dnsName = value; }
        }

        // Check to see if DNSName property is set
        internal bool IsSetDNSName()
        {
            return this._dnsName != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluateTargetHealth. 
        /// <para>
        /// <i>Alias resource record sets only:</i> A boolean value that indicates whether this
        /// Resource Record Set should respect the health status of any health checks associated
        /// with the ALIAS target record which it is linked to.
        /// </para>
        ///  
        /// <para>
        /// For more information and an example, see <a href="http://docs.aws.amazon.com/Route53/latest/DeveloperGuide/CreatingAliasRRSets.html">Creating
        /// Alias Resource Record Sets</a> in the <i>Amazon Route 53 Developer Guide</i>
        /// </para>
        /// .
        /// </summary>
        public bool EvaluateTargetHealth
        {
            get { return this._evaluateTargetHealth.GetValueOrDefault(); }
            set { this._evaluateTargetHealth = value; }
        }

        // Check to see if EvaluateTargetHealth property is set
        internal bool IsSetEvaluateTargetHealth()
        {
            return this._evaluateTargetHealth.HasValue; 
        }

    }
}