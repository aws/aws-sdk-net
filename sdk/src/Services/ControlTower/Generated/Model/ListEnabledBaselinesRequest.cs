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
 * Do not modify this file. This file is generated from the controltower-2018-05-10.normal.json service model.
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
namespace Amazon.ControlTower.Model
{
    /// <summary>
    /// Container for the parameters to the ListEnabledBaselines operation.
    /// Returns a list of summaries describing <c>EnabledBaseline</c> resources. You can filter
    /// the list by the corresponding <c>Baseline</c> or <c>Target</c> of the <c>EnabledBaseline</c>
    /// resources. For usage examples, see <a href="https://docs.aws.amazon.com/controltower/latest/userguide/baseline-api-examples.html">
    /// <i>the Amazon Web Services Control Tower User Guide</i> </a>.
    /// </summary>
    public partial class ListEnabledBaselinesRequest : AmazonControlTowerRequest
    {
        private EnabledBaselineFilter _filter;
        private bool? _includeChildren;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property Filter. 
        /// <para>
        /// A filter applied on the <c>ListEnabledBaseline</c> operation. Allowed filters are
        /// <c>baselineIdentifiers</c> and <c>targetIdentifiers</c>. The filter can be applied
        /// for either, or both.
        /// </para>
        /// </summary>
        public EnabledBaselineFilter Filter
        {
            get { return this._filter; }
            set { this._filter = value; }
        }

        // Check to see if Filter property is set
        internal bool IsSetFilter()
        {
            return this._filter != null;
        }

        /// <summary>
        /// Gets and sets the property IncludeChildren. 
        /// <para>
        /// A value that can be set to include the child enabled baselines in responses. The default
        /// value is false.
        /// </para>
        /// </summary>
        public bool? IncludeChildren
        {
            get { return this._includeChildren; }
            set { this._includeChildren = value; }
        }

        // Check to see if IncludeChildren property is set
        internal bool IsSetIncludeChildren()
        {
            return this._includeChildren.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to be shown.
        /// </para>
        /// </summary>
        [AWSProperty(Min=5, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token.
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

    }
}