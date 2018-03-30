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
 * Do not modify this file. This file is generated from the greengrass-2017-06-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Greengrass.Model
{
    /// <summary>
    /// A container for resource data. The container takes only one of the following supported
    /// resource data types: ''LocalDeviceResourceData'', ''LocalVolumeResourceData'', ''SageMakerMachineLearningModelResourceData'',
    /// ''S3MachineLearningModelResourceData''.
    /// </summary>
    public partial class ResourceDataContainer
    {
        private LocalDeviceResourceData _localDeviceResourceData;
        private LocalVolumeResourceData _localVolumeResourceData;
        private S3MachineLearningModelResourceData _s3MachineLearningModelResourceData;
        private SageMakerMachineLearningModelResourceData _sageMakerMachineLearningModelResourceData;

        /// <summary>
        /// Gets and sets the property LocalDeviceResourceData. Attributes that define the local
        /// device resource.
        /// </summary>
        public LocalDeviceResourceData LocalDeviceResourceData
        {
            get { return this._localDeviceResourceData; }
            set { this._localDeviceResourceData = value; }
        }

        // Check to see if LocalDeviceResourceData property is set
        internal bool IsSetLocalDeviceResourceData()
        {
            return this._localDeviceResourceData != null;
        }

        /// <summary>
        /// Gets and sets the property LocalVolumeResourceData. Attributes that define the local
        /// volume resource.
        /// </summary>
        public LocalVolumeResourceData LocalVolumeResourceData
        {
            get { return this._localVolumeResourceData; }
            set { this._localVolumeResourceData = value; }
        }

        // Check to see if LocalVolumeResourceData property is set
        internal bool IsSetLocalVolumeResourceData()
        {
            return this._localVolumeResourceData != null;
        }

        /// <summary>
        /// Gets and sets the property S3MachineLearningModelResourceData. Attributes that define
        /// an S3 machine learning resource.
        /// </summary>
        public S3MachineLearningModelResourceData S3MachineLearningModelResourceData
        {
            get { return this._s3MachineLearningModelResourceData; }
            set { this._s3MachineLearningModelResourceData = value; }
        }

        // Check to see if S3MachineLearningModelResourceData property is set
        internal bool IsSetS3MachineLearningModelResourceData()
        {
            return this._s3MachineLearningModelResourceData != null;
        }

        /// <summary>
        /// Gets and sets the property SageMakerMachineLearningModelResourceData. Attributes that
        /// define an SageMaker machine learning resource.
        /// </summary>
        public SageMakerMachineLearningModelResourceData SageMakerMachineLearningModelResourceData
        {
            get { return this._sageMakerMachineLearningModelResourceData; }
            set { this._sageMakerMachineLearningModelResourceData = value; }
        }

        // Check to see if SageMakerMachineLearningModelResourceData property is set
        internal bool IsSetSageMakerMachineLearningModelResourceData()
        {
            return this._sageMakerMachineLearningModelResourceData != null;
        }

    }
}