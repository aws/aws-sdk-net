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
 * Do not modify this file. This file is generated from the vpc-lattice-2022-11-30.normal.json service model.
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
namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the ListServiceNetworkResourceAssociations operation.
    /// Lists the associations between a service network and a resource configuration.
    /// </summary>
    public partial class ListServiceNetworkResourceAssociationsRequest : AmazonVPCLatticeRequest
    {
        private bool? _includeChildren;
        private int? _maxResults;
        private string _nextToken;
        private string _resourceConfigurationIdentifier;
        private string _serviceNetworkIdentifier;

        /// <summary>
        /// Gets and sets the property IncludeChildren. 
        /// <para>
        /// Include service network resource associations of the child resource configuration
        /// with the grouped resource configuration.
        /// </para>
        ///  
        /// <para>
        /// The type is boolean and the default value is false.
        /// </para>
        /// </summary>
        public bool? IncludeChildren
        {
            get { return this._includeChildren; }
            set { this._includeChildren = value; }
        }

        // Check to see if IncludeChildren property is set
        internal bool IsSetIncludeChildren()
        {
            return this._includeChildren.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum page size.
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
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If there are additional results, a pagination token for the next page of results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property ResourceConfigurationIdentifier. 
        /// <para>
        /// The ID of the resource configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ResourceConfigurationIdentifier
        {
            get { return this._resourceConfigurationIdentifier; }
            set { this._resourceConfigurationIdentifier = value; }
        }

        // Check to see if ResourceConfigurationIdentifier property is set
        internal bool IsSetResourceConfigurationIdentifier()
        {
            return this._resourceConfigurationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkIdentifier. 
        /// <para>
        /// The ID of the service network.
        /// </para>
        /// </summary>
        [AWSProperty(Min=3, Max=2048)]
        public string ServiceNetworkIdentifier
        {
            get { return this._serviceNetworkIdentifier; }
            set { this._serviceNetworkIdentifier = value; }
        }

        // Check to see if ServiceNetworkIdentifier property is set
        internal bool IsSetServiceNetworkIdentifier()
        {
            return this._serviceNetworkIdentifier != null;
        }

    }
}