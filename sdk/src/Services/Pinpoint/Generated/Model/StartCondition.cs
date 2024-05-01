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
 * Do not modify this file. This file is generated from the pinpoint-2016-12-01.normal.json service model.
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
namespace Amazon.Pinpoint.Model
{
    /// <summary>
    /// Specifies the conditions for the first activity in a journey. This activity and its
    /// conditions determine which users are participants in a journey.
    /// </summary>
    public partial class StartCondition
    {
        private string _description;
        private EventStartCondition _eventStartCondition;
        private SegmentCondition _segmentStartCondition;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the condition.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EventStartCondition.
        /// </summary>
        public EventStartCondition EventStartCondition
        {
            get { return this._eventStartCondition; }
            set { this._eventStartCondition = value; }
        }

        // Check to see if EventStartCondition property is set
        internal bool IsSetEventStartCondition()
        {
            return this._eventStartCondition != null;
        }

        /// <summary>
        /// Gets and sets the property SegmentStartCondition. 
        /// <para>
        /// The segment that's associated with the first activity in the journey. This segment
        /// determines which users are participants in the journey.
        /// </para>
        /// </summary>
        public SegmentCondition SegmentStartCondition
        {
            get { return this._segmentStartCondition; }
            set { this._segmentStartCondition = value; }
        }

        // Check to see if SegmentStartCondition property is set
        internal bool IsSetSegmentStartCondition()
        {
            return this._segmentStartCondition != null;
        }

    }
}