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

namespace Amazon.Translate.Model
{
    /// <summary>
    /// The properties of a parallel data resource.
    /// </summary>
    public partial class ParallelDataProperties
    {
        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parallel data resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 512)]
        public string Arn { get; set; }

        /// <summary>
        /// Checks to see if the Arn property is set.
        /// </summary>
        internal bool IsSetArn() => this.Arn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The time at which the parallel data resource was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description assigned to the parallel data resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EncryptionKey.
        /// </summary>
        public EncryptionKey EncryptionKey { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKey property is set.
        /// </summary>
        internal bool IsSetEncryptionKey() => this.EncryptionKey != null;

        /// <summary>
        /// Gets and sets the property FailedRecordCount. 
        /// <para>
        /// The number of records unsuccessfully imported from the parallel data input file.
        /// </para>
        /// </summary>
        public long? FailedRecordCount { get; set; }

        /// <summary>
        /// Checks to see if the FailedRecordCount property is set.
        /// </summary>
        internal bool IsSetFailedRecordCount() => this.FailedRecordCount.HasValue;

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
        public long? ImportedDataSize { get; set; }

        /// <summary>
        /// Checks to see if the ImportedDataSize property is set.
        /// </summary>
        internal bool IsSetImportedDataSize() => this.ImportedDataSize.HasValue;

        /// <summary>
        /// Gets and sets the property ImportedRecordCount. 
        /// <para>
        /// The number of records successfully imported from the parallel data input file.
        /// </para>
        /// </summary>
        public long? ImportedRecordCount { get; set; }

        /// <summary>
        /// Checks to see if the ImportedRecordCount property is set.
        /// </summary>
        internal bool IsSetImportedRecordCount() => this.ImportedRecordCount.HasValue;

        /// <summary>
        /// Gets and sets the property LastUpdatedAt. 
        /// <para>
        /// The time at which the parallel data resource was last updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedAt { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedAt property is set.
        /// </summary>
        internal bool IsSetLastUpdatedAt() => this.LastUpdatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property LatestUpdateAttemptAt. 
        /// <para>
        /// The time that the most recent update was attempted.
        /// </para>
        /// </summary>
        public DateTime? LatestUpdateAttemptAt { get; set; }

        /// <summary>
        /// Checks to see if the LatestUpdateAttemptAt property is set.
        /// </summary>
        internal bool IsSetLatestUpdateAttemptAt() => this.LatestUpdateAttemptAt.HasValue;

        /// <summary>
        /// Gets and sets the property LatestUpdateAttemptStatus. 
        /// <para>
        /// The status of the most recent update attempt for the parallel data resource.
        /// </para>
        /// </summary>
        public ParallelDataStatus LatestUpdateAttemptStatus { get; set; }

        /// <summary>
        /// Checks to see if the LatestUpdateAttemptStatus property is set.
        /// </summary>
        internal bool IsSetLatestUpdateAttemptStatus() => this.LatestUpdateAttemptStatus != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// Additional information from Amazon Translate about the parallel data resource. 
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The custom name assigned to the parallel data resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ParallelDataConfig. 
        /// <para>
        /// Specifies the format and S3 location of the parallel data input file.
        /// </para>
        /// </summary>
        public ParallelDataConfig ParallelDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the ParallelDataConfig property is set.
        /// </summary>
        internal bool IsSetParallelDataConfig() => this.ParallelDataConfig != null;

        /// <summary>
        /// Gets and sets the property SkippedRecordCount. 
        /// <para>
        /// The number of items in the input file that Amazon Translate skipped when you created
        /// or updated the parallel data resource. For example, Amazon Translate skips empty records,
        /// empty target texts, and empty lines.
        /// </para>
        /// </summary>
        public long? SkippedRecordCount { get; set; }

        /// <summary>
        /// Checks to see if the SkippedRecordCount property is set.
        /// </summary>
        internal bool IsSetSkippedRecordCount() => this.SkippedRecordCount.HasValue;

        /// <summary>
        /// Gets and sets the property SourceLanguageCode. 
        /// <para>
        /// The source language of the translations in the parallel data file.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 2, Max = 5)]
        public string SourceLanguageCode { get; set; }

        /// <summary>
        /// Checks to see if the SourceLanguageCode property is set.
        /// </summary>
        internal bool IsSetSourceLanguageCode() => this.SourceLanguageCode != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the parallel data resource. When the parallel data is ready for you
        /// to use, the status is <c>ACTIVE</c>.
        /// </para>
        /// </summary>
        public ParallelDataStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetLanguageCodes. 
        /// <para>
        /// The language codes for the target languages available in the parallel data file. All
        /// possible target languages are returned as an array.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> TargetLanguageCodes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the TargetLanguageCodes property is set.
        /// </summary>
        internal bool IsSetTargetLanguageCodes() => this.TargetLanguageCodes != null && (this.TargetLanguageCodes.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
