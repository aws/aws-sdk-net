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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
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
namespace Amazon.GameLift.Model
{
    /// <summary>
    /// This is the response object from the DescribeVpcPeeringAuthorizations operation.
    /// </summary>
    public partial class DescribeVpcPeeringAuthorizationsResponse : AmazonWebServiceResponse
    {
        private List<VpcPeeringAuthorization> _vpcPeeringAuthorizations = AWSConfigs.InitializeCollections ? new List<VpcPeeringAuthorization>() : null;

        /// <summary>
        /// Gets and sets the property VpcPeeringAuthorizations. 
        /// <para>
        /// A collection of objects that describe all valid VPC peering operations for the current
        /// Amazon Web Services account.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<VpcPeeringAuthorization> VpcPeeringAuthorizations
        {
            get { return this._vpcPeeringAuthorizations; }
            set { this._vpcPeeringAuthorizations = value; }
        }

        // Check to see if VpcPeeringAuthorizations property is set
        internal bool IsSetVpcPeeringAuthorizations()
        {
            return this._vpcPeeringAuthorizations != null && (this._vpcPeeringAuthorizations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}