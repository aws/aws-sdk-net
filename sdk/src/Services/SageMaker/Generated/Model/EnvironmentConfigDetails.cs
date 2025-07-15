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
    /// The configuration details for the restricted instance groups (RIG) environment.
    /// </summary>
    public partial class EnvironmentConfigDetails
    {
        private FSxLustreConfig _fSxLustreConfig;
        private string _s3OutputPath;

        /// <summary>
        /// Gets and sets the property FSxLustreConfig. 
        /// <para>
        /// Configuration settings for an Amazon FSx for Lustre file system to be used with the
        /// cluster.
        /// </para>
        /// </summary>
        public FSxLustreConfig FSxLustreConfig
        {
            get { return this._fSxLustreConfig; }
            set { this._fSxLustreConfig = value; }
        }

        // Check to see if FSxLustreConfig property is set
        internal bool IsSetFSxLustreConfig()
        {
            return this._fSxLustreConfig != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// The Amazon S3 path where output data from the restricted instance group (RIG) environment
        /// will be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string S3OutputPath
        {
            get { return this._s3OutputPath; }
            set { this._s3OutputPath = value; }
        }

        // Check to see if S3OutputPath property is set
        internal bool IsSetS3OutputPath()
        {
            return this._s3OutputPath != null;
        }

    }
}