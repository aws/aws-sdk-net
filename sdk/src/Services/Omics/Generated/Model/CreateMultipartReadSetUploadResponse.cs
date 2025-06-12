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
 * Do not modify this file. This file is generated from the omics-2022-11-28.normal.json service model.
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
    /// This is the response object from the CreateMultipartReadSetUpload operation.
    /// </summary>
    public partial class CreateMultipartReadSetUploadResponse : AmazonWebServiceResponse
    {
        private DateTime? _creationTime;
        private string _description;
        private string _generatedFrom;
        private string _name;
        private string _referenceArn;
        private string _sampleId;
        private string _sequenceStoreId;
        private FileType _sourceFileType;
        private string _subjectId;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _uploadId;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The creation time of the multipart upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the read set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property GeneratedFrom. 
        /// <para>
        /// The source of the read set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string GeneratedFrom
        {
            get { return this._generatedFrom; }
            set { this._generatedFrom = value; }
        }

        // Check to see if GeneratedFrom property is set
        internal bool IsSetGeneratedFrom()
        {
            return this._generatedFrom != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the read set.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property ReferenceArn. 
        /// <para>
        /// The read set source's reference ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string ReferenceArn
        {
            get { return this._referenceArn; }
            set { this._referenceArn = value; }
        }

        // Check to see if ReferenceArn property is set
        internal bool IsSetReferenceArn()
        {
            return this._referenceArn != null;
        }

        /// <summary>
        /// Gets and sets the property SampleId. 
        /// <para>
        /// The source's sample ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string SampleId
        {
            get { return this._sampleId; }
            set { this._sampleId = value; }
        }

        // Check to see if SampleId property is set
        internal bool IsSetSampleId()
        {
            return this._sampleId != null;
        }

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        /// The sequence store ID for the store that the read set will be created in.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
        public string SequenceStoreId
        {
            get { return this._sequenceStoreId; }
            set { this._sequenceStoreId = value; }
        }

        // Check to see if SequenceStoreId property is set
        internal bool IsSetSequenceStoreId()
        {
            return this._sequenceStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFileType. 
        /// <para>
        /// The file type of the read set source.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileType SourceFileType
        {
            get { return this._sourceFileType; }
            set { this._sourceFileType = value; }
        }

        // Check to see if SourceFileType property is set
        internal bool IsSetSourceFileType()
        {
            return this._sourceFileType != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        /// The source's subject ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string SubjectId
        {
            get { return this._subjectId; }
            set { this._subjectId = value; }
        }

        // Check to see if SubjectId property is set
        internal bool IsSetSubjectId()
        {
            return this._subjectId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags to add to the read set.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UploadId. 
        /// <para>
        /// The ID for the initiated multipart upload.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
        public string UploadId
        {
            get { return this._uploadId; }
            set { this._uploadId = value; }
        }

        // Check to see if UploadId property is set
        internal bool IsSetUploadId()
        {
            return this._uploadId != null;
        }

    }
}