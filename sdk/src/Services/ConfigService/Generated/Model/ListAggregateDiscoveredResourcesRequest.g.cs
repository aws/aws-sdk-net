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

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the ListAggregateDiscoveredResources operation. Accepts
    /// a resource type and returns a list of resource identifiers that are aggregated for
    /// a specific resource type across accounts and regions. A resource identifier includes
    /// the resource type, ID, (if available) the custom resource name, source account, and
    /// source region. You can narrow the results to include only resources that have specific
    /// resource IDs, or a resource name, or source account ID, or source region. <para> For
    /// example, if the input consists of accountID 12345678910 and the region is us-east-1
    /// for resource type <c>AWS::EC2::Instance</c> then the API returns all the EC2 instance
    /// identifiers of accountID 12345678910 and region us-east-1. </para>
    /// </summary>
    public partial class ListAggregateDiscoveredResourcesRequest : AmazonConfigServiceRequest
    {
        /// <summary>
        /// Gets and sets the property ConfigurationAggregatorName. 
        /// <para>
        /// The name of the configuration aggregator. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ConfigurationAggregatorName { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationAggregatorName property is set.
        /// </summary>
        internal bool IsSetConfigurationAggregatorName() => this.ConfigurationAggregatorName != null;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// Filters the results based on the <c>ResourceFilters</c> object.
        /// </para>
        /// </summary>
        public ResourceFilters Filters { get; set; }

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of resource identifiers returned on each page. You cannot specify
        /// a number greater than 100. If you specify 0, Config uses the default.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> string returned on a previous page that you use to get the next
        /// page of results in a paginated response.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resources that you want Config to list in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;
    }
}
