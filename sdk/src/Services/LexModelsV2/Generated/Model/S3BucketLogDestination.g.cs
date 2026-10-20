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

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Specifies an Amazon S3 bucket for logging audio conversations
    /// </summary>
    public partial class S3BucketLogDestination
    {
        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon Web Services Key Management Service (KMS)
        /// key for encrypting audio log files stored in an S3 bucket.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property LogPrefix. 
        /// <para>
        /// The S3 prefix to assign to audio log files.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 1024)]
        public string LogPrefix { get; set; }

        /// <summary>
        /// Checks to see if the LogPrefix property is set.
        /// </summary>
        internal bool IsSetLogPrefix() => this.LogPrefix != null;

        /// <summary>
        /// Gets and sets the property S3BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an Amazon S3 bucket where audio log files are stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 2048)]
        public string S3BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the S3BucketArn property is set.
        /// </summary>
        internal bool IsSetS3BucketArn() => this.S3BucketArn != null;
    }
}
