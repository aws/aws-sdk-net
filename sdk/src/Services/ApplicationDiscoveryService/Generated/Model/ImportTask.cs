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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// An array of information related to the import task request that includes status information,
    /// times, IDs, the Amazon S3 Object URL for the import file, and more.
    /// </summary>
    public partial class ImportTask
    {
        private int? _applicationImportFailure;
        private int? _applicationImportSuccess;
        private string _clientRequestToken;
        private string _errorsAndFailedEntriesZip;
        private DateTime? _importCompletionTime;
        private DateTime? _importDeletedTime;
        private DateTime? _importRequestTime;
        private string _importTaskId;
        private string _importUrl;
        private string _name;
        private int? _serverImportFailure;
        private int? _serverImportSuccess;
        private ImportStatus _status;

        /// <summary>
        /// Gets and sets the property ApplicationImportFailure. 
        /// <para>
        /// The total number of application records in the import file that failed to be imported.
        /// </para>
        /// </summary>
        public int ApplicationImportFailure
        {
            get { return this._applicationImportFailure.GetValueOrDefault(); }
            set { this._applicationImportFailure = value; }
        }

        // Check to see if ApplicationImportFailure property is set
        internal bool IsSetApplicationImportFailure()
        {
            return this._applicationImportFailure.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ApplicationImportSuccess. 
        /// <para>
        /// The total number of application records in the import file that were successfully
        /// imported.
        /// </para>
        /// </summary>
        public int ApplicationImportSuccess
        {
            get { return this._applicationImportSuccess.GetValueOrDefault(); }
            set { this._applicationImportSuccess = value; }
        }

        // Check to see if ApplicationImportSuccess property is set
        internal bool IsSetApplicationImportSuccess()
        {
            return this._applicationImportSuccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique token used to prevent the same import request from occurring more than once.
        /// If you didn't provide a token, a token was automatically generated when the import
        /// task request was sent.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

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
        public string ErrorsAndFailedEntriesZip
        {
            get { return this._errorsAndFailedEntriesZip; }
            set { this._errorsAndFailedEntriesZip = value; }
        }

        // Check to see if ErrorsAndFailedEntriesZip property is set
        internal bool IsSetErrorsAndFailedEntriesZip()
        {
            return this._errorsAndFailedEntriesZip != null;
        }

        /// <summary>
        /// Gets and sets the property ImportCompletionTime. 
        /// <para>
        /// The time that the import task request finished, presented in the Unix time stamp format.
        /// </para>
        /// </summary>
        public DateTime ImportCompletionTime
        {
            get { return this._importCompletionTime.GetValueOrDefault(); }
            set { this._importCompletionTime = value; }
        }

        // Check to see if ImportCompletionTime property is set
        internal bool IsSetImportCompletionTime()
        {
            return this._importCompletionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportDeletedTime. 
        /// <para>
        /// The time that the import task request was deleted, presented in the Unix time stamp
        /// format.
        /// </para>
        /// </summary>
        public DateTime ImportDeletedTime
        {
            get { return this._importDeletedTime.GetValueOrDefault(); }
            set { this._importDeletedTime = value; }
        }

        // Check to see if ImportDeletedTime property is set
        internal bool IsSetImportDeletedTime()
        {
            return this._importDeletedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportRequestTime. 
        /// <para>
        /// The time that the import task request was made, presented in the Unix time stamp format.
        /// </para>
        /// </summary>
        public DateTime ImportRequestTime
        {
            get { return this._importRequestTime.GetValueOrDefault(); }
            set { this._importRequestTime = value; }
        }

        // Check to see if ImportRequestTime property is set
        internal bool IsSetImportRequestTime()
        {
            return this._importRequestTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportTaskId. 
        /// <para>
        /// The unique ID for a specific import task. These IDs aren't globally unique, but they
        /// are unique within an Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Max=200)]
        public string ImportTaskId
        {
            get { return this._importTaskId; }
            set { this._importTaskId = value; }
        }

        // Check to see if ImportTaskId property is set
        internal bool IsSetImportTaskId()
        {
            return this._importTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property ImportUrl. 
        /// <para>
        /// The URL for your import file that you've uploaded to Amazon S3.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=4000)]
        public string ImportUrl
        {
            get { return this._importUrl; }
            set { this._importUrl = value; }
        }

        // Check to see if ImportUrl property is set
        internal bool IsSetImportUrl()
        {
            return this._importUrl != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A descriptive name for an import task. You can use this name to filter future requests
        /// related to this import task, such as identifying applications and servers that were
        /// included in this import task. We recommend that you use a meaningful name for each
        /// import task.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// Gets and sets the property ServerImportFailure. 
        /// <para>
        /// The total number of server records in the import file that failed to be imported.
        /// </para>
        /// </summary>
        public int ServerImportFailure
        {
            get { return this._serverImportFailure.GetValueOrDefault(); }
            set { this._serverImportFailure = value; }
        }

        // Check to see if ServerImportFailure property is set
        internal bool IsSetServerImportFailure()
        {
            return this._serverImportFailure.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ServerImportSuccess. 
        /// <para>
        /// The total number of server records in the import file that were successfully imported.
        /// </para>
        /// </summary>
        public int ServerImportSuccess
        {
            get { return this._serverImportSuccess.GetValueOrDefault(); }
            set { this._serverImportSuccess = value; }
        }

        // Check to see if ServerImportSuccess property is set
        internal bool IsSetServerImportSuccess()
        {
            return this._serverImportSuccess.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the import task. An import can have the status of <code>IMPORT_COMPLETE</code>
        /// and still have some records fail to import from the overall request. More information
        /// can be found in the downloadable archive defined in the <code>errorsAndFailedEntriesZip</code>
        /// field, or in the Migration Hub management console.
        /// </para>
        /// </summary>
        public ImportStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

    }
}