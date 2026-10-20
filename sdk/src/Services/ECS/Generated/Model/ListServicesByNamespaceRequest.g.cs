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
    /// Container for the parameters to the ListServicesByNamespace operation. This operation
    /// lists all of the services that are associated with a Cloud Map namespace. This list
    /// might include services in different clusters. In contrast, <c>ListServices</c> can
    /// only list services in one cluster at a time. If you need to filter the list of services
    /// in a single cluster by various parameters, use <c>ListServices</c>. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
    /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
    /// </summary>
    public partial class ListServicesByNamespaceRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of service results that <c>ListServicesByNamespace</c> returns
        /// in paginated output. When this parameter is used, <c>ListServicesByNamespace</c> only
        /// returns <c>maxResults</c> results in a single page along with a <c>nextToken</c> response
        /// element. The remaining results of the initial request can be seen by sending another
        /// <c>ListServicesByNamespace</c> request with the returned <c>nextToken</c> value. This
        /// value can be between 1 and 100. If this parameter isn't used, then <c>ListServicesByNamespace</c>
        /// returns up to 10 results and a <c>nextToken</c> value if applicable.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property Namespace. 
        /// <para>
        /// The namespace name or full Amazon Resource Name (ARN) of the Cloud Map namespace to
        /// list the services in.
        /// </para>
        ///  
        /// <para>
        /// Tasks that run in a namespace can use short names to connect to services in the namespace.
        /// Tasks can connect to services across all of the clusters in the namespace. Tasks connect
        /// through a managed proxy container that collects logs and metrics for increased visibility.
        /// Only the tasks that Amazon ECS services create are supported with Service Connect.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonECS/latest/developerguide/service-connect.html">Service
        /// Connect</a> in the <i>Amazon Elastic Container Service Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Namespace { get; set; }

        /// <summary>
        /// Checks to see if the Namespace property is set.
        /// </summary>
        internal bool IsSetNamespace() => this.Namespace != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value that's returned from a <c>ListServicesByNamespace</c> request.
        /// It indicates that more results are available to fulfill the request and further calls
        /// are needed. If <c>maxResults</c> is returned, it is possible the number of results
        /// is less than <c>maxResults</c>.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;
    }
}
