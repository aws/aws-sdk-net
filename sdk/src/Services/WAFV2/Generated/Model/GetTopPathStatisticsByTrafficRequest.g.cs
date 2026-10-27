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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// Container for the parameters to the GetTopPathStatisticsByTraffic operation. Retrieves
    /// aggregated statistics about the top URI paths accessed by bot traffic for a specified
    /// web ACL and time window. You can use this operation to analyze which paths on your
    /// web application receive the most bot traffic and identify the specific bots accessing
    /// those paths. The operation supports filtering by bot category, organization, or name,
    /// and allows you to drill down into specific path prefixes to view detailed URI-level
    /// statistics.
    /// </summary>
    public partial class GetTopPathStatisticsByTrafficRequest : AmazonWAFV2Request
    {
        /// <summary>
        /// Gets and sets the property BotCategory. 
        /// <para>
        /// Filters the results to include only traffic from bots in the specified category. For
        /// example, you can filter by <c>ai</c> to see only AI crawler traffic, or <c>search_engine</c>
        /// to see only search engine bot traffic. When you apply this filter, the <c>Source</c>
        /// field is populated in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string BotCategory { get; set; }

        /// <summary>
        /// Checks to see if the BotCategory property is set.
        /// </summary>
        internal bool IsSetBotCategory() => this.BotCategory != null;

        /// <summary>
        /// Gets and sets the property BotName. 
        /// <para>
        /// Filters the results to include only traffic from the specified bot. For example, you
        /// can filter by <c>gptbot</c> or <c>googlebot</c>. When you apply this filter, the <c>Source</c>
        /// field is populated in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string BotName { get; set; }

        /// <summary>
        /// Checks to see if the BotName property is set.
        /// </summary>
        internal bool IsSetBotName() => this.BotName != null;

        /// <summary>
        /// Gets and sets the property BotOrganization. 
        /// <para>
        /// Filters the results to include only traffic from bots belonging to the specified organization.
        /// For example, you can filter by <c>openai</c> or <c>google</c>. When you apply this
        /// filter, the <c>Source</c> field is populated in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string BotOrganization { get; set; }

        /// <summary>
        /// Checks to see if the BotOrganization property is set.
        /// </summary>
        internal bool IsSetBotOrganization() => this.BotOrganization != null;

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of path statistics to return. Valid values are 1 to 100.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public int? Limit { get; set; }

        /// <summary>
        /// Checks to see if the Limit property is set.
        /// </summary>
        internal bool IsSetLimit() => this.Limit.HasValue;

        /// <summary>
        /// Gets and sets the property NextMarker. 
        /// <para>
        /// When you request a list of objects with a <c>Limit</c> setting, if the number of objects
        /// that are still available for retrieval exceeds the limit, WAF returns a <c>NextMarker</c>
        /// value in the response. To retrieve the next batch of objects, provide the marker from
        /// the prior call in your next request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string NextMarker { get; set; }

        /// <summary>
        /// Checks to see if the NextMarker property is set.
        /// </summary>
        internal bool IsSetNextMarker() => this.NextMarker != null;

        /// <summary>
        /// Gets and sets the property NumberOfTopTrafficBotsPerPath. 
        /// <para>
        /// The maximum number of top bots to include in the statistics for each path. Valid values
        /// are 1 to 10.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 10)]
        public int? NumberOfTopTrafficBotsPerPath { get; set; }

        /// <summary>
        /// Checks to see if the NumberOfTopTrafficBotsPerPath property is set.
        /// </summary>
        internal bool IsSetNumberOfTopTrafficBotsPerPath() => this.NumberOfTopTrafficBotsPerPath.HasValue;

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// Specifies whether the web ACL is for an Amazon Web Services CloudFront distribution
        /// or for a regional application. A regional application can be an Application Load Balancer,
        /// an AppSync GraphQL API, an Amazon Cognito user pool, an Amazon Web Services App Runner
        /// service, or an Amazon Web Services Verified Access instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public Scope Scope { get; set; }

        /// <summary>
        /// Checks to see if the Scope property is set.
        /// </summary>
        internal bool IsSetScope() => this.Scope != null;

        /// <summary>
        /// Gets and sets the property TimeWindow. 
        /// <para>
        /// The time window for which you want to retrieve path statistics. The time window must
        /// be within the data retention period for your web ACL.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TimeWindow TimeWindow { get; set; }

        /// <summary>
        /// Checks to see if the TimeWindow property is set.
        /// </summary>
        internal bool IsSetTimeWindow() => this.TimeWindow != null;

        /// <summary>
        /// Gets and sets the property UriPathPrefix. 
        /// <para>
        /// A URI path prefix to filter the results. When you specify this parameter, the operation
        /// returns statistics for individual URIs within the specified path prefix. For example,
        /// if you specify <c>/api</c>, the response includes statistics for paths like <c>/api/v1/users</c>
        /// and <c>/api/v2/orders</c>. If you don't specify this parameter, the operation returns
        /// top-level path statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string UriPathPrefix { get; set; }

        /// <summary>
        /// Checks to see if the UriPathPrefix property is set.
        /// </summary>
        internal bool IsSetUriPathPrefix() => this.UriPathPrefix != null;

        /// <summary>
        /// Gets and sets the property WebAclArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the web ACL for which you want to retrieve path
        /// statistics.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 2048)]
        public string WebAclArn { get; set; }

        /// <summary>
        /// Checks to see if the WebAclArn property is set.
        /// </summary>
        internal bool IsSetWebAclArn() => this.WebAclArn != null;
    }
}
