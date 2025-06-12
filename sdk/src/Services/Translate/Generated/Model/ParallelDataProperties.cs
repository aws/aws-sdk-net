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
 * Do not modify this file. This file is generated from the translate-2017-07-01.normal.json service model.
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
namespace Amazon.Translate.Model
{
    /// <summary>
    /// The properties of a parallel data resource.
    /// </summary>
    public partial class ParallelDataProperties
    {
        private string _arn;
        private DateTime? _createdAt;
        private string _description;
        private EncryptionKey _encryptionKey;
        private long? _failedRecordCount;
        private long? _importedDataSize;
        private long? _importedRecordCount;
        private DateTime? _lastUpdatedAt;
        private DateTime? _latestUpdateAttemptAt;
        private ParallelDataStatus _latestUpdateAttemptStatus;
        private string _message;
        private string _name;
        private ParallelDataConfig _parallelDataConfig;
        private long? _skippedRecordCount;
        private string _sourceLanguageCode;
        private ParallelDataStatus _status;
        private List<string> _targetLanguageCodes = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parallel data resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=512)]
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
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the parallel data resource was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description assigned to the parallel data resource.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
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
        /// Gets and sets the property EncryptionKey.
        /// </summary>
        public EncryptionKey EncryptionKey
        {
            get { return this._encryptionKey; }
            set { this._encryptionKey = value; }
        }

        // Check to see if EncryptionKey property is set
        internal bool IsSetEncryptionKey()
        {
            return this._encryptionKey != null;
        }

        /// <summary>
        /// Gets and sets the property FailedRecordCount. 
        /// <para>
        /// The number of records unsuccessfully imported from the parallel data input file.
        /// </para>
        /// </summary>
        public long? FailedRecordCount
        {
            get { return this._failedRecordCount; }
            set { this._failedRecordCount = value; }
        }

        // Check to see if FailedRecordCount property is set
        internal bool IsSetFailedRecordCount()
        {
            return this._failedRecordCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportedDataSize. 
        /// <para>
        /// The number of UTF-8 characters that Amazon Translate imported from the parallel data
        /// input file. This number includes only the characters in your translation examples.
        /// It does not include characters that are used to format your file. For example, if
        /// you provided a Translation Memory Exchange (.tmx) file, this number does not include
        /// the tags.
        /// </para>
        /// </summary>
        public long? ImportedDataSize
        {
            get { return this._importedDataSize; }
            set { this._importedDataSize = value; }
        }

        // Check to see if ImportedDataSize property is set
        internal bool IsSetImportedDataSize()
        {
            return this._importedDataSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportedRecordCount. 
        /// <para>
        /// The number of records successfully imported from the parallel data input file.
        /// </para>
        /// </summary>
        public long? ImportedRecordCount
        {
            get { return this._importedRecordCount; }
            set { this._importedRecordCount = value; }
        }

        // Check to see if ImportedRecordCount property is set
        internal bool IsSetImportedRecordCount()
        {
            return this._importedRecordCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time at which the parallel data resource was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt
        {
            get { return this._lastUpdatedAt; }
            set { this._lastUpdatedAt = value; }
        }

        // Check to see if LastUpdatedAt property is set
        internal bool IsSetLastUpdatedAt()
        {
            return this._lastUpdatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestUpdateAttemptAt. 
        /// <para>
        /// The time that the most recent update was attempted.
        /// </para>
        /// </summary>
        public DateTime? LatestUpdateAttemptAt
        {
            get { return this._latestUpdateAttemptAt; }
            set { this._latestUpdateAttemptAt = value; }
        }

        // Check to see if LatestUpdateAttemptAt property is set
        internal bool IsSetLatestUpdateAttemptAt()
        {
            return this._latestUpdateAttemptAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestUpdateAttemptStatus. 
        /// <para>
        /// The status of the most recent update attempt for the parallel data resource.
        /// </para>
        /// </summary>
        public ParallelDataStatus LatestUpdateAttemptStatus
        {
            get { return this._latestUpdateAttemptStatus; }
            set { this._latestUpdateAttemptStatus = value; }
        }

        // Check to see if LatestUpdateAttemptStatus property is set
        internal bool IsSetLatestUpdateAttemptStatus()
        {
            return this._latestUpdateAttemptStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Additional information from Amazon Translate about the parallel data resource. 
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom name assigned to the parallel data resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
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
        /// Gets and sets the property ParallelDataConfig. 
        /// <para>
        /// Specifies the format and S3 location of the parallel data input file.
        /// </para>
        /// </summary>
        public ParallelDataConfig ParallelDataConfig
        {
            get { return this._parallelDataConfig; }
            set { this._parallelDataConfig = value; }
        }

        // Check to see if ParallelDataConfig property is set
        internal bool IsSetParallelDataConfig()
        {
            return this._parallelDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property SkippedRecordCount. 
        /// <para>
        /// The number of items in the input file that Amazon Translate skipped when you created
        /// or updated the parallel data resource. For example, Amazon Translate skips empty records,
        /// empty target texts, and empty lines.
        /// </para>
        /// </summary>
        public long? SkippedRecordCount
        {
            get { return this._skippedRecordCount; }
            set { this._skippedRecordCount = value; }
        }

        // Check to see if SkippedRecordCount property is set
        internal bool IsSetSkippedRecordCount()
        {
            return this._skippedRecordCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The source language of the translations in the parallel data file.
        /// </para>
        /// </summary>
        [AWSProperty(Min=2, Max=5)]
        public string SourceLanguageCode
        {
            get { return this._sourceLanguageCode; }
            set { this._sourceLanguageCode = value; }
        }

        // Check to see if SourceLanguageCode property is set
        internal bool IsSetSourceLanguageCode()
        {
            return this._sourceLanguageCode != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the parallel data resource. When the parallel data is ready for you
        /// to use, the status is <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        public ParallelDataStatus Status
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
        /// Gets and sets the property TargetLanguageCodes. 
        /// <para>
        /// The language codes for the target languages available in the parallel data file. All
        /// possible target languages are returned as an array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetLanguageCodes
        {
            get { return this._targetLanguageCodes; }
            set { this._targetLanguageCodes = value; }
        }

        // Check to see if TargetLanguageCodes property is set
        internal bool IsSetTargetLanguageCodes()
        {
            return this._targetLanguageCodes != null && (this._targetLanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}