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
 * Do not modify this file. This file is generated from the sagemaker-geospatial-2020-05-27.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SageMakerGeospatial.Model
{
    /// <summary>
    /// Container for the parameters to the ExportEarthObservationJob operation.
    /// Use this operation to export results of an Earth Observation job and optionally source
    /// images used as input to the EOJ to an S3 location.
    /// </summary>
    public partial class ExportEarthObservationJobRequest : AmazonSageMakerGeospatialRequest
    {
        private string _arn;
        private string _executionRoleArn;
        private bool? _exportSourceImages;
        private OutputConfigInput _outputConfig;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The input Amazon Resource Name (ARN) of the Earth Observation job being exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role that you specified for the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExportSourceImages. 
        /// <para>
        /// The source images provided to the Earth Observation job being exported.
        /// </para>
        /// </summary>
        public bool ExportSourceImages
        {
            get { return this._exportSourceImages.GetValueOrDefault(); }
            set { this._exportSourceImages = value; }
        }

        // Check to see if ExportSourceImages property is set
        internal bool IsSetExportSourceImages()
        {
            return this._exportSourceImages.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// An object containing information about the output file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputConfigInput OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

    }
}