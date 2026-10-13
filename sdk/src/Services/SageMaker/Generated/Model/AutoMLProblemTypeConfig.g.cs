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
    /// A collection of settings specific to the problem type used to configure an AutoML
    /// job V2. There must be one and only one config of the following type.
    /// </summary>
    public partial class AutoMLProblemTypeConfig
    {
        /// <summary>
        /// Gets and sets the property ImageClassificationJobConfig. 
        /// <para>
        /// Settings used to configure an AutoML job V2 for the image classification problem type.
        /// </para>
        /// </summary>
        public ImageClassificationJobConfig ImageClassificationJobConfig { get; set; }

        /// <summary>
        /// Checks to see if the ImageClassificationJobConfig property is set.
        /// </summary>
        internal bool IsSetImageClassificationJobConfig() => this.ImageClassificationJobConfig != null;

        /// <summary>
        /// Gets and sets the property TabularJobConfig. 
        /// <para>
        /// Settings used to configure an AutoML job V2 for the tabular problem type (regression,
        /// classification).
        /// </para>
        /// </summary>
        public TabularJobConfig TabularJobConfig { get; set; }

        /// <summary>
        /// Checks to see if the TabularJobConfig property is set.
        /// </summary>
        internal bool IsSetTabularJobConfig() => this.TabularJobConfig != null;

        /// <summary>
        /// Gets and sets the property TextClassificationJobConfig. 
        /// <para>
        /// Settings used to configure an AutoML job V2 for the text classification problem type.
        /// </para>
        /// </summary>
        public TextClassificationJobConfig TextClassificationJobConfig { get; set; }

        /// <summary>
        /// Checks to see if the TextClassificationJobConfig property is set.
        /// </summary>
        internal bool IsSetTextClassificationJobConfig() => this.TextClassificationJobConfig != null;

        /// <summary>
        /// Gets and sets the property TextGenerationJobConfig. 
        /// <para>
        /// Settings used to configure an AutoML job V2 for the text generation (LLMs fine-tuning)
        /// problem type.
        /// </para>
        ///  <note> 
        /// <para>
        /// The text generation models that support fine-tuning in Autopilot are currently accessible
        /// exclusively in regions supported by Canvas. Refer to the documentation of Canvas for
        /// the <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/canvas.html">full list
        /// of its supported Regions</a>.
        /// </para>
        ///  </note>
        /// </summary>
        public TextGenerationJobConfig TextGenerationJobConfig { get; set; }

        /// <summary>
        /// Checks to see if the TextGenerationJobConfig property is set.
        /// </summary>
        internal bool IsSetTextGenerationJobConfig() => this.TextGenerationJobConfig != null;

        /// <summary>
        /// Gets and sets the property TimeSeriesForecastingJobConfig. 
        /// <para>
        /// Settings used to configure an AutoML job V2 for the time-series forecasting problem
        /// type.
        /// </para>
        /// </summary>
        public TimeSeriesForecastingJobConfig TimeSeriesForecastingJobConfig { get; set; }

        /// <summary>
        /// Checks to see if the TimeSeriesForecastingJobConfig property is set.
        /// </summary>
        internal bool IsSetTimeSeriesForecastingJobConfig() => this.TimeSeriesForecastingJobConfig != null;
    }
}
