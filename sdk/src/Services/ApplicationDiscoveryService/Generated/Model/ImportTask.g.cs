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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// An array of information related to the import task request that includes status information,
    /// times, IDs, the Amazon S3 Object URL for the import file, and more.
    /// </summary>
    public partial class ImportTask
    {
        /// <summary>
        /// Gets and sets the property ApplicationImportFailure. 
        /// <para>
        /// The total number of application records in the import file that failed to be imported.
        /// </para>
        /// </summary>
        public int? ApplicationImportFailure { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationImportFailure property is set.
        /// </summary>
        internal bool IsSetApplicationImportFailure() => this.ApplicationImportFailure.HasValue;

        /// <summary>
        /// Gets and sets the property ApplicationImportSuccess. 
        /// <para>
        /// The total number of application records in the import file that were successfully
        /// imported.
        /// </para>
        /// </summary>
        public int? ApplicationImportSuccess { get; set; }

        /// <summary>
        /// Checks to see if the ApplicationImportSuccess property is set.
        /// </summary>
        internal bool IsSetApplicationImportSuccess() => this.ApplicationImportSuccess.HasValue;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique token used to prevent the same import request from occurring more than once.
        /// If you didn't provide a token, a token was automatically generated when the import
        /// task request was sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property ErrorsAndFailedEntriesZip. 
        /// <para>
        /// A link to a compressed archive folder (in the ZIP format) that contains an error log
        /// and a file of failed records. You can use these two files to quickly identify records
        /// that failed, why they failed, and correct those records. Afterward, you can upload
        /// the corrected file to your Amazon S3 bucket and create another import task request.
        /// </para>
        ///  
        /// <para>
        /// This field also includes authorization information so you can confirm the authenticity
        /// of the compressed archive before you download it.
        /// </para>
        ///  
        /// <para>
        /// If some records failed to be imported we recommend that you correct the records in
        /// the failed entries file and then imports that failed entries file. This prevents you
        /// from having to correct and update the larger original file and attempt importing it
        /// again.
        /// </para>
        /// </summary>
        public string ErrorsAndFailedEntriesZip { get; set; }

        /// <summary>
        /// Checks to see if the ErrorsAndFailedEntriesZip property is set.
        /// </summary>
        internal bool IsSetErrorsAndFailedEntriesZip() => this.ErrorsAndFailedEntriesZip != null;

        /// <summary>
        /// Gets and sets the property FileClassification. 
        /// <para>
        /// The type of file detected by the import task.
        /// </para>
        /// </summary>
        public FileClassification FileClassification { get; set; }

        /// <summary>
        /// Checks to see if the FileClassification property is set.
        /// </summary>
        internal bool IsSetFileClassification() => this.FileClassification != null;

        /// <summary>
        /// Gets and sets the property ImportCompletionTime. 
        /// <para>
        /// The time that the import task request finished, presented in the Unix time stamp format.
        /// </para>
        /// </summary>
        public DateTime? ImportCompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the ImportCompletionTime property is set.
        /// </summary>
        internal bool IsSetImportCompletionTime() => this.ImportCompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImportDeletedTime. 
        /// <para>
        /// The time that the import task request was deleted, presented in the Unix time stamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime? ImportDeletedTime { get; set; }

        /// <summary>
        /// Checks to see if the ImportDeletedTime property is set.
        /// </summary>
        internal bool IsSetImportDeletedTime() => this.ImportDeletedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImportRequestTime. 
        /// <para>
        /// The time that the import task request was made, presented in the Unix time stamp format.
        /// </para>
        /// </summary>
        public DateTime? ImportRequestTime { get; set; }

        /// <summary>
        /// Checks to see if the ImportRequestTime property is set.
        /// </summary>
        internal bool IsSetImportRequestTime() => this.ImportRequestTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImportTaskId. 
        /// <para>
        /// The unique ID for a specific import task. These IDs aren't globally unique, but they
        /// are unique within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 200)]
        public string ImportTaskId { get; set; }

        /// <summary>
        /// Checks to see if the ImportTaskId property is set.
        /// </summary>
        internal bool IsSetImportTaskId() => this.ImportTaskId != null;

        /// <summary>
        /// Gets and sets the property ImportUrl. 
        /// <para>
        /// The URL for your import file that you've uploaded to Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 4000)]
        public string ImportUrl { get; set; }

        /// <summary>
        /// Checks to see if the ImportUrl property is set.
        /// </summary>
        internal bool IsSetImportUrl() => this.ImportUrl != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for an import task. You can use this name to filter future requests
        /// related to this import task, such as identifying applications and servers that were
        /// included in this import task. We recommend that you use a meaningful name for each
        /// import task.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 255)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property ServerImportFailure. 
        /// <para>
        /// The total number of server records in the import file that failed to be imported.
        /// </para>
        /// </summary>
        public int? ServerImportFailure { get; set; }

        /// <summary>
        /// Checks to see if the ServerImportFailure property is set.
        /// </summary>
        internal bool IsSetServerImportFailure() => this.ServerImportFailure.HasValue;

        /// <summary>
        /// Gets and sets the property ServerImportSuccess. 
        /// <para>
        /// The total number of server records in the import file that were successfully imported.
        /// </para>
        /// </summary>
        public int? ServerImportSuccess { get; set; }

        /// <summary>
        /// Checks to see if the ServerImportSuccess property is set.
        /// </summary>
        internal bool IsSetServerImportSuccess() => this.ServerImportSuccess.HasValue;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the import task. An import can have the status of <c>IMPORT_COMPLETE</c>
        /// and still have some records fail to import from the overall request. More information
        /// can be found in the downloadable archive defined in the <c>errorsAndFailedEntriesZip</c>
        /// field, or in the Migration Hub management console.
        /// </para>
        /// </summary>
        public ImportStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
