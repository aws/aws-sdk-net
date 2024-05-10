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
 * Do not modify this file. This file is generated from the lex-models-2017-04-19.normal.json service model.
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
namespace Amazon.LexModelBuildingService.Model
{
    /// <summary>
    /// Container for the parameters to the GetBots operation.
    /// Returns bot information as follows: 
    /// 
    ///  <ul> <li> 
    /// <para>
    /// If you provide the <c>nameContains</c> field, the response includes information for
    /// the <c>$LATEST</c> version of all bots whose name contains the specified string.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you don't specify the <c>nameContains</c> field, the operation returns information
    /// about the <c>$LATEST</c> version of all of your bots.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// This operation requires permission for the <c>lex:GetBots</c> action.
    /// </para>
    /// </summary>
    public partial class GetBotsRequest : AmazonLexModelBuildingServiceRequest
    {
        private int? _maxResults;
        private string _nameContains;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of bots to return in the response that the request will return.
        /// The default is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Substring to match in bot names. A bot will be returned if any part of its name matches
        /// the substring. For example, "xyz" matches both "xyzabc" and "abcxyz."
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=50)]
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// A pagination token that fetches the next page of bots. If the response to this call
        /// is truncated, Amazon Lex returns a pagination token in the response. To fetch the
        /// next page of bots, specify the pagination token in the next request. 
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