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
    /// <note> 
    /// <para>
    /// This data type is intended for use exclusively by SageMaker Canvas and cannot be used
    /// in other contexts at the moment.
    /// 
    ///  </note> 
    /// <para>
    /// Specifies the compute configuration for the EMR Serverless job.
    /// </para>
    /// 
    /// </para>
    /// </summary>
    public partial class EmrServerlessComputeConfig
    {
        private string _executionRoleARN;

        /// <summary>
        /// Gets and sets the property ExecutionRoleARN. 
        /// <para>
        /// The ARN of the IAM role granting the AutoML job V2 the necessary permissions access
        /// policies to list, connect to, or manage EMR Serverless jobs. For detailed information
        /// about the required permissions of this role, see "How to configure AutoML to initiate
        /// a remote job on EMR Serverless for large datasets" in <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-automate-model-development-create-experiment.html">Create
        /// a regression or classification job for tabular data using the AutoML API</a> or <a
        /// href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-create-experiment-timeseries-forecasting.html#timeseries-forecasting-api-optional-params">Create
        /// an AutoML job for time-series forecasting using the API</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ExecutionRoleARN
        {
            get { return this._executionRoleARN; }
            set { this._executionRoleARN = value; }
        }

        // Check to see if ExecutionRoleARN property is set
        internal bool IsSetExecutionRoleARN()
        {
            return this._executionRoleARN != null;
        }

    }
}