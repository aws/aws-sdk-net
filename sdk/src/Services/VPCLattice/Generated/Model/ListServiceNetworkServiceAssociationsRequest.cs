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

namespace Amazon.VPCLattice.Model
{
    /// <summary>
    /// Container for the parameters to the ListServiceNetworkServiceAssociations operation.
    /// Lists the associations between the service network and the service. You can filter
    /// the list either by service or service network. You must provide either the service
    /// network identifier or the service identifier.
    /// 
    ///  
    /// <para>
    /// Every association in Amazon VPC Lattice is given a unique Amazon Resource Name (ARN),
    /// such as when a service network is associated with a VPC or when a service is associated
    /// with a service network. If the association is for a resource that is shared with another
    /// account, the association will include the local account ID as the prefix in the ARN
    /// for each account the resource is shared with.
    /// </para>
    /// </summary>
    public partial class ListServiceNetworkServiceAssociationsRequest : AmazonVPCLatticeRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _serviceIdentifier;
        private string _serviceNetworkIdentifier;

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
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
        /// A pagination token for the next page of results.
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
        /// Gets and sets the property ServiceIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the service.
        /// </para>
        /// </summary>
        [AWSProperty(Min=17, Max=2048)]
        public string ServiceIdentifier
        {
            get { return this._serviceIdentifier; }
            set { this._serviceIdentifier = value; }
        }

        // Check to see if ServiceIdentifier property is set
        internal bool IsSetServiceIdentifier()
        {
            return this._serviceIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceNetworkIdentifier. 
        /// <para>
        /// The ID or Amazon Resource Name (ARN) of the service network.
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