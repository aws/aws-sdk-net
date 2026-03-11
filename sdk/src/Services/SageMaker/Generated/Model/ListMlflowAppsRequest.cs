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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
    /// Container for the parameters to the ListMlflowApps operation.
    /// Lists all MLflow Apps
    /// </summary>
    public partial class ListMlflowAppsRequest : AmazonSageMakerRequest
    {
        private AccountDefaultStatus _accountDefaultStatus;
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private string _defaultForDomainId;
        private int? _maxResults;
        private string _mlflowVersion;
        private string _nextToken;
        private SortMlflowAppBy _sortBy;
        private SortOrder _sortOrder;
        private MlflowAppStatus _status;

        /// <summary>
        /// Gets and sets the property AccountDefaultStatus. 
        /// <para>
        /// Filter for MLflow Apps with the specified <c>AccountDefaultStatus</c>.
        /// </para>
        /// </summary>
        public AccountDefaultStatus AccountDefaultStatus
        {
            get { return this._accountDefaultStatus; }
            set { this._accountDefaultStatus = value; }
        }

        // Check to see if AccountDefaultStatus property is set
        internal bool IsSetAccountDefaultStatus()
        {
            return this._accountDefaultStatus != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// Use the <c>CreatedAfter</c> filter to only list MLflow Apps created after a specific
        /// date and time. Listed MLflow Apps are shown with a date and time such as <c>"2024-03-16T01:46:56+00:00"</c>.
        /// The <c>CreatedAfter</c> parameter takes in a Unix timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedAfter
        {
            get { return this._createdAfter; }
            set { this._createdAfter = value; }
        }

        // Check to see if CreatedAfter property is set
        internal bool IsSetCreatedAfter()
        {
            return this._createdAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBefore. 
        /// <para>
        /// Use the <c>CreatedBefore</c> filter to only list MLflow Apps created before a specific
        /// date and time. Listed MLflow Apps are shown with a date and time such as <c>"2024-03-16T01:46:56+00:00"</c>.
        /// The <c>CreatedAfter</c> parameter takes in a Unix timestamp.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore
        {
            get { return this._createdBefore; }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DefaultForDomainId. 
        /// <para>
        /// Filter for MLflow Apps with the specified default SageMaker Domain ID.
        /// </para>
        /// </summary>
        public string DefaultForDomainId
        {
            get { return this._defaultForDomainId; }
            set { this._defaultForDomainId = value; }
        }

        // Check to see if DefaultForDomainId property is set
        internal bool IsSetDefaultForDomainId()
        {
            return this._defaultForDomainId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of MLflow Apps to list.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public int? MaxResults
        {
            get { return this._maxResults; }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MlflowVersion. 
        /// <para>
        /// Filter for Mlflow Apps with the specified version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=16)]
        public string MlflowVersion
        {
            get { return this._mlflowVersion; }
            set { this._mlflowVersion = value; }
        }

        // Check to see if MlflowVersion property is set
        internal bool IsSetMlflowVersion()
        {
            return this._mlflowVersion != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the previous response was truncated, use this token in your next request to receive
        /// the next set of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=8192)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// Filter for MLflow Apps sorting by name, creation time, or creation status.
        /// </para>
        /// </summary>
        public SortMlflowAppBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// Change the order of the listed MLflow Apps. By default, MLflow Apps are listed in
        /// <c>Descending</c> order by creation time. To change the list order, specify <c>SortOrder</c>
        /// to be <c>Ascending</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder
        {
            get { return this._sortOrder; }
            set { this._sortOrder = value; }
        }

        // Check to see if SortOrder property is set
        internal bool IsSetSortOrder()
        {
            return this._sortOrder != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Filter for Mlflow apps with a specific creation status.
        /// </para>
        /// </summary>
        public MlflowAppStatus Status
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