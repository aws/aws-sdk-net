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

namespace Amazon.Glue.Model
{
    /// <summary>
    /// Specifies how Amazon CloudWatch data should be encrypted.
    /// </summary>
    public partial class CloudWatchEncryption
    {
        /// <summary>
        /// Gets and sets the property CloudWatchEncryptionMode. 
        /// <para>
        /// The encryption mode to use for CloudWatch data.
        /// </para>
        /// </summary>
        public CloudWatchEncryptionMode CloudWatchEncryptionMode { get; set; }

        /// <summary>
        /// Checks to see if the CloudWatchEncryptionMode property is set.
        /// </summary>
        internal bool IsSetCloudWatchEncryptionMode() => this.CloudWatchEncryptionMode != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key to be used to encrypt the data.
        /// </para>
        /// </summary>
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;
    }
}
