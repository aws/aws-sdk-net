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
    /// Container for the parameters to the ListAttributes operation. Lists the attributes
    /// for Amazon ECS resources within a specified target type and cluster. When you specify
    /// a target type and cluster, <c>ListAttributes</c> returns a list of attribute objects,
    /// one for each attribute on each resource. You can filter the list of results to a single
    /// attribute name to only return results that have that name. You can also filter the
    /// results by attribute name and value. You can do this, for example, to see which container
    /// instances in a cluster are running a Linux AMI (<c>ecs.os-type=linux</c>).
    /// </summary>
    public partial class ListAttributesRequest : AmazonECSRequest
    {
        /// <summary>
        /// Gets and sets the property AttributeName. 
        /// <para>
        /// The name of the attribute to filter the results with. 
        /// </para>
        /// </summary>
        public string AttributeName { get; set; }

        /// <summary>
        /// Checks to see if the AttributeName property is set.
        /// </summary>
        internal bool IsSetAttributeName() => this.AttributeName != null;

        /// <summary>
        /// Gets and sets the property AttributeValue. 
        /// <para>
        /// The value of the attribute to filter results with. You must also specify an attribute
        /// name to use this parameter.
        /// </para>
        /// </summary>
        public string AttributeValue { get; set; }

        /// <summary>
        /// Checks to see if the AttributeValue property is set.
        /// </summary>
        internal bool IsSetAttributeValue() => this.AttributeValue != null;

        /// <summary>
        /// Gets and sets the property Cluster. 
        /// <para>
        /// The short name or full Amazon Resource Name (ARN) of the cluster to list attributes.
        /// If you do not specify a cluster, the default cluster is assumed.
        /// </para>
        /// </summary>
        public string Cluster { get; set; }

        /// <summary>
        /// Checks to see if the Cluster property is set.
        /// </summary>
        internal bool IsSetCluster() => this.Cluster != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of cluster results that <c>ListAttributes</c> returned in paginated
        /// output. When this parameter is used, <c>ListAttributes</c> only returns <c>maxResults</c>
        /// results in a single page along with a <c>nextToken</c> response element. The remaining
        /// results of the initial request can be seen by sending another <c>ListAttributes</c>
        /// request with the returned <c>nextToken</c> value. This value can be between 1 and
        /// 100. If this parameter isn't used, then <c>ListAttributes</c> returns up to 100 results
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
        /// The <c>nextToken</c> value returned from a <c>ListAttributes</c> request indicating
        /// that more results are available to fulfill the request and further calls are needed.
        /// If <c>maxResults</c> was provided, it's possible the number of results to be fewer
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
        /// Gets and sets the property TargetType. 
        /// <para>
        /// The type of the target to list attributes with.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TargetType TargetType { get; set; }

        /// <summary>
        /// Checks to see if the TargetType property is set.
        /// </summary>
        internal bool IsSetTargetType() => this.TargetType != null;
    }
}
