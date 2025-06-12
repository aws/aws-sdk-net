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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DeleteVpcEndpoints operation.
    /// Deletes the specified VPC endpoints.
    /// 
    ///  
    /// <para>
    /// When you delete a gateway endpoint, we delete the endpoint routes in the route tables
    /// for the endpoint.
    /// </para>
    ///  
    /// <para>
    /// When you delete a Gateway Load Balancer endpoint, we delete its endpoint network interfaces.
    /// You can only delete Gateway Load Balancer endpoints when the routes that are associated
    /// with the endpoint are deleted.
    /// </para>
    ///  
    /// <para>
    /// When you delete an interface endpoint, we delete its endpoint network interfaces.
    /// </para>
    /// </summary>
    public partial class DeleteVpcEndpointsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<string> _vpcEndpointIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VpcEndpointIds. 
        /// <para>
        /// The IDs of the VPC endpoints.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> VpcEndpointIds
        {
            get { return this._vpcEndpointIds; }
            set { this._vpcEndpointIds = value; }
        }

        // Check to see if VpcEndpointIds property is set
        internal bool IsSetVpcEndpointIds()
        {
            return this._vpcEndpointIds != null && (this._vpcEndpointIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}