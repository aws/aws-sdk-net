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
 * Do not modify this file. This file is generated from the codeguruprofiler-2019-07-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// Container for the parameters to the GetProfile operation.
    /// Get the aggregated profile of a profiling group for the specified time range. If the
    /// requested time range does not align with the available aggregated profiles, it will
    /// be expanded to attain alignment. If aggregated profiles are available only for part
    /// of the period requested, the profile is returned from the earliest available to the
    /// latest within the requested time range. For instance, if the requested time range
    /// is from 00:00 to 00:20 and the available profiles are from 00:15 to 00:25, then the
    /// returned profile will be from 00:15 to 00:20.
    /// </summary>
    public partial class GetProfileRequest : AmazonCodeGuruProfilerRequest
    {
        private string _accept;
        private DateTime? _endTime;
        private int? _maxDepth;
        private string _period;
        private string _profilingGroupName;
        private DateTime? _startTime;

        /// <summary>
        /// Gets and sets the property Accept. 
        /// <para>
        /// The format of the profile to return. Supports application/json or application/x-amzn-ion.
        /// Defaults to application/x-amzn-ion.
        /// </para>
        /// </summary>
        public string Accept
        {
            get { return this._accept; }
            set { this._accept = value; }
        }

        // Check to see if Accept property is set
        internal bool IsSetAccept()
        {
            return this._accept != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The end time of the profile to get. Either period or endTime must be specified. Must
        /// be greater than start and the overall time range to be in the past and not larger
        /// than a week.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MaxDepth.
        /// </summary>
        [AWSProperty(Min=1, Max=10000)]
        public int MaxDepth
        {
            get { return this._maxDepth.GetValueOrDefault(); }
            set { this._maxDepth = value; }
        }

        // Check to see if MaxDepth property is set
        internal bool IsSetMaxDepth()
        {
            return this._maxDepth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Period. 
        /// <para>
        /// The period of the profile to get. Exactly two of <code>startTime</code>, <code>period</code>
        /// and <code>endTime</code> must be specified. Must be positive and the overall time
        /// range to be in the past and not larger than a week.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Period
        {
            get { return this._period; }
            set { this._period = value; }
        }

        // Check to see if Period property is set
        internal bool IsSetPeriod()
        {
            return this._period != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string ProfilingGroupName
        {
            get { return this._profilingGroupName; }
            set { this._profilingGroupName = value; }
        }

        // Check to see if ProfilingGroupName property is set
        internal bool IsSetProfilingGroupName()
        {
            return this._profilingGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        /// The start time of the profile to get.
        /// </para>
        /// </summary>
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