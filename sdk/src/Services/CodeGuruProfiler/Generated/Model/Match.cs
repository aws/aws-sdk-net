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
    /// The part of a profile that contains a recommendation found during analysis.
    /// </summary>
    public partial class Match
    {
        private string _frameAddress;
        private int? _targetFramesIndex;
        private double? _thresholdBreachValue;

        /// <summary>
        /// Gets and sets the property FrameAddress. 
        /// <para>
        /// The location in the profiling graph that contains a recommendation found during analysis.
        /// </para>
        /// </summary>
        public string FrameAddress
        {
            get { return this._frameAddress; }
            set { this._frameAddress = value; }
        }

        // Check to see if FrameAddress property is set
        internal bool IsSetFrameAddress()
        {
            return this._frameAddress != null;
        }

        /// <summary>
        /// Gets and sets the property TargetFramesIndex. 
        /// <para>
        /// The target frame that triggered a match.
        /// </para>
        /// </summary>
        public int? TargetFramesIndex
        {
            get { return this._targetFramesIndex; }
            set { this._targetFramesIndex = value; }
        }

        // Check to see if TargetFramesIndex property is set
        internal bool IsSetTargetFramesIndex()
        {
            return this._targetFramesIndex.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ThresholdBreachValue. 
        /// <para>
        /// The value in the profile data that exceeded the recommendation threshold.
        /// </para>
        /// </summary>
        public double? ThresholdBreachValue
        {
            get { return this._thresholdBreachValue; }
            set { this._thresholdBreachValue = value; }
        }

        // Check to see if ThresholdBreachValue property is set
        internal bool IsSetThresholdBreachValue()
        {
            return this._thresholdBreachValue.HasValue; 
        }

    }
}