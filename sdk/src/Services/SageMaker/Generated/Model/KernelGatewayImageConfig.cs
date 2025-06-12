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
    /// The configuration for the file system and kernels in a SageMaker AI image running
    /// as a KernelGateway app.
    /// </summary>
    public partial class KernelGatewayImageConfig
    {
        private FileSystemConfig _fileSystemConfig;
        private List<KernelSpec> _kernelSpecs = AWSConfigs.InitializeCollections ? new List<KernelSpec>() : null;

        /// <summary>
        /// Gets and sets the property FileSystemConfig. 
        /// <para>
        /// The Amazon Elastic File System storage configuration for a SageMaker AI image.
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=5)]
        public List<KernelSpec> KernelSpecs
        {
            get { return this._kernelSpecs; }
            set { this._kernelSpecs = value; }
        }

        // Check to see if KernelSpecs property is set
        internal bool IsSetKernelSpecs()
        {
            return this._kernelSpecs != null && (this._kernelSpecs.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}