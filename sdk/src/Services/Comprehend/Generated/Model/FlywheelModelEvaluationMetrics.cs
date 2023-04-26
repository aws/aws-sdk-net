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

namespace Amazon.Comprehend.Model
{
    /// <summary>
    /// The evaluation metrics associated with the evaluated model.
    /// </summary>
    public partial class FlywheelModelEvaluationMetrics
    {
        private double? _averageAccuracy;
        private double? _averageF1Score;
        private double? _averagePrecision;
        private double? _averageRecall;

        /// <summary>
        /// Gets and sets the property AverageAccuracy. 
        /// <para>
        /// Average accuracy metric for the model.
        /// </para>
        /// </summary>
        public double AverageAccuracy
        {
            get { return this._averageAccuracy.GetValueOrDefault(); }
            set { this._averageAccuracy = value; }
        }

        // Check to see if AverageAccuracy property is set
        internal bool IsSetAverageAccuracy()
        {
            return this._averageAccuracy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AverageF1Score. 
        /// <para>
        /// The average F1 score from the evaluation metrics.
        /// </para>
        /// </summary>
        public double AverageF1Score
        {
            get { return this._averageF1Score.GetValueOrDefault(); }
            set { this._averageF1Score = value; }
        }

        // Check to see if AverageF1Score property is set
        internal bool IsSetAverageF1Score()
        {
            return this._averageF1Score.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AveragePrecision. 
        /// <para>
        /// Average precision metric for the model.
        /// </para>
        /// </summary>
        public double AveragePrecision
        {
            get { return this._averagePrecision.GetValueOrDefault(); }
            set { this._averagePrecision = value; }
        }

        // Check to see if AveragePrecision property is set
        internal bool IsSetAveragePrecision()
        {
            return this._averagePrecision.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AverageRecall. 
        /// <para>
        /// Average recall metric for the model.
        /// </para>
        /// </summary>
        public double AverageRecall
        {
            get { return this._averageRecall.GetValueOrDefault(); }
            set { this._averageRecall = value; }
        }

        // Check to see if AverageRecall property is set
        internal bool IsSetAverageRecall()
        {
            return this._averageRecall.HasValue; 
        }

    }
}