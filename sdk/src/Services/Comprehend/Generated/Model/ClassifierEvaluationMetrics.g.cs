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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// Describes the result metrics for the test data associated with an documentation classifier.
    /// </summary>
    public partial class ClassifierEvaluationMetrics
    {
        /// <summary>
        /// Gets and sets the property Accuracy. 
        /// <para>
        /// The fraction of the labels that were correct recognized. It is computed by dividing
        /// the number of labels in the test documents that were correctly recognized by the total
        /// number of labels in the test documents.
        /// </para>
        /// </summary>
        public double? Accuracy { get; set; }

        /// <summary>
        /// Checks to see if the Accuracy property is set.
        /// </summary>
        internal bool IsSetAccuracy() => this.Accuracy.HasValue;

        /// <summary>
        /// Gets and sets the property F1Score. 
        /// <para>
        /// A measure of how accurate the classifier results are for the test data. It is derived
        /// from the <c>Precision</c> and <c>Recall</c> values. The <c>F1Score</c> is the harmonic
        /// average of the two scores. The highest score is 1, and the worst score is 0. 
        /// </para>
        /// </summary>
        public double? F1Score { get; set; }

        /// <summary>
        /// Checks to see if the F1Score property is set.
        /// </summary>
        internal bool IsSetF1Score() => this.F1Score.HasValue;

        /// <summary>
        /// Gets and sets the property HammingLoss. 
        /// <para>
        /// Indicates the fraction of labels that are incorrectly predicted. Also seen as the
        /// fraction of wrong labels compared to the total number of labels. Scores closer to
        /// zero are better.
        /// </para>
        /// </summary>
        public double? HammingLoss { get; set; }

        /// <summary>
        /// Checks to see if the HammingLoss property is set.
        /// </summary>
        internal bool IsSetHammingLoss() => this.HammingLoss.HasValue;

        /// <summary>
        /// Gets and sets the property MicroF1Score. 
        /// <para>
        /// A measure of how accurate the classifier results are for the test data. It is a combination
        /// of the <c>Micro Precision</c> and <c>Micro Recall</c> values. The <c>Micro F1Score</c>
        /// is the harmonic mean of the two scores. The highest score is 1, and the worst score
        /// is 0.
        /// </para>
        /// </summary>
        public double? MicroF1Score { get; set; }

        /// <summary>
        /// Checks to see if the MicroF1Score property is set.
        /// </summary>
        internal bool IsSetMicroF1Score() => this.MicroF1Score.HasValue;

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
        public double? MicroPrecision { get; set; }

        /// <summary>
        /// Checks to see if the MicroPrecision property is set.
        /// </summary>
        internal bool IsSetMicroPrecision() => this.MicroPrecision.HasValue;

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
        public double? MicroRecall { get; set; }

        /// <summary>
        /// Checks to see if the MicroRecall property is set.
        /// </summary>
        internal bool IsSetMicroRecall() => this.MicroRecall.HasValue;

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// A measure of the usefulness of the classifier results in the test data. High precision
        /// means that the classifier returned substantially more relevant results than irrelevant
        /// ones.
        /// </para>
        /// </summary>
        public double? Precision { get; set; }

        /// <summary>
        /// Checks to see if the Precision property is set.
        /// </summary>
        internal bool IsSetPrecision() => this.Precision.HasValue;

        /// <summary>
        /// Gets and sets the property Recall. 
        /// <para>
        /// A measure of how complete the classifier results are for the test data. High recall
        /// means that the classifier returned most of the relevant results. 
        /// </para>
        /// </summary>
        public double? Recall { get; set; }

        /// <summary>
        /// Checks to see if the Recall property is set.
        /// </summary>
        internal bool IsSetRecall() => this.Recall.HasValue;
    }
}
