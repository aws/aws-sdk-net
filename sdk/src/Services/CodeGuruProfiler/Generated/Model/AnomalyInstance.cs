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
    /// The specific duration in which the metric is flagged as anomalous.
    /// </summary>
    public partial class AnomalyInstance
    {
        private DateTime? _endTime;
        private string _id;
        private DateTime? _startTime;
        private UserFeedback _userFeedback;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        ///  The end time of the period during which the metric is flagged as anomalous. This
        /// is specified using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents
        /// 1 millisecond past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        ///  The universally unique identifier (UUID) of an instance of an anomaly in a metric.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property StartTime. 
        /// <para>
        ///  The start time of the period during which the metric is flagged as anomalous. This
        /// is specified using the ISO 8601 format. For example, 2020-06-01T13:15:02.001Z represents
        /// 1 millisecond past June 1, 2020 1:15:02 PM UTC. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserFeedback. 
        /// <para>
        /// Feedback type on a specific instance of anomaly submitted by the user.
        /// </para>
        /// </summary>
        public UserFeedback UserFeedback
        {
            get { return this._userFeedback; }
            set { this._userFeedback = value; }
        }

        // Check to see if UserFeedback property is set
        internal bool IsSetUserFeedback()
        {
            return this._userFeedback != null;
        }

    }
}