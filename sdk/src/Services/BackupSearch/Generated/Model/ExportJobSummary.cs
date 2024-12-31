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
 * Do not modify this file. This file is generated from the backupsearch-2018-05-10.normal.json service model.
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
namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// This is the summary of an export job.
    /// </summary>
    public partial class ExportJobSummary
    {
        private DateTime? _completionTime;
        private DateTime? _creationTime;
        private string _exportJobArn;
        private string _exportJobIdentifier;
        private string _searchJobArn;
        private ExportJobStatus _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// This is a timestamp of the time the export job compeleted.
        /// </para>
        /// </summary>
        public DateTime CompletionTime
        {
            get { return this._completionTime.GetValueOrDefault(); }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// This is a timestamp of the time the export job was created.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property ExportJobArn. 
        /// <para>
        /// This is the unique ARN (Amazon Resource Name) that belongs to the new export job.
        /// </para>
        /// </summary>
        public string ExportJobArn
        {
            get { return this._exportJobArn; }
            set { this._exportJobArn = value; }
        }

        // Check to see if ExportJobArn property is set
        internal bool IsSetExportJobArn()
        {
            return this._exportJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property ExportJobIdentifier. 
        /// <para>
        /// This is the unique string that identifies a specific export job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ExportJobIdentifier
        {
            get { return this._exportJobIdentifier; }
            set { this._exportJobIdentifier = value; }
        }

        // Check to see if ExportJobIdentifier property is set
        internal bool IsSetExportJobIdentifier()
        {
            return this._exportJobIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SearchJobArn. 
        /// <para>
        /// The unique string that identifies the Amazon Resource Name (ARN) of the specified
        /// search job.
        /// </para>
        /// </summary>
        public string SearchJobArn
        {
            get { return this._searchJobArn; }
            set { this._searchJobArn = value; }
        }

        // Check to see if SearchJobArn property is set
        internal bool IsSetSearchJobArn()
        {
            return this._searchJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the export job is one of the following:
        /// </para>
        ///  
        /// <para>
        ///  <c>CREATED</c>; <c>RUNNING</c>; <c>FAILED</c>; or <c>COMPLETED</c>.
        /// </para>
        /// </summary>
        public ExportJobStatus Status
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
        /// A status message is a string that is returned for an export job.
        /// </para>
        ///  
        /// <para>
        /// A status message is included for any status other than <c>COMPLETED</c> without issues.
        /// </para>
        /// </summary>
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

    }
}