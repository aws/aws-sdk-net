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
    /// Container for the parameters to the ListResourceEndpointAssociations operation.
    /// Lists the associations for the specified VPC endpoint.
    /// </summary>
    public partial class ListResourceEndpointAssociationsRequest : AmazonVPCLatticeRequest
    {
        private int? _maxResults;
        private string _nextToken;
        private string _resourceConfigurationIdentifier;
        private string _resourceEndpointAssociationIdentifier;
        private string _vpcEndpointId;
        private string _vpcEndpointOwner;

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
        /// Gets and sets the property ResourceConfigurationIdentifier. 
        /// <para>
        /// The ID for the resource configuration associated with the VPC endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property ResourceEndpointAssociationIdentifier. 
        /// <para>
        /// The ID of the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=21, Max=2048)]
        public string ResourceEndpointAssociationIdentifier
        {
            get { return this._resourceEndpointAssociationIdentifier; }
            set { this._resourceEndpointAssociationIdentifier = value; }
        }

        // Check to see if ResourceEndpointAssociationIdentifier property is set
        internal bool IsSetResourceEndpointAssociationIdentifier()
        {
            return this._resourceEndpointAssociationIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointId. 
        /// <para>
        /// The ID of the VPC endpoint in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=22, Max=22)]
        public string VpcEndpointId
        {
            get { return this._vpcEndpointId; }
            set { this._vpcEndpointId = value; }
        }

        // Check to see if VpcEndpointId property is set
        internal bool IsSetVpcEndpointId()
        {
            return this._vpcEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointOwner. 
        /// <para>
        /// The owner of the VPC endpoint in the association.
        /// </para>
        /// </summary>
        [AWSProperty(Min=12, Max=12)]
        public string VpcEndpointOwner
        {
            get { return this._vpcEndpointOwner; }
            set { this._vpcEndpointOwner = value; }
        }

        // Check to see if VpcEndpointOwner property is set
        internal bool IsSetVpcEndpointOwner()
        {
            return this._vpcEndpointOwner != null;
        }

    }
}