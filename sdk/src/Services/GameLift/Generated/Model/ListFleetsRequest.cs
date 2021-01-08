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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the ListFleets operation.
    /// Retrieves a collection of fleet resources for this AWS account. You can filter the
    /// result set to find only those fleets that are deployed with a specific build or script.
    /// Use the pagination parameters to retrieve results in sequential pages.
    /// 
    ///  <note> 
    /// <para>
    /// Fleet resources are not listed in a particular order.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/fleets-intro.html">Setting
    /// up GameLift Fleets</a> 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related operations</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>ListFleets</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteFleet</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>UpdateFleetAttributes</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>StartFleetActions</a> or <a>StopFleetActions</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListFleetsRequest : AmazonGameLiftRequest
    {
        private string _buildId;
        private int? _limit;
        private string _nextToken;
        private string _scriptId;

        /// <summary>
        /// Gets and sets the property BuildId. 
        /// <para>
        /// A unique identifier for a build to return fleets for. Use this parameter to return
        /// only fleets using a specified build. Use either the build ID or ARN value. To retrieve
        /// all fleets, do not include either a BuildId and ScriptID parameter.
        /// </para>
        /// </summary>
        public string BuildId
        {
            get { return this._buildId; }
            set { this._buildId = value; }
        }

        // Check to see if BuildId property is set
        internal bool IsSetBuildId()
        {
            return this._buildId != null;
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of results to return. Use this parameter with <code>NextToken</code>
        /// to get results as a set of sequential pages.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int Limit
        {
            get { return this._limit.GetValueOrDefault(); }
            set { this._limit = value; }
        }

        // Check to see if Limit property is set
        internal bool IsSetLimit()
        {
            return this._limit.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property ScriptId. 
        /// <para>
        /// A unique identifier for a Realtime script to return fleets for. Use this parameter
        /// to return only fleets using a specified script. Use either the script ID or ARN value.
        /// To retrieve all fleets, leave this parameter empty.
        /// </para>
        /// </summary>
        public string ScriptId
        {
            get { return this._scriptId; }
            set { this._scriptId = value; }
        }

        // Check to see if ScriptId property is set
        internal bool IsSetScriptId()
        {
            return this._scriptId != null;
        }

    }
}