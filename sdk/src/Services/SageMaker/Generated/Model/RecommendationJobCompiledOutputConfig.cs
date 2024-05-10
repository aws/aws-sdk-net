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
    /// Provides information about the output configuration for the compiled model.
    /// </summary>
    public partial class RecommendationJobCompiledOutputConfig
    {
        private string _s3OutputUri;

        /// <summary>
        /// Gets and sets the property S3OutputUri. 
        /// <para>
        /// Identifies the Amazon S3 bucket where you want SageMaker to store the compiled model
        /// artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
        public string S3OutputUri
        {
            get { return this._s3OutputUri; }
            set { this._s3OutputUri = value; }
        }

        // Check to see if S3OutputUri property is set
        internal bool IsSetS3OutputUri()
        {
            return this._s3OutputUri != null;
        }

    }
}