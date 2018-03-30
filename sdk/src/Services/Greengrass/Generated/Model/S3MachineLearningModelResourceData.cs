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
    /// Attributes that define an S3 machine learning resource.
    /// </summary>
    public partial class S3MachineLearningModelResourceData
    {
        private string _destinationPath;
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property DestinationPath. The absolute local path of the resource
        /// inside the Lambda environment.
        /// </summary>
        public string DestinationPath
        {
            get { return this._destinationPath; }
            set { this._destinationPath = value; }
        }

        // Check to see if DestinationPath property is set
        internal bool IsSetDestinationPath()
        {
            return this._destinationPath != null;
        }

        /// <summary>
        /// Gets and sets the property S3Uri. The URI of the source model in an S3 bucket. The
        /// model package must be in tar.gz or .zip format.
        /// </summary>
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}