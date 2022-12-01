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
    /// Container for the parameters to the ListBuilds operation.
    /// Retrieves build resources for all builds associated with the Amazon Web Services account
    /// in use. You can limit results to builds that are in a specific status by using the
    /// <code>Status</code> parameter. Use the pagination parameters to retrieve results in
    /// a set of sequential pages. 
    /// 
    ///  <note> 
    /// <para>
    /// Build resources are not listed in any particular order.
    /// </para>
    ///  </note> 
    /// <para>
    ///  <b>Learn more</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/gamelift-build-intro.html">
    /// Upload a Custom Server Build</a> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class ListBuildsRequest : AmazonGameLiftRequest
    {
        private int? _limit;
        private string _nextToken;
        private BuildStatus _status;

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
        /// A token that indicates the start of the next sequential page of results. Use the token
        /// that is returned with a previous call to this operation. To start at the beginning
        /// of the result set, do not specify a value.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Build status to filter results by. To retrieve all builds, leave this parameter empty.
        /// </para>
        ///  
        /// <para>
        /// Possible build statuses include the following:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>INITIALIZED</b> -- A new build has been defined, but no files have been uploaded.
        /// You cannot create fleets for builds that are in this status. When a build is successfully
        /// created, the build status is set to this value. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>READY</b> -- The game build has been successfully uploaded. You can now create
        /// new fleets for this build.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>FAILED</b> -- The game build upload failed. You cannot create new fleets for this
        /// build. 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public BuildStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}