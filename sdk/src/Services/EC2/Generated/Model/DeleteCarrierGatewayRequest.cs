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
    /// Container for the parameters to the DeleteCarrierGateway operation.
    /// Deletes a carrier gateway.
    /// 
    ///  <important> 
    /// <para>
    /// If you do not delete the route that contains the carrier gateway as the Target, the
    /// route is a blackhole route. For information about how to delete a route, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DeleteRoute.html">DeleteRoute</a>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeleteCarrierGatewayRequest : AmazonEC2Request
    {
        private string _carrierGatewayId;
        private bool? _dryRun;

        /// <summary>
        /// Gets and sets the property CarrierGatewayId. 
        /// <para>
        /// The ID of the carrier gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string CarrierGatewayId
        {
            get { return this._carrierGatewayId; }
            set { this._carrierGatewayId = value; }
        }

        // Check to see if CarrierGatewayId property is set
        internal bool IsSetCarrierGatewayId()
        {
            return this._carrierGatewayId != null;
        }

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

    }
}