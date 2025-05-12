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
    /// Provides information about the location that is configured for storing model artifacts.
    /// 
    /// 
    ///  
    /// <para>
    /// Model artifacts are outputs that result from training a model. They typically consist
    /// of trained parameters, a model definition that describes how to compute inferences,
    /// and other metadata. A SageMaker container stores your trained model artifacts in the
    /// <c>/opt/ml/model</c> directory. After training has completed, by default, these artifacts
    /// are uploaded to your Amazon S3 bucket as compressed files.
    /// </para>
    /// </summary>
    public partial class ModelArtifacts
    {
        private string _s3ModelArtifacts;

        /// <summary>
        /// Gets and sets the property S3ModelArtifacts. 
        /// <para>
        /// The path of the S3 object that contains the model artifacts. For example, <c>s3://bucket-name/keynameprefix/model.tar.gz</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
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