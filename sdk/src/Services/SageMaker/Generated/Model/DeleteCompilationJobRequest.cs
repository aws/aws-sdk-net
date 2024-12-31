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
    /// Container for the parameters to the DeleteCompilationJob operation.
    /// Deletes the specified compilation job. This action deletes only the compilation job
    /// resource in Amazon SageMaker AI. It doesn't delete other resources that are related
    /// to that job, such as the model artifacts that the job creates, the compilation logs
    /// in CloudWatch, the compiled model, or the IAM role.
    /// 
    ///  
    /// <para>
    /// You can delete a compilation job only if its current status is <c>COMPLETED</c>, <c>FAILED</c>,
    /// or <c>STOPPED</c>. If the job status is <c>STARTING</c> or <c>INPROGRESS</c>, stop
    /// the job, and then delete it after its status becomes <c>STOPPED</c>.
    /// </para>
    /// </summary>
    public partial class DeleteCompilationJobRequest : AmazonSageMakerRequest
    {
        private string _compilationJobName;

        /// <summary>
        /// Gets and sets the property CompilationJobName. 
        /// <para>
        /// The name of the compilation job to delete.
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