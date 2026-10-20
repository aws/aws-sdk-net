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

namespace Amazon.ECS.Model
{
    /// <summary>
    /// Container for the parameters to the ListServices operation. Returns a list of services.
    /// You can filter the results by cluster, launch type, and scheduling strategy.
    /// </summary>
    public partial class ListServicesRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster to use when filtering
        /// the <c>ListServices</c> results. If you do not specify a cluster, the default cluster
        /// is assumed.
        /// </para>
        /// </summary>
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property LaunchType. 
        /// <para>
        /// The launch type to use when filtering the <c>ListServices</c> results.
        /// </para>
        /// </summary>
        public LaunchType LaunchType { get; set; }

        /// <summary>
        /// Checks to see if the LaunchType property is set.
        /// </summary>
        internal bool IsSetLaunchType() => this.LaunchType != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of service results that <c>ListServices</c> returned in paginated
        /// output. When this parameter is used, <c>ListServices</c> only returns <c>maxResults</c>
        /// results in a single page along with a <c>nextToken</c> response element. The remaining
        /// results of the initial request can be seen by sending another <c>ListServices</c>
        /// request with the returned <c>nextToken</c> value. This value can be between 1 and
        /// 100. If this parameter isn't used, then <c>ListServices</c> returns up to 10 results
        /// and a <c>nextToken</c> value if applicable.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value returned from a <c>ListServices</c> request indicating
        /// that more results are available to fulfill the request and further calls will be needed.
        /// If <c>maxResults</c> was provided, it is possible the number of results to be fewer
        /// than <c>maxResults</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This token should be treated as an opaque identifier that is only used to retrieve
        /// the next items in a list and not for other programmatic purposes.
        /// </para>
        ///  </note>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceManagementType. 
        /// <para>
        /// The resourceManagementType type to use when filtering the <c>ListServices</c> results.
        /// </para>
        /// </summary>
        public ResourceManagementType ResourceManagementType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceManagementType property is set.
        /// </summary>
        internal bool IsSetResourceManagementType() => this.ResourceManagementType != null;

        /// <summary>
        /// Gets and sets the property SchedulingStrategy. 
        /// <para>
        /// The scheduling strategy to use when filtering the <c>ListServices</c> results.
        /// </para>
        /// </summary>
        public SchedulingStrategy SchedulingStrategy { get; set; }

        /// <summary>
        /// Checks to see if the SchedulingStrategy property is set.
        /// </summary>
        internal bool IsSetSchedulingStrategy() => this.SchedulingStrategy != null;
    }
}
