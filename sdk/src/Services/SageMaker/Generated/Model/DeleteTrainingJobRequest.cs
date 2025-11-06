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
    /// Container for the parameters to the DeleteTrainingJob operation.
    /// Deletes a training job. After SageMaker deletes a training job, all of the metadata
    /// for the training job is lost. You can delete only training jobs that are in a terminal
    /// state (<c>Stopped</c>, <c>Failed</c>, or <c>Completed</c>) and don't retain an <c>Available</c>
    /// <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/train-warm-pools.html">managed
    /// warm pool</a>. You cannot delete a job that is in the <c>InProgress</c> or <c>Stopping</c>
    /// state. After deleting the job, you can reuse its name to create another training job.
    /// </summary>
    public partial class DeleteTrainingJobRequest : AmazonSageMakerRequest
    {
        private string _trainingJobName;

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of the training job to delete.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string TrainingJobName
        {
            get { return this._trainingJobName; }
            set { this._trainingJobName = value; }
        }

        // Check to see if TrainingJobName property is set
        internal bool IsSetTrainingJobName()
        {
            return this._trainingJobName != null;
        }

    }
}