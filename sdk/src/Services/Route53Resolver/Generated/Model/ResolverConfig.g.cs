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

namespace Amazon.Route53Resolver.Model
{
    /// <summary>
    /// A complex type that contains information about a Resolver configuration for a VPC.
    /// </summary>
    public partial class ResolverConfig
    {
        /// <summary>
        /// Gets and sets the property AutodefinedReverse. 
        /// <para>
        ///  The status of whether or not the Resolver will create autodefined rules for reverse
        /// DNS lookups. This is enabled by default. The status can be one of following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>ENABLING:</b> Autodefined rules for reverse DNS lookups are being enabled but
        /// are not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>ENABLED:</b> Autodefined rules for reverse DNS lookups are enabled.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DISABLING:</b> Autodefined rules for reverse DNS lookups are being disabled but
        /// are not complete.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>DISABLED:</b> Autodefined rules for reverse DNS lookups are disabled.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ResolverAutodefinedReverseStatus AutodefinedReverse { get; set; }

        /// <summary>
        /// Checks to see if the AutodefinedReverse property is set.
        /// </summary>
        internal bool IsSetAutodefinedReverse() => this.AutodefinedReverse != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// ID for the Resolver configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The owner account ID of the Amazon Virtual Private Cloud VPC.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 32)]
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the Amazon Virtual Private Cloud VPC or a Route 53 Profile that you're configuring
        /// Resolver for.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;
    }
}
