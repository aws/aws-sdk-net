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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The location of artifacts for an AutoML candidate job.
    /// </summary>
    public partial class CandidateArtifactLocations
    {
        private string _backtestResults;
        private string _explainability;
        private string _modelInsights;

        /// <summary>
        /// Gets and sets the property BacktestResults. 
        /// <para>
        /// The Amazon S3 prefix to the accuracy metrics and the inference results observed over
        /// the testing window. Available only for the time-series forecasting problem type.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string BacktestResults
        {
            get { return this._backtestResults; }
            set { this._backtestResults = value; }
        }

        // Check to see if BacktestResults property is set
        internal bool IsSetBacktestResults()
        {
            return this._backtestResults != null;
        }

        /// <summary>
        /// Gets and sets the property Explainability. 
        /// <para>
        /// The Amazon S3 prefix to the explainability artifacts generated for the AutoML candidate.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string Explainability
        {
            get { return this._explainability; }
            set { this._explainability = value; }
        }

        // Check to see if Explainability property is set
        internal bool IsSetExplainability()
        {
            return this._explainability != null;
        }

        /// <summary>
        /// Gets and sets the property ModelInsights. 
        /// <para>
        /// The Amazon S3 prefix to the model insight artifacts generated for the AutoML candidate.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ModelInsights
        {
            get { return this._modelInsights; }
            set { this._modelInsights = value; }
        }

        // Check to see if ModelInsights property is set
        internal bool IsSetModelInsights()
        {
            return this._modelInsights != null;
        }

    }
}