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
 * Do not modify this file. This file is generated from the s3control-2018-08-20.normal.json service model.
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
namespace Amazon.S3Control.Model
{
    /// <summary>
    /// Configures the type of the job's ManifestGenerator.
    /// </summary>
    public partial class JobManifestGenerator
    {
        private S3JobManifestGenerator _s3JobManifestGenerator;

        /// <summary>
        /// Gets and sets the property S3JobManifestGenerator. 
        /// <para>
        /// The S3 job ManifestGenerator's configuration details.
        /// </para>
        /// </summary>
        public S3JobManifestGenerator S3JobManifestGenerator
        {
            get { return this._s3JobManifestGenerator; }
            set { this._s3JobManifestGenerator = value; }
        }

        // Check to see if S3JobManifestGenerator property is set
        internal bool IsSetS3JobManifestGenerator()
        {
            return this._s3JobManifestGenerator != null;
        }

    }
}