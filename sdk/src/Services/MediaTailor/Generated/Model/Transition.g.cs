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
    /// Program transition configuration.
    /// </summary>
    public partial class Transition
    {
        /// <summary>
        /// Gets and sets the property DurationMillis. 
        /// <para>
        /// The duration of the live program in seconds.
        /// </para>
        /// </summary>
        public long? DurationMillis { get; set; }

        /// <summary>
        /// Checks to see if the DurationMillis property is set.
        /// </summary>
        internal bool IsSetDurationMillis() => this.DurationMillis.HasValue;

        /// <summary>
        /// Gets and sets the property RelativePosition. 
        /// <para>
        /// The position where this program will be inserted relative to the <c>RelativePosition</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public RelativePosition RelativePosition { get; set; }

        /// <summary>
        /// Checks to see if the RelativePosition property is set.
        /// </summary>
        internal bool IsSetRelativePosition() => this.RelativePosition != null;

        /// <summary>
        /// Gets and sets the property RelativeProgram. 
        /// <para>
        /// The name of the program that this program will be inserted next to, as defined by
        /// <c>RelativePosition</c>.
        /// </para>
        /// </summary>
        public string RelativeProgram { get; set; }

        /// <summary>
        /// Checks to see if the RelativeProgram property is set.
        /// </summary>
        internal bool IsSetRelativeProgram() => this.RelativeProgram != null;

        /// <summary>
        /// Gets and sets the property ScheduledStartTimeMillis. 
        /// <para>
        /// The date and time that the program is scheduled to start, in epoch milliseconds.
        /// </para>
        /// </summary>
        public long? ScheduledStartTimeMillis { get; set; }

        /// <summary>
        /// Checks to see if the ScheduledStartTimeMillis property is set.
        /// </summary>
        internal bool IsSetScheduledStartTimeMillis() => this.ScheduledStartTimeMillis.HasValue;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// Defines when the program plays in the schedule. You can set the value to <c>ABSOLUTE</c>
        /// or <c>RELATIVE</c>.
        /// </para>
        ///  
        /// <para>
        ///  <c>ABSOLUTE</c> - The program plays at a specific wall clock time. This setting can
        /// only be used for channels using the <c>LINEAR</c> <c>PlaybackMode</c>.
        /// </para>
        ///  
        /// <para>
        /// Note the following considerations when using <c>ABSOLUTE</c> transitions:
        /// </para>
        ///  
        /// <para>
        /// If the preceding program in the schedule has a duration that extends past the wall
        /// clock time, MediaTailor truncates the preceding program on a common segment boundary.
        /// </para>
        ///  
        /// <para>
        /// If there are gaps in playback, MediaTailor plays the <c>FillerSlate</c> you configured
        /// for your linear channel.
        /// </para>
        ///  
        /// <para>
        ///  <c>RELATIVE</c> - The program is inserted into the schedule either before or after
        /// a program that you specify via <c>RelativePosition</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
