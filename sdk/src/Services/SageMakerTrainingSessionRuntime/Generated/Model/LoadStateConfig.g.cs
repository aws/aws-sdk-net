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
    /// The configuration for loading training state from a previously saved checkpoint. This
    /// restores model weights and optionally optimizer state.
    /// </summary>
    public partial class LoadStateConfig
    {
        /// <summary>
        /// Gets and sets the property LoadOptimizer. 
        /// <para>
        /// Specifies whether to also restore the optimizer state alongside model weights. When
        /// true, optimizer state is restored to resume training from where it left off.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? LoadOptimizer { get; set; }

        /// <summary>
        /// Checks to see if the LoadOptimizer property is set.
        /// </summary>
        internal bool IsSetLoadOptimizer() => this.LoadOptimizer.HasValue;

        /// <summary>
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The ARN of the model package containing the checkpoint to load. Must be a valid SageMaker
        /// model package ARN in the format <c>arn:aws:sagemaker:REGION:ACCOUNT:model-package/PACKAGE_NAME/VERSION</c>.
        /// Model package group ARNs are not accepted.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ModelPackageArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageArn property is set.
        /// </summary>
        internal bool IsSetModelPackageArn() => this.ModelPackageArn != null;
    }
}
