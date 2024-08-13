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
    /// A set of parameters that allow you to filter out certain results from your returned
    /// results.
    /// </summary>
    public partial class DetectionFilter
    {
        private float? _minBoundingBoxHeight;
        private float? _minBoundingBoxWidth;
        private float? _minConfidence;

        /// <summary>
        /// Gets and sets the property MinBoundingBoxHeight. 
        /// <para>
        /// Sets the minimum height of the word bounding box. Words with bounding box heights
        /// lesser than this value will be excluded from the result. Value is relative to the
        /// video frame height.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float? MinBoundingBoxHeight
        {
            get { return this._minBoundingBoxHeight; }
            set { this._minBoundingBoxHeight = value; }
        }

        // Check to see if MinBoundingBoxHeight property is set
        internal bool IsSetMinBoundingBoxHeight()
        {
            return this._minBoundingBoxHeight.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinBoundingBoxWidth. 
        /// <para>
        /// Sets the minimum width of the word bounding box. Words with bounding boxes widths
        /// lesser than this value will be excluded from the result. Value is relative to the
        /// video frame width.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public float? MinBoundingBoxWidth
        {
            get { return this._minBoundingBoxWidth; }
            set { this._minBoundingBoxWidth = value; }
        }

        // Check to see if MinBoundingBoxWidth property is set
        internal bool IsSetMinBoundingBoxWidth()
        {
            return this._minBoundingBoxWidth.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MinConfidence. 
        /// <para>
        /// Sets the confidence of word detection. Words with detection confidence below this
        /// will be excluded from the result. Values should be between 0 and 100. The default
        /// MinConfidence is 80.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public float? MinConfidence
        {
            get { return this._minConfidence; }
            set { this._minConfidence = value; }
        }

        // Check to see if MinConfidence property is set
        internal bool IsSetMinConfidence()
        {
            return this._minConfidence.HasValue; 
        }

    }
}