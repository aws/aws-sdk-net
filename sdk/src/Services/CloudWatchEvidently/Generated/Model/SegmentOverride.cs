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
 * Do not modify this file. This file is generated from the evidently-2021-02-01.normal.json service model.
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
namespace Amazon.CloudWatchEvidently.Model
{
    /// <summary>
    /// This structure specifies a segment that you have already created, and defines the
    /// traffic split for that segment to be used in a launch.
    /// </summary>
    public partial class SegmentOverride
    {
        private long? _evaluationOrder;
        private string _segment;
        private Dictionary<string, long> _weights = AWSConfigs.InitializeCollections ? new Dictionary<string, long>() : null;

        /// <summary>
        /// Gets and sets the property EvaluationOrder. 
        /// <para>
        /// A number indicating the order to use to evaluate segment overrides, if there are more
        /// than one. Segment overrides with lower numbers are evaluated first.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public long? EvaluationOrder
        {
            get { return this._evaluationOrder; }
            set { this._evaluationOrder = value; }
        }

        // Check to see if EvaluationOrder property is set
        internal bool IsSetEvaluationOrder()
        {
            return this._evaluationOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Segment. 
        /// <para>
        /// The ARN of the segment to use.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string Segment
        {
            get { return this._segment; }
            set { this._segment = value; }
        }

        // Check to see if Segment property is set
        internal bool IsSetSegment()
        {
            return this._segment != null;
        }

        /// <summary>
        /// Gets and sets the property Weights. 
        /// <para>
        /// The traffic allocation percentages among the feature variations to assign to this
        /// segment. This is a set of key-value pairs. The keys are variation names. The values
        /// represent the amount of traffic to allocate to that variation for this segment. This
        /// is expressed in thousandths of a percent, so a weight of 50000 represents 50% of traffic.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=5)]
        public Dictionary<string, long> Weights
        {
            get { return this._weights; }
            set { this._weights = value; }
        }

        // Check to see if Weights property is set
        internal bool IsSetWeights()
        {
            return this._weights != null && (this._weights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}