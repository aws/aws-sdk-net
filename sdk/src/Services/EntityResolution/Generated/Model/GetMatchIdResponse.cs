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
 * Do not modify this file. This file is generated from the entityresolution-2018-05-10.normal.json service model.
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
namespace Amazon.EntityResolution.Model
{
    /// <summary>
    /// This is the response object from the GetMatchId operation.
    /// </summary>
    public partial class GetMatchIdResponse : AmazonWebServiceResponse
    {
        private string _matchId;
        private string _matchRule;

        /// <summary>
        /// Gets and sets the property MatchId. 
        /// <para>
        /// The unique identifiers for this group of match records.
        /// </para>
        /// </summary>
        public string MatchId
        {
            get { return this._matchId; }
            set { this._matchId = value; }
        }

        // Check to see if MatchId property is set
        internal bool IsSetMatchId()
        {
            return this._matchId != null;
        }

        /// <summary>
        /// Gets and sets the property MatchRule. 
        /// <para>
        /// The rule the record matched on.
        /// </para>
        /// </summary>
        public string MatchRule
        {
            get { return this._matchRule; }
            set { this._matchRule = value; }
        }

        // Check to see if MatchRule property is set
        internal bool IsSetMatchRule()
        {
            return this._matchRule != null;
        }

    }
}