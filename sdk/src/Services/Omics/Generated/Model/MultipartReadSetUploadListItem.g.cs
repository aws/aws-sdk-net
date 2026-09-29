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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// Part of the response to ListMultipartReadSetUploads, excluding completed and aborted
    /// multipart uploads.
    /// </summary>
    public partial class MultipartReadSetUploadListItem
    {
        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        ///  The time stamp for when a direct upload was created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of a read set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property GeneratedFrom. 
        /// <para>
        ///  The source of an uploaded part. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string GeneratedFrom { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedFrom property is set.
        /// </summary>
        internal bool IsSetGeneratedFrom() => this.GeneratedFrom != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        ///  The name of a read set. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReferenceArn. 
        /// <para>
        ///  The source's reference ARN. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string ReferenceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceArn property is set.
        /// </summary>
        internal bool IsSetReferenceArn() => this.ReferenceArn != null;

        /// <summary>
        /// Gets and sets the property SampleId. 
        /// <para>
        ///  The read set source's sample ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string SampleId { get; set; }

        /// <summary>
        /// Checks to see if the SampleId property is set.
        /// </summary>
        internal bool IsSetSampleId() => this.SampleId != null;

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        ///  The sequence store ID used for the multipart upload. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string SequenceStoreId { get; set; }

        /// <summary>
        /// Checks to see if the SequenceStoreId property is set.
        /// </summary>
        internal bool IsSetSequenceStoreId() => this.SequenceStoreId != null;

        /// <summary>
        /// Gets and sets the property SourceFileType. 
        /// <para>
        ///  The type of file the read set originated from. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileType SourceFileType { get; set; }

        /// <summary>
        /// Checks to see if the SourceFileType property is set.
        /// </summary>
        internal bool IsSetSourceFileType() => this.SourceFileType != null;

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        ///  The read set source's subject ID. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string SubjectId { get; set; }

        /// <summary>
        /// Checks to see if the SubjectId property is set.
        /// </summary>
        internal bool IsSetSubjectId() => this.SubjectId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  Any tags you wish to add to a read set. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        ///  The ID for the initiated multipart upload. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string UploadId { get; set; }

        /// <summary>
        /// Checks to see if the UploadId property is set.
        /// </summary>
        internal bool IsSetUploadId() => this.UploadId != null;
    }
}
