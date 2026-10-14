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
    /// The Amazon S3 location of a source model to optimize with an optimization job.
    /// </summary>
    public partial class OptimizationJobModelSourceS3
    {
        /// <summary>
        /// Gets and sets the property ModelAccessConfig. 
        /// <para>
        /// The access configuration settings for the source ML model for an optimization job,
        /// where you can accept the model end-user license agreement (EULA).
        /// </para>
        /// </summary>
        public OptimizationModelAccessConfig ModelAccessConfig { get; set; }

        /// <summary>
        /// Checks to see if the ModelAccessConfig property is set.
        /// </summary>
        internal bool IsSetModelAccessConfig() => this.ModelAccessConfig != null;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// An Amazon S3 URI that locates a source model to optimize with an optimization job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string S3Uri { get; set; }

        /// <summary>
        /// Checks to see if the S3Uri property is set.
        /// </summary>
        internal bool IsSetS3Uri() => this.S3Uri != null;
    }
}
