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

namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Contains custom model training parameters. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-custom-models.html">Custom
    /// models in Neptune ML</a>.
    /// </summary>
    public partial class CustomModelTrainingParameters
    {
        /// <summary>
        /// Gets and sets the property SourceS3DirectoryPath. 
        /// <para>
        /// The path to the Amazon S3 location where the Python module implementing your model
        /// is located. This must point to a valid existing Amazon S3 location that contains,
        /// at a minimum, a training script, a transform script, and a <c>model-hpo-configuration.json</c>
        /// file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceS3DirectoryPath { get; set; }

        /// <summary>
        /// Checks to see if the SourceS3DirectoryPath property is set.
        /// </summary>
        internal bool IsSetSourceS3DirectoryPath() => this.SourceS3DirectoryPath != null;

        /// <summary>
        /// Gets and sets the property TrainingEntryPointScript. 
        /// <para>
        /// The name of the entry point in your module of a script that performs model training
        /// and takes hyperparameters as command-line arguments, including fixed hyperparameters.
        /// The default is <c>training.py</c>.
        /// </para>
        /// </summary>
        public string TrainingEntryPointScript { get; set; }

        /// <summary>
        /// Checks to see if the TrainingEntryPointScript property is set.
        /// </summary>
        internal bool IsSetTrainingEntryPointScript() => this.TrainingEntryPointScript != null;

        /// <summary>
        /// Gets and sets the property TransformEntryPointScript. 
        /// <para>
        /// The name of the entry point in your module of a script that should be run after the
        /// best model from the hyperparameter search has been identified, to compute the model
        /// artifacts necessary for model deployment. It should be able to run with no command-line
        /// arguments.The default is <c>transform.py</c>.
        /// </para>
        /// </summary>
        public string TransformEntryPointScript { get; set; }

        /// <summary>
        /// Checks to see if the TransformEntryPointScript property is set.
        /// </summary>
        internal bool IsSetTransformEntryPointScript() => this.TransformEntryPointScript != null;
    }
}
