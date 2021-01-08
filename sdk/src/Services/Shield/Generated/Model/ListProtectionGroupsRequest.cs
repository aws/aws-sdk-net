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

namespace Amazon.Shield.Model
{
    /// <summary>
    /// Container for the parameters to the ListProtectionGroups operation.
    /// Retrieves the <a>ProtectionGroup</a> objects for the account.
    /// </summary>
    public partial class ListProtectionGroupsRequest : AmazonShieldRequest
    {
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of <a>ProtectionGroup</a> objects to return. If you leave this
        /// blank, Shield Advanced returns the first 20 results.
        /// </para>
        ///  
        /// <para>
        /// This is a maximum value. Shield Advanced might return the results in smaller batches.
        /// That is, the number of objects returned could be less than <code>MaxResults</code>,
        /// even if there are still more objects yet to return. If there are more objects to return,
        /// Shield Advanced returns a value in <code>NextToken</code> that you can use in your
        /// next request, to get the next batch of objects.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10000)]
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The next token value from a previous call to <code>ListProtectionGroups</code>. Pass
        /// null if this is the first call.
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