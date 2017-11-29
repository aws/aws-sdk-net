/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Provides information about the location that is configured for storing model artifacts.
    /// </summary>
    public partial class ModelArtifacts
    {
        private string _s3ModelArtifacts;

        /// <summary>
        /// Gets and sets the property S3ModelArtifacts. 
        /// <para>
        /// The path of the S3 object that contains the model artifacts. For example, <code>s3://bucket-name/keynameprefix/model.tar.gz</code>.
        /// </para>
        /// </summary>
        public string S3ModelArtifacts
        {
            get { return this._s3ModelArtifacts; }
            set { this._s3ModelArtifacts = value; }
        }

        // Check to see if S3ModelArtifacts property is set
        internal bool IsSetS3ModelArtifacts()
        {
            return this._s3ModelArtifacts != null;
        }

    }
}