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

namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// Filters for the technical segments returned by <a>GetSegmentDetection</a>. For more
    /// information, see <a>StartSegmentDetectionFilters</a>.
    /// </summary>
    public partial class StartTechnicalCueDetectionFilter
    {
        /// <summary>
        /// Gets and sets the property BlackFrame. 
        /// <para>
        ///  A filter that allows you to control the black frame detection by specifying the black
        /// levels and pixel coverage of black pixels in a frame. Videos can come from multiple
        /// sources, formats, and time periods, with different standards and varying noise levels
        /// for black frames that need to be accounted for. 
        /// </para>
        /// </summary>
        public BlackFrame BlackFrame { get; set; }

        /// <summary>
        /// Checks to see if the BlackFrame property is set.
        /// </summary>
        internal bool IsSetBlackFrame() => this.BlackFrame != null;

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
        /// If you don't specify <c>MinSegmentConfidence</c>, <c>GetSegmentDetection</c> returns
        /// segments with confidence values greater than or equal to 50 percent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 50, Max = 100)]
        public float? MinSegmentConfidence { get; set; }

        /// <summary>
        /// Checks to see if the MinSegmentConfidence property is set.
        /// </summary>
        internal bool IsSetMinSegmentConfidence() => this.MinSegmentConfidence.HasValue;
    }
}
