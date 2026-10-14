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
    /// The output configuration for an AI benchmark job.
    /// </summary>
    public partial class AIBenchmarkOutputConfig
    {
        /// <summary>
        /// Gets and sets the property MlflowConfig. 
        /// <para>
        /// The MLflow tracking configuration for the job. If you don't specify this parameter,
        /// MLflow tracking is disabled.
        /// </para>
        /// </summary>
        public AIMlflowConfig MlflowConfig { get; set; }

        /// <summary>
        /// Checks to see if the MlflowConfig property is set.
        /// </summary>
        internal bool IsSetMlflowConfig() => this.MlflowConfig != null;

        /// <summary>
        /// Gets and sets the property S3OutputLocation. 
        /// <para>
        /// The Amazon S3 URI where benchmark results are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string S3OutputLocation { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputLocation property is set.
        /// </summary>
        internal bool IsSetS3OutputLocation() => this.S3OutputLocation != null;
    }
}
