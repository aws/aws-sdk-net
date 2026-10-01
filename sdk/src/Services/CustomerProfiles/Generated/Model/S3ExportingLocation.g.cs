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

namespace Amazon.CustomerProfiles.Model
{
    /// <summary>
    /// The S3 location where Identity Resolution Jobs write result files.
    /// </summary>
    public partial class S3ExportingLocation
    {
        /// <summary>
        /// Gets and sets the property S3BucketName. 
        /// <para>
        /// The name of the S3 bucket name where Identity Resolution Jobs write result files.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string S3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketName property is set.
        /// </summary>
        internal bool IsSetS3BucketName() => this.S3BucketName != null;

        /// <summary>
        /// Gets and sets the property S3KeyName. 
        /// <para>
        /// The S3 key name of the location where Identity Resolution Jobs write result files.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string S3KeyName { get; set; }

        /// <summary>
        /// Checks to see if the S3KeyName property is set.
        /// </summary>
        internal bool IsSetS3KeyName() => this.S3KeyName != null;
    }
}
