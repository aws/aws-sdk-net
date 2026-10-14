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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Contains metrics captured from a model.
    /// </summary>
    public partial class ModelMetrics
    {
        /// <summary>
        /// Gets and sets the property Bias. 
        /// <para>
        /// Metrics that measure bias in a model.
        /// </para>
        /// </summary>
        public Bias Bias { get; set; }

        /// <summary>
        /// Checks to see if the Bias property is set.
        /// </summary>
        internal bool IsSetBias() => this.Bias != null;

        /// <summary>
        /// Gets and sets the property Explainability. 
        /// <para>
        /// Metrics that help explain a model.
        /// </para>
        /// </summary>
        public Explainability Explainability { get; set; }

        /// <summary>
        /// Checks to see if the Explainability property is set.
        /// </summary>
        internal bool IsSetExplainability() => this.Explainability != null;

        /// <summary>
        /// Gets and sets the property ModelDataQuality. 
        /// <para>
        /// Metrics that measure the quality of the input data for a model.
        /// </para>
        /// </summary>
        public ModelDataQuality ModelDataQuality { get; set; }

        /// <summary>
        /// Checks to see if the ModelDataQuality property is set.
        /// </summary>
        internal bool IsSetModelDataQuality() => this.ModelDataQuality != null;

        /// <summary>
        /// Gets and sets the property ModelQuality. 
        /// <para>
        /// Metrics that measure the quality of a model.
        /// </para>
        /// </summary>
        public ModelQuality ModelQuality { get; set; }

        /// <summary>
        /// Checks to see if the ModelQuality property is set.
        /// </summary>
        internal bool IsSetModelQuality() => this.ModelQuality != null;
    }
}
