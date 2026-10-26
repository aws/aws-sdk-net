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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The custom description of the condition.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EventStartCondition.
        /// </summary>
        public EventStartCondition EventStartCondition { get; set; }

        /// <summary>
        /// Checks to see if the EventStartCondition property is set.
        /// </summary>
        internal bool IsSetEventStartCondition() => this.EventStartCondition != null;

        /// <summary>
        /// Gets and sets the property SegmentStartCondition. 
        /// <para>
        /// The segment that's associated with the first activity in the journey. This segment
        /// determines which users are participants in the journey.
        /// </para>
        /// </summary>
        public SegmentCondition SegmentStartCondition { get; set; }

        /// <summary>
        /// Checks to see if the SegmentStartCondition property is set.
        /// </summary>
        internal bool IsSetSegmentStartCondition() => this.SegmentStartCondition != null;
    }
}
