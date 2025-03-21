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
    /// Container for the parameters to the StopCompilationJob operation.
    /// Stops a model compilation job.
    /// 
    ///  
    /// <para>
    ///  To stop a job, Amazon SageMaker AI sends the algorithm the SIGTERM signal. This gracefully
    /// shuts the job down. If the job hasn't stopped, it sends the SIGKILL signal.
    /// </para>
    ///  
    /// <para>
    /// When it receives a <c>StopCompilationJob</c> request, Amazon SageMaker AI changes
    /// the <c>CompilationJobStatus</c> of the job to <c>Stopping</c>. After Amazon SageMaker
    /// stops the job, it sets the <c>CompilationJobStatus</c> to <c>Stopped</c>. 
    /// </para>
    /// </summary>
    public partial class StopCompilationJobRequest : AmazonSageMakerRequest
    {
        private string _compilationJobName;

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the model compilation job to stop.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string CompilationJobName
        {
            get { return this._compilationJobName; }
            set { this._compilationJobName = value; }
        }

        // Check to see if CompilationJobName property is set
        internal bool IsSetCompilationJobName()
        {
            return this._compilationJobName != null;
        }

    }
}