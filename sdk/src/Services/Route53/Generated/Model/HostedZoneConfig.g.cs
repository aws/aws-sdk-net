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
    /// A complex type that contains an optional comment about your hosted zone. If you don't
    /// want to specify a comment, omit both the <c>HostedZoneConfig</c> and <c>Comment</c>
    /// elements.
    /// </summary>
    public partial class HostedZoneConfig
    {
        /// <summary>
        /// Empty constructor used to set properties independently even when a simple constructor is available
        /// </summary>
        public HostedZoneConfig() { }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Any comments that you want to include about the hosted zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Comment { get; set; }

        /// <summary>
        /// Checks to see if the Comment property is set.
        /// </summary>
        internal bool IsSetComment() => this.Comment != null;

        /// <summary>
        /// Gets and sets the property PrivateZone. 
        /// <para>
        /// A value that indicates whether this is a private hosted zone.
        /// </para>
        /// </summary>
        public bool? PrivateZone { get; set; }

        /// <summary>
        /// Checks to see if the PrivateZone property is set.
        /// </summary>
        internal bool IsSetPrivateZone() => this.PrivateZone.HasValue;

        /// <summary>
        /// Gets and sets the property HostedZoneTier. 
        /// <para>
        /// The tier of the hosted zone. The tier controls which features you get and which optional
        /// features you can turn on. Valid values are the following:
        /// </para>
        ///  <dl> <dt>STANDARD</dt> <dd> 
        /// <para>
        ///  <c>STANDARD</c> is the default tier for new hosted zones.
        /// </para>
        ///  </dd> <dt>ADVANCED</dt> <dd> 
        /// <para>
        ///  <c>ADVANCED</c> is a tier that includes Change History and offers more optional features.
        /// </para>
        ///  </dd> </dl> 
        /// <para>
        /// If you don't specify a tier when you create a hosted zone, Route 53 uses <c>STANDARD</c>.
        /// Route 53 always returns this value. For pricing information, see Amazon Route 53 pricing
        /// on the <a href="https://aws.amazon.com/route53/pricing/">AWS website</a>.
        /// </para>
        /// </summary>
        public HostedZoneTier HostedZoneTier { get; set; }

        /// <summary>
        /// Checks to see if the HostedZoneTier property is set.
        /// </summary>
        internal bool IsSetHostedZoneTier() => this.HostedZoneTier != null;
    }
}
