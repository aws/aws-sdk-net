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
 * Do not modify this file. This file is generated from the mailmanager-2023-10-17.normal.json service model.
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
namespace Amazon.MailManager.Model
{
    /// <summary>
    /// Details about an import job.
    /// </summary>
    public partial class ImportJob
    {
        private string _addressListId;
        private DateTime? _completedTimestamp;
        private DateTime? _createdTimestamp;
        private string _error;
        private int? _failedItemsCount;
        private ImportDataFormat _importDataFormat;
        private int? _importedItemsCount;
        private string _jobId;
        private string _name;
        private string _preSignedUrl;
        private DateTime? _startTimestamp;
        private ImportJobStatus _status;

        /// <summary>
        /// Gets and sets the property AddressListId. 
        /// <para>
        /// The unique identifier of the address list the import job was created for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string AddressListId
        {
            get { return this._addressListId; }
            set { this._addressListId = value; }
        }

        // Check to see if AddressListId property is set
        internal bool IsSetAddressListId()
        {
            return this._addressListId != null;
        }

        /// <summary>
        /// Gets and sets the property CompletedTimestamp. 
        /// <para>
        /// The timestamp of when the import job was completed.
        /// </para>
        /// </summary>
        public DateTime? CompletedTimestamp
        {
            get { return this._completedTimestamp; }
            set { this._completedTimestamp = value; }
        }

        // Check to see if CompletedTimestamp property is set
        internal bool IsSetCompletedTimestamp()
        {
            return this._completedTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedTimestamp. 
        /// <para>
        /// The timestamp of when the import job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedTimestamp
        {
            get { return this._createdTimestamp; }
            set { this._createdTimestamp = value; }
        }

        // Check to see if CreatedTimestamp property is set
        internal bool IsSetCreatedTimestamp()
        {
            return this._createdTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Error. 
        /// <para>
        /// The reason for failure of an import job.
        /// </para>
        /// </summary>
        public string Error
        {
            get { return this._error; }
            set { this._error = value; }
        }

        // Check to see if Error property is set
        internal bool IsSetError()
        {
            return this._error != null;
        }

        /// <summary>
        /// Gets and sets the property FailedItemsCount. 
        /// <para>
        /// The number of addresses in the input that failed to get imported into address list.
        /// </para>
        /// </summary>
        public int? FailedItemsCount
        {
            get { return this._failedItemsCount; }
            set { this._failedItemsCount = value; }
        }

        // Check to see if FailedItemsCount property is set
        internal bool IsSetFailedItemsCount()
        {
            return this._failedItemsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportDataFormat. 
        /// <para>
        /// The format of the input for the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportDataFormat ImportDataFormat
        {
            get { return this._importDataFormat; }
            set { this._importDataFormat = value; }
        }

        // Check to see if ImportDataFormat property is set
        internal bool IsSetImportDataFormat()
        {
            return this._importDataFormat != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedItemsCount. 
        /// <para>
        /// The number of addresses in the input that were successfully imported into the address
        /// list.
        /// </para>
        /// </summary>
        public int? ImportedItemsCount
        {
            get { return this._importedItemsCount; }
            set { this._importedItemsCount = value; }
        }

        // Check to see if ImportedItemsCount property is set
        internal bool IsSetImportedItemsCount()
        {
            return this._importedItemsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property JobId. 
        /// <para>
        /// The identifier of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string JobId
        {
            get { return this._jobId; }
            set { this._jobId = value; }
        }

        // Check to see if JobId property is set
        internal bool IsSetJobId()
        {
            return this._jobId != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// A user-friendly name for the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
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
        /// Gets and sets the property PreSignedUrl. 
        /// <para>
        /// The pre-signed URL target for uploading the input file.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true)]
        public string PreSignedUrl
        {
            get { return this._preSignedUrl; }
            set { this._preSignedUrl = value; }
        }

        // Check to see if PreSignedUrl property is set
        internal bool IsSetPreSignedUrl()
        {
            return this._preSignedUrl != null;
        }

        /// <summary>
        /// Gets and sets the property StartTimestamp. 
        /// <para>
        /// The timestamp of when the import job was started.
        /// </para>
        /// </summary>
        public DateTime? StartTimestamp
        {
            get { return this._startTimestamp; }
            set { this._startTimestamp = value; }
        }

        // Check to see if StartTimestamp property is set
        internal bool IsSetStartTimestamp()
        {
            return this._startTimestamp.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the import job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ImportJobStatus Status
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