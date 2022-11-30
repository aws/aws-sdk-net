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
    /// This is the response object from the CreateModelCardExportJob operation.
    /// </summary>
    public partial class CreateModelCardExportJobResponse : AmazonWebServiceResponse
    {
        private string _modelCardExportJobArn;

        /// <summary>
        /// Gets and sets the property ModelCardExportJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model card export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
        public string ModelCardExportJobArn
        {
            get { return this._modelCardExportJobArn; }
            set { this._modelCardExportJobArn = value; }
        }

        // Check to see if ModelCardExportJobArn property is set
        internal bool IsSetModelCardExportJobArn()
        {
            return this._modelCardExportJobArn != null;
        }

    }
}