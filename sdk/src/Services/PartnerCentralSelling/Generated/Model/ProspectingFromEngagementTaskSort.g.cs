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

namespace Amazon.PartnerCentralSelling.Model
{
    /// <summary>
    /// Specifies the sort configuration for <c>ListProspectingFromEngagementTasks</c>. Contains
    /// the field to sort by and the sort direction.
    /// </summary>
    public partial class ProspectingFromEngagementTaskSort
    {
        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// The field by which to sort the returned tasks. Valid values: <c>StartTime</c> (task
        /// creation timestamp), <c>TaskName</c> (alphabetically by task name), and <c>FailedEngagementCount</c>
        /// (number of failed engagements).
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public ProspectingFromEngagementTaskSortName SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The direction in which to sort the results. Use <c>ASCENDING</c> to return the smallest
        /// or earliest values first, or <c>DESCENDING</c> to return the largest or most recent
        /// values first.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
