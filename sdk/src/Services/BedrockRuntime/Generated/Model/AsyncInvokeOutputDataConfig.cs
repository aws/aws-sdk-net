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
 * Do not modify this file. This file is generated from the bedrock-runtime-2023-09-30.normal.json service model.
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
namespace Amazon.BedrockRuntime.Model
{
    /// <summary>
    /// Asynchronous invocation output data settings.
    /// </summary>
    public partial class AsyncInvokeOutputDataConfig
    {
        private AsyncInvokeS3OutputDataConfig _s3OutputDataConfig;

        /// <summary>
        /// Gets and sets the property S3OutputDataConfig. 
        /// <para>
        /// A storage location for the output data in an S3 bucket
        /// </para>
        /// </summary>
        public AsyncInvokeS3OutputDataConfig S3OutputDataConfig
        {
            get { return this._s3OutputDataConfig; }
            set { this._s3OutputDataConfig = value; }
        }

        // Check to see if S3OutputDataConfig property is set
        internal bool IsSetS3OutputDataConfig()
        {
            return this._s3OutputDataConfig != null;
        }

    }
}