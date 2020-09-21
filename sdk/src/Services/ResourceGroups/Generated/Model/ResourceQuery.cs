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
 * Do not modify this file. This file is generated from the resource-groups-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// The query that is used to define a resource group or a search for resources. A query
    /// specifies both a query type and a query string as a JSON object. See the examples
    /// section for example JSON strings.
    /// 
    ///  
    /// <para>
    /// The examples that follow are shown as standard JSON strings. If you include such a
    /// string as a parameter to the AWS CLI or an SDK API, you might need to 'escape' the
    /// string into a single line. For example, see the <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-quoting-strings.html">Quoting
    /// strings</a> in the <i>AWS CLI User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Example 1</b> 
    /// </para>
    ///  
    /// <para>
    /// The following generic example shows a resource query JSON string that includes only
    /// resources that meet the following criteria:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// The resource type must be either <code>resource_type1</code> or <code>resource_type2</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The resource must have a tag <code>Key1</code> with a value of either <code>ValueA</code>
    /// or <code>ValueB</code>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The resource must have a tag <code>Key2</code> with a value of either <code>ValueC</code>
    /// or <code>ValueD</code>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <code>{ "Type": "TAG_FILTERS_1_0", "Query": { "ResourceTypeFilters": [ "resource_type1",
    /// "resource_type2"], "TagFilters": [ { "Key": "Key1", "Values": ["ValueA","ValueB"]
    /// }, { "Key":"Key2", "Values":["ValueC","ValueD"] } ] } }</code> 
    /// </para>
    ///  
    /// <para>
    /// This has the equivalent "shortcut" syntax of the following:
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "Type": "TAG_FILTERS_1_0", "Query": { "ResourceTypeFilters": [ "resource_type1",
    /// "resource_type2"], "TagFilters": [ { "Key1": ["ValueA","ValueB"] }, { "Key2": ["ValueC","ValueD"]
    /// } ] } }</code> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Example 2</b> 
    /// </para>
    ///  
    /// <para>
    /// The following example shows a resource query JSON string that includes only Amazon
    /// EC2 instances that are tagged <code>Stage</code> with a value of <code>Test</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "Type": "TAG_FILTERS_1_0", "Query": "{ "ResourceTypeFilters": "AWS::EC2::Instance",
    /// "TagFilters": { "Stage": "Test" } } }</code> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Example 3</b> 
    /// </para>
    ///  
    /// <para>
    /// The following example shows a resource query JSON string that includes resource of
    /// any supported type as long as it is tagged <code>Stage</code> with a value of <code>Prod</code>.
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "Type": "TAG_FILTERS_1_0", "Query": { "ResourceTypeFilters": "AWS::AllSupported",
    /// "TagFilters": { "Stage": "Prod" } } }</code> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Example 4</b> 
    /// </para>
    ///  
    /// <para>
    /// The following example shows a resource query JSON string that includes only Amazon
    /// EC2 instances and Amazon S3 buckets that are part of the specified AWS CloudFormation
    /// stack.
    /// </para>
    ///  
    /// <para>
    ///  <code>{ "Type": "CLOUDFORMATION_STACK_1_0", "Query": { "ResourceTypeFilters": [ "AWS::EC2::Instance",
    /// "AWS::S3::Bucket" ], "StackIdentifier": "arn:aws:cloudformation:us-west-2:123456789012:stack/AWStestuseraccount/fb0d5000-aba8-00e8-aa9e-50d5cEXAMPLE"
    /// } }</code> 
    /// </para>
    /// </summary>
    public partial class ResourceQuery
    {
        private string _query;
        private QueryType _type;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The query that defines a group or a search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=4096)]
        public string Query
        {
            get { return this._query; }
            set { this._query = value; }
        }

        // Check to see if Query property is set
        internal bool IsSetQuery()
        {
            return this._query != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of the query. You can use the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i> <code>CLOUDFORMATION_STACK_1_0:</code> </i>Specifies that the <code>Query</code>
        /// contains an ARN for a CloudFormation stack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>TAG_FILTERS_1_0:</code> </i>Specifies that the <code>Query</code> parameter
        /// contains a JSON string that represents a collection of simple tag filters for resource
        /// types and tags. The JSON string uses a syntax similar to the <code> <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_GetResources.html">GetResources</a>
        /// </code> operation, but uses only the <code> <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_GetResources.html#resourcegrouptagging-GetResources-request-ResourceTypeFilters">
        /// ResourceTypeFilters</a> </code> and <code> <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_GetResources.html#resourcegrouptagging-GetResources-request-TagFiltersTagFilters">TagFilters</a>
        /// </code> fields. If you specify more than one tag key, only resources that match all
        /// tag keys, and at least one value of each specified tag key, are returned in your query.
        /// If you specify more than one value for a tag key, a resource matches the filter if
        /// it has a tag key value that matches <i>any</i> of the specified values.
        /// </para>
        ///  
        /// <para>
        /// For example, consider the following sample query for resources that have two tags,
        /// <code>Stage</code> and <code>Version</code>, with two values each:
        /// </para>
        ///  
        /// <para>
        ///  <code>[{"Stage":["Test","Deploy"]},{"Version":["1","2"]}]</code> 
        /// </para>
        ///  
        /// <para>
        /// The results of this query could include the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An EC2 instance that has the following two tags: <code>{"Stage":"Deploy"}</code>,
        /// and <code>{"Version":"2"}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An S3 bucket that has the following two tags: <code>{"Stage":"Test"}</code>, and <code>{"Version":"1"}</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The query would not include the following items in the results, however. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An EC2 instance that has only the following tag: <code>{"Stage":"Deploy"}</code>.
        /// </para>
        ///  
        /// <para>
        /// The instance does not have <b>all</b> of the tag keys specified in the filter, so
        /// it is excluded from the results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An RDS database that has the following two tags: <code>{"Stage":"Archived"}</code>
        /// and <code>{"Version":"4"}</code> 
        /// </para>
        ///  
        /// <para>
        /// The database has all of the tag keys, but none of those keys has an associated value
        /// that matches at least one of the specified values in the filter.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=128)]
        public QueryType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}