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
    /// This is information pertaining to a search job.
    /// </summary>
    public partial class SearchJobSummary
    {
        private DateTime? _completionTime;
        private DateTime? _creationTime;
        private string _name;
        private string _searchJobArn;
        private string _searchJobIdentifier;
        private SearchScopeSummary _searchScopeSummary;
        private SearchJobState _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// This is the completion time of the search job.
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
        /// This is the creation time of the search job.
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
        /// Gets and sets the property Name. 
        /// <para>
        /// This is the name of the search job.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property SearchJobIdentifier. 
        /// <para>
        /// The unique string that specifies the search job.
        /// </para>
        /// </summary>
        public string SearchJobIdentifier
        {
            get { return this._searchJobIdentifier; }
            set { this._searchJobIdentifier = value; }
        }

        // Check to see if SearchJobIdentifier property is set
        internal bool IsSetSearchJobIdentifier()
        {
            return this._searchJobIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property SearchScopeSummary. 
        /// <para>
        /// Returned summary of the specified search job scope, including: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TotalBackupsToScanCount, the number of recovery points returned by the search.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// TotalItemsToScanCount, the number of items returned by the search.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public SearchScopeSummary SearchScopeSummary
        {
            get { return this._searchScopeSummary; }
            set { this._searchScopeSummary = value; }
        }

        // Check to see if SearchScopeSummary property is set
        internal bool IsSetSearchScopeSummary()
        {
            return this._searchScopeSummary != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// This is the status of the search job.
        /// </para>
        /// </summary>
        public SearchJobState Status
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
        /// A status message will be returned for either a earch job with a status of <c>ERRORED</c>
        /// or a status of <c>COMPLETED</c> jobs with issues.
        /// </para>
        ///  
        /// <para>
        /// For example, a message may say that a search contained recovery points unable to be
        /// scanned because of a permissions issue.
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