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

namespace Amazon.DataZone.Model
{
    /// <summary>
    /// Container for the parameters to the ListNotebookRuns operation. Lists <a href="https://docs.aws.amazon.com/sagemaker-unified-studio/latest/userguide/notebooks.html">notebook
    /// runs</a> in Amazon SageMaker Unified Studio.
    /// </summary>
    public partial class ListNotebookRunsRequest : AmazonDataZoneRequest
    {
        /// <summary>
        /// Gets and sets the property DomainIdentifier. 
        /// <para>
        /// The identifier of the Amazon SageMaker Unified Studio domain in which to list notebook
        /// runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DomainIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DomainIdentifier property is set.
        /// </summary>
        internal bool IsSetDomainIdentifier() => this.DomainIdentifier != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of notebook runs to return in a single call. When the number of
        /// notebook runs exceeds the value of <c>MaxResults</c>, the response contains a <c>NextToken</c>
        /// value.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// When the number of notebook runs is greater than the default value for the <c>MaxResults</c>
        /// parameter, or if you explicitly specify a value for <c>MaxResults</c> that is less
        /// than the number of notebook runs, the response includes a pagination token named <c>NextToken</c>.
        /// You can specify this <c>NextToken</c> value in a subsequent call to <c>ListNotebookRuns</c>
        /// to list the next set of notebook runs.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property NotebookIdentifier. 
        /// <para>
        /// The identifier of the notebook to filter runs by.
        /// </para>
        /// </summary>
        public string NotebookIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the NotebookIdentifier property is set.
        /// </summary>
        internal bool IsSetNotebookIdentifier() => this.NotebookIdentifier != null;

        /// <summary>
        /// Gets and sets the property OwningProjectIdentifier. 
        /// <para>
        /// The identifier of the project that owns the notebook runs.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OwningProjectIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the OwningProjectIdentifier property is set.
        /// </summary>
        internal bool IsSetOwningProjectIdentifier() => this.OwningProjectIdentifier != null;

        /// <summary>
        /// Gets and sets the property ScheduleIdentifier. 
        /// <para>
        /// The identifier of the schedule to filter notebook runs by.
        /// </para>
        /// </summary>
        public string ScheduleIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the ScheduleIdentifier property is set.
        /// </summary>
        internal bool IsSetScheduleIdentifier() => this.ScheduleIdentifier != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for the results.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status to filter notebook runs by.
        /// </para>
        /// </summary>
        public NotebookRunStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
