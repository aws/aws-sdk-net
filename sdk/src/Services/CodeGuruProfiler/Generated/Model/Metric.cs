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
    /// Details about the metric that the analysis used when it detected the anomaly. The
    /// metric what is analyzed to create recommendations. It includes the name of the frame
    /// that was analyzed and the type and thread states used to derive the metric value for
    /// that frame.
    /// </summary>
    public partial class Metric
    {
        private string _frameName;
        private List<string> _threadStates = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private MetricType _type;

        /// <summary>
        /// Gets and sets the property FrameName. 
        /// <para>
        ///  The name of the method that appears as a frame in any stack in a profile. 
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
        ///  The list of application runtime thread states that is used to calculate the metric
        /// value for the frame. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._threadStates != null && (this._threadStates.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        ///  A type that specifies how a metric for a frame is analyzed. The supported value <c>AggregatedRelativeTotalTime</c>
        /// is an aggregation of the metric value for one frame that is calculated across the
        /// occurences of all frames in a profile.
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