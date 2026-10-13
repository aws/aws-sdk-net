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

namespace Amazon.FraudDetector.Model
{
    /// <summary>
    /// The Online Fraud Insights (OFI) model performance metrics data points.
    /// </summary>
    public partial class OFIMetricDataPoint
    {
        /// <summary>
        /// Gets and sets the property Fpr. 
        /// <para>
        ///  The false positive rate. This is the percentage of total legitimate events that are
        /// incorrectly predicted as fraud. 
        /// </para>
        /// </summary>
        public float? Fpr { get; set; }

        /// <summary>
        /// Checks to see if the Fpr property is set.
        /// </summary>
        internal bool IsSetFpr() => this.Fpr.HasValue;

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        ///  The percentage of fraud events correctly predicted as fraudulent as compared to all
        /// events predicted as fraudulent. 
        /// </para>
        /// </summary>
        public float? Precision { get; set; }

        /// <summary>
        /// Checks to see if the Precision property is set.
        /// </summary>
        internal bool IsSetPrecision() => this.Precision.HasValue;

        /// <summary>
        /// Gets and sets the property Threshold. 
        /// <para>
        ///  The model threshold that specifies an acceptable fraud capture rate. For example,
        /// a threshold of 500 means any model score 500 or above is labeled as fraud. 
        /// </para>
        /// </summary>
        public float? Threshold { get; set; }

        /// <summary>
        /// Checks to see if the Threshold property is set.
        /// </summary>
        internal bool IsSetThreshold() => this.Threshold.HasValue;

        /// <summary>
        /// Gets and sets the property Tpr. 
        /// <para>
        ///  The true positive rate. This is the percentage of total fraud the model detects.
        /// Also known as capture rate. 
        /// </para>
        /// </summary>
        public float? Tpr { get; set; }

        /// <summary>
        /// Checks to see if the Tpr property is set.
        /// </summary>
        internal bool IsSetTpr() => this.Tpr.HasValue;
    }
}
