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
    /// Detailed information about the source of a trial component. Either <c>ProcessingJob</c>
    /// or <c>TrainingJob</c> is returned.
    /// </summary>
    public partial class TrialComponentSourceDetail
    {
        /// <summary>
        /// Gets and sets the property ProcessingJob. 
        /// <para>
        /// Information about a processing job that's the source of a trial component.
        /// </para>
        /// </summary>
        public ProcessingJob ProcessingJob { get; set; }

        /// <summary>
        /// Checks to see if the ProcessingJob property is set.
        /// </summary>
        internal bool IsSetProcessingJob() => this.ProcessingJob != null;

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SourceArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceArn property is set.
        /// </summary>
        internal bool IsSetSourceArn() => this.SourceArn != null;

        /// <summary>
        /// Gets and sets the property TrainingJob. 
        /// <para>
        /// Information about a training job that's the source of a trial component.
        /// </para>
        /// </summary>
        public TrainingJob TrainingJob { get; set; }

        /// <summary>
        /// Checks to see if the TrainingJob property is set.
        /// </summary>
        internal bool IsSetTrainingJob() => this.TrainingJob != null;

        /// <summary>
        /// Gets and sets the property TransformJob. 
        /// <para>
        /// Information about a transform job that's the source of a trial component.
        /// </para>
        /// </summary>
        public TransformJob TransformJob { get; set; }

        /// <summary>
        /// Checks to see if the TransformJob property is set.
        /// </summary>
        internal bool IsSetTransformJob() => this.TransformJob != null;
    }
}
