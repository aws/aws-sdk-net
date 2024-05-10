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
 * Do not modify this file. This file is generated from the textract-2018-06-27.normal.json service model.
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
    /// Contains information on the metrics used to evalute the peformance of a given adapter
    /// version. Includes data for baseline model performance and individual adapter version
    /// perfromance.
    /// </summary>
    public partial class AdapterVersionEvaluationMetric
    {
        private EvaluationMetric _adapterVersion;
        private EvaluationMetric _baseline;
        private FeatureType _featureType;

        /// <summary>
        /// Gets and sets the property AdapterVersion. 
        /// <para>
        /// The F1 score, precision, and recall metrics for the baseline model.
        /// </para>
        /// </summary>
        public EvaluationMetric AdapterVersion
        {
            get { return this._adapterVersion; }
            set { this._adapterVersion = value; }
        }

        // Check to see if AdapterVersion property is set
        internal bool IsSetAdapterVersion()
        {
            return this._adapterVersion != null;
        }

        /// <summary>
        /// Gets and sets the property Baseline. 
        /// <para>
        /// The F1 score, precision, and recall metrics for the baseline model.
        /// </para>
        /// </summary>
        public EvaluationMetric Baseline
        {
            get { return this._baseline; }
            set { this._baseline = value; }
        }

        // Check to see if Baseline property is set
        internal bool IsSetBaseline()
        {
            return this._baseline != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureType. 
        /// <para>
        /// Indicates the feature type being analyzed by a given adapter version.
        /// </para>
        /// </summary>
        public FeatureType FeatureType
        {
            get { return this._featureType; }
            set { this._featureType = value; }
        }

        // Check to see if FeatureType property is set
        internal bool IsSetFeatureType()
        {
            return this._featureType != null;
        }

    }
}