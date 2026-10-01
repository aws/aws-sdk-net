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
 * Do not modify this file. This file is generated from the eventbridgev2-2025-05-15.normal.json service model.
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
namespace Amazon.EventBridgeV2.Model
{
    /// <summary>
    /// Point-in-time configuration for a subscriber. Only applicable when StartingPosition
    /// is POINT_IN_TIME.
    /// </summary>
    public partial class PointInTimeConfiguration
    {
        private DateTime? _endPoint;
        private PointType _pointType;
        private DateTime? _startingPoint;

        /// <summary>
        /// Gets and sets the property EndPoint. 
        /// <para>
        /// Timestamp to stop at. Optional.
        /// </para>
        /// </summary>
        public DateTime? EndPoint
        {
            get { return this._endPoint; }
            set { this._endPoint = value; }
        }

        // Check to see if EndPoint property is set
        internal bool IsSetEndPoint()
        {
            return this._endPoint.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PointType. 
        /// <para>
        /// Whether to start from the horizon or a specific timestamp.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public PointType PointType
        {
            get { return this._pointType; }
            set { this._pointType = value; }
        }

        // Check to see if PointType property is set
        internal bool IsSetPointType()
        {
            return this._pointType != null;
        }

        /// <summary>
        /// Gets and sets the property StartingPoint. 
        /// <para>
        /// Timestamp to start from. Required when PointType is TIMESTAMP.
        /// </para>
        /// </summary>
        public DateTime? StartingPoint
        {
            get { return this._startingPoint; }
            set { this._startingPoint = value; }
        }

        // Check to see if StartingPoint property is set
        internal bool IsSetStartingPoint()
        {
            return this._startingPoint.HasValue; 
        }

    }
}