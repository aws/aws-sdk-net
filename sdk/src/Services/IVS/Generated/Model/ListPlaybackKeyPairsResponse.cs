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
 * Do not modify this file. This file is generated from the ivs-2020-07-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IVS.Model
{
    /// <summary>
    /// This is the response object from the ListPlaybackKeyPairs operation.
    /// </summary>
    public partial class ListPlaybackKeyPairsResponse : AmazonWebServiceResponse
    {
        private List<PlaybackKeyPairSummary> _keyPairs = new List<PlaybackKeyPairSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property KeyPairs. 
        /// <para>
        /// List of key pairs.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<PlaybackKeyPairSummary> KeyPairs
        {
            get { return this._keyPairs; }
            set { this._keyPairs = value; }
        }

        // Check to see if KeyPairs property is set
        internal bool IsSetKeyPairs()
        {
            return this._keyPairs != null && this._keyPairs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are more key pairs than <code>maxResults</code>, use <code>nextToken</code>
        /// in the request to get the next set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
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