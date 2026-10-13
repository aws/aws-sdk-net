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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// Container for the parameters to the ListMlflowApps operation. Lists all MLflow Apps
    /// </summary>
    public partial class ListMlflowAppsRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property AccountDefaultStatus. 
        /// <para>
        /// Filter for MLflow Apps with the specified <c>AccountDefaultStatus</c>.
        /// </para>
        /// </summary>
        public AccountDefaultStatus AccountDefaultStatus { get; set; }

        /// <summary>
        /// Checks to see if the AccountDefaultStatus property is set.
        /// </summary>
        internal bool IsSetAccountDefaultStatus() => this.AccountDefaultStatus != null;

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Use the <c>CreatedAfter</c> filter to only list MLflow Apps created after a specific
        /// date and time. Listed MLflow Apps are shown with a date and time such as <c>"2024-03-16T01:46:56+00:00"</c>.
        /// The <c>CreatedAfter</c> parameter takes in a Unix timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAfter property is set.
        /// </summary>
        internal bool IsSetCreatedAfter() => this.CreatedAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Use the <c>CreatedBefore</c> filter to only list MLflow Apps created before a specific
        /// date and time. Listed MLflow Apps are shown with a date and time such as <c>"2024-03-16T01:46:56+00:00"</c>.
        /// The <c>CreatedAfter</c> parameter takes in a Unix timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property DefaultForDomainId. 
        /// <para>
        /// Filter for MLflow Apps with the specified default SageMaker Domain ID.
        /// </para>
        /// </summary>
        public string DefaultForDomainId { get; set; }

        /// <summary>
        /// Checks to see if the DefaultForDomainId property is set.
        /// </summary>
        internal bool IsSetDefaultForDomainId() => this.DefaultForDomainId != null;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of MLflow Apps to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property MlflowVersion. 
        /// <para>
        /// Filter for Mlflow Apps with the specified version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 16)]
        public string MlflowVersion { get; set; }

        /// <summary>
        /// Checks to see if the MlflowVersion property is set.
        /// </summary>
        internal bool IsSetMlflowVersion() => this.MlflowVersion != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was truncated, use this token in your next request to receive
        /// the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 8192)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Filter for MLflow Apps sorting by name, creation time, or creation status.
        /// </para>
        /// </summary>
        public SortMlflowAppBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Change the order of the listed MLflow Apps. By default, MLflow Apps are listed in
        /// <c>Descending</c> order by creation time. To change the list order, specify <c>SortOrder</c>
        /// to be <c>Ascending</c>.
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
        /// Filter for Mlflow apps with a specific creation status.
        /// </para>
        /// </summary>
        public MlflowAppStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;
    }
}
