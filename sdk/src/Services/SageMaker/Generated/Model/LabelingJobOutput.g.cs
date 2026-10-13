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
    /// Specifies the location of the output produced by the labeling job.
    /// </summary>
    public partial class LabelingJobOutput
    {
        /// <summary>
        /// Gets and sets the property FinalActiveLearningModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) for the most recent SageMaker model trained as part
        /// of automated data labeling. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string FinalActiveLearningModelArn { get; set; }

        /// <summary>
        /// Checks to see if the FinalActiveLearningModelArn property is set.
        /// </summary>
        internal bool IsSetFinalActiveLearningModelArn() => this.FinalActiveLearningModelArn != null;

        /// <summary>
        /// Gets and sets the property OutputDatasetS3Uri. 
        /// <para>
        /// The Amazon S3 bucket location of the manifest file for labeled data. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string OutputDatasetS3Uri { get; set; }

        /// <summary>
        /// Checks to see if the OutputDatasetS3Uri property is set.
        /// </summary>
        internal bool IsSetOutputDatasetS3Uri() => this.OutputDatasetS3Uri != null;
    }
}
