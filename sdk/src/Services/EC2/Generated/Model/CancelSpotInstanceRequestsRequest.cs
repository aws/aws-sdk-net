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
    /// Container for the parameters to the CancelSpotInstanceRequests operation.
    /// Cancels one or more Spot Instance requests.
    /// 
    ///  <important> 
    /// <para>
    /// Canceling a Spot Instance request does not terminate running Spot Instances associated
    /// with the request.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CancelSpotInstanceRequestsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<string> _spotInstanceRequestIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public CancelSpotInstanceRequestsRequest() { }

        /// <summary>
        /// Instantiates CancelSpotInstanceRequestsRequest with the parameterized properties
        /// </summary>
        /// <param name="spotInstanceRequestIds">The IDs of the Spot Instance requests.</param>
        public CancelSpotInstanceRequestsRequest(List<string> spotInstanceRequestIds)
        {
            _spotInstanceRequestIds = spotInstanceRequestIds;
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

        /// <summary>
        /// Gets and sets the property SpotInstanceRequestIds. 
        /// <para>
        /// The IDs of the Spot Instance requests.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> SpotInstanceRequestIds
        {
            get { return this._spotInstanceRequestIds; }
            set { this._spotInstanceRequestIds = value; }
        }

        // Check to see if SpotInstanceRequestIds property is set
        internal bool IsSetSpotInstanceRequestIds()
        {
            return this._spotInstanceRequestIds != null && (this._spotInstanceRequestIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}