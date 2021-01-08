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
    /// This is the response object from the ListAttacks operation.
    /// </summary>
    public partial class ListAttacksResponse : AmazonWebServiceResponse
    {
        private List<AttackSummary> _attackSummaries = new List<AttackSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AttackSummaries. 
        /// <para>
        /// The attack information for the specified time range.
        /// </para>
        /// </summary>
        public List<AttackSummary> AttackSummaries
        {
            get { return this._attackSummaries; }
            set { this._attackSummaries = value; }
        }

        // Check to see if AttackSummaries property is set
        internal bool IsSetAttackSummaries()
        {
            return this._attackSummaries != null && this._attackSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token returned by a previous call to indicate that there is more data available.
        /// If not null, more results are available. Pass this value for the <code>NextMarker</code>
        /// parameter in a subsequent call to <code>ListAttacks</code> to retrieve the next set
        /// of items.
        /// </para>
        ///  
        /// <para>
        /// Shield Advanced might return the list of <a>AttackSummary</a> objects in batches smaller
        /// than the number specified by MaxResults. If there are more attack summary objects
        /// to return, Shield Advanced will always also return a <code>NextToken</code>.
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