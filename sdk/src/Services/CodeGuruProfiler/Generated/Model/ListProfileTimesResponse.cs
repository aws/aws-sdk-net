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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
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
namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The structure representing the listProfileTimesResponse.
    /// </summary>
    public partial class ListProfileTimesResponse : AmazonWebServiceResponse
    {
        private string _nextToken;
        private List<ProfileTime> _profileTimes = AWSConfigs.InitializeCollections ? new List<ProfileTime>() : null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <c>nextToken</c> value to include in a future <c>ListProfileTimes</c> request.
        /// When the results of a <c>ListProfileTimes</c> request exceed <c>maxResults</c>, this
        /// value can be used to retrieve the next page of results. This value is <c>null</c>
        /// when there are no more results to return. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ProfileTimes. 
        /// <para>
        /// The list of start times of the available profiles for the aggregation period in the
        /// specified time range. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ProfileTime> ProfileTimes
        {
            get { return this._profileTimes; }
            set { this._profileTimes = value; }
        }

        // Check to see if ProfileTimes property is set
        internal bool IsSetProfileTimes()
        {
            return this._profileTimes != null && (this._profileTimes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}