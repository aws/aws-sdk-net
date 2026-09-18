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

namespace Amazon.KafkaConnect.Model
{
    /// <summary>
    /// The description of the location of an object in Amazon S3.
    /// </summary>
    public partial class S3LocationDescription
    {
        /// <summary>
        /// Gets and sets the property BucketArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an S3 bucket.
        /// </para>
        /// </summary>
        public string BucketArn { get; set; }

        /// <summary>
        /// Checks to see if the BucketArn property is set.
        /// </summary>
        internal bool IsSetBucketArn() => this.BucketArn != null;

        /// <summary>
        /// Gets and sets the property FileKey. 
        /// <para>
        /// The file key for an object in an S3 bucket.
        /// </para>
        /// </summary>
        public string FileKey { get; set; }

        /// <summary>
        /// Checks to see if the FileKey property is set.
        /// </summary>
        internal bool IsSetFileKey() => this.FileKey != null;

        /// <summary>
        /// Gets and sets the property ObjectVersion. 
        /// <para>
        /// The version of an object in an S3 bucket.
        /// </para>
        /// </summary>
        public string ObjectVersion { get; set; }

        /// <summary>
        /// Checks to see if the ObjectVersion property is set.
        /// </summary>
        internal bool IsSetObjectVersion() => this.ObjectVersion != null;
    }
}
