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

namespace Amazon.RTBFabric.Model
{
    /// <summary>
    /// What an update targeted.
    /// </summary>
    public partial class UpdateTarget
    {
        /// <summary>
        /// Gets and sets the property Gateway. 
        /// <para>
        /// The gateway itself.
        /// </para>
        /// </summary>
        public Unit Gateway { get; set; }

        /// <summary>
        /// Checks to see if the Gateway property is set.
        /// </summary>
        internal bool IsSetGateway() => this.Gateway != null;

        /// <summary>
        /// Gets and sets the property Link. 
        /// <para>
        /// A link on the gateway.
        /// </para>
        /// </summary>
        public LinkTarget Link { get; set; }

        /// <summary>
        /// Checks to see if the Link property is set.
        /// </summary>
        internal bool IsSetLink() => this.Link != null;

        /// <summary>
        /// Gets and sets the property RoutingRule. 
        /// <para>
        /// A routing rule on one of the gateway's links.
        /// </para>
        /// </summary>
        public RoutingRuleTarget RoutingRule { get; set; }

        /// <summary>
        /// Checks to see if the RoutingRule property is set.
        /// </summary>
        internal bool IsSetRoutingRule() => this.RoutingRule != null;
    }
}
