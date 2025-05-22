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
    /// Container for the parameters to the ListModelPackages operation.
    /// Lists the model packages that have been created.
    /// </summary>
    public partial class ListModelPackagesRequest : AmazonSageMakerRequest
    {
        private DateTime? _creationTimeAfter;
        private DateTime? _creationTimeBefore;
        private int? _maxResults;
        private ModelApprovalStatus _modelApprovalStatus;
        private string _modelPackageGroupName;
        private ModelPackageType _modelPackageType;
        private string _nameContains;
        private string _nextToken;
        private ModelPackageSortBy _sortBy;
        private SortOrder _sortOrder;

        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns only model packages created after the specified time (timestamp).
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter
        {
            get { return this._creationTimeAfter; }
            set { this._creationTimeAfter = value; }
        }

        // Check to see if CreationTimeAfter property is set
        internal bool IsSetCreationTimeAfter()
        {
            return this._creationTimeAfter.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// A filter that returns only model packages created before the specified time (timestamp).
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore
        {
            get { return this._creationTimeBefore; }
            set { this._creationTimeBefore = value; }
        }

        // Check to see if CreationTimeBefore property is set
        internal bool IsSetCreationTimeBefore()
        {
            return this._creationTimeBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of model packages to return in the response.
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
        /// Gets and sets the property ModelApprovalStatus. 
        /// <para>
        /// A filter that returns only the model packages with the specified approval status.
        /// </para>
        /// </summary>
        public ModelApprovalStatus ModelApprovalStatus
        {
            get { return this._modelApprovalStatus; }
            set { this._modelApprovalStatus = value; }
        }

        // Check to see if ModelApprovalStatus property is set
        internal bool IsSetModelApprovalStatus()
        {
            return this._modelApprovalStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// A filter that returns only model versions that belong to the specified model group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=170)]
        public string ModelPackageGroupName
        {
            get { return this._modelPackageGroupName; }
            set { this._modelPackageGroupName = value; }
        }

        // Check to see if ModelPackageGroupName property is set
        internal bool IsSetModelPackageGroupName()
        {
            return this._modelPackageGroupName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelPackageType. 
        /// <para>
        /// A filter that returns only the model packages of the specified type. This can be one
        /// of the following values.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>UNVERSIONED</c> - List only unversioined models. This is the default value if
        /// no <c>ModelPackageType</c> is specified.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>VERSIONED</c> - List only versioned models.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BOTH</c> - List both versioned and unversioned models.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelPackageType ModelPackageType
        {
            get { return this._modelPackageType; }
            set { this._modelPackageType = value; }
        }

        // Check to see if ModelPackageType property is set
        internal bool IsSetModelPackageType()
        {
            return this._modelPackageType != null;
        }

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// A string in the model package name. This filter returns only model packages whose
        /// name contains the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=63)]
        public string NameContains
        {
            get { return this._nameContains; }
            set { this._nameContains = value; }
        }

        // Check to see if NameContains property is set
        internal bool IsSetNameContains()
        {
            return this._nameContains != null;
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response to a previous <c>ListModelPackages</c> request was truncated, the
        /// response includes a <c>NextToken</c>. To retrieve the next set of model packages,
        /// use the token in the next request.
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
        /// The parameter by which to sort the results. The default is <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public ModelPackageSortBy SortBy
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
        /// The sort order for the results. The default is <c>Ascending</c>.
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

    }
}