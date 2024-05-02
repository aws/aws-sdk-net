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
    /// Container for the parameters to the SubmitFeedback operation.
    /// Sends feedback to CodeGuru Profiler about whether the anomaly detected by the analysis
    /// is useful or not.
    /// </summary>
    public partial class SubmitFeedbackRequest : AmazonCodeGuruProfilerRequest
    {
        private string _anomalyInstanceId;
        private string _comment;
        private string _profilingGroupName;
        private FeedbackType _type;

        /// <summary>
        /// Gets and sets the property AnomalyInstanceId. 
        /// <para>
        /// The universally unique identifier (UUID) of the <a href="https://docs.aws.amazon.com/codeguru/latest/profiler-api/API_AnomalyInstance.html">
        /// <c>AnomalyInstance</c> </a> object that is included in the analysis data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AnomalyInstanceId
        {
            get { return this._anomalyInstanceId; }
            set { this._anomalyInstanceId = value; }
        }

        // Check to see if AnomalyInstanceId property is set
        internal bool IsSetAnomalyInstanceId()
        {
            return this._anomalyInstanceId != null;
        }

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Optional feedback about this anomaly.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property ProfilingGroupName. 
        /// <para>
        /// The name of the profiling group that is associated with the analysis data.
        /// </para>
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
        /// Gets and sets the property Type. 
        /// <para>
        ///  The feedback tpye. Thee are two valid values, <c>Positive</c> and <c>Negative</c>.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FeedbackType Type
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