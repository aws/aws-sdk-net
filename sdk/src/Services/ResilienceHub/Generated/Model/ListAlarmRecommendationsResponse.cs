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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
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
namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the ListAlarmRecommendations operation.
    /// </summary>
    public partial class ListAlarmRecommendationsResponse : AmazonWebServiceResponse
    {
        private List<AlarmRecommendation> _alarmRecommendations = AWSConfigs.InitializeCollections ? new List<AlarmRecommendation>() : null;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property AlarmRecommendations. 
        /// <para>
        /// The alarm recommendations for an Resilience Hub application, returned as an object.
        /// This object includes Application Component names, descriptions, information about
        /// whether a recommendation has already been implemented or not, prerequisites, and more.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<AlarmRecommendation> AlarmRecommendations
        {
            get { return this._alarmRecommendations; }
            set { this._alarmRecommendations = value; }
        }

        // Check to see if AlarmRecommendations property is set
        internal bool IsSetAlarmRecommendations()
        {
            return this._alarmRecommendations != null && (this._alarmRecommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token for the next set of results, or null if there are no more results.
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