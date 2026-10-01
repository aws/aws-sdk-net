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

namespace Amazon.EKS.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeClusterVersions operation. Lists available
    /// Kubernetes versions for Amazon EKS clusters.
    /// </summary>
    public partial class DescribeClusterVersionsRequest : AmazonEKSRequest
    {
        /// <summary>
        /// Gets and sets the property ClusterType. 
        /// <para>
        /// The type of cluster to filter versions by.
        /// </para>
        /// </summary>
        public string ClusterType { get; set; }

        /// <summary>
        /// Checks to see if the ClusterType property is set.
        /// </summary>
        internal bool IsSetClusterType() => this.ClusterType != null;

        /// <summary>
        /// Gets and sets the property ClusterVersions. 
        /// <para>
        /// List of specific cluster versions to describe.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> ClusterVersions { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ClusterVersions property is set.
        /// </summary>
        internal bool IsSetClusterVersions() => this.ClusterVersions != null && (this.ClusterVersions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DefaultOnly. 
        /// <para>
        /// Filter to show only default versions.
        /// </para>
        /// </summary>
        public bool? DefaultOnly { get; set; }

        /// <summary>
        /// Checks to see if the DefaultOnly property is set.
        /// </summary>
        internal bool IsSetDefaultOnly() => this.DefaultOnly.HasValue;

        /// <summary>
        /// Gets and sets the property IncludeAll. 
        /// <para>
        /// Include all available versions in the response.
        /// </para>
        /// </summary>
        public bool? IncludeAll { get; set; }

        /// <summary>
        /// Checks to see if the IncludeAll property is set.
        /// </summary>
        internal bool IsSetIncludeAll() => this.IncludeAll.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// Maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 100)]
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Pagination token for the next set of results.
        /// </para>
        /// </summary>
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property Status. <important> 
        /// <para>
        /// This field is deprecated. Use <c>versionStatus</c> instead, as that field matches
        /// for input and output of this action.
        /// </para>
        ///  </important> 
        /// <para>
        /// Filter versions by their current status.
        /// </para>
        /// </summary>
        [Obsolete("status has been replaced by versionStatus")]
        public ClusterVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property VersionStatus. 
        /// <para>
        /// Filter versions by their current status.
        /// </para>
        /// </summary>
        public VersionStatus VersionStatus { get; set; }

        /// <summary>
        /// Checks to see if the VersionStatus property is set.
        /// </summary>
        internal bool IsSetVersionStatus() => this.VersionStatus != null;
    }
}
