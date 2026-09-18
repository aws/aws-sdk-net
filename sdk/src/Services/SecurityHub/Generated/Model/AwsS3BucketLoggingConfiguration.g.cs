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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Information about logging for the S3 bucket
    /// </summary>
    public partial class AwsS3BucketLoggingConfiguration
    {
        /// <summary>
        /// Gets and sets the property DestinationBucketName. 
        /// <para>
        /// The name of the S3 bucket where log files for the S3 bucket are stored.
        /// </para>
        /// </summary>
        public string DestinationBucketName { get; set; }

        /// <summary>
        /// Checks to see if the DestinationBucketName property is set.
        /// </summary>
        internal bool IsSetDestinationBucketName() => this.DestinationBucketName != null;

        /// <summary>
        /// Gets and sets the property LogFilePrefix. 
        /// <para>
        /// The prefix added to log files for the S3 bucket.
        /// </para>
        /// </summary>
        public string LogFilePrefix { get; set; }

        /// <summary>
        /// Checks to see if the LogFilePrefix property is set.
        /// </summary>
        internal bool IsSetLogFilePrefix() => this.LogFilePrefix != null;
    }
}
