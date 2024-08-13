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
 * Do not modify this file. This file is generated from the rekognition-2016-06-27.normal.json service model.
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
namespace Amazon.Rekognition.Model
{
    /// <summary>
    /// The evaluation results for the training of a model.
    /// </summary>
    public partial class EvaluationResult
    {
        private float? _f1Score;
        private Summary _summary;

        /// <summary>
        /// Gets and sets the property F1Score. 
        /// <para>
        /// The F1 score for the evaluation of all labels. The F1 score metric evaluates the overall
        /// precision and recall performance of the model as a single value. A higher value indicates
        /// better precision and recall performance. A lower score indicates that precision, recall,
        /// or both are performing poorly. 
        /// </para>
        /// </summary>
        public float? F1Score
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
        /// Gets and sets the property Summary. 
        /// <para>
        /// The S3 bucket that contains the training summary.
        /// </para>
        /// </summary>
        public Summary Summary
        {
            get { return this._summary; }
            set { this._summary = value; }
        }

        // Check to see if Summary property is set
        internal bool IsSetSummary()
        {
            return this._summary != null;
        }

    }
}