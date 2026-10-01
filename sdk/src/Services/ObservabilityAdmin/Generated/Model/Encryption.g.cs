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

namespace Amazon.ObservabilityAdmin.Model
{
    /// <summary>
    /// Defines the encryption configuration for S3 Table integrations, including the encryption
    /// algorithm and KMS key settings.
    /// </summary>
    public partial class Encryption
    {
        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key used for encryption when using customer-managed
        /// keys.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1011)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property SseAlgorithm. 
        /// <para>
        /// The server-side encryption algorithm used for encrypting data in the S3 Table integration.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SSEAlgorithm SseAlgorithm { get; set; }

        /// <summary>
        /// Checks to see if the SseAlgorithm property is set.
        /// </summary>
        internal bool IsSetSseAlgorithm() => this.SseAlgorithm != null;
    }
}
