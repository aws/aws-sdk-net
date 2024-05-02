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
    /// Container for the parameters to the DescribeTrainingJob operation.
    /// Returns information about a training job. 
    /// 
    ///  
    /// <para>
    /// Some of the attributes below only appear if the training job successfully starts.
    /// If the training job fails, <c>TrainingJobStatus</c> is <c>Failed</c> and, depending
    /// on the <c>FailureReason</c>, attributes like <c>TrainingStartTime</c>, <c>TrainingTimeInSeconds</c>,
    /// <c>TrainingEndTime</c>, and <c>BillableTimeInSeconds</c> may not be present in the
    /// response.
    /// </para>
    /// </summary>
    public partial class DescribeTrainingJobRequest : AmazonSageMakerRequest
    {
        private string _trainingJobName;

        /// <summary>
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of the training job.
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