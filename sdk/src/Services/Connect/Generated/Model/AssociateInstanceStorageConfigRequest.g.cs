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

namespace Amazon.Connect.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateInstanceStorageConfig operation. This
    /// API is in preview release for Connect Customer and is subject to change. <para> Associates
    /// a storage resource type for the first time. You can only associate one type of storage
    /// configuration in a single call. This means, for example, that you can't define an
    /// instance with multiple S3 buckets for storing chat transcripts. </para> <para> This
    /// API does not create a resource that doesn't exist. It only associates it to the instance.
    /// Ensure that the resource being specified in the storage configuration, like an S3
    /// bucket, exists when being used for association. </para>
    /// </summary>
    public partial class AssociateInstanceStorageConfigRequest : AmazonConnectRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier that you provide to ensure the idempotency of
        /// the request. If not provided, the Amazon Web Services SDK populates this field. For
        /// more information about idempotency, see <a href="https://aws.amazon.com/builders-library/making-retries-safe-with-idempotent-APIs/">Making
        /// retries safe with idempotent APIs</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 500)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The identifier of the Connect Customer instance. You can <a href="https://docs.aws.amazon.com/connect/latest/adminguide/find-instance-arn.html">find
        /// the instance ID</a> in the Amazon Resource Name (ARN) of the instance.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 100)]
        public string InstanceId { get; set; }

        /// <summary>
        /// Checks to see if the InstanceId property is set.
        /// </summary>
        internal bool IsSetInstanceId() => this.InstanceId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// A valid resource type. To <a href="https://docs.aws.amazon.com/connect/latest/adminguide/enable-contact-analysis-segment-streams.html">enable
        /// streaming for real-time analysis of contacts</a>, use the following types:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For chat contacts, use <c>REAL_TIME_CONTACT_ANALYSIS_CHAT_SEGMENTS</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// For voice contacts, use <c>REAL_TIME_CONTACT_ANALYSIS_VOICE_SEGMENTS</c>.
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        ///  <c>REAL_TIME_CONTACT_ANALYSIS_SEGMENTS</c> is deprecated, but it is still supported
        /// and will apply only to VOICE channel contacts. Use <c>REAL_TIME_CONTACT_ANALYSIS_VOICE_SEGMENTS</c>
        /// for voice contacts moving forward.
        /// </para>
        ///  
        /// <para>
        /// If you have previously associated a stream with <c>REAL_TIME_CONTACT_ANALYSIS_SEGMENTS</c>,
        /// no action is needed to update the stream to <c>REAL_TIME_CONTACT_ANALYSIS_VOICE_SEGMENTS</c>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceStorageResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property StorageConfig. 
        /// <para>
        /// A valid storage type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public InstanceStorageConfig StorageConfig { get; set; }

        /// <summary>
        /// Checks to see if the StorageConfig property is set.
        /// </summary>
        internal bool IsSetStorageConfig() => this.StorageConfig != null;
    }
}
