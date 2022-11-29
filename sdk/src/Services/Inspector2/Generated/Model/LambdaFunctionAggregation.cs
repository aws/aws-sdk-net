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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// The details that define a findings aggregation based on AWS Lambda functions.
    /// </summary>
    public partial class LambdaFunctionAggregation
    {
        private List<StringFilter> _functionNames = new List<StringFilter>();
        private List<MapFilter> _functionTags = new List<MapFilter>();
        private List<StringFilter> _resourceIds = new List<StringFilter>();
        private List<StringFilter> _runtimes = new List<StringFilter>();
        private LambdaFunctionSortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property FunctionNames. 
        /// <para>
        /// The AWS Lambda function names to include in the aggregation results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> FunctionNames
        {
            get { return this._functionNames; }
            set { this._functionNames = value; }
        }

        // Check to see if FunctionNames property is set
        internal bool IsSetFunctionNames()
        {
            return this._functionNames != null && this._functionNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FunctionTags. 
        /// <para>
        /// The tags to include in the aggregation results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<MapFilter> FunctionTags
        {
            get { return this._functionTags; }
            set { this._functionTags = value; }
        }

        // Check to see if FunctionTags property is set
        internal bool IsSetFunctionTags()
        {
            return this._functionTags != null && this._functionTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ResourceIds. 
        /// <para>
        /// The resource IDs to include in the aggregation results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> ResourceIds
        {
            get { return this._resourceIds; }
            set { this._resourceIds = value; }
        }

        // Check to see if ResourceIds property is set
        internal bool IsSetResourceIds()
        {
            return this._resourceIds != null && this._resourceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Runtimes. 
        /// <para>
        /// Returns findings aggregated by AWS Lambda function runtime environments.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<StringFilter> Runtimes
        {
            get { return this._runtimes; }
            set { this._runtimes = value; }
        }

        // Check to see if Runtimes property is set
        internal bool IsSetRuntimes()
        {
            return this._runtimes != null && this._runtimes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The finding severity to use for sorting the results.
        /// </para>
        /// </summary>
        public LambdaFunctionSortBy SortBy
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
        /// The order to use for sorting the results.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
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