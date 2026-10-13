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
    /// A set of parameters that allow you to filter out certain results from your returned
    /// results.
    /// </summary>
    public partial class DetectionFilter
    {
        /// <summary>
        /// Gets and sets the property MinBoundingBoxHeight. 
        /// <para>
        /// Sets the minimum height of the word bounding box. Words with bounding box heights
        /// lesser than this value will be excluded from the result. Value is relative to the
        /// video frame height.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? MinBoundingBoxHeight { get; set; }

        /// <summary>
        /// Checks to see if the MinBoundingBoxHeight property is set.
        /// </summary>
        internal bool IsSetMinBoundingBoxHeight() => this.MinBoundingBoxHeight.HasValue;

        /// <summary>
        /// Gets and sets the property MinBoundingBoxWidth. 
        /// <para>
        /// Sets the minimum width of the word bounding box. Words with bounding boxes widths
        /// lesser than this value will be excluded from the result. Value is relative to the
        /// video frame width.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1)]
        public float? MinBoundingBoxWidth { get; set; }

        /// <summary>
        /// Checks to see if the MinBoundingBoxWidth property is set.
        /// </summary>
        internal bool IsSetMinBoundingBoxWidth() => this.MinBoundingBoxWidth.HasValue;

        /// <summary>
        /// Gets and sets the property MinConfidence. 
        /// <para>
        /// Sets the confidence of word detection. Words with detection confidence below this
        /// will be excluded from the result. Values should be between 0 and 100. The default
        /// MinConfidence is 80.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public float? MinConfidence { get; set; }

        /// <summary>
        /// Checks to see if the MinConfidence property is set.
        /// </summary>
        internal bool IsSetMinConfidence() => this.MinConfidence.HasValue;
    }
}
