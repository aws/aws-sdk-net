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
 * Do not modify this file. This file is generated from the resource-explorer-2-2022-07-28.normal.json service model.
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
namespace Amazon.ResourceExplorer2.Model
{
    /// <summary>
    /// Information about the number of results that match the query. At this time, Amazon
    /// Web Services Resource Explorer doesn't count more than 1,000 matches for any query.
    /// This structure provides information about whether the query exceeded this limit.
    /// 
    ///  
    /// <para>
    /// This field is included in every page when you paginate the results.
    /// </para>
    /// </summary>
    public partial class ResourceCount
    {
        private bool? _complete;
        private long? _totalResources;

        /// <summary>
        /// Gets and sets the property Complete. 
        /// <para>
        /// Indicates whether the <c>TotalResources</c> value represents an exhaustive count of
        /// search results.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// If <c>True</c>, it indicates that the search was exhaustive. Every resource that matches
        /// the query was counted.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If <c>False</c>, then the search reached the limit of 1,000 matching results, and
        /// stopped counting.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public bool? Complete
        {
            get { return this._complete; }
            set { this._complete = value; }
        }

        // Check to see if Complete property is set
        internal bool IsSetComplete()
        {
            return this._complete.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TotalResources. 
        /// <para>
        /// The number of resources that match the search query. This value can't exceed 1,000.
        /// If there are more than 1,000 resources that match the query, then only 1,000 are counted
        /// and the <c>Complete</c> field is set to false. We recommend that you refine your query
        /// to return a smaller number of results.
        /// </para>
        /// </summary>
        public long? TotalResources
        {
            get { return this._totalResources; }
            set { this._totalResources = value; }
        }

        // Check to see if TotalResources property is set
        internal bool IsSetTotalResources()
        {
            return this._totalResources.HasValue; 
        }

    }
}