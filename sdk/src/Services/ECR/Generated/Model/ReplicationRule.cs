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
 * Do not modify this file. This file is generated from the ecr-2015-09-21.normal.json service model.
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
namespace Amazon.ECR.Model
{
    /// <summary>
    /// An array of objects representing the replication destinations and repository filters
    /// for a replication configuration.
    /// </summary>
    public partial class ReplicationRule
    {
        private List<ReplicationDestination> _destinations = AWSConfigs.InitializeCollections ? new List<ReplicationDestination>() : null;
        private List<RepositoryFilter> _repositoryFilters = AWSConfigs.InitializeCollections ? new List<RepositoryFilter>() : null;

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// An array of objects representing the destination for a replication rule.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=100)]
        public List<ReplicationDestination> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RepositoryFilters. 
        /// <para>
        /// An array of objects representing the filters for a replication rule. Specifying a
        /// repository filter for a replication rule provides a method for controlling which repositories
        /// in a private registry are replicated.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<RepositoryFilter> RepositoryFilters
        {
            get { return this._repositoryFilters; }
            set { this._repositoryFilters = value; }
        }

        // Check to see if RepositoryFilters property is set
        internal bool IsSetRepositoryFilters()
        {
            return this._repositoryFilters != null && (this._repositoryFilters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}