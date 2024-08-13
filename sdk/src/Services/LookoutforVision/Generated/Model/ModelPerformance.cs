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
 * Do not modify this file. This file is generated from the lookoutvision-2020-11-20.normal.json service model.
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
namespace Amazon.LookoutforVision.Model
{
    /// <summary>
    /// Information about the evaluation performance of a trained model.
    /// </summary>
    public partial class ModelPerformance
    {
        private float? _f1Score;
        private float? _precision;
        private float? _recall;

        /// <summary>
        /// Gets and sets the property F1Score. 
        /// <para>
        /// The overall F1 score metric for the trained model.
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
        /// Gets and sets the property Precision. 
        /// <para>
        /// The overall precision metric value for the trained model.
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
        /// Gets and sets the property Recall. 
        /// <para>
        /// The overall recall metric value for the trained model. 
        /// </para>
        /// </summary>
        public float? Recall
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