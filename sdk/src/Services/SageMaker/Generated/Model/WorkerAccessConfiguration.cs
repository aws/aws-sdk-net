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
    /// Use this optional parameter to constrain access to an Amazon S3 resource based on
    /// the IP address using supported IAM global condition keys. The Amazon S3 resource is
    /// accessed in the worker portal using a Amazon S3 presigned URL.
    /// </summary>
    public partial class WorkerAccessConfiguration
    {
        private S3Presign _s3Presign;

        /// <summary>
        /// Gets and sets the property S3Presign. 
        /// <para>
        /// Defines any Amazon S3 resource constraints.
        /// </para>
        /// </summary>
        public S3Presign S3Presign
        {
            get { return this._s3Presign; }
            set { this._s3Presign = value; }
        }

        // Check to see if S3Presign property is set
        internal bool IsSetS3Presign()
        {
            return this._s3Presign != null;
        }

    }
}