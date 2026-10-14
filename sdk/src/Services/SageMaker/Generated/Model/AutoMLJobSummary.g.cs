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
    /// Provides a summary about an AutoML job.
    /// </summary>
    public partial class AutoMLJobSummary
    {
        /// <summary>
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// The ARN of the AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string AutoMLJobArn { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobArn property is set.
        /// </summary>
        internal bool IsSetAutoMLJobArn() => this.AutoMLJobArn != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobName. 
        /// <para>
        /// The name of the AutoML job you are requesting.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 32)]
        public string AutoMLJobName { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobName property is set.
        /// </summary>
        internal bool IsSetAutoMLJobName() => this.AutoMLJobName != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobSecondaryStatus. 
        /// <para>
        /// The secondary status of the AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoMLJobSecondaryStatus AutoMLJobSecondaryStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobSecondaryStatus property is set.
        /// </summary>
        internal bool IsSetAutoMLJobSecondaryStatus() => this.AutoMLJobSecondaryStatus != null;

        /// <summary>
        /// Gets and sets the property AutoMLJobStatus. 
        /// <para>
        /// The status of the AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public AutoMLJobStatus AutoMLJobStatus { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLJobStatus property is set.
        /// </summary>
        internal bool IsSetAutoMLJobStatus() => this.AutoMLJobStatus != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the AutoML job was created.
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
        /// The end time of an AutoML job.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The failure reason of an AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string FailureReason { get; set; }

        /// <summary>
        /// Checks to see if the FailureReason property is set.
        /// </summary>
        internal bool IsSetFailureReason() => this.FailureReason != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// When the AutoML job was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property PartialFailureReasons. 
        /// <para>
        /// The list of reasons for partial failures within an AutoML job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 5)]
        public List<AutoMLPartialFailureReason> PartialFailureReasons { get; set; } = AWSConfigs.InitializeCollections ? new List<AutoMLPartialFailureReason>() : null;

        /// <summary>
        /// Checks to see if the PartialFailureReasons property is set.
        /// </summary>
        internal bool IsSetPartialFailureReasons() => this.PartialFailureReasons != null && (this.PartialFailureReasons.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
