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
    /// The output configuration.
    /// </summary>
    public partial class EdgeOutputConfig
    {
        private string _kmsKeyId;
        private string _presetDeploymentConfig;
        private EdgePresetDeploymentType _presetDeploymentType;
        private string _s3OutputLocation;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services Key Management Service (Amazon Web Services KMS) key that
        /// Amazon SageMaker uses to encrypt data on the storage volume after compilation job.
        /// If you don't provide a KMS key ID, Amazon SageMaker uses the default KMS key for Amazon
        /// S3 for your role's account.
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
        /// Gets and sets the property PresetDeploymentConfig. 
        /// <para>
        /// The configuration used to create deployment artifacts. Specify configuration options
        /// with a JSON string. The available configuration options for each type are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ComponentName</c> (optional) - Name of the GreenGrass V2 component. If not specified,
        /// the default name generated consists of "SagemakerEdgeManager" and the name of your
        /// SageMaker Edge Manager packaging job.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ComponentDescription</c> (optional) - Description of the component.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ComponentVersion</c> (optional) - The version of the component.
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon Web Services IoT Greengrass uses semantic versions for components. Semantic
        /// versions follow a<i> major.minor.patch</i> number system. For example, version 1.0.0
        /// represents the first major release for a component. For more information, see the
        /// <a href="https://semver.org/">semantic version specification</a>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        ///  <c>PlatformOS</c> (optional) - The name of the operating system for the platform.
        /// Supported platforms include Windows and Linux.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>PlatformArchitecture</c> (optional) - The processor architecture for the platform.
        /// 
        /// </para>
        ///  
        /// <para>
        /// Supported architectures Windows include: Windows32_x86, Windows64_x64.
        /// </para>
        ///  
        /// <para>
        /// Supported architectures for Linux include: Linux x86_64, Linux ARMV8.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string PresetDeploymentConfig
        {
            get { return this._presetDeploymentConfig; }
            set { this._presetDeploymentConfig = value; }
        }

        // Check to see if PresetDeploymentConfig property is set
        internal bool IsSetPresetDeploymentConfig()
        {
            return this._presetDeploymentConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PresetDeploymentType. 
        /// <para>
        /// The deployment type SageMaker Edge Manager will create. Currently only supports Amazon
        /// Web Services IoT Greengrass Version 2 components.
        /// </para>
        /// </summary>
        public EdgePresetDeploymentType PresetDeploymentType
        {
            get { return this._presetDeploymentType; }
            set { this._presetDeploymentType = value; }
        }

        // Check to see if PresetDeploymentType property is set
        internal bool IsSetPresetDeploymentType()
        {
            return this._presetDeploymentType != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputLocation. 
        /// <para>
        /// The Amazon Simple Storage (S3) bucker URI.
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