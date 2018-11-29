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
    /// Contains information about the output location for the compiled model and the device
    /// (target) that the model runs on.
    /// </summary>
    public partial class OutputConfig
    {
        private string _s3OutputLocation;
        private TargetDevice _targetDevice;

        /// <summary>
        /// Gets and sets the property S3OutputLocation. 
        /// <para>
        /// Identifies the S3 path where you want Amazon SageMaker to store the model artifacts.
        /// For example, s3://bucket-name/key-name-prefix.
        /// </para>
        /// </summary>
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

        /// <summary>
        /// Gets and sets the property TargetDevice. 
        /// <para>
        /// Identifies the device that you want to run your model on after it has been compiled.
        /// For example: ml_c5.
        /// </para>
        /// </summary>
        public TargetDevice TargetDevice
        {
            get { return this._targetDevice; }
            set { this._targetDevice = value; }
        }

        // Check to see if TargetDevice property is set
        internal bool IsSetTargetDevice()
        {
            return this._targetDevice != null;
        }

    }
}