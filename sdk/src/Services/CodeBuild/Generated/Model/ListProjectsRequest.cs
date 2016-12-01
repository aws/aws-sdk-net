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
 * Do not modify this file. This file is generated from the codebuild-2016-10-06.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeBuild.Model
{
    /// <summary>
    /// Container for the parameters to the ListProjects operation.
    /// Gets a list of build project names, with each build project name representing a single
    /// build project.
    /// </summary>
    public partial class ListProjectsRequest : AmazonCodeBuildRequest
    {
        private string _nextToken;
        private ProjectSortByType _sortBy;
        private SortOrderType _sortOrder;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// During a previous call, if there are more than 100 items in the list, only the first
        /// 100 items are returned, along with a unique string called a <i>next token</i>. To
        /// get the next batch of items in the list, call this operation again, adding the next
        /// token to the call. To get all of the items in the list, keep calling this operation
        /// with each subsequent next token that is returned, until no more next tokens are returned.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The criterion to be used to list build project names. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CREATED_TIME</code>: List the build project names based on when each build
        /// project was created.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>LAST_MODIFIED_TIME</code>: List the build project names based on when information
        /// about each build project was last changed.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>NAME</code>: List the build project names based on each build project's name.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use <code>sortOrder</code> to specify in what order to list the build project names
        /// based on the preceding criteria.
        /// </para>
        /// </summary>
        public ProjectSortByType SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The order in which to list build projects. Valid values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ASCENDING</code>: List the build project names in ascending order.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DESCENDING</code>: List the build project names in descending order.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Use <code>sortBy</code> to specify the criterion to be used to list build project
        /// names.
        /// </para>
        /// </summary>
        public SortOrderType SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

    }
}