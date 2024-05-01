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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Filters for the shot detection segments returned by <c>GetSegmentDetection</c>. For
    /// more information, see <a>StartSegmentDetectionFilters</a>.
    /// </summary>
    public partial class StartShotDetectionFilter
    {
        private float? _minSegmentConfidence;

        /// <summary>
        /// Gets and sets the property MinSegmentConfidence. 
        /// <para>
        /// Specifies the minimum confidence that Amazon Rekognition Video must have in order
        /// to return a detected segment. Confidence represents how certain Amazon Rekognition
        /// is that a segment is correctly identified. 0 is the lowest confidence. 100 is the
        /// highest confidence. Amazon Rekognition Video doesn't return any segments with a confidence
        /// level lower than this specified value.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify <c>MinSegmentConfidence</c>, the <c>GetSegmentDetection</c> returns
        /// segments with confidence values greater than or equal to 50 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=50, Max=100)]
        public float? MinSegmentConfidence
        {
            get { return this._minSegmentConfidence; }
            set { this._minSegmentConfidence = value; }
        }

        // Check to see if MinSegmentConfidence property is set
        internal bool IsSetMinSegmentConfidence()
        {
            return this._minSegmentConfidence.HasValue; 
        }

    }
}