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
    /// Information about one customization job
    /// </summary>
    public partial class ModelCustomizationJobSummary
    {
        /// <summary>
        /// Gets and sets the property BaseModelArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the base model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string BaseModelArn { get; set; }

        /// <summary>
        /// Checks to see if the BaseModelArn property is set.
        /// </summary>
        internal bool IsSetBaseModelArn() => this.BaseModelArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the custom model. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomModelArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1011)]
        public string CustomModelArn { get; set; }

        /// <summary>
        /// Checks to see if the CustomModelArn property is set.
        /// </summary>
        internal bool IsSetCustomModelArn() => this.CustomModelArn != null;

        /// <summary>
        /// Gets and sets the property CustomModelName. 
        /// <para>
        /// Name of the custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string CustomModelName { get; set; }

        /// <summary>
        /// Checks to see if the CustomModelName property is set.
        /// </summary>
        internal bool IsSetCustomModelName() => this.CustomModelName != null;

        /// <summary>
        /// Gets and sets the property CustomizationType. 
        /// <para>
        /// Specifies whether to carry out continued pre-training of a model or whether to fine-tune
        /// it. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
        /// models</a>.
        /// </para>
        /// </summary>
        public CustomizationType CustomizationType { get; set; }

        /// <summary>
        /// Checks to see if the CustomizationType property is set.
        /// </summary>
        internal bool IsSetCustomizationType() => this.CustomizationType != null;

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time that the customization job ended.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the customization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Name of the customization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Time that the customization job was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Status of the customization job. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ModelCustomizationJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// Details about the status of the data processing sub-task of the job.
        /// </para>
        /// </summary>
        public StatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;
    }
}
