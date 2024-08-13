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
 * Do not modify this file. This file is generated from the comprehend-2017-11-27.normal.json service model.
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
namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Describes the result metrics for the test data associated with an documentation classifier.
    /// </summary>
    public partial class ClassifierEvaluationMetrics
    {
        private double? _accuracy;
        private double? _f1Score;
        private double? _hammingLoss;
        private double? _microF1Score;
        private double? _microPrecision;
        private double? _microRecall;
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
        public double? Accuracy
        {
            get { return this._accuracy; }
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
        /// from the <c>Precision</c> and <c>Recall</c> values. The <c>F1Score</c> is the harmonic
        /// average of the two scores. The highest score is 1, and the worst score is 0. 
        /// </para>
        /// </summary>
        public double? F1Score
        {
            get { return this._f1Score; }
            set { this._f1Score = value; }
        }

        // Check to see if F1Score property is set
        internal bool IsSetF1Score()
        {
            return this._f1Score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HammingLoss. 
        /// <para>
        /// Indicates the fraction of labels that are incorrectly predicted. Also seen as the
        /// fraction of wrong labels compared to the total number of labels. Scores closer to
        /// zero are better.
        /// </para>
        /// </summary>
        public double? HammingLoss
        {
            get { return this._hammingLoss; }
            set { this._hammingLoss = value; }
        }

        // Check to see if HammingLoss property is set
        internal bool IsSetHammingLoss()
        {
            return this._hammingLoss.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MicroF1Score. 
        /// <para>
        /// A measure of how accurate the classifier results are for the test data. It is a combination
        /// of the <c>Micro Precision</c> and <c>Micro Recall</c> values. The <c>Micro F1Score</c>
        /// is the harmonic mean of the two scores. The highest score is 1, and the worst score
        /// is 0.
        /// </para>
        /// </summary>
        public double? MicroF1Score
        {
            get { return this._microF1Score; }
            set { this._microF1Score = value; }
        }

        // Check to see if MicroF1Score property is set
        internal bool IsSetMicroF1Score()
        {
            return this._microF1Score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MicroPrecision. 
        /// <para>
        /// A measure of the usefulness of the recognizer results in the test data. High precision
        /// means that the recognizer returned substantially more relevant results than irrelevant
        /// ones. Unlike the Precision metric which comes from averaging the precision of all
        /// available labels, this is based on the overall score of all precision scores added
        /// together.
        /// </para>
        /// </summary>
        public double? MicroPrecision
        {
            get { return this._microPrecision; }
            set { this._microPrecision = value; }
        }

        // Check to see if MicroPrecision property is set
        internal bool IsSetMicroPrecision()
        {
            return this._microPrecision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MicroRecall. 
        /// <para>
        /// A measure of how complete the classifier results are for the test data. High recall
        /// means that the classifier returned most of the relevant results. Specifically, this
        /// indicates how many of the correct categories in the text that the model can predict.
        /// It is a percentage of correct categories in the text that can found. Instead of averaging
        /// the recall scores of all labels (as with Recall), micro Recall is based on the overall
        /// score of all recall scores added together.
        /// </para>
        /// </summary>
        public double? MicroRecall
        {
            get { return this._microRecall; }
            set { this._microRecall = value; }
        }

        // Check to see if MicroRecall property is set
        internal bool IsSetMicroRecall()
        {
            return this._microRecall.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// A measure of the usefulness of the classifier results in the test data. High precision
        /// means that the classifier returned substantially more relevant results than irrelevant
        /// ones.
        /// </para>
        /// </summary>
        public double? Precision
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
        /// Gets and sets the property Recall. 
        /// <para>
        /// A measure of how complete the classifier results are for the test data. High recall
        /// means that the classifier returned most of the relevant results. 
        /// </para>
        /// </summary>
        public double? Recall
        {
            get { return this._recall; }
            set { this._recall = value; }
        }

        // Check to see if Recall property is set
        internal bool IsSetRecall()
        {
            return this._recall.HasValue; 
        }

    }
}