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
    /// Attributes that define an Amazon S3 machine learning resource.
    /// </summary>
    public partial class S3MachineLearningModelResourceData
    {
        /// <summary>
        /// Gets and sets the property DestinationPath. The absolute local path of the resource
        /// inside the Lambda environment.
        /// </summary>
        public string DestinationPath { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPath property is set.
        /// </summary>
        internal bool IsSetDestinationPath() => this.DestinationPath != null;

        /// <summary>
        /// Gets and sets the property OwnerSetting.
        /// </summary>
        public ResourceDownloadOwnerSetting OwnerSetting { get; set; }

        /// <summary>
        /// Checks to see if the OwnerSetting property is set.
        /// </summary>
        internal bool IsSetOwnerSetting() => this.OwnerSetting != null;

        /// <summary>
        /// Gets and sets the property S3Uri. The URI of the source model in an S3 bucket. The
        /// model package must be in tar.gz or .zip format.
        /// </summary>
        public string S3Uri { get; set; }

        /// <summary>
        /// Checks to see if the S3Uri property is set.
        /// </summary>
        internal bool IsSetS3Uri() => this.S3Uri != null;
    }
}
