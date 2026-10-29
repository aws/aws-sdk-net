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
    /// Information about the attached file.
    /// </summary>
    public partial class AttachedFile
    {
        /// <summary>
        /// Gets and sets the property AssociatedResourceArn. 
        /// <para>
        /// The resource to which the attached file is (being) uploaded to. The supported resources
        /// are <a href="https://docs.aws.amazon.com/connect/latest/adminguide/cases.html">Cases</a>,
        /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/setup-email-channel.html">Email</a>,
        /// and <a href="https://docs.aws.amazon.com/connect/latest/adminguide/concepts-getting-started-tasks.html">Task</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This value must be a valid ARN.
        /// </para>
        ///  </note>
        /// </summary>
        public string AssociatedResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the AssociatedResourceArn property is set.
        /// </summary>
        internal bool IsSetAssociatedResourceArn() => this.AssociatedResourceArn != null;

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// Represents the identity that created the file.
        /// </para>
        /// </summary>
        public CreatedByInfo CreatedBy { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBy property is set.
        /// </summary>
        internal bool IsSetCreatedBy() => this.CreatedBy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The time of Creation of the file resource as an ISO timestamp. It's specified in ISO
        /// 8601 format: <c>yyyy-MM-ddThh:mm:ss.SSSZ</c>. For example, <c>2024-05-03T02:41:28.172Z</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime != null;

        /// <summary>
        /// Gets and sets the property FileArn. 
        /// <para>
        /// The unique identifier of the attached file resource (ARN).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string FileArn { get; set; }

        /// <summary>
        /// Checks to see if the FileArn property is set.
        /// </summary>
        internal bool IsSetFileArn() => this.FileArn != null;

        /// <summary>
        /// Gets and sets the property FileId. 
        /// <para>
        /// The unique identifier of the attached file resource.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FileId { get; set; }

        /// <summary>
        /// Checks to see if the FileId property is set.
        /// </summary>
        internal bool IsSetFileId() => this.FileId != null;

        /// <summary>
        /// Gets and sets the property FileName. 
        /// <para>
        /// A case-sensitive name of the attached file being uploaded.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 256)]
        public string FileName { get; set; }

        /// <summary>
        /// Checks to see if the FileName property is set.
        /// </summary>
        internal bool IsSetFileName() => this.FileName != null;

        /// <summary>
        /// Gets and sets the property FileSizeInBytes. 
        /// <para>
        /// The size of the attached file in bytes.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1)]
        public long? FileSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the FileSizeInBytes property is set.
        /// </summary>
        internal bool IsSetFileSizeInBytes() => this.FileSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property FileStatus. 
        /// <para>
        /// The current status of the attached file.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileStatusType FileStatus { get; set; }

        /// <summary>
        /// Checks to see if the FileStatus property is set.
        /// </summary>
        internal bool IsSetFileStatus() => this.FileStatus != null;

        /// <summary>
        /// Gets and sets the property FileUseCaseType. 
        /// <para>
        /// The use case for the file.
        /// </para>
        /// </summary>
        public FileUseCaseType FileUseCaseType { get; set; }

        /// <summary>
        /// Checks to see if the FileUseCaseType property is set.
        /// </summary>
        internal bool IsSetFileUseCaseType() => this.FileUseCaseType != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags used to organize, track, or control access for this resource. For example,
        /// <c>{ "Tags": {"key1":"value1", "key2":"value2"} }</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
