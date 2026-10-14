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

namespace Amazon.Textract.Model
{
    /// <summary>
    /// The evaluation metrics (F1 score, Precision, and Recall) for an adapter version.
    /// </summary>
    public partial class EvaluationMetric
    {
        /// <summary>
        /// Gets and sets the property F1Score. 
        /// <para>
        /// The F1 score for an adapter version.
        /// </para>
        /// </summary>
        public float? F1Score { get; set; }

        /// <summary>
        /// Checks to see if the F1Score property is set.
        /// </summary>
        internal bool IsSetF1Score() => this.F1Score.HasValue;

        /// <summary>
        /// Gets and sets the property Precision. 
        /// <para>
        /// The Precision score for an adapter version.
        /// </para>
        /// </summary>
        public float? Precision { get; set; }

        /// <summary>
        /// Checks to see if the Precision property is set.
        /// </summary>
        internal bool IsSetPrecision() => this.Precision.HasValue;

        /// <summary>
        /// Gets and sets the property Recall. 
        /// <para>
        /// The Recall score for an adapter version.
        /// </para>
        /// </summary>
        public float? Recall { get; set; }

        /// <summary>
        /// Checks to see if the Recall property is set.
        /// </summary>
        internal bool IsSetRecall() => this.Recall.HasValue;
    }
}
