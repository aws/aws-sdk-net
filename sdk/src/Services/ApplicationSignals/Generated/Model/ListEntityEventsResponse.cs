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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// This is the response object from the ListEntityEvents operation.
    /// </summary>
    public partial class ListEntityEventsResponse : AmazonWebServiceResponse
    {
        private List<ChangeEvent> _changeEvents = AWSConfigs.InitializeCollections ? new List<ChangeEvent>() : null;
        private DateTime? _endTime;
        private string _nextToken;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property ChangeEvents. 
        /// <para>
        /// An array of structures, where each structure contains information about one change
        /// event that occurred for the specified entity during the requested time period.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=250)]
        public List<ChangeEvent> ChangeEvents
        {
            get { return this._changeEvents; }
            set { this._changeEvents = value; }
        }

        // Check to see if ChangeEvents property is set
        internal bool IsSetChangeEvents()
        {
            return this._changeEvents != null && (this._changeEvents.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end of the time period that the returned change events apply to. When used in
        /// a raw HTTP Query API, it is formatted as epoch time in seconds. For example: <c>1698778057</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Include this value in your next use of this API to get the next set of change events.
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start of the time period that the returned change events apply to. When used in
        /// a raw HTTP Query API, it is formatted as epoch time in seconds. For example: <c>1698778057</c>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartTime
        {
            get { return this._startTime.GetValueOrDefault(); }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

    }
}