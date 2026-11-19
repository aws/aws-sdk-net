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
    /// What an update requested.
    /// </summary>
    public partial class UpdateParameters
    {
        /// <summary>
        /// Gets and sets the property LinkConfig. 
        /// <para>
        /// The requested link configuration.
        /// </para>
        /// </summary>
        public LinkConfigParameters LinkConfig { get; set; }

        /// <summary>
        /// Checks to see if the LinkConfig property is set.
        /// </summary>
        internal bool IsSetLinkConfig() => this.LinkConfig != null;

        /// <summary>
        /// Gets and sets the property LinkFlow. 
        /// <para>
        /// The requested link flow.
        /// </para>
        /// </summary>
        public LinkFlowParameters LinkFlow { get; set; }

        /// <summary>
        /// Checks to see if the LinkFlow property is set.
        /// </summary>
        internal bool IsSetLinkFlow() => this.LinkFlow != null;

        /// <summary>
        /// Gets and sets the property ResponderGatewayConfig. 
        /// <para>
        /// The requested responder gateway configuration.
        /// </para>
        /// </summary>
        public ResponderGatewayConfigParameters ResponderGatewayConfig { get; set; }

        /// <summary>
        /// Checks to see if the ResponderGatewayConfig property is set.
        /// </summary>
        internal bool IsSetResponderGatewayConfig() => this.ResponderGatewayConfig != null;

        /// <summary>
        /// Gets and sets the property RoutingRule. 
        /// <para>
        /// The requested routing rule.
        /// </para>
        /// </summary>
        public RoutingRuleParameters RoutingRule { get; set; }

        /// <summary>
        /// Checks to see if the RoutingRule property is set.
        /// </summary>
        internal bool IsSetRoutingRule() => this.RoutingRule != null;
    }
}
