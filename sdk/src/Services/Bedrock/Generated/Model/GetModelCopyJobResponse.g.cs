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

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// This is the response object from the GetModelCopyJob operation.
    /// </summary>
    public partial class GetModelCopyJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time at which the model copy job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// An error message for why the model copy job failed.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model copy job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property SourceAccountId. 
        /// <para>
        /// The unique identifier of the account that the model being copied originated from.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SourceAccountId { get; set; }

        /// <summary>
        /// Checks to see if the SourceAccountId property is set.
        /// </summary>
        internal bool IsSetSourceAccountId() => this.SourceAccountId != null;

        /// <summary>
        /// Gets and sets the property SourceModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the original model being copied.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string SourceModelArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceModelArn property is set.
        /// </summary>
        internal bool IsSetSourceModelArn() => this.SourceModelArn != null;

        /// <summary>
        /// Gets and sets the property SourceModelName. 
        /// <para>
        /// The name of the original model being copied.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string SourceModelName { get; set; }

        /// <summary>
        /// Checks to see if the SourceModelName property is set.
        /// </summary>
        internal bool IsSetSourceModelName() => this.SourceModelName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the model copy job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelCopyJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the copied model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string TargetModelArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetModelArn property is set.
        /// </summary>
        internal bool IsSetTargetModelArn() => this.TargetModelArn != null;

        /// <summary>
        /// Gets and sets the property TargetModelKmsKeyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the KMS key encrypting the copied model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string TargetModelKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the TargetModelKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetTargetModelKmsKeyArn() => this.TargetModelKmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property TargetModelName. 
        /// <para>
        /// The name of the copied model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string TargetModelName { get; set; }

        /// <summary>
        /// Checks to see if the TargetModelName property is set.
        /// </summary>
        internal bool IsSetTargetModelName() => this.TargetModelName != null;

        /// <summary>
        /// Gets and sets the property TargetModelTags. 
        /// <para>
        /// The tags associated with the copied model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public List<Tag> TargetModelTags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the TargetModelTags property is set.
        /// </summary>
        internal bool IsSetTargetModelTags() => this.TargetModelTags != null && (this.TargetModelTags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
