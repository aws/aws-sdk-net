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
    /// A source for an import read set job.
    /// </summary>
    public partial class ImportReadSetSourceItem
    {
        private string _description;
        private string _generatedFrom;
        private string _name;
        private string _referenceArn;
        private string _sampleId;
        private SourceFiles _sourceFiles;
        private FileType _sourceFileType;
        private ReadSetImportJobItemStatus _status;
        private string _statusMessage;
        private string _subjectId;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The source's description.
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
        /// Where the source originated.
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
        /// The source's name.
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
        /// The source's genome reference ARN.
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
        /// Gets and sets the property SourceFiles. 
        /// <para>
        /// The source files' location in Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SourceFiles SourceFiles
        {
            get { return this._sourceFiles; }
            set { this._sourceFiles = value; }
        }

        // Check to see if SourceFiles property is set
        internal bool IsSetSourceFiles()
        {
            return this._sourceFiles != null;
        }

        /// <summary>
        /// Gets and sets the property SourceFileType. 
        /// <para>
        /// The source's file type.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The source's status.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ReadSetImportJobItemStatus Status
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
        /// Gets and sets the property StatusMessage. 
        /// <para>
        /// The source's status message.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=127)]
        public string StatusMessage
        {
            get { return this._statusMessage; }
            set { this._statusMessage = value; }
        }

        // Check to see if StatusMessage property is set
        internal bool IsSetStatusMessage()
        {
            return this._statusMessage != null;
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
        /// The source's tags.
        /// </para>
        /// </summary>
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}