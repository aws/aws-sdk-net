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
    /// Container for the parameters to the ListModelPackages operation. Lists the model packages
    /// that have been created.
    /// </summary>
    public partial class ListModelPackagesRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// A filter that returns only model packages created after the specified time (timestamp).
        /// </para>
        /// </summary>
        public DateTime? CreationTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeAfter property is set.
        /// </summary>
        internal bool IsSetCreationTimeAfter() => this.CreationTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property CreationTimeBefore. 
        /// <para>
        /// A filter that returns only model packages created before the specified time (timestamp).
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of model packages to return in the response.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property ModelApprovalStatus. 
        /// <para>
        /// A filter that returns only the model packages with the specified approval status.
        /// </para>
        /// </summary>
        public ModelApprovalStatus ModelApprovalStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelApprovalStatus property is set.
        /// </summary>
        internal bool IsSetModelApprovalStatus() => this.ModelApprovalStatus != null;

        /// <summary>
        /// Gets and sets the property ModelPackageGroupName. 
        /// <para>
        /// A filter that returns only model versions that belong to the specified model group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 170)]
        public string ModelPackageGroupName { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageGroupName property is set.
        /// </summary>
        internal bool IsSetModelPackageGroupName() => this.ModelPackageGroupName != null;

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
        public ModelPackageType ModelPackageType { get; set; }

        /// <summary>
        /// Checks to see if the ModelPackageType property is set.
        /// </summary>
        internal bool IsSetModelPackageType() => this.ModelPackageType != null;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// A string in the model package name. This filter returns only model packages whose
        /// name contains the specified string.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string NameContains { get; set; }

        /// <summary>
        /// Checks to see if the NameContains property is set.
        /// </summary>
        internal bool IsSetNameContains() => this.NameContains != null;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response to a previous <c>ListModelPackages</c> request was truncated, the
        /// response includes a <c>NextToken</c>. To retrieve the next set of model packages,
        /// use the token in the next request.
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
        /// The parameter by which to sort the results. The default is <c>CreationTime</c>.
        /// </para>
        /// </summary>
        public ModelPackageSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The sort order for the results. The default is <c>Ascending</c>.
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
