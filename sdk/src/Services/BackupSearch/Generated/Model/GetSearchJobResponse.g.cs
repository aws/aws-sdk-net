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

namespace Amazon.BackupSearch.Model
{
    /// <summary>
    /// This is the response object from the GetSearchJob operation.
    /// </summary>
    public partial class GetSearchJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// The date and time that a search job completed, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CompletionTime</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime { get; set; }

        /// <summary>
        /// Checks to see if the CompletionTime property is set.
        /// </summary>
        internal bool IsSetCompletionTime() => this.CompletionTime.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The date and time that a search job was created, in Unix format and Coordinated Universal
        /// Time (UTC). The value of <c>CompletionTime</c> is accurate to milliseconds. For example,
        /// the value 1516925490.087 represents Friday, January 26, 2018 12:11:30.087 AM.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CurrentSearchProgress. 
        /// <para>
        /// Returns numbers representing BackupsScannedCount, ItemsScanned, and ItemsMatched.
        /// </para>
        /// </summary>
        public CurrentSearchProgress CurrentSearchProgress { get; set; }

        /// <summary>
        /// Checks to see if the CurrentSearchProgress property is set.
        /// </summary>
        internal bool IsSetCurrentSearchProgress() => this.CurrentSearchProgress != null;

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
        public string EncryptionKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionKeyArn property is set.
        /// </summary>
        internal bool IsSetEncryptionKeyArn() => this.EncryptionKeyArn != null;

        /// <summary>
        /// Gets and sets the property ItemFilters. 
        /// <para>
        /// Item Filters represent all input item properties specified when the search was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ItemFilters ItemFilters { get; set; }

        /// <summary>
        /// Checks to see if the ItemFilters property is set.
        /// </summary>
        internal bool IsSetItemFilters() => this.ItemFilters != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// Returned name of the specified search job.
        /// </para>
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property SearchJobArn. 
        /// <para>
        /// The unique string that identifies the Amazon Resource Name (ARN) of the specified
        /// search job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SearchJobArn { get; set; }

        /// <summary>
        /// Checks to see if the SearchJobArn property is set.
        /// </summary>
        internal bool IsSetSearchJobArn() => this.SearchJobArn != null;

        /// <summary>
        /// Gets and sets the property SearchJobIdentifier. 
        /// <para>
        /// The unique string that identifies the specified search job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string SearchJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SearchJobIdentifier property is set.
        /// </summary>
        internal bool IsSetSearchJobIdentifier() => this.SearchJobIdentifier != null;

        /// <summary>
        /// Gets and sets the property SearchScope. 
        /// <para>
        /// The search scope is all backup properties input into a search.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SearchScope SearchScope { get; set; }

        /// <summary>
        /// Checks to see if the SearchScope property is set.
        /// </summary>
        internal bool IsSetSearchScope() => this.SearchScope != null;

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
        public SearchScopeSummary SearchScopeSummary { get; set; }

        /// <summary>
        /// Checks to see if the SearchScopeSummary property is set.
        /// </summary>
        internal bool IsSetSearchScopeSummary() => this.SearchScopeSummary != null;

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
        [AWSProperty(Required = true)]
        public SearchJobState Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

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
        public string StatusMessage { get; set; }

        /// <summary>
        /// Checks to see if the StatusMessage property is set.
        /// </summary>
        internal bool IsSetStatusMessage() => this.StatusMessage != null;
    }
}
