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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// The query you can use to define a resource group or a search for resources. A <c>ResourceQuery</c>
    /// specifies both a query <c>Type</c> and a <c>Query</c> string as JSON string objects.
    /// See the examples section for example JSON strings. For more information about creating
    /// a resource group with a resource query, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html">Build
    /// queries and groups in Resource Groups</a> in the <i>Resource Groups User Guide</i>
    /// 
    /// 
    ///  
    /// <para>
    /// When you combine all of the elements together into a single string, any double quotes
    /// that are embedded inside another double quote pair must be escaped by preceding the
    /// embedded double quote with a backslash character (\). For example, a complete <c>ResourceQuery</c>
    /// parameter must be formatted like the following CLI parameter example:
    /// </para>
    ///  
    /// <para>
    ///  <c>--resource-query '{"Type":"TAG_FILTERS_1_0","Query":"{\"ResourceTypeFilters\":[\"AWS::AllSupported\"],\"TagFilters\":[{\"Key\":\"Stage\",\"Values\":[\"Test\"]}]}"}'</c>
    /// 
    /// </para>
    ///  
    /// <para>
    /// In the preceding example, all of the double quote characters in the value part of
    /// the <c>Query</c> element must be escaped because the value itself is surrounded by
    /// double quotes. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-quoting-strings.html">Quoting
    /// strings</a> in the <i>Command Line Interface User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For the complete list of resource types that you can use in the array value for <c>ResourceTypeFilters</c>,
    /// see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/supported-resources.html">Resources
    /// you can use with Resource Groups and Tag Editor</a> in the <i>Resource Groups User
    /// Guide</i>. For example:
    /// </para>
    ///  
    /// <para>
    ///  <c>"ResourceTypeFilters":["AWS::S3::Bucket", "AWS::EC2::Instance"]</c> 
    /// </para>
    /// </summary>
    public partial class ResourceQuery
    {
        private string _query;
        private QueryType _type;

        /// <summary>
        /// Gets and sets the property Query. 
        /// <para>
        /// The query that defines a group or a search. The contents depends on the value of the
        /// <c>Type</c> element.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ResourceTypeFilters</c> – Applies to all <c>ResourceQuery</c> objects of either
        /// <c>Type</c>. This element contains one of the following two items:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value <c>AWS::AllSupported</c>. This causes the ResourceQuery to match resources
        /// of any resource type that also match the query.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A list (a JSON array) of resource type identifiers that limit the query to only resources
        /// of the specified types. For the complete list of resource types that you can use in
        /// the array value for <c>ResourceTypeFilters</c>, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/supported-resources.html">Resources
        /// you can use with Resource Groups and Tag Editor</a> in the <i>Resource Groups User
        /// Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>"ResourceTypeFilters": ["AWS::AllSupported"]</c> or <c>"ResourceTypeFilters":
        /// ["AWS::EC2::Instance", "AWS::S3::Bucket"]</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TagFilters</c> – applicable only if <c>Type</c> = <c>TAG_FILTERS_1_0</c>. The
        /// <c>Query</c> contains a JSON string that represents a collection of simple tag filters.
        /// The JSON string uses a syntax similar to the <c> <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_GetResources.html">GetResources</a>
        /// </c> operation, but uses only the <c> <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_GetResources.html#resourcegrouptagging-GetResources-request-ResourceTypeFilters">
        /// ResourceTypeFilters</a> </c> and <c> <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_GetResources.html#resourcegrouptagging-GetResources-request-TagFiltersTagFilters">TagFilters</a>
        /// </c> fields. If you specify more than one tag key, only resources that match all tag
        /// keys, and at least one value of each specified tag key, are returned in your query.
        /// If you specify more than one value for a tag key, a resource matches the filter if
        /// it has a tag key value that matches <i>any</i> of the specified values.
        /// </para>
        ///  
        /// <para>
        /// For example, consider the following sample query for resources that have two tags,
        /// <c>Stage</c> and <c>Version</c>, with two values each:
        /// </para>
        ///  
        /// <para>
        ///  <c>[{"Stage":["Test","Deploy"]},{"Version":["1","2"]}]</c> 
        /// </para>
        ///  
        /// <para>
        /// The results of this resource query could include the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon EC2 instance that has the following two tags: <c>{"Stage":"Deploy"}</c>,
        /// and <c>{"Version":"2"}</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An S3 bucket that has the following two tags: <c>{"Stage":"Test"}</c>, and <c>{"Version":"1"}</c>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The resource query results would <i>not</i> include the following items in the results,
        /// however. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon EC2 instance that has only the following tag: <c>{"Stage":"Deploy"}</c>.
        /// </para>
        ///  
        /// <para>
        /// The instance does not have <b>all</b> of the tag keys specified in the filter, so
        /// it is excluded from the results.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An RDS database that has the following two tags: <c>{"Stage":"Archived"}</c> and <c>{"Version":"4"}</c>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The database has all of the tag keys, but none of those keys has an associated value
        /// that matches at least one of the specified values in the filter.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <c>"TagFilters": [ { "Key": "Stage", "Values": [ "Gamma", "Beta" ] }</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>StackIdentifier</c> – applicable only if <c>Type</c> = <c>CLOUDFORMATION_STACK_1_0</c>.
        /// The value of this parameter is the Amazon Resource Name (ARN) of the CloudFormation
        /// stack whose resources you want included in the group.
        /// </para>
        ///  </li> </ul>
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
        /// The type of the query to perform. This can have one of two values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i> <c>CLOUDFORMATION_STACK_1_0:</c> </i> Specifies that you want the group to contain
        /// the members of an CloudFormation stack. The <c>Query</c> contains a <c>StackIdentifier</c>
        /// element with an Amazon resource name (ARN) for a CloudFormation stack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <c>TAG_FILTERS_1_0:</c> </i> Specifies that you want the group to include resource
        /// that have tags that match the query. 
        /// </para>
        ///  </li> </ul>
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