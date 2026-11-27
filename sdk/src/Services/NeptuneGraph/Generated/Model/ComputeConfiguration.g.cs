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

namespace Amazon.NeptuneGraph.Model
{
    /// <summary>
    /// The compute configuration of a graph. A graph is either a provisioned graph or a graph
    /// session.
    /// </summary>
    public partial class ComputeConfiguration
    {
        /// <summary>
        /// Gets and sets the property GraphSession. 
        /// <para>
        /// Configuration for a graph session. A graph session uses ephemeral compute that is
        /// bootstrapped when a query is sent to the graph. The compute is automatically stopped
        /// after a few minutes with no traffic; the next query bootstraps the compute again.
        /// Queries that bootstrap the compute are subject to cold start latency.
        /// </para>
        /// </summary>
        public GraphSessionConfiguration GraphSession { get; set; }

        /// <summary>
        /// Checks to see if the GraphSession property is set.
        /// </summary>
        internal bool IsSetGraphSession() => this.GraphSession != null;

        /// <summary>
        /// Gets and sets the property ProvisionedGraph. 
        /// <para>
        /// Configuration for a provisioned graph. A provisioned graph uses dedicated compute
        /// that is always available. Use provisioned graphs for workloads that require higher
        /// memory or predictable latency.
        /// </para>
        /// </summary>
        public ProvisionedGraphConfiguration ProvisionedGraph { get; set; }

        /// <summary>
        /// Checks to see if the ProvisionedGraph property is set.
        /// </summary>
        internal bool IsSetProvisionedGraph() => this.ProvisionedGraph != null;
    }
}
