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
    /// This is the response object from the CreateCodeRepository operation.
    /// </summary>
    public partial class CreateCodeRepositoryResponse : AmazonWebServiceResponse
    {
        private string _codeRepositoryArn;

        /// <summary>
        /// Gets and sets the property CodeRepositoryArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the new repository.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string CodeRepositoryArn
        {
            get { return this._codeRepositoryArn; }
            set { this._codeRepositoryArn = value; }
        }

        // Check to see if CodeRepositoryArn property is set
        internal bool IsSetCodeRepositoryArn()
        {
            return this._codeRepositoryArn != null;
        }

    }
}