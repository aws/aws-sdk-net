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
    /// Container for the parameters to the ListEdgeDeploymentPlans operation. Lists all edge
    /// deployment plans.
    /// </summary>
    public partial class ListEdgeDeploymentPlansRequest : AmazonSageMakerRequest
    {
        /// <summary>
        /// Gets and sets the property CreationTimeAfter. 
        /// <para>
        /// Selects edge deployment plans created after this time.
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
        /// Selects edge deployment plans created before this time.
        /// </para>
        /// </summary>
        public DateTime? CreationTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreationTimeBefore property is set.
        /// </summary>
        internal bool IsSetCreationTimeBefore() => this.CreationTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property DeviceFleetNameContains. 
        /// <para>
        /// Selects edge deployment plans with a device fleet name containing this name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 63)]
        public string DeviceFleetNameContains { get; set; }

        /// <summary>
        /// Checks to see if the DeviceFleetNameContains property is set.
        /// </summary>
        internal bool IsSetDeviceFleetNameContains() => this.DeviceFleetNameContains != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTimeAfter. 
        /// <para>
        /// Selects edge deployment plans that were last updated after this time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeAfter { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimeAfter property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimeAfter() => this.LastModifiedTimeAfter.HasValue;

        /// <summary>
        /// Gets and sets the property LastModifiedTimeBefore. 
        /// <para>
        /// Selects edge deployment plans that were last updated before this time.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTimeBefore { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTimeBefore property is set.
        /// </summary>
        internal bool IsSetLastModifiedTimeBefore() => this.LastModifiedTimeBefore.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to select (50 by default).
        /// </para>
        /// </summary>
        [AWSProperty(Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NameContains. 
        /// <para>
        /// Selects edge deployment plans with names containing this name.
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
        /// The response from the last list when returning a list large enough to need tokening.
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
        /// The column by which to sort the edge deployment plans. Can be one of <c>NAME</c>,
        /// <c>DEVICEFLEETNAME</c>, <c>CREATIONTIME</c>, <c>LASTMODIFIEDTIME</c>.
        /// </para>
        /// </summary>
        public ListEdgeDeploymentPlansSortBy SortBy { get; set; }

        /// <summary>
        /// Checks to see if the SortBy property is set.
        /// </summary>
        internal bool IsSetSortBy() => this.SortBy != null;

        /// <summary>
        /// Gets and sets the property SortOrder. 
        /// <para>
        /// The direction of the sorting (ascending or descending).
        /// </para>
        /// </summary>
        public SortOrder SortOrder { get; set; }

        /// <summary>
        /// Checks to see if the SortOrder property is set.
        /// </summary>
        internal bool IsSetSortOrder() => this.SortOrder != null;
    }
}
