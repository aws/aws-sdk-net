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

namespace Amazon.RDS.Model
{
    /// <summary>
    /// This is the response object from the ModifyActivityStream operation.
    /// </summary>
    public partial class ModifyActivityStreamResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property EngineNativeAuditFieldsIncluded. 
        /// <para>
        /// Indicates whether engine-native audit fields are included in the database activity
        /// stream.
        /// </para>
        /// </summary>
        public bool? EngineNativeAuditFieldsIncluded { get; set; }

        /// <summary>
        /// Checks to see if the EngineNativeAuditFieldsIncluded property is set.
        /// </summary>
        internal bool IsSetEngineNativeAuditFieldsIncluded() => this.EngineNativeAuditFieldsIncluded.HasValue;

        /// <summary>
        /// Gets and sets the property KinesisStreamName. 
        /// <para>
        /// The name of the Amazon Kinesis data stream to be used for the database activity stream.
        /// </para>
        /// </summary>
        public string KinesisStreamName { get; set; }

        /// <summary>
        /// Checks to see if the KinesisStreamName property is set.
        /// </summary>
        internal bool IsSetKinesisStreamName() => this.KinesisStreamName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyId. 
        /// <para>
        /// The Amazon Web Services KMS key identifier for encryption of messages in the database
        /// activity stream.
        /// </para>
        /// </summary>
        public string KmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyId property is set.
        /// </summary>
        internal bool IsSetKmsKeyId() => this.KmsKeyId != null;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The mode of the database activity stream.
        /// </para>
        /// </summary>
        public ActivityStreamMode Mode { get; set; }

        /// <summary>
        /// Checks to see if the Mode property is set.
        /// </summary>
        internal bool IsSetMode() => this.Mode != null;

        /// <summary>
        /// Gets and sets the property PolicyStatus. 
        /// <para>
        /// The status of the modification to the policy state of the database activity stream.
        /// </para>
        /// </summary>
        public ActivityStreamPolicyStatus PolicyStatus { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStatus property is set.
        /// </summary>
        internal bool IsSetPolicyStatus() => this.PolicyStatus != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the modification to the database activity stream.
        /// </para>
        /// </summary>
        public ActivityStreamStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
