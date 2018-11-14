/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResourceGroups.Model
{
    /// <summary>
    /// The query that is used to define a resource group or a search for resources.
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
        /// The type of the query. The valid values in this release are <code>TAG_FILTERS_1_0</code>
        /// and <code>CLOUDFORMATION_STACK_1_0</code>.
        /// </para>
        ///  
        /// <para>
        ///  <i> <code>TAG_FILTERS_1_0:</code> </i> A JSON syntax that lets you specify a collection
        /// of simple tag filters for resource types and tags, as supported by the AWS Tagging
        /// API <a href="https://docs.aws.amazon.com/resourcegroupstagging/latest/APIReference/API_GetResources.html">GetResources</a>
        /// operation. If you specify more than one tag key, only resources that match all tag
        /// keys, and at least one value of each specified tag key, are returned in your query.
        /// If you specify more than one value for a tag key, a resource matches the filter if
        /// it has a tag key value that matches <i>any</i> of the specified values.
        /// </para>
        ///  
        /// <para>
        /// For example, consider the following sample query for resources that have two tags,
        /// <code>Stage</code> and <code>Version</code>, with two values each. (<code>[{"Key":"Stage","Values":["Test","Deploy"]},{"Key":"Version","Values":["1","2"]}]</code>)
        /// The results of this query might include the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An EC2 instance that has the following two tags: <code>{"Key":"Stage","Values":["Deploy"]}</code>,
        /// and <code>{"Key":"Version","Values":["2"]}</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An S3 bucket that has the following two tags: {"Key":"Stage","Values":["Test","Deploy"]},
        /// and {"Key":"Version","Values":["1"]}
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The query would not return the following results, however. The following EC2 instance
        /// does not have all tag keys specified in the filter, so it is rejected. The RDS database
        /// has all of the tag keys, but no values that match at least one of the specified tag
        /// key values in the filter.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An EC2 instance that has only the following tag: <code>{"Key":"Stage","Values":["Deploy"]}</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// An RDS database that has the following two tags: <code>{"Key":"Stage","Values":["Archived"]}</code>,
        /// and <code>{"Key":"Version","Values":["4"]}</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <i> <code>CLOUDFORMATION_STACK_1_0:</code> </i> A JSON syntax that lets you specify
        /// a CloudFormation stack ARN.
        /// </para>
        /// </summary>
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