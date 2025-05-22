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
    /// Details for where to store the optimized model that you create with the optimization
    /// job.
    /// </summary>
    public partial class OptimizationJobOutputConfig
    {
        private string _kmsKeyId;
        private string _s3OutputLocation;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Resource Name (ARN) of a key in Amazon Web Services KMS. SageMaker uses
        /// they key to encrypt the artifacts of the optimized model when SageMaker uploads the
        /// model to Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string KmsKeyId
        {
            get { return this._kmsKeyId; }
            set { this._kmsKeyId = value; }
        }

        // Check to see if KmsKeyId property is set
        internal bool IsSetKmsKeyId()
        {
            return this._kmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputLocation. 
        /// <para>
        /// The Amazon S3 URI for where to store the optimized model that you create with an optimization
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1024)]
        public string S3OutputLocation
        {
            get { return this._s3OutputLocation; }
            set { this._s3OutputLocation = value; }
        }

        // Check to see if S3OutputLocation property is set
        internal bool IsSetS3OutputLocation()
        {
            return this._s3OutputLocation != null;
        }

    }
}