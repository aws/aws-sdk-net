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
 * Do not modify this file. This file is generated from the config-2014-10-17.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the GetResourceConfigHistory operation.
    /// Returns a list of configuration items for the specified resource. The list contains
    /// details about each state of the resource during the specified time interval. You can
    /// specify a <code>limit</code> on the number of results returned on the page. If a limit
    /// is specified, a <code>nextToken</code> is returned as part of the result that you
    /// can use to continue this request. 
    /// 
    ///  <note> 
    /// <para>
    /// Each call to the API is limited to span a duration of seven days. It is likely that
    /// the number of records returned is smaller than the specified <code>limit</code>. In
    /// such cases, you can make another call, using the <code>nextToken</code> .
    /// </para>
    ///  </note>
    /// </summary>
    public partial class GetResourceConfigHistoryRequest : AmazonConfigServiceRequest
    {
        private ChronologicalOrder _chronologicalOrder;
        private DateTime? _earlierTime;
        private DateTime? _laterTime;
        private int? _limit;
        private string _nextToken;
        private string _resourceId;
        private ResourceType _resourceType;

        /// <summary>
        /// Gets and sets the property ChronologicalOrder. 
        /// <para>
        /// The chronological order for configuration items listed. By default the results are
        /// listed in reverse chronological order.
        /// </para>
        /// </summary>
        public ChronologicalOrder ChronologicalOrder
        {
            get { return this._chronologicalOrder; }
            set { this._chronologicalOrder = value; }
        }

        // Check to see if ChronologicalOrder property is set
        internal bool IsSetChronologicalOrder()
        {
            return this._chronologicalOrder != null;
        }

        /// <summary>
        /// Gets and sets the property EarlierTime. 
        /// <para>
        /// The time stamp that indicates an earlier time. If not specified, the action returns
        /// paginated results that contain configuration items that start from when the first
        /// configuration item was recorded.
        /// </para>
        /// </summary>
        public DateTime EarlierTime
        {
            get { return this._earlierTime.GetValueOrDefault(); }
            set { this._earlierTime = value; }
        }

        // Check to see if EarlierTime property is set
        internal bool IsSetEarlierTime()
        {
            return this._earlierTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LaterTime. 
        /// <para>
        /// The time stamp that indicates a later time. If not specified, current time is taken.
        /// </para>
        /// </summary>
        public DateTime LaterTime
        {
            get { return this._laterTime.GetValueOrDefault(); }
            set { this._laterTime = value; }
        }

        // Check to see if LaterTime property is set
        internal bool IsSetLaterTime()
        {
            return this._laterTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Limit. 
        /// <para>
        /// The maximum number of configuration items returned in each page. The default is 10.
        /// You cannot specify a limit greater than 100.
        /// </para>
        /// </summary>
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
        /// An optional parameter used for pagination of the results. 
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
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource (for example., <code>sg-xxxxxx</code>).
        /// </para>
        /// </summary>
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The resource type.
        /// </para>
        /// </summary>
        public ResourceType ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}