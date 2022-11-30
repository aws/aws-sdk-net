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
    /// The artifacts of the model card export job.
    /// </summary>
    public partial class ModelCardExportArtifacts
    {
        private string _s3ExportArtifacts;

        /// <summary>
        /// Gets and sets the property S3ExportArtifacts. 
        /// <para>
        /// The Amazon S3 URI of the exported model artifacts.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=1024)]
        public string S3ExportArtifacts
        {
            get { return this._s3ExportArtifacts; }
            set { this._s3ExportArtifacts = value; }
        }

        // Check to see if S3ExportArtifacts property is set
        internal bool IsSetS3ExportArtifacts()
        {
            return this._s3ExportArtifacts != null;
        }

    }
}