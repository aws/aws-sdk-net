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
 * Do not modify this file. This file is generated from the oam-2022-06-10.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OAM.Model
{
    /// <summary>
    /// Container for the parameters to the ListAttachedLinks operation.
    /// Returns a list of source account links that are linked to this monitoring account
    /// sink.
    /// 
    ///  
    /// <para>
    /// To use this operation, provide the sink ARN. To retrieve a list of sink ARNs, use
    /// <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListSinks.html">ListSinks</a>.
    /// </para>
    ///  
    /// <para>
    /// To find a list of links for one source account, use <a href="https://docs.aws.amazon.com/OAM/latest/APIReference/API_ListLinks.html">ListLinks</a>.
    /// </para>
    /// </summary>
    public partial class ListAttachedLinksRequest : AmazonOAMRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _sinkIdentifier;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Limits the number of returned links to the specified number.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
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
        /// The token for the next set of items to return. You received this token from a previous
        /// call.
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
        /// Gets and sets the property SinkIdentifier. 
        /// <para>
        /// The ARN of the sink that you want to retrieve links for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string SinkIdentifier
        {
            get { return this._sinkIdentifier; }
            set { this._sinkIdentifier = value; }
        }

        // Check to see if SinkIdentifier property is set
        internal bool IsSetSinkIdentifier()
        {
            return this._sinkIdentifier != null;
        }

    }
}