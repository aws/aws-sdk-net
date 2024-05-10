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
    /// Contains metrics captured from a model.
    /// </summary>
    public partial class ModelMetrics
    {
        private Bias _bias;
        private Explainability _explainability;
        private ModelDataQuality _modelDataQuality;
        private ModelQuality _modelQuality;

        /// <summary>
        /// Gets and sets the property Bias. 
        /// <para>
        /// Metrics that measure bias in a model.
        /// </para>
        /// </summary>
        public Bias Bias
        {
            get { return this._bias; }
            set { this._bias = value; }
        }

        // Check to see if Bias property is set
        internal bool IsSetBias()
        {
            return this._bias != null;
        }

        /// <summary>
        /// Gets and sets the property Explainability. 
        /// <para>
        /// Metrics that help explain a model.
        /// </para>
        /// </summary>
        public Explainability Explainability
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
        /// Gets and sets the property ModelDataQuality. 
        /// <para>
        /// Metrics that measure the quality of the input data for a model.
        /// </para>
        /// </summary>
        public ModelDataQuality ModelDataQuality
        {
            get { return this._modelDataQuality; }
            set { this._modelDataQuality = value; }
        }

        // Check to see if ModelDataQuality property is set
        internal bool IsSetModelDataQuality()
        {
            return this._modelDataQuality != null;
        }

        /// <summary>
        /// Gets and sets the property ModelQuality. 
        /// <para>
        /// Metrics that measure the quality of a model.
        /// </para>
        /// </summary>
        public ModelQuality ModelQuality
        {
            get { return this._modelQuality; }
            set { this._modelQuality = value; }
        }

        // Check to see if ModelQuality property is set
        internal bool IsSetModelQuality()
        {
            return this._modelQuality != null;
        }

    }
}