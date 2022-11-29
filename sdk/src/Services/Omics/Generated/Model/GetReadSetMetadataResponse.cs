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

namespace Amazon.Omics.Model
{
    /// <summary>
    /// This is the response object from the GetReadSetMetadata operation.
    /// </summary>
    public partial class GetReadSetMetadataResponse : AmazonWebServiceResponse
    {
        private string _arn;
        private DateTime? _creationTime;
        private string _description;
        private ReadSetFiles _files;
        private FileType _fileType;
        private string _id;
        private string _name;
        private string _referenceArn;
        private string _sampleId;
        private SequenceInformation _sequenceInformation;
        private string _sequenceStoreId;
        private ReadSetStatus _status;
        private string _subjectId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The read set's ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=127)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the read set was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        /// The read set's description.
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
        /// Gets and sets the property Files. 
        /// <para>
        /// The read set's files.
        /// </para>
        /// </summary>
        public ReadSetFiles Files
        {
            get { return this._files; }
            set { this._files = value; }
        }

        // Check to see if Files property is set
        internal bool IsSetFiles()
        {
            return this._files != null;
        }

        /// <summary>
        /// Gets and sets the property FileType. 
        /// <para>
        /// The read set's file type.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public FileType FileType
        {
            get { return this._fileType; }
            set { this._fileType = value; }
        }

        // Check to see if FileType property is set
        internal bool IsSetFileType()
        {
            return this._fileType != null;
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The read set's ID.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=36)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The read set's name.
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
        /// The read set's genome reference ARN.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// The read set's sample ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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
        /// Gets and sets the property SequenceInformation. 
        /// <para>
        /// The read set's sequence information.
        /// </para>
        /// </summary>
        public SequenceInformation SequenceInformation
        {
            get { return this._sequenceInformation; }
            set { this._sequenceInformation = value; }
        }

        // Check to see if SequenceInformation property is set
        internal bool IsSetSequenceInformation()
        {
            return this._sequenceInformation != null;
        }

        /// <summary>
        /// Gets and sets the property SequenceStoreId. 
        /// <para>
        /// The read set's sequence store ID.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The read set's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReadSetStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property SubjectId. 
        /// <para>
        /// The read set's subject ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
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

    }
}