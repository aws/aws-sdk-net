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

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the ListVirtualClusters operation. Lists information
    /// about the specified virtual cluster. Virtual cluster is a managed entity on Amazon
    /// EMR on EKS. You can create, update, describe, list and delete virtual clusters. They
    /// do not consume any additional resource in your system. A single virtual cluster maps
    /// to a single Kubernetes namespace. Given this relationship, you can model virtual clusters
    /// the same way you model Kubernetes namespaces to meet your requirements.
    /// </summary>
    public partial class ListVirtualClustersRequest : AmazonEMRContainersRequest
    {
        /// <summary>
        /// Gets and sets the property ContainerProviderId. 
        /// <para>
        /// The container provider ID of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ContainerProviderId { get; set; }

        /// <summary>
        /// Checks to see if the ContainerProviderId property is set.
        /// </summary>
        internal bool IsSetContainerProviderId() => this.ContainerProviderId != null;

        /// <summary>
        /// Gets and sets the property ContainerProviderType. 
        /// <para>
        /// The container provider type of the virtual cluster. Amazon EKS is the only supported
        /// type as of now.
        /// </para>
        /// </summary>
        public ContainerProviderType ContainerProviderType { get; set; }

        /// <summary>
        /// Checks to see if the ContainerProviderType property is set.
        /// </summary>
        internal bool IsSetContainerProviderType() => this.ContainerProviderType != null;

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// The date and time after which the virtual clusters are created.
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
        /// The date and time before which the virtual clusters are created.
        /// </para>
        /// </summary>
        public DateTime? CreatedBefore { get; set; }

        /// <summary>
        /// Checks to see if the CreatedBefore property is set.
        /// </summary>
        internal bool IsSetCreatedBefore() => this.CreatedBefore.HasValue;

        /// <summary>
        /// Gets and sets the property EksAccessEntryIntegrated. 
        /// <para>
        /// Optional Boolean that specifies whether the operation should return the virtual clusters
        /// that have the access entry integration enabled or disabled. If not specified, the
        /// operation returns all applicable virtual clusters.
        /// </para>
        /// </summary>
        public bool? EksAccessEntryIntegrated { get; set; }

        /// <summary>
        /// Checks to see if the EksAccessEntryIntegrated property is set.
        /// </summary>
        internal bool IsSetEksAccessEntryIntegrated() => this.EksAccessEntryIntegrated.HasValue;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of virtual clusters that can be listed.
        /// </para>
        /// </summary>
        public int? MaxResults { get; set; }

        /// <summary>
        /// Checks to see if the MaxResults property is set.
        /// </summary>
        internal bool IsSetMaxResults() => this.MaxResults.HasValue;

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of virtual clusters to return. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string NextToken { get; set; }

        /// <summary>
        /// Checks to see if the NextToken property is set.
        /// </summary>
        internal bool IsSetNextToken() => this.NextToken != null;

        /// <summary>
        /// Gets and sets the property States. 
        /// <para>
        /// The states of the requested virtual clusters.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 10)]
        public List<string> States { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the States property is set.
        /// </summary>
        internal bool IsSetStates() => this.States != null && (this.States.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
