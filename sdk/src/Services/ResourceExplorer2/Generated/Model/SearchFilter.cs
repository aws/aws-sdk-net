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
    /// A search filter defines which resources can be part of a search query result set.
    /// </summary>
    public partial class SearchFilter
    {
        private string _filterString;

        /// <summary>
        /// Gets and sets the property FilterString. 
        /// <para>
        /// The string that contains the search keywords, prefixes, and operators to control the
        /// results that can be returned by a <a>Search</a> operation. For more details, see <a
        /// href="https://docs.aws.amazon.com/resource-explorer/latest/APIReference/about-query-syntax.html">Search
        /// query syntax</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string FilterString
        {
            get { return this._filterString; }
            set { this._filterString = value; }
        }

        // Check to see if FilterString property is set
        internal bool IsSetFilterString()
        {
            return this._filterString != null;
        }

    }
}