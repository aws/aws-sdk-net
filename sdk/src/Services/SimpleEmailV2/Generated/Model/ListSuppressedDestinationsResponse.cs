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
 * Do not modify this file. This file is generated from the sesv2-2019-09-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SimpleEmailV2.Model
{
    /// <summary>
    /// A list of suppressed email addresses.
    /// </summary>
    public partial class ListSuppressedDestinationsResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<SuppressedDestinationSummary> _suppressedDestinationSummaries = new List<SuppressedDestinationSummary>();

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A token that indicates that there are additional email addresses on the suppression
        /// list for your account. To view additional suppressed addresses, issue another request
        /// to <code>ListSuppressedDestinations</code>, and pass this token in the <code>NextToken</code>
        /// parameter.
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
        /// Gets and sets the property SuppressedDestinationSummaries. 
        /// <para>
        /// A list of summaries, each containing a summary for a suppressed email destination.
        /// </para>
        /// </summary>
        public List<SuppressedDestinationSummary> SuppressedDestinationSummaries
        {
            get { return this._suppressedDestinationSummaries; }
            set { this._suppressedDestinationSummaries = value; }
        }

        // Check to see if SuppressedDestinationSummaries property is set
        internal bool IsSetSuppressedDestinationSummaries()
        {
            return this._suppressedDestinationSummaries != null && this._suppressedDestinationSummaries.Count > 0; 
        }

    }
}