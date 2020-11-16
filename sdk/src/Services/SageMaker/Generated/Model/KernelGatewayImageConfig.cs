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
    /// The configuration for the file system and kernels in a SageMaker image running as
    /// a KernelGateway app.
    /// </summary>
    public partial class KernelGatewayImageConfig
    {
        private FileSystemConfig _fileSystemConfig;
        private List<KernelSpec> _kernelSpecs = new List<KernelSpec>();

        /// <summary>
        /// Gets and sets the property FileSystemConfig. 
        /// <para>
        /// The Amazon Elastic File System (EFS) storage configuration for a SageMaker image.
        /// </para>
        /// </summary>
        public FileSystemConfig FileSystemConfig
        {
            get { return this._fileSystemConfig; }
            set { this._fileSystemConfig = value; }
        }

        // Check to see if FileSystemConfig property is set
        internal bool IsSetFileSystemConfig()
        {
            return this._fileSystemConfig != null;
        }

        /// <summary>
        /// Gets and sets the property KernelSpecs. 
        /// <para>
        /// The specification of the Jupyter kernels in the image.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<KernelSpec> KernelSpecs
        {
            get { return this._kernelSpecs; }
            set { this._kernelSpecs = value; }
        }

        // Check to see if KernelSpecs property is set
        internal bool IsSetKernelSpecs()
        {
            return this._kernelSpecs != null && this._kernelSpecs.Count > 0; 
        }

    }
}