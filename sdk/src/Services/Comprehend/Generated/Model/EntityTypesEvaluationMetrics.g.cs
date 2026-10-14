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
    /// Detailed information about the accuracy of an entity recognizer for a specific entity
    /// type.
    /// </summary>
    public partial class EntityTypesEvaluationMetrics
    {
        /// <summary>
        /// Gets and sets the property F1Score. 
        /// <para>
        /// A measure of how accurate the recognizer results are for a specific entity type in
        /// the test data. It is derived from the <c>Precision</c> and <c>Recall</c> values. The
        /// <c>F1Score</c> is the harmonic average of the two scores. The highest score is 1,
        /// and the worst score is 0. 
        /// </para>
        /// </summary>
        public double? F1Score { get; set; }

        /// <summary>
        /// Checks to see if the F1Score property is set.
        /// </summary>
        internal bool IsSetF1Score() => this.F1Score.HasValue;

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// A measure of the usefulness of the recognizer results for a specific entity type in
        /// the test data. High precision means that the recognizer returned substantially more
        /// relevant results than irrelevant ones. 
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
        /// A measure of how complete the recognizer results are for a specific entity type in
        /// the test data. High recall means that the recognizer returned most of the relevant
        /// results.
        /// </para>
        /// </summary>
        public double? Recall { get; set; }

        /// <summary>
        /// Checks to see if the Recall property is set.
        /// </summary>
        internal bool IsSetRecall() => this.Recall.HasValue;
    }
}
