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

namespace Amazon.MediaConvert.Model
{
    /// <summary>
    /// Settings associated with S3 destination
    /// </summary>
    public partial class S3DestinationSettings
    {
        /// <summary>
        /// Gets and sets the property AccessControl. Optional. Have MediaConvert automatically
        /// apply Amazon S3 access control for the outputs in this output group. When you don't
        /// use this setting, S3 automatically applies the default access control list PRIVATE.
        /// </summary>
        public S3DestinationAccessControl AccessControl { get; set; }

        /// <summary>
        /// Checks to see if the AccessControl property is set.
        /// </summary>
        internal bool IsSetAccessControl() => this.AccessControl != null;

        /// <summary>
        /// Gets and sets the property Encryption. Settings for how your job outputs are encrypted
        /// as they are uploaded to Amazon S3.
        /// </summary>
        public S3EncryptionSettings Encryption { get; set; }

        /// <summary>
        /// Checks to see if the Encryption property is set.
        /// </summary>
        internal bool IsSetEncryption() => this.Encryption != null;

        /// <summary>
        /// Gets and sets the property StorageClass. Specify the S3 storage class to use for this
        /// output. To use your destination's default storage class: Keep the default value, Not
        /// set. For more information about S3 storage classes, see https://docs.aws.amazon.com/AmazonS3/latest/userguide/storage-class-intro.html
        /// </summary>
        public S3StorageClass StorageClass { get; set; }

        /// <summary>
        /// Checks to see if the StorageClass property is set.
        /// </summary>
        internal bool IsSetStorageClass() => this.StorageClass != null;
    }
}
