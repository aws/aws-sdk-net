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
    /// Container for the parameters to the CreateModelCardExportJob operation. Creates an
    /// Amazon SageMaker Model Card export job.
    /// </summary>
    public partial class CreateModelCardExportJobRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property ModelCardExportJobName. 
        /// <para>
        /// The name of the model card export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelCardExportJobName { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardExportJobName property is set.
        /// </summary>
        internal bool IsSetModelCardExportJobName() => this.ModelCardExportJobName != null;

        /// <summary>
        /// Gets and sets the property ModelCardName. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the model card to export.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string ModelCardName { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardName property is set.
        /// </summary>
        internal bool IsSetModelCardName() => this.ModelCardName != null;

        /// <summary>
        /// Gets and sets the property ModelCardVersion. 
        /// <para>
        /// The version of the model card to export. If a version is not provided, then the latest
        /// version of the model card is exported.
        /// </para>
        /// </summary>
        public int? ModelCardVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelCardVersion property is set.
        /// </summary>
        internal bool IsSetModelCardVersion() => this.ModelCardVersion.HasValue;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The model card output configuration that specifies the Amazon S3 path for exporting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelCardExportOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;
    }
}
