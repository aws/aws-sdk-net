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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The part of a profile that contains a recommendation found during analysis.
    /// </summary>
    public partial class Match
    {
        /// <summary>
        /// Gets and sets the property FrameAddress. 
        /// <para>
        /// The location in the profiling graph that contains a recommendation found during analysis.
        /// </para>
        /// </summary>
        public string FrameAddress { get; set; }

        /// <summary>
        /// Checks to see if the FrameAddress property is set.
        /// </summary>
        internal bool IsSetFrameAddress() => this.FrameAddress != null;

        /// <summary>
        /// Gets and sets the property TargetFramesIndex. 
        /// <para>
        /// The target frame that triggered a match.
        /// </para>
        /// </summary>
        public int? TargetFramesIndex { get; set; }

        /// <summary>
        /// Checks to see if the TargetFramesIndex property is set.
        /// </summary>
        internal bool IsSetTargetFramesIndex() => this.TargetFramesIndex.HasValue;

        /// <summary>
        /// Gets and sets the property ThresholdBreachValue. 
        /// <para>
        /// The value in the profile data that exceeded the recommendation threshold.
        /// </para>
        /// </summary>
        public double? ThresholdBreachValue { get; set; }

        /// <summary>
        /// Checks to see if the ThresholdBreachValue property is set.
        /// </summary>
        internal bool IsSetThresholdBreachValue() => this.ThresholdBreachValue.HasValue;
    }
}
