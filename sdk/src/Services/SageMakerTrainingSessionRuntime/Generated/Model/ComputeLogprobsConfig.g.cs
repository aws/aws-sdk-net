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
    /// The configuration for computing log-probabilities of prompt tokens without generating
    /// new text.
    /// </summary>
    public partial class ComputeLogprobsConfig
    {
        /// <summary>
        /// Gets and sets the property ModelPackageArn. 
        /// <para>
        /// The ARN of the model package whose checkpoint this operation should run against. Must
        /// be a valid SageMaker model package ARN in the format <c>arn:aws:sagemaker:REGION:ACCOUNT:model-package/PACKAGE_NAME/VERSION</c>.
        /// When absent, the operation runs against the session's latest checkpoint.
        /// </para>
        /// </summary>
        public string ModelPackageArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageArn property is set.
        /// </summary>
        internal bool IsSetModelPackageArn() => this.ModelPackageArn != null;

        /// <summary>
        /// Gets and sets the property Prompt. 
        /// <para>
        /// The input prompt whose token log-probabilities will be computed.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Sensitive = true)]
        public ModelInput Prompt { get; set; }

        /// <summary>
        /// Checks to see if the Prompt property is set.
        /// </summary>
        internal bool IsSetPrompt() => this.Prompt != null;
    }
}
