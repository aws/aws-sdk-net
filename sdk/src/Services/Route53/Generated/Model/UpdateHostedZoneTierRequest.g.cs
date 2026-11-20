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

namespace Amazon.Route53.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateHostedZoneTier operation. Changes the tier
    /// of a hosted zone. The tier determines which features the hosted zone includes and
    /// which optional features you can turn on. For pricing information, see <a href="https://aws.amazon.com/route53/pricing/">Amazon
    /// Route 53 pricing</a> on the AWS website. <para> When the hosted zone moves to a new
    /// tier, Route 53 turns on the features that the new tier includes. Route 53 also disables
    /// any enabled features that the new tier doesn't include. </para> <para> Before you
    /// move a hosted zone to a tier that doesn't offer an optional feature that you turned
    /// on, turn off that feature. You can't change the tier of a hosted zone that uses a
    /// CloudFront flat-rate pricing plan. </para>
    /// </summary>
    public partial class UpdateHostedZoneTierRequest : AmazonRoute53Request
    {
        /// <summary>
        /// Gets and sets the property HostedZoneId. 
        /// <para>
        /// Specify the ID of the hosted zone whose tier you want to change.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 32)]
        public string HostedZoneId { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneId property is set.
        /// </summary>
        internal bool IsSetHostedZoneId() => this.HostedZoneId != null;

        /// <summary>
        /// Gets and sets the property HostedZoneTier. 
        /// <para>
        /// Specify the tier to move the hosted zone to. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>STANDARD</c>: The default tier for new hosted zones.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ADVANCED</c>: A tier that includes Change History and offers more optional features.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public HostedZoneTier HostedZoneTier { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneTier property is set.
        /// </summary>
        internal bool IsSetHostedZoneTier() => this.HostedZoneTier != null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Specifies whether to validate the request without changing the tier. Route 53 returns
        /// the same errors as for a real request, but doesn't change the hosted zone. The default
        /// is <c>false</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;
    }
}
