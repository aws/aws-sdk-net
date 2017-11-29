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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Container for the parameters to the ListThingGroups operation.
    /// List the thing groups in your account.
    /// </summary>
    public partial class ListThingGroupsRequest : AmazonIoTRequest
    {
        private int? _maxResults;
        private string _namePrefixFilter;
        private string _nextToken;
        private string _parentGroup;
        private bool? _recursive;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return at one time.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NamePrefixFilter. 
        /// <para>
        /// A filter that limits the results to those with the specified name prefix.
        /// </para>
        /// </summary>
        public string NamePrefixFilter
        {
            get { return this._namePrefixFilter; }
            set { this._namePrefixFilter = value; }
        }

        // Check to see if NamePrefixFilter property is set
        internal bool IsSetNamePrefixFilter()
        {
            return this._namePrefixFilter != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token used to get the next set of results, or <b>null</b> if there are no additional
        /// results.
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
        /// Gets and sets the property ParentGroup. 
        /// <para>
        /// A filter that limits the results to those with the specified parent group.
        /// </para>
        /// </summary>
        public string ParentGroup
        {
            get { return this._parentGroup; }
            set { this._parentGroup = value; }
        }

        // Check to see if ParentGroup property is set
        internal bool IsSetParentGroup()
        {
            return this._parentGroup != null;
        }

        /// <summary>
        /// Gets and sets the property Recursive. 
        /// <para>
        /// If true, return child groups as well.
        /// </para>
        /// </summary>
        public bool Recursive
        {
            get { return this._recursive.GetValueOrDefault(); }
            set { this._recursive = value; }
        }

        // Check to see if Recursive property is set
        internal bool IsSetRecursive()
        {
            return this._recursive.HasValue; 
        }

    }
}