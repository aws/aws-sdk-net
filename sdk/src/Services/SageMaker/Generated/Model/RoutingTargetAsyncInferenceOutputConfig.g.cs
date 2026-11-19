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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The output settings for the asynchronous requests of a routing target. Every destination
    /// writes to the same locations. <c>CreateInferenceRouter</c> and <c>UpdateInferenceRouter</c>
    /// don't check who owns the buckets. If another account owns the output bucket, requests
    /// fail.
    /// </summary>
    public partial class RoutingTargetAsyncInferenceOutputConfig
    {
        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The KMS key that encrypts the results in Amazon S3. You can specify a key ID, key
        /// ARN, alias name, or alias ARN. If any destination is in a different account or Amazon
        /// Web Services Region from the inference router, specify a key ARN or an alias ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2048)]
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property NotificationConfig. 
        /// <para>
        /// The Amazon SNS topics that the inference router publishes to when a request completes
        /// or fails.
        /// </para>
        /// </summary>
        public RoutingTargetAsyncInferenceNotificationConfig NotificationConfig { get; set; }

        /// <summary>
        /// Checks to see if the NotificationConfig property is set.
        /// </summary>
        internal bool IsSetNotificationConfig() => this.NotificationConfig != null;

        /// <summary>
        /// Gets and sets the property S3FailurePath. 
        /// <para>
        /// The Amazon S3 location for the failure details of failed requests. The bucket must
        /// be in the inference router's Amazon Web Services Region and owned by the router's
        /// account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string S3FailurePath { get; set; }

        /// <summary>
        /// Checks to see if the S3FailurePath property is set.
        /// </summary>
        internal bool IsSetS3FailurePath() => this.S3FailurePath != null;

        /// <summary>
        /// Gets and sets the property S3OutputPath. 
        /// <para>
        /// The Amazon S3 location for the results of successful requests. The bucket must be
        /// in the inference router's Amazon Web Services Region and owned by the router's account.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 512)]
        public string S3OutputPath { get; set; }

        /// <summary>
        /// Checks to see if the S3OutputPath property is set.
        /// </summary>
        internal bool IsSetS3OutputPath() => this.S3OutputPath != null;
    }
}
