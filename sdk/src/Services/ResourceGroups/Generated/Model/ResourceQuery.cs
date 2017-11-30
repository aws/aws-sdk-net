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
        /// The type of the query. The valid value in this release is <code>TAG_FILTERS_1_0</code>.
        /// </para>
        ///  
        /// <para>
        ///  <i> <code>TAG_FILTERS_1_0:</code> </i> A JSON syntax that lets you specify a collection
        /// of simple tag filters for resource types and tags, as supported by the AWS Tagging
        /// API GetResources operation. When more than one element is present, only resources
        /// that match all filters are part of the result. If a filter specifies more than one
        /// value for a key, a resource matches the filter if its tag value matches any of the
        /// specified values.
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