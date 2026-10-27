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
    /// The evaluation metrics associated with the evaluated model.
    /// </summary>
    public partial class FlywheelModelEvaluationMetrics
    {
        /// <summary>
        /// Gets and sets the property AverageAccuracy. 
        /// <para>
        /// Average accuracy metric for the model.
        /// </para>
        /// </summary>
        public double? AverageAccuracy { get; set; }

        /// <summary>
        /// Checks to see if the AverageAccuracy property is set.
        /// </summary>
        internal bool IsSetAverageAccuracy() => this.AverageAccuracy.HasValue;

        /// <summary>
        /// Gets and sets the property AverageF1Score. 
        /// <para>
        /// The average F1 score from the evaluation metrics.
        /// </para>
        /// </summary>
        public double? AverageF1Score { get; set; }

        /// <summary>
        /// Checks to see if the AverageF1Score property is set.
        /// </summary>
        internal bool IsSetAverageF1Score() => this.AverageF1Score.HasValue;

        /// <summary>
        /// Gets and sets the property AveragePrecision. 
        /// <para>
        /// Average precision metric for the model.
        /// </para>
        /// </summary>
        public double? AveragePrecision { get; set; }

        /// <summary>
        /// Checks to see if the AveragePrecision property is set.
        /// </summary>
        internal bool IsSetAveragePrecision() => this.AveragePrecision.HasValue;

        /// <summary>
        /// Gets and sets the property AverageRecall. 
        /// <para>
        /// Average recall metric for the model.
        /// </para>
        /// </summary>
        public double? AverageRecall { get; set; }

        /// <summary>
        /// Checks to see if the AverageRecall property is set.
        /// </summary>
        internal bool IsSetAverageRecall() => this.AverageRecall.HasValue;
    }
}
