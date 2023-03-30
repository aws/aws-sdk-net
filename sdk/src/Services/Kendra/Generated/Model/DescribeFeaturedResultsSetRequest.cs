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
 * Do not modify this file. This file is generated from the kendra-2019-02-03.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Kendra.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeFeaturedResultsSet operation.
    /// Gets information about a set of featured results. Features results are placed above
    /// all other results for certain queries. If there's an exact match of a query, then
    /// one or more specific documents are featured in the search results.
    /// </summary>
    public partial class DescribeFeaturedResultsSetRequest : AmazonKendraRequest
    {
        private string _featuredResultsSetId;
        private string _indexId;

        /// <summary>
        /// Gets and sets the property FeaturedResultsSetId. 
        /// <para>
        /// The identifier of the set of featured results that you want to get information on.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string FeaturedResultsSetId
        {
            get { return this._featuredResultsSetId; }
            set { this._featuredResultsSetId = value; }
        }

        // Check to see if FeaturedResultsSetId property is set
        internal bool IsSetFeaturedResultsSetId()
        {
            return this._featuredResultsSetId != null;
        }

        /// <summary>
        /// Gets and sets the property IndexId. 
        /// <para>
        /// The identifier of the index used for featuring results.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string IndexId
        {
            get { return this._indexId; }
            set { this._indexId = value; }
        }

        // Check to see if IndexId property is set
        internal bool IsSetIndexId()
        {
            return this._indexId != null;
        }

    }
}