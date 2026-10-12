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

namespace Amazon.SageMakerTrainingSessionRuntime.Model
{
    /// <summary>
    /// The configuration for saving model weights as a checkpoint.
    /// </summary>
    public partial class SaveWeightsConfig
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A human-readable description for the saved checkpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1024)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property MergeWeights. 
        /// <para>
        /// Specifies whether to merge LoRA adapter weights into the base model before saving.
        /// When true, the saved checkpoint contains the full merged model weights.
        /// </para>
        /// </summary>
        public bool? MergeWeights { get; set; }

        /// <summary>
        /// Checks to see if the MergeWeights property is set.
        /// </summary>
        internal bool IsSetMergeWeights() => this.MergeWeights.HasValue;
    }
}
