/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the StopHyperParameterTuningJob operation.
    /// Stops a running hyperparameter tuning job and all running training jobs that the tuning
    /// job launched.
    /// 
    ///  
    /// <para>
    /// All model artifacts output from the training jobs are stored in Amazon Simple Storage
    /// Service (Amazon S3). All data that the training jobs write toAmazon CloudWatch Logs
    /// are still available in CloudWatch. After the tuning job moves to the <code>Stopped</code>
    /// state, it releases all reserved resources for the tuning job.
    /// </para>
    /// </summary>
    public partial class StopHyperParameterTuningJobRequest : AmazonSageMakerRequest
    {
        private string _hyperParameterTuningJobName;

        /// <summary>
        /// Gets and sets the property HyperParameterTuningJobName. 
        /// <para>
        /// The name of the tuning job to stop.
        /// </para>
        /// </summary>
        public string HyperParameterTuningJobName
        {
            get { return this._hyperParameterTuningJobName; }
            set { this._hyperParameterTuningJobName = value; }
        }

        // Check to see if HyperParameterTuningJobName property is set
        internal bool IsSetHyperParameterTuningJobName()
        {
            return this._hyperParameterTuningJobName != null;
        }

    }
}