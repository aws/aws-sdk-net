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
    /// Provides configuration information for auto-labeling of your data objects. A <c>LabelingJobAlgorithmsConfig</c>
    /// object must be supplied in order to use auto-labeling.
    /// </summary>
    public partial class LabelingJobAlgorithmsConfig
    {
        /// <summary>
        /// Gets and sets the property InitialActiveLearningModelArn. 
        /// <para>
        /// At the end of an auto-label job Ground Truth sends the Amazon Resource Name (ARN)
        /// of the final model used for auto-labeling. You can use this model as the starting
        /// point for subsequent similar jobs by providing the ARN of the model here. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string InitialActiveLearningModelArn { get; set; }

        /// <summary>
        /// Checks to see if the InitialActiveLearningModelArn property is set.
        /// </summary>
        internal bool IsSetInitialActiveLearningModelArn() => this.InitialActiveLearningModelArn != null;

        /// <summary>
        /// Gets and sets the property LabelingJobAlgorithmSpecificationArn. 
        /// <para>
        /// Specifies the Amazon Resource Name (ARN) of the algorithm used for auto-labeling.
        /// You must select one of the following ARNs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>Image classification</i> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sagemaker:<i>region</i>:027400017018:labeling-job-algorithm-specification/image-classification</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Text classification</i> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sagemaker:<i>region</i>:027400017018:labeling-job-algorithm-specification/text-classification</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Object detection</i> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sagemaker:<i>region</i>:027400017018:labeling-job-algorithm-specification/object-detection</c>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>Semantic Segmentation</i> 
        /// </para>
        ///  
        /// <para>
        ///  <c>arn:aws:sagemaker:<i>region</i>:027400017018:labeling-job-algorithm-specification/semantic-segmentation</c>
        /// 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 2048)]
        public string LabelingJobAlgorithmSpecificationArn { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobAlgorithmSpecificationArn property is set.
        /// </summary>
        internal bool IsSetLabelingJobAlgorithmSpecificationArn() => this.LabelingJobAlgorithmSpecificationArn != null;

        /// <summary>
        /// Gets and sets the property LabelingJobResourceConfig. 
        /// <para>
        /// Provides configuration information for a labeling job.
        /// </para>
        /// </summary>
        public LabelingJobResourceConfig LabelingJobResourceConfig { get; set; }

        /// <summary>
        /// Checks to see if the LabelingJobResourceConfig property is set.
        /// </summary>
        internal bool IsSetLabelingJobResourceConfig() => this.LabelingJobResourceConfig != null;
    }
}
