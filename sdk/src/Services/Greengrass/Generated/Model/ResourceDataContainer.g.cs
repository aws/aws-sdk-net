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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// A container for resource data. The container takes only one of the following supported
    /// resource data types: ''LocalDeviceResourceData'', ''LocalVolumeResourceData'', ''SageMakerMachineLearningModelResourceData'',
    /// ''S3MachineLearningModelResourceData'', ''SecretsManagerSecretResourceData''.
    /// </summary>
    public partial class ResourceDataContainer
    {
        /// <summary>
        /// Gets and sets the property LocalDeviceResourceData. Attributes that define the local
        /// device resource.
        /// </summary>
        public LocalDeviceResourceData LocalDeviceResourceData { get; set; }

        /// <summary>
        /// Checks to see if the LocalDeviceResourceData property is set.
        /// </summary>
        internal bool IsSetLocalDeviceResourceData() => this.LocalDeviceResourceData != null;

        /// <summary>
        /// Gets and sets the property LocalVolumeResourceData. Attributes that define the local
        /// volume resource.
        /// </summary>
        public LocalVolumeResourceData LocalVolumeResourceData { get; set; }

        /// <summary>
        /// Checks to see if the LocalVolumeResourceData property is set.
        /// </summary>
        internal bool IsSetLocalVolumeResourceData() => this.LocalVolumeResourceData != null;

        /// <summary>
        /// Gets and sets the property S3MachineLearningModelResourceData. Attributes that define
        /// an Amazon S3 machine learning resource.
        /// </summary>
        public S3MachineLearningModelResourceData S3MachineLearningModelResourceData { get; set; }

        /// <summary>
        /// Checks to see if the S3MachineLearningModelResourceData property is set.
        /// </summary>
        internal bool IsSetS3MachineLearningModelResourceData() => this.S3MachineLearningModelResourceData != null;

        /// <summary>
        /// Gets and sets the property SageMakerMachineLearningModelResourceData. Attributes that
        /// define an Amazon SageMaker machine learning resource.
        /// </summary>
        public SageMakerMachineLearningModelResourceData SageMakerMachineLearningModelResourceData { get; set; }

        /// <summary>
        /// Checks to see if the SageMakerMachineLearningModelResourceData property is set.
        /// </summary>
        internal bool IsSetSageMakerMachineLearningModelResourceData() => this.SageMakerMachineLearningModelResourceData != null;

        /// <summary>
        /// Gets and sets the property SecretsManagerSecretResourceData. Attributes that define
        /// a secret resource, which references a secret from AWS Secrets Manager.
        /// </summary>
        public SecretsManagerSecretResourceData SecretsManagerSecretResourceData { get; set; }

        /// <summary>
        /// Checks to see if the SecretsManagerSecretResourceData property is set.
        /// </summary>
        internal bool IsSetSecretsManagerSecretResourceData() => this.SecretsManagerSecretResourceData != null;
    }
}
