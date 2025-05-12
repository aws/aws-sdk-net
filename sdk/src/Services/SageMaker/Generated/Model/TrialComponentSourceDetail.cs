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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
        private ProcessingJob _processingJob;
        private string _sourceArn;
        private TrainingJob _trainingJob;
        private TransformJob _transformJob;

        /// <summary>
        /// Gets and sets the property ProcessingJob. 
        /// <para>
        /// Information about a processing job that's the source of a trial component.
        /// </para>
        /// </summary>
        public ProcessingJob ProcessingJob
        {
            get { return this._processingJob; }
            set { this._processingJob = value; }
        }

        // Check to see if ProcessingJob property is set
        internal bool IsSetProcessingJob()
        {
            return this._processingJob != null;
        }

        /// <summary>
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingJob. 
        /// <para>
        /// Information about a training job that's the source of a trial component.
        /// </para>
        /// </summary>
        public TrainingJob TrainingJob
        {
            get { return this._trainingJob; }
            set { this._trainingJob = value; }
        }

        // Check to see if TrainingJob property is set
        internal bool IsSetTrainingJob()
        {
            return this._trainingJob != null;
        }

        /// <summary>
        /// Gets and sets the property TransformJob. 
        /// <para>
        /// Information about a transform job that's the source of a trial component.
        /// </para>
        /// </summary>
        public TransformJob TransformJob
        {
            get { return this._transformJob; }
            set { this._transformJob = value; }
        }

        // Check to see if TransformJob property is set
        internal bool IsSetTransformJob()
        {
            return this._transformJob != null;
        }

    }
}