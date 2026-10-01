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
    /// A read set.
    /// </summary>
    public partial class ReadSetListItem
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The read set's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 127)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the read set was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationType. 
        /// <para>
        ///  The creation type of the read set. 
        /// </para>
        /// </summary>
        public CreationType CreationType { get; set; }

        /// <summary>
        /// Checks to see if the CreationType property is set.
        /// </summary>
        internal bool IsSetCreationType() => this.CreationType != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The read set's description.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property Etag. 
        /// <para>
        /// The entity tag (ETag) is a hash of the object representing its semantic content.
        /// </para>
        /// </summary>
        public ETag Etag { get; set; }

        /// <summary>
        /// Checks to see if the Etag property is set.
        /// </summary>
        internal bool IsSetEtag() => this.Etag != null;

        /// <summary>
        /// Gets and sets the property FileType. 
        /// <para>
        /// The read set's file type.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FileType FileType { get; set; }

        /// <summary>
        /// Checks to see if the FileType property is set.
        /// </summary>
        internal bool IsSetFileType() => this.FileType != null;

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The read set's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string Id { get; set; }

        /// <summary>
        /// Checks to see if the Id property is set.
        /// </summary>
        internal bool IsSetId() => this.Id != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The read set's name.
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
        /// The read set's genome reference ARN.
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
        /// The read set's sample ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string SampleId { get; set; }

        /// <summary>
        /// Checks to see if the SampleId property is set.
        /// </summary>
        internal bool IsSetSampleId() => this.SampleId != null;

        /// <summary>
        /// Gets and sets the property SequenceInformation.
        /// </summary>
        public SequenceInformation SequenceInformation { get; set; }

        /// <summary>
        /// Checks to see if the SequenceInformation property is set.
        /// </summary>
        internal bool IsSetSequenceInformation() => this.SequenceInformation != null;

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        /// The read set's sequence store ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 10, Max = 36)]
        public string SequenceStoreId { get; set; }

        /// <summary>
        /// Checks to see if the SequenceStoreId property is set.
        /// </summary>
        internal bool IsSetSequenceStoreId() => this.SequenceStoreId != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The read set's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ReadSetStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusMessage. 
        /// <para>
        ///  The status for a read set. It provides more detail as to why the read set has a status.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        /// The read set's subject ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 127)]
        public string SubjectId { get; set; }

        /// <summary>
        /// Checks to see if the SubjectId property is set.
        /// </summary>
        internal bool IsSetSubjectId() => this.SubjectId != null;
    }
}
