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
 * Do not modify this file. This file is generated from the globalaccelerator-2018-08-08.normal.json service model.
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
namespace Amazon.GlobalAccelerator.Model
{
    /// <summary>
    /// Container for the parameters to the ListCustomRoutingPortMappingsByDestination operation.
    /// List the port mappings for a specific EC2 instance (destination) in a VPC subnet endpoint.
    /// The response is the mappings for one destination IP address. This is useful when your
    /// subnet endpoint has mappings that span multiple custom routing accelerators in your
    /// account, or for scenarios where you only want to list the port mappings for a specific
    /// destination instance.
    /// </summary>
    public partial class ListCustomRoutingPortMappingsByDestinationRequest : AmazonGlobalAcceleratorRequest
    {
        private string _destinationAddress;
        private string _endpointId;
        private int? _maxResults;
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property DestinationAddress. 
        /// <para>
        /// The endpoint IP address in a virtual private cloud (VPC) subnet for which you want
        /// to receive back port mappings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string DestinationAddress
        {
            get { return this._destinationAddress; }
            set { this._destinationAddress = value; }
        }

        // Check to see if DestinationAddress property is set
        internal bool IsSetDestinationAddress()
        {
            return this._destinationAddress != null;
        }

        /// <summary>
        /// Gets and sets the property EndpointId. 
        /// <para>
        /// The ID for the virtual private cloud (VPC) subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=255)]
        public string EndpointId
        {
            get { return this._endpointId; }
            set { this._endpointId = value; }
        }

        // Check to see if EndpointId property is set
        internal bool IsSetEndpointId()
        {
            return this._endpointId != null;
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The number of destination port mappings that you want to return with this call. The
        /// default value is 10.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20000)]
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
        /// The token for the next set of results. You receive this token from a previous call.
        /// </para>
        /// </summary>
        [AWSProperty(Max=255)]
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

    }
}