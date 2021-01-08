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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// The prediction results from a call to <a>DetectAnomalies</a>.
    /// </summary>
    public partial class DetectAnomalyResult
    {
        private float? _confidence;
        private bool? _isAnomalous;
        private ImageSource _source;

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence that Amazon Lookout for Vision has in the accuracy of the prediction.
        /// </para>
        /// </summary>
        public float Confidence
        {
            get { return this._confidence.GetValueOrDefault(); }
            set { this._confidence = value; }
        }

        // Check to see if Confidence property is set
        internal bool IsSetConfidence()
        {
            return this._confidence.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IsAnomalous. 
        /// <para>
        /// True if the image contains an anomaly, otherwise false.
        /// </para>
        /// </summary>
        public bool IsAnomalous
        {
            get { return this._isAnomalous.GetValueOrDefault(); }
            set { this._isAnomalous = value; }
        }

        // Check to see if IsAnomalous property is set
        internal bool IsSetIsAnomalous()
        {
            return this._isAnomalous.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Source. 
        /// <para>
        /// The source of the image that was analyzed. <code>direct</code> means that the images
        /// was supplied from the local computer. No other values are supported.
        /// </para>
        /// </summary>
        public ImageSource Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

    }
}