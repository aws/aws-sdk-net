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
    /// The prediction results from a call to <a>DetectAnomalies</a>. <code>DetectAnomalyResult</code>
    /// includes classification information for the prediction (<code>IsAnomalous</code> and
    /// <code>Confidence</code>). If the model you use is an image segementation model, <code>DetectAnomalyResult</code>
    /// also includes segmentation information (<code>Anomalies</code> and <code>AnomalyMask</code>).
    /// Classification information is calculated separately from segmentation information
    /// and you shouldn't assume a relationship between them.
    /// </summary>
    public partial class DetectAnomalyResult
    {
        private List<Anomaly> _anomalies = new List<Anomaly>();
        private MemoryStream _anomalyMask;
        private float? _confidence;
        private bool? _isAnomalous;
        private ImageSource _source;

        /// <summary>
        /// Gets and sets the property Anomalies. 
        /// <para>
        /// If the model is an image segmentation model, <code>Anomalies</code> contains a list
        /// of anomaly types found in the image. There is one entry for each type of anomaly found
        /// (even if multiple instances of an anomaly type exist on the image). The first element
        /// in the list is always an anomaly type representing the image background ('background')
        /// and shouldn't be considered an anomaly. Amazon Lookout for Vision automatically add
        /// the background anomaly type to the response, and you don't need to declare a background
        /// anomaly type in your dataset.
        /// </para>
        ///  
        /// <para>
        /// If the list has one entry ('background'), no anomalies were found on the image.
        /// </para>
        ///   
        /// <para>
        /// An image classification model doesn't return an <code>Anomalies</code> list. 
        /// </para>
        /// </summary>
        public List<Anomaly> Anomalies
        {
            get { return this._anomalies; }
            set { this._anomalies = value; }
        }

        // Check to see if Anomalies property is set
        internal bool IsSetAnomalies()
        {
            return this._anomalies != null && this._anomalies.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AnomalyMask. 
        /// <para>
        /// If the model is an image segmentation model, <code>AnomalyMask</code> contains pixel
        /// masks that covers all anomaly types found on the image. Each anomaly type has a different
        /// mask color. To map a color to an anomaly type, see the <code>color</code> field of
        /// the <a>PixelAnomaly</a> object.
        /// </para>
        ///  
        /// <para>
        /// An image classification model doesn't return an <code>Anomalies</code> list. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5242880)]
        public MemoryStream AnomalyMask
        {
            get { return this._anomalyMask; }
            set { this._anomalyMask = value; }
        }

        // Check to see if AnomalyMask property is set
        internal bool IsSetAnomalyMask()
        {
            return this._anomalyMask != null;
        }

        /// <summary>
        /// Gets and sets the property Confidence. 
        /// <para>
        /// The confidence that Lookout for Vision has in the accuracy of the classification in
        /// <code>IsAnomalous</code>.
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
        /// True if Amazon Lookout for Vision classifies the image as containing an anomaly, otherwise
        /// false.
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