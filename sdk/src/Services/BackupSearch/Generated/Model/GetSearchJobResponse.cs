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
    /// This is the response object from the GetSearchJob operation.
    /// </summary>
    public partial class GetSearchJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _completionTime;
        private DateTime? _creationTime;
        private CurrentSearchProgress _currentSearchProgress;
        private string _encryptionKeyArn;
        private ItemFilters _itemFilters;
        private string _name;
        private string _searchJobArn;
        private string _searchJobIdentifier;
        private SearchScope _searchScope;
        private SearchScopeSummary _searchScopeSummary;
        private SearchJobState _status;
        private string _statusMessage;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time that a search job completed, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CompletionTime</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
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
        /// The date and time that a search job was created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CompletionTime</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
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
        /// Gets and sets the property CurrentSearchProgress. 
        /// <para>
        /// Returns numbers representing BackupsScannedCount, ItemsScanned, and ItemsMatched.
        /// </para>
        /// </summary>
        public CurrentSearchProgress CurrentSearchProgress
        {
            get { return this._currentSearchProgress; }
            set { this._currentSearchProgress = value; }
        }

        // Check to see if CurrentSearchProgress property is set
        internal bool IsSetCurrentSearchProgress()
        {
            return this._currentSearchProgress != null;
        }

        /// <summary>
        /// Gets and sets the property EncryptionKeyArn. 
        /// <para>
        /// The encryption key for the specified search job.
        /// </para>
        ///  
        /// <para>
        /// Example: <c>arn:aws:kms:us-west-2:111122223333:key/1234abcd-12ab-34cd-56ef-1234567890ab</c>.
        /// </para>
        /// </summary>
        public string EncryptionKeyArn
        {
            get { return this._encryptionKeyArn; }
            set { this._encryptionKeyArn = value; }
        }

        // Check to see if EncryptionKeyArn property is set
        internal bool IsSetEncryptionKeyArn()
        {
            return this._encryptionKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ItemFilters. 
        /// <para>
        /// Item Filters represent all input item properties specified when the search was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ItemFilters ItemFilters
        {
            get { return this._itemFilters; }
            set { this._itemFilters = value; }
        }

        // Check to see if ItemFilters property is set
        internal bool IsSetItemFilters()
        {
            return this._itemFilters != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Returned name of the specified search job.
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
        [AWSProperty(Required=true)]
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
        /// The unique string that identifies the specified search job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property SearchScope. 
        /// <para>
        /// The search scope is all backup properties input into a search.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SearchScope SearchScope
        {
            get { return this._searchScope; }
            set { this._searchScope = value; }
        }

        // Check to see if SearchScope property is set
        internal bool IsSetSearchScope()
        {
            return this._searchScope != null;
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
        /// The current status of the specified search job.
        /// </para>
        ///  
        /// <para>
        /// A search job may have one of the following statuses: <c>RUNNING</c>; <c>COMPLETED</c>;
        /// <c>STOPPED</c>; <c>FAILED</c>; <c>TIMED_OUT</c>; or <c>EXPIRED</c> .
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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