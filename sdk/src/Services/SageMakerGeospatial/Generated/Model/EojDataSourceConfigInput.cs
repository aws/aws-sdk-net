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
    /// Union representing different data sources to be used as input for an Earth Observation
    /// job.
    /// </summary>
    public partial class EojDataSourceConfigInput
    {
        private S3DataInput _s3Data;

        /// <summary>
        /// Gets and sets the property S3Data. 
        /// <para>
        /// The input structure for S3Data; representing the Amazon S3 location of the input data
        /// objects.
        /// </para>
        /// </summary>
        public S3DataInput S3Data
        {
            get { return this._s3Data; }
            set { this._s3Data = value; }
        }

        // Check to see if S3Data property is set
        internal bool IsSetS3Data()
        {
            return this._s3Data != null;
        }

    }
}