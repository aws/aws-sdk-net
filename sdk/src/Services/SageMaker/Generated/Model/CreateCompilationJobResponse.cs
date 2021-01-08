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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the CreateCompilationJob operation.
    /// </summary>
    public partial class CreateCompilationJobResponse : AmazonWebServiceResponse
    {
        private string _compilationJobArn;

        /// <summary>
        /// Gets and sets the property CompilationJobArn. 
        /// <para>
        /// If the action is successful, the service sends back an HTTP 200 response. Amazon SageMaker
        /// returns the following data in JSON format:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CompilationJobArn</code>: The Amazon Resource Name (ARN) of the compiled job.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string CompilationJobArn
        {
            get { return this._compilationJobArn; }
            set { this._compilationJobArn = value; }
        }

        // Check to see if CompilationJobArn property is set
        internal bool IsSetCompilationJobArn()
        {
            return this._compilationJobArn != null;
        }

    }
}