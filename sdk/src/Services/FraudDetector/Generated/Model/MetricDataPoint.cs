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
 * Do not modify this file. This file is generated from the frauddetector-2019-11-15.normal.json service model.
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
namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// Model performance metrics data points.
    /// </summary>
    public partial class MetricDataPoint
    {
        private float? _fpr;
        private float? _precision;
        private float? _threshold;
        private float? _tpr;

        /// <summary>
        /// Gets and sets the property Fpr. 
        /// <para>
        /// The false positive rate. This is the percentage of total legitimate events that are
        /// incorrectly predicted as fraud.
        /// </para>
        /// </summary>
        public float? Fpr
        {
            get { return this._fpr; }
            set { this._fpr = value; }
        }

        // Check to see if Fpr property is set
        internal bool IsSetFpr()
        {
            return this._fpr.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// The percentage of fraud events correctly predicted as fraudulent as compared to all
        /// events predicted as fraudulent.
        /// </para>
        /// </summary>
        public float? Precision
        {
            get { return this._precision; }
            set { this._precision = value; }
        }

        // Check to see if Precision property is set
        internal bool IsSetPrecision()
        {
            return this._precision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        /// The model threshold that specifies an acceptable fraud capture rate. For example,
        /// a threshold of 500 means any model score 500 or above is labeled as fraud.
        /// </para>
        /// </summary>
        public float? Threshold
        {
            get { return this._threshold; }
            set { this._threshold = value; }
        }

        // Check to see if Threshold property is set
        internal bool IsSetThreshold()
        {
            return this._threshold.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tpr. 
        /// <para>
        /// The true positive rate. This is the percentage of total fraud the model detects. Also
        /// known as capture rate.
        /// </para>
        /// </summary>
        public float? Tpr
        {
            get { return this._tpr; }
            set { this._tpr = value; }
        }

        // Check to see if Tpr property is set
        internal bool IsSetTpr()
        {
            return this._tpr.HasValue; 
        }

    }
}