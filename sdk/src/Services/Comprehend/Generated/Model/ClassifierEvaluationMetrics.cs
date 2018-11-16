/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Describes the result metrics for the test data associated with an documentation classifier.
    /// </summary>
    public partial class ClassifierEvaluationMetrics
    {
        private double? _accuracy;
        private double? _f1Score;
        private double? _precision;
        private double? _recall;

        /// <summary>
        /// Gets and sets the property Accuracy. 
        /// <para>
        /// The fraction of the labels that were correct recognized. It is computed by dividing
        /// the number of labels in the test documents that were correctly recognized by the total
        /// number of labels in the test documents.
        /// </para>
        /// </summary>
        public double Accuracy
        {
            get { return this._accuracy.GetValueOrDefault(); }
            set { this._accuracy = value; }
        }

        // Check to see if Accuracy property is set
        internal bool IsSetAccuracy()
        {
            return this._accuracy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property F1Score. 
        /// <para>
        /// A measure of how accurate the classifier results are for the test data. It is derived
        /// from the <code>Precision</code> and <code>Recall</code> values. The <code>F1Score</code>
        /// is the harmonic average of the two scores. The highest score is 1, and the worst score
        /// is 0. 
        /// </para>
        /// </summary>
        public double F1Score
        {
            get { return this._f1Score.GetValueOrDefault(); }
            set { this._f1Score = value; }
        }

        // Check to see if F1Score property is set
        internal bool IsSetF1Score()
        {
            return this._f1Score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// A measure of the usefulness of the classifier results in the test data. High precision
        /// means that the classifier returned substantially more relevant results than irrelevant
        /// ones.
        /// </para>
        /// </summary>
        public double Precision
        {
            get { return this._precision.GetValueOrDefault(); }
            set { this._precision = value; }
        }

        // Check to see if Precision property is set
        internal bool IsSetPrecision()
        {
            return this._precision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Recall. 
        /// <para>
        /// A measure of how complete the classifier results are for the test data. High recall
        /// means that the classifier returned most of the relevant results. 
        /// </para>
        /// </summary>
        public double Recall
        {
            get { return this._recall.GetValueOrDefault(); }
            set { this._recall = value; }
        }

        // Check to see if Recall property is set
        internal bool IsSetRecall()
        {
            return this._recall.HasValue; 
        }

    }
}