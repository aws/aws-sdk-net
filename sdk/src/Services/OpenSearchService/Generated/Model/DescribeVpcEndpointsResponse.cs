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
 * Do not modify this file. This file is generated from the opensearch-2021-01-01.normal.json service model.
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
namespace Amazon.OpenSearchService.Model
{
    /// <summary>
    /// This is the response object from the DescribeVpcEndpoints operation.
    /// </summary>
    public partial class DescribeVpcEndpointsResponse : AmazonWebServiceResponse
    {
        private List<VpcEndpointError> _vpcEndpointErrors = AWSConfigs.InitializeCollections ? new List<VpcEndpointError>() : null;
        private List<VpcEndpoint> _vpcEndpoints = AWSConfigs.InitializeCollections ? new List<VpcEndpoint>() : null;

        /// <summary>
        /// Gets and sets the property VpcEndpointErrors. 
        /// <para>
        /// Any errors associated with the request.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VpcEndpointError> VpcEndpointErrors
        {
            get { return this._vpcEndpointErrors; }
            set { this._vpcEndpointErrors = value; }
        }

        // Check to see if VpcEndpointErrors property is set
        internal bool IsSetVpcEndpointErrors()
        {
            return this._vpcEndpointErrors != null && (this._vpcEndpointErrors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpoints. 
        /// <para>
        /// Information about each requested VPC endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<VpcEndpoint> VpcEndpoints
        {
            get { return this._vpcEndpoints; }
            set { this._vpcEndpoints = value; }
        }

        // Check to see if VpcEndpoints property is set
        internal bool IsSetVpcEndpoints()
        {
            return this._vpcEndpoints != null && (this._vpcEndpoints.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}