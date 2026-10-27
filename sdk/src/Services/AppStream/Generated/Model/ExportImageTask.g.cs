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

namespace Amazon.AppStream.Model
{
    /// <summary>
    /// Information about an export image task, including its current state, timestamps, and
    /// any error details.
    /// </summary>
    public partial class ExportImageTask
    {
        /// <summary>
        /// Gets and sets the property AmiDescription. 
        /// <para>
        /// The description that will be applied to the exported EC2 AMI.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AmiDescription { get; set; }

        /// <summary>
        /// Checks to see if the AmiDescription property is set.
        /// </summary>
        internal bool IsSetAmiDescription() => this.AmiDescription != null;

        /// <summary>
        /// Gets and sets the property AmiId. 
        /// <para>
        /// The ID of the EC2 AMI that was created by this export task. This field is only populated
        /// when the task completes successfully.
        /// </para>
        /// </summary>
        public string AmiId { get; set; }

        /// <summary>
        /// Checks to see if the AmiId property is set.
        /// </summary>
        internal bool IsSetAmiId() => this.AmiId != null;

        /// <summary>
        /// Gets and sets the property AmiName. 
        /// <para>
        /// The name of the EC2 AMI that will be created by this export task.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string AmiName { get; set; }

        /// <summary>
        /// Checks to see if the AmiName property is set.
        /// </summary>
        internal bool IsSetAmiName() => this.AmiName != null;

        /// <summary>
        /// Gets and sets the property CreatedDate. 
        /// <para>
        /// The date and time when the export image task was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Checks to see if the CreatedDate property is set.
        /// </summary>
        internal bool IsSetCreatedDate() => this.CreatedDate.HasValue;

        /// <summary>
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// Details about any errors that occurred during the export process. This field is only
        /// populated when the task fails.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ErrorDetails> ErrorDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<ErrorDetails>() : null;

        /// <summary>
        /// Checks to see if the ErrorDetails property is set.
        /// </summary>
        internal bool IsSetErrorDetails() => this.ErrorDetails != null && (this.ErrorDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ImageArn. 
        /// <para>
        /// The ARN of the WorkSpaces Applications image being exported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ImageArn { get; set; }

        /// <summary>
        /// Checks to see if the ImageArn property is set.
        /// </summary>
        internal bool IsSetImageArn() => this.ImageArn != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the export image task, such as PENDING, RUNNING, COMPLETED, or
        /// FAILED.
        /// </para>
        /// </summary>
        public ExportImageTaskState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags that will be applied to the exported EC2 AMI.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TaskId. 
        /// <para>
        /// The unique identifier for the export image task. Use this ID to track the task's progress
        /// and retrieve its details.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string TaskId { get; set; }

        /// <summary>
        /// Checks to see if the TaskId property is set.
        /// </summary>
        internal bool IsSetTaskId() => this.TaskId != null;
    }
}
