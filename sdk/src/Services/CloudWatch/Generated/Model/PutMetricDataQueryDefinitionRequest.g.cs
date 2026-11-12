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

namespace Amazon.CloudWatch.Model
{
    /// <summary>
    /// Container for the parameters to the PutMetricDataQueryDefinition operation. Creates
    /// or updates a metric data query definition. <para> A metric data query definition saves
    /// a metric query so that you can reuse it later. It includes the query expression, the
    /// query language, and a path that names the definition and can organize it into folders.
    /// When you save a definition, CloudWatch doesn't validate or run its expression. </para>
    /// <para> To create a definition, omit <c>Id</c>. CloudWatch generates the ID and returns
    /// it. To update a definition, specify its <c>Id</c>. An update replaces the path, expression,
    /// and type, and keeps the creation time. </para> <para> The path must be unique in your
    /// account and Region. If another definition already uses the path, the request fails
    /// with a <c>ConflictException</c>. </para> <para> You can have up to 1,000 metric data
    /// query definitions in each Region of your account. A request that would create more
    /// fails with a <c>LimitExceededException</c>. </para> <para> <b>Permissions</b> </para>
    /// <para> To create or update a definition, you need the <c>cloudwatch:PutMetricDataQueryDefinition</c>
    /// permission on the metric data query definition resource. The resource ARN has the
    /// format <c>arn:aws:cloudwatch:Region:account-id:metric-query-definition/Id</c>. </para>
    /// <para> To add tags when you create a definition, you also need the <c>cloudwatch:TagResource</c>
    /// permission. You can use the <c>aws:RequestTag/${TagKey}</c> and <c>aws:TagKeys</c>
    /// condition keys to control which tags can be added. </para>
    /// </summary>
    public partial class PutMetricDataQueryDefinitionRequest : AmazonCloudWatchRequest
    {
        /// <summary>
        /// Gets and sets the property Expression. 
        /// <para>
        /// The query expression, in the language that <c>Type</c> specifies. CloudWatch doesn't
        /// validate or run the expression when you save it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true, Min = 1, Max = 65536)]
        public string Expression { get; set; }

        /// <summary>
        /// Checks to see if the Expression property is set.
        /// </summary>
        internal bool IsSetExpression() => this.Expression != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the metric data query definition to update. Omit this parameter to create
        /// a definition. CloudWatch then generates the ID and returns it in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 64)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Path. 
        /// <para>
        /// The name of the metric data query definition. Use slashes (<c>/</c>) to organize definitions
        /// into folders, for example <c>team/web/latency</c>. The path must meet the following
        /// requirements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// It must be unique in your account and Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It can't start or end with a slash.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It can't contain an empty folder name (<c>//</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// It can be at most 1,015 bytes when encoded as UTF-8.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 1024)]
        public string Path { get; set; }

        /// <summary>
        /// Checks to see if the Path property is set.
        /// </summary>
        internal bool IsSetPath() => this.Path != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A list of key-value pairs to associate with the metric data query definition. You
        /// can use tags to categorize definitions and to control access to them. Tags are applied
        /// only when the request creates a definition, that is, when you omit <c>Id</c>. To change
        /// the tags of an existing definition, use <c>TagResource</c> and <c>UntagResource</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The language of the expression. Valid values are the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PROMQL</c> – A PromQL query.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SQL</c> – A CloudWatch Metrics Insights query.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>METRIC_MATH</c> – A metric math expression.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public QueryType Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
