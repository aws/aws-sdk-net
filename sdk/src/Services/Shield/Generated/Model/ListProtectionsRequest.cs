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
 * Do not modify this file. This file is generated from the shield-2016-06-02.normal.json service model.
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
namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the ListProtections operation.
    /// Retrieves <a>Protection</a> objects for the account. You can retrieve all protections
    /// or you can provide filtering criteria and retrieve just the subset of protections
    /// that match the criteria.
    /// </summary>
    public partial class ListProtectionsRequest : AmazonShieldRequest
    {
        private InclusionProtectionFilters _inclusionFilters;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property InclusionFilters. 
        /// <para>
        /// Narrows the set of protections that the call retrieves. You can retrieve a single
        /// protection by providing its name or the ARN (Amazon Resource Name) of its protected
        /// resource. You can also retrieve all protections for a specific resource type. You
        /// can provide up to one criteria per filter type. Shield Advanced returns protections
        /// that exactly match all of the filter criteria that you provide.
        /// </para>
        /// </summary>
        public InclusionProtectionFilters InclusionFilters
        {
            get { return this._inclusionFilters; }
            set { this._inclusionFilters = value; }
        }

        // Check to see if InclusionFilters property is set
        internal bool IsSetInclusionFilters()
        {
            return this._inclusionFilters != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The greatest number of objects that you want Shield Advanced to return to the list
        /// request. Shield Advanced might return fewer objects than you indicate in this setting,
        /// even if more objects are available. If there are more objects remaining, Shield Advanced
        /// will always also return a <c>NextToken</c> value in the response.
        /// </para>
        ///  
        /// <para>
        /// The default setting is 20.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
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
        /// When you request a list of objects from Shield Advanced, if the response does not
        /// include all of the remaining available objects, Shield Advanced includes a <c>NextToken</c>
        /// value in the response. You can retrieve the next batch of objects by requesting the
        /// list again and providing the token that was returned by the prior call in your request.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can indicate the maximum number of objects that you want Shield Advanced to return
        /// for a single call with the <c>MaxResults</c> setting. Shield Advanced will not return
        /// more than <c>MaxResults</c> objects, but may return fewer, even if more objects are
        /// still available.
        /// </para>
        ///  
        /// <para>
        /// Whenever more objects remain that Shield Advanced has not yet returned to you, the
        /// response will include a <c>NextToken</c> value.
        /// </para>
        ///  
        /// <para>
        /// On your first call to a list operation, leave this setting empty.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4096)]
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