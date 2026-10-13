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
    /// Contains detailed information about a training session.
    /// </summary>
    public partial class TrainingSessionDetail
    {
        /// <summary>
        /// Gets and sets the property BillableTokenUsage. 
        /// <para>
        /// The billable token usage for the training session.
        /// </para>
        /// </summary>
        public BillableTokenUsage BillableTokenUsage { get; set; }

        /// <summary>
        /// Checks to see if the BillableTokenUsage property is set.
        /// </summary>
        internal bool IsSetBillableTokenUsage() => this.BillableTokenUsage != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that the training session was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// The date and time that the training session ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// If the training session failed or is blocked, detailed error information.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ErrorDetails { get; set; }

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// The date and time that the training session was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LastReceivedSequenceNumber. 
        /// <para>
        /// The sequence number of the last training operation received by the session.
        /// </para>
        /// </summary>
        public int? LastReceivedSequenceNumber { get; set; }

        /// <summary>
        /// Checks to see if the LastReceivedSequenceNumber property is set.
        /// </summary>
        internal bool IsSetLastReceivedSequenceNumber() => this.LastReceivedSequenceNumber.HasValue;

        /// <summary>
        /// Gets and sets the property LoraConfig. 
        /// <para>
        /// The Low-Rank Adaptation (LoRA) configuration for the training session.
        /// </para>
        /// </summary>
        public LoraConfig LoraConfig { get; set; }

        /// <summary>
        /// Checks to see if the LoraConfig property is set.
        /// </summary>
        internal bool IsSetLoraConfig() => this.LoraConfig != null;

        /// <summary>
        /// Gets and sets the property ModelConfig. 
        /// <para>
        /// The configuration for the base model.
        /// </para>
        /// </summary>
        public TrainingSessionModelConfig ModelConfig { get; set; }

        /// <summary>
        /// Checks to see if the ModelConfig property is set.
        /// </summary>
        internal bool IsSetModelConfig() => this.ModelConfig != null;

        /// <summary>
        /// Gets and sets the property ModelPackageGroupArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model package group where checkpoints are published.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ModelPackageGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageGroupArn property is set.
        /// </summary>
        internal bool IsSetModelPackageGroupArn() => this.ModelPackageGroupArn != null;

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for the training session.
        /// </para>
        /// </summary>
        public TrainingSessionOutputConfig OutputConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputConfig property is set.
        /// </summary>
        internal bool IsSetOutputConfig() => this.OutputConfig != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role associated with the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the training session.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TrainingSessionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 256)]
        public string TrainingSessionArn { get; set; }

        /// <summary>
        /// Checks to see if the TrainingSessionArn property is set.
        /// </summary>
        internal bool IsSetTrainingSessionArn() => this.TrainingSessionArn != null;

        /// <summary>
        /// Gets and sets the property TrainingSessionName. 
        /// <para>
        /// The name of the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string TrainingSessionName { get; set; }

        /// <summary>
        /// Checks to see if the TrainingSessionName property is set.
        /// </summary>
        internal bool IsSetTrainingSessionName() => this.TrainingSessionName != null;

        /// <summary>
        /// Gets and sets the property TrainingSessionStatus. 
        /// <para>
        /// The current status of the training session.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public TrainingSessionStatus TrainingSessionStatus { get; set; }

        /// <summary>
        /// Checks to see if the TrainingSessionStatus property is set.
        /// </summary>
        internal bool IsSetTrainingSessionStatus() => this.TrainingSessionStatus != null;

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The Virtual Private Cloud (VPC) configuration for the training session.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
