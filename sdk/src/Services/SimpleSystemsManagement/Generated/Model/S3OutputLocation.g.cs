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

namespace Amazon.SimpleSystemsManagement.Model
{
    /// <summary>
    /// An S3 bucket where you want to store the results of this request.
    /// </summary>
    public partial class S3OutputLocation
    {
        /// <summary>
        /// Gets and sets the property OutputS3BucketName. 
        /// <para>
        /// The name of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 63)]
        public string OutputS3BucketName { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3BucketName property is set.
        /// </summary>
        internal bool IsSetOutputS3BucketName() => this.OutputS3BucketName != null;

        /// <summary>
        /// Gets and sets the property OutputS3KeyPrefix. 
        /// <para>
        /// The S3 bucket subfolder.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string OutputS3KeyPrefix { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3KeyPrefix property is set.
        /// </summary>
        internal bool IsSetOutputS3KeyPrefix() => this.OutputS3KeyPrefix != null;

        /// <summary>
        /// Gets and sets the property OutputS3Region. 
        /// <para>
        /// The Amazon Web Services Region of the S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 3, Max = 20)]
        public string OutputS3Region { get; set; }

        /// <summary>
        /// Checks to see if the OutputS3Region property is set.
        /// </summary>
        internal bool IsSetOutputS3Region() => this.OutputS3Region != null;
    }
}
