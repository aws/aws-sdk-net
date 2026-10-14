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
    /// Describes the results of a processing job. The processing output must specify exactly
    /// one of either <c>S3Output</c> or <c>FeatureStoreOutput</c> types.
    /// </summary>
    public partial class ProcessingOutput
    {
        /// <summary>
        /// Gets and sets the property AppManaged. 
        /// <para>
        /// When <c>True</c>, output operations such as data upload are managed natively by the
        /// processing job application. When <c>False</c> (default), output operations are managed
        /// by Amazon SageMaker.
        /// </para>
        /// </summary>
        public bool? AppManaged { get; set; }

        /// <summary>
        /// Checks to see if the AppManaged property is set.
        /// </summary>
        internal bool IsSetAppManaged() => this.AppManaged.HasValue;

        /// <summary>
        /// Gets and sets the property FeatureStoreOutput. 
        /// <para>
        /// Configuration for processing job outputs in Amazon SageMaker Feature Store. This processing
        /// output type is only supported when <c>AppManaged</c> is specified. 
        /// </para>
        /// </summary>
        public ProcessingFeatureStoreOutput FeatureStoreOutput { get; set; }

        /// <summary>
        /// Checks to see if the FeatureStoreOutput property is set.
        /// </summary>
        internal bool IsSetFeatureStoreOutput() => this.FeatureStoreOutput != null;

        /// <summary>
        /// Gets and sets the property OutputName. 
        /// <para>
        /// The name for the processing job output.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OutputName { get; set; }

        /// <summary>
        /// Checks to see if the OutputName property is set.
        /// </summary>
        internal bool IsSetOutputName() => this.OutputName != null;

        /// <summary>
        /// Gets and sets the property S3Output. 
        /// <para>
        /// Configuration for processing job outputs in Amazon S3.
        /// </para>
        /// </summary>
        public ProcessingS3Output S3Output { get; set; }

        /// <summary>
        /// Checks to see if the S3Output property is set.
        /// </summary>
        internal bool IsSetS3Output() => this.S3Output != null;
    }
}
