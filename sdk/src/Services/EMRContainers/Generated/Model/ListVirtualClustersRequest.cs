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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// Container for the parameters to the ListVirtualClusters operation.
    /// Lists information about the specified virtual cluster. Virtual cluster is a managed
    /// entity on Amazon EMR on EKS. You can create, describe, list and delete virtual clusters.
    /// They do not consume any additional resource in your system. A single virtual cluster
    /// maps to a single Kubernetes namespace. Given this relationship, you can model virtual
    /// clusters the same way you model Kubernetes namespaces to meet your requirements.
    /// </summary>
    public partial class ListVirtualClustersRequest : AmazonEMRContainersRequest
    {
        private string _containerProviderId;
        private ContainerProviderType _containerProviderType;
        private DateTime? _createdAfter;
        private DateTime? _createdBefore;
        private int? _maxResults;
        private string _nextToken;
        private List<string> _states = new List<string>();

        /// <summary>
        /// Gets and sets the property ContainerProviderId. 
        /// <para>
        /// The container provider ID of the virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ContainerProviderId
        {
            get { return this._containerProviderId; }
            set { this._containerProviderId = value; }
        }

        // Check to see if ContainerProviderId property is set
        internal bool IsSetContainerProviderId()
        {
            return this._containerProviderId != null;
        }

        /// <summary>
        /// Gets and sets the property ContainerProviderType. 
        /// <para>
        /// The container provider type of the virtual cluster. Amazon EKS is the only supported
        /// type as of now.
        /// </para>
        /// </summary>
        public ContainerProviderType ContainerProviderType
        {
            get { return this._containerProviderType; }
            set { this._containerProviderType = value; }
        }

        // Check to see if ContainerProviderType property is set
        internal bool IsSetContainerProviderType()
        {
            return this._containerProviderType != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAfter. 
        /// <para>
        /// The date and time after which the virtual clusters are created.
        /// </para>
        /// </summary>
        public DateTime CreatedAfter
        {
            get { return this._createdAfter.GetValueOrDefault(); }
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
        /// The date and time before which the virtual clusters are created.
        /// </para>
        /// </summary>
        public DateTime CreatedBefore
        {
            get { return this._createdBefore.GetValueOrDefault(); }
            set { this._createdBefore = value; }
        }

        // Check to see if CreatedBefore property is set
        internal bool IsSetCreatedBefore()
        {
            return this._createdBefore.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of virtual clusters that can be listed.
        /// </para>
        /// </summary>
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The token for the next set of virtual clusters to return. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property States. 
        /// <para>
        /// The states of the requested virtual clusters.
        /// </para>
        /// </summary>
        [AWSProperty(Max=10)]
        public List<string> States
        {
            get { return this._states; }
            set { this._states = value; }
        }

        // Check to see if States property is set
        internal bool IsSetStates()
        {
            return this._states != null && this._states.Count > 0; 
        }

    }
}