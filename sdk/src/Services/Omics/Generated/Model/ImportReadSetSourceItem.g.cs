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
    /// A source for an import read set job.
    /// </summary>
    public partial class ImportReadSetSourceItem
    {
        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The source's description.
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
        /// Where the source originated.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string GeneratedFrom { get; set; }

        /// <summary>
        /// Checks to see if the GeneratedFrom property is set.
        /// </summary>
        internal bool IsSetGeneratedFrom() => this.GeneratedFrom != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The source's name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ReadSetId. 
        /// <para>
        /// The source's read set ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 10, Max = 36)]
        public string ReadSetId { get; set; }

        /// <summary>
        /// Checks to see if the ReadSetId property is set.
        /// </summary>
        internal bool IsSetReadSetId() => this.ReadSetId != null;

        /// <summary>
        /// Gets and sets the property ReferenceArn. 
        /// <para>
        /// The source's genome reference ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string ReferenceArn { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceArn property is set.
        /// </summary>
        internal bool IsSetReferenceArn() => this.ReferenceArn != null;

        /// <summary>
        /// Gets and sets the property SampleId. 
        /// <para>
        /// The source's sample ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string SampleId { get; set; }

        /// <summary>
        /// Checks to see if the SampleId property is set.
        /// </summary>
        internal bool IsSetSampleId() => this.SampleId != null;

        /// <summary>
        /// Gets and sets the property SourceFileType. 
        /// <para>
        /// The source's file type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileType SourceFileType { get; set; }

        /// <summary>
        /// Checks to see if the SourceFileType property is set.
        /// </summary>
        internal bool IsSetSourceFileType() => this.SourceFileType != null;

        /// <summary>
        /// Gets and sets the property SourceFiles. 
        /// <para>
        /// The source files' location in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SourceFiles SourceFiles { get; set; }

        /// <summary>
        /// Checks to see if the SourceFiles property is set.
        /// </summary>
        internal bool IsSetSourceFiles() => this.SourceFiles != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The source's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReadSetImportJobItemStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The source's status message.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        /// The source's subject ID.
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
        /// The source's tags.
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
    }
}
