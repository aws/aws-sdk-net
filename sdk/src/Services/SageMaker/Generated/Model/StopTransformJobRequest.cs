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
    /// Container for the parameters to the StopTransformJob operation.
    /// Stops a batch transform job.
    /// 
    ///  
    /// <para>
    /// When Amazon SageMaker receives a <c>StopTransformJob</c> request, the status of the
    /// job changes to <c>Stopping</c>. After Amazon SageMaker stops the job, the status is
    /// set to <c>Stopped</c>. When you stop a batch transform job before it is completed,
    /// Amazon SageMaker doesn't store the job's output in Amazon S3.
    /// </para>
    /// </summary>
    public partial class StopTransformJobRequest : AmazonSageMakerRequest
    {
        private string _transformJobName;

        /// <summary>
        /// Gets and sets the property TransformJobName. 
        /// <para>
        /// The name of the batch transform job to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string TransformJobName
        {
            get { return this._transformJobName; }
            set { this._transformJobName = value; }
        }

        // Check to see if TransformJobName property is set
        internal bool IsSetTransformJobName()
        {
            return this._transformJobName != null;
        }

    }
}