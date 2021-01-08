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

namespace Amazon.CodeGuruProfiler.Model
{
    /// <summary>
    /// The frame name, metric type, and thread states. These are used to derive the value
    /// of the metric for the frame.
    /// </summary>
    public partial class FrameMetric
    {
        private string _frameName;
        private List<string> _threadStates = new List<string>();
        private MetricType _type;

        /// <summary>
        /// Gets and sets the property FrameName. 
        /// <para>
        ///  Name of the method common across the multiple occurrences of a frame in an application
        /// profile.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string FrameName
        {
            get { return this._frameName; }
            set { this._frameName = value; }
        }

        // Check to see if FrameName property is set
        internal bool IsSetFrameName()
        {
            return this._frameName != null;
        }

        /// <summary>
        /// Gets and sets the property ThreadStates. 
        /// <para>
        /// List of application runtime thread states used to get the counts for a frame a derive
        /// a metric value.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> ThreadStates
        {
            get { return this._threadStates; }
            set { this._threadStates = value; }
        }

        // Check to see if ThreadStates property is set
        internal bool IsSetThreadStates()
        {
            return this._threadStates != null && this._threadStates.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  A type of aggregation that specifies how a metric for a frame is analyzed. The supported
        /// value <code>AggregatedRelativeTotalTime</code> is an aggregation of the metric value
        /// for one frame that is calculated across the occurrences of all frames in a profile.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public MetricType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}