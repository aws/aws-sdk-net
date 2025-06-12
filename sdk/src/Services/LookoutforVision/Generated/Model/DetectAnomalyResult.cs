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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// The prediction results from a call to <a>DetectAnomalies</a>. <c>DetectAnomalyResult</c>
    /// includes classification information for the prediction (<c>IsAnomalous</c> and <c>Confidence</c>).
    /// If the model you use is an image segementation model, <c>DetectAnomalyResult</c> also
    /// includes segmentation information (<c>Anomalies</c> and <c>AnomalyMask</c>). Classification
    /// information is calculated separately from segmentation information and you shouldn't
    /// assume a relationship between them.
    /// </summary>
    public partial class DetectAnomalyResult
    {
        private List<Anomaly> _anomalies = AWSConfigs.InitializeCollections ? new List<Anomaly>() : null;
        private MemoryStream _anomalyMask;
        private float? _confidence;
        private bool? _isAnomalous;
        private ImageSource _source;

        /// <summary>
        /// Gets and sets the property Anomalies. 
        /// <para>
        /// If the model is an image segmentation model, <c>Anomalies</c> contains a list of anomaly
        /// types found in the image. There is one entry for each type of anomaly found (even
        /// if multiple instances of an anomaly type exist on the image). The first element in
        /// the list is always an anomaly type representing the image background ('background')
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
        /// An image classification model doesn't return an <c>Anomalies</c> list. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Anomaly> Anomalies
        {
            get { return this._anomalies; }
            set { this._anomalies = value; }
        }

        // Check to see if Anomalies property is set
        internal bool IsSetAnomalies()
        {
            return this._anomalies != null && (this._anomalies.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property AnomalyMask. 
        /// <para>
        /// If the model is an image segmentation model, <c>AnomalyMask</c> contains pixel masks
        /// that covers all anomaly types found on the image. Each anomaly type has a different
        /// mask color. To map a color to an anomaly type, see the <c>color</c> field of the <a>PixelAnomaly</a>
        /// object.
        /// </para>
        ///  
        /// <para>
        /// An image classification model doesn't return an <c>Anomalies</c> list. 
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
        /// <c>IsAnomalous</c>.
        /// </para>
        /// </summary>
        public float? Confidence
        {
            get { return this._confidence; }
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
        public bool? IsAnomalous
        {
            get { return this._isAnomalous; }
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
        /// The source of the image that was analyzed. <c>direct</c> means that the images was
        /// supplied from the local computer. No other values are supported.
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