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
    /// The query you can use to define a resource group or a search for resources. A <code>ResourceQuery</code>
    /// specifies both a query <code>Type</code> and a <code>Query</code> string as JSON string
    /// objects. See the examples section for example JSON strings. For more information about
    /// creating a resource group with a resource query, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/gettingstarted-query.html">Build
    /// queries and groups in Resource Groups</a> in the <i>Resource Groups User Guide</i>
    /// 
    /// 
    ///  
    /// <para>
    /// When you combine all of the elements together into a single string, any double quotes
    /// that are embedded inside another double quote pair must be escaped by preceding the
    /// embedded double quote with a backslash character (\). For example, a complete <code>ResourceQuery</code>
    /// parameter must be formatted like the following CLI parameter example:
    /// </para>
    ///  
    /// <para>
    ///  <code>--resource-query '{"Type":"TAG_FILTERS_1_0","Query":"{\"ResourceTypeFilters\":[\"AWS::AllSupported\"],\"TagFilters\":[{\"Key\":\"Stage\",\"Values\":[\"Test\"]}]}"}'</code>
    /// 
    /// </para>
    ///  
    /// <para>
    /// In the preceding example, all of the double quote characters in the value part of
    /// the <code>Query</code> element must be escaped because the value itself is surrounded
    /// by double quotes. For more information, see <a href="https://docs.aws.amazon.com/cli/latest/userguide/cli-usage-parameters-quoting-strings.html">Quoting
    /// strings</a> in the <i>Command Line Interface User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For the complete list of resource types that you can use in the array value for <code>ResourceTypeFilters</code>,
    /// see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/supported-resources.html">Resources
    /// you can use with Resource Groups and Tag Editor</a> in the <i>Resource Groups User
    /// Guide</i>. For example:
    /// </para>
    ///  
    /// <para>
    ///  <code>"ResourceTypeFilters":["AWS::S3::Bucket", "AWS::EC2::Instance"]</code> 
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
        /// <code>Type</code> element.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ResourceTypeFilters</code> – Applies to all <code>ResourceQuery</code> objects
        /// of either <code>Type</code>. This element contains one of the following two items:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The value <code>AWS::AllSupported</code>. This causes the ResourceQuery to match resources
        /// of any resource type that also match the query.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A list (a JSON array) of resource type identifiers that limit the query to only resources
        /// of the specified types. For the complete list of resource types that you can use in
        /// the array value for <code>ResourceTypeFilters</code>, see <a href="https://docs.aws.amazon.com/ARG/latest/userguide/supported-resources.html">Resources
        /// you can use with Resource Groups and Tag Editor</a> in the <i>Resource Groups User
        /// Guide</i>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>"ResourceTypeFilters": ["AWS::AllSupported"]</code> or <code>"ResourceTypeFilters":
        /// ["AWS::EC2::Instance", "AWS::S3::Bucket"]</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>TagFilters</code> – applicable only if <code>Type</code> = <code>TAG_FILTERS_1_0</code>.
        /// The <code>Query</code> contains a JSON string that represents a collection of simple
        /// tag filters. The JSON string uses a syntax similar to the <code> <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_GetResources.html">GetResources</a>
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
        /// The results of this resource query could include the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon EC2 instance that has the following two tags: <code>{"Stage":"Deploy"}</code>,
        /// and <code>{"Version":"2"}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An S3 bucket that has the following two tags: <code>{"Stage":"Test"}</code>, and <code>{"Version":"1"}</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The resource query results would <i>not</i> include the following items in the results,
        /// however. 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An Amazon EC2 instance that has only the following tag: <code>{"Stage":"Deploy"}</code>.
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
        ///  </li> </ul> 
        /// <para>
        /// Example: <code>"TagFilters": [ { "Key": "Stage", "Values": [ "Gamma", "Beta" ] }</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>StackIdentifier</code> – applicable only if <code>Type</code> = <code>CLOUDFORMATION_STACK_1_0</code>.
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
        ///  <i> <code>CLOUDFORMATION_STACK_1_0:</code> </i> Specifies that you want the group
        /// to contain the members of an CloudFormation stack. The <code>Query</code> contains
        /// a <code>StackIdentifier</code> element with an ARN for a CloudFormation stack.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i> <code>TAG_FILTERS_1_0:</code> </i> Specifies that you want the group to include
        /// resource that have tags that match the query. 
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