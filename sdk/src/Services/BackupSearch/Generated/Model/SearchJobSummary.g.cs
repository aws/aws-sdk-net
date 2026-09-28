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
    /// This is information pertaining to a search job.
    /// </summary>
    public partial class SearchJobSummary
    {
        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// This is the completion time of the search job.
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
        /// This is the creation time of the search job.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// This is the name of the search job.
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
        public string SearchJobArn { get; set; }

        /// <summary>
        /// Checks to see if the SearchJobArn property is set.
        /// </summary>
        internal bool IsSetSearchJobArn() => this.SearchJobArn != null;

        /// <summary>
        /// Gets and sets the property SearchJobIdentifier. 
        /// <para>
        /// The unique string that specifies the search job.
        /// </para>
        /// </summary>
        public string SearchJobIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the SearchJobIdentifier property is set.
        /// </summary>
        internal bool IsSetSearchJobIdentifier() => this.SearchJobIdentifier != null;

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
        /// This is the status of the search job.
        /// </para>
        /// </summary>
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
