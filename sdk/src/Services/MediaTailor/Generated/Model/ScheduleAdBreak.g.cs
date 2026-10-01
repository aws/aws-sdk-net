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

namespace Amazon.MediaTailor.Model
{
    /// <summary>
    /// The schedule's ad break properties.
    /// </summary>
    public partial class ScheduleAdBreak
    {
        /// <summary>
        /// Gets and sets the property ApproximateDurationSeconds. 
        /// <para>
        /// The approximate duration of the ad break, in seconds.
        /// </para>
        /// </summary>
        public long? ApproximateDurationSeconds { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateDurationSeconds property is set.
        /// </summary>
        internal bool IsSetApproximateDurationSeconds() => this.ApproximateDurationSeconds.HasValue;

        /// <summary>
        /// Gets and sets the property ApproximateStartTime. 
        /// <para>
        /// The approximate time that the ad will start playing.
        /// </para>
        /// </summary>
        public DateTime? ApproximateStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ApproximateStartTime property is set.
        /// </summary>
        internal bool IsSetApproximateStartTime() => this.ApproximateStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property SourceLocationName. 
        /// <para>
        /// The name of the source location containing the VOD source used for the ad break.
        /// </para>
        /// </summary>
        public string SourceLocationName { get; set; }

        /// <summary>
        /// Checks to see if the SourceLocationName property is set.
        /// </summary>
        internal bool IsSetSourceLocationName() => this.SourceLocationName != null;

        /// <summary>
        /// Gets and sets the property VodSourceName. 
        /// <para>
        /// The name of the VOD source used for the ad break.
        /// </para>
        /// </summary>
        public string VodSourceName { get; set; }

        /// <summary>
        /// Checks to see if the VodSourceName property is set.
        /// </summary>
        internal bool IsSetVodSourceName() => this.VodSourceName != null;
    }
}
