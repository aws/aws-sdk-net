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
 * Do not modify this file. This file is generated from the apigateway-2015-07-09.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.APIGateway.Model
{
    /// <summary>
    /// Container for the parameters to the GetVpcLink operation.
    /// Gets a specified VPC link under the caller's account in a region.
    /// </summary>
    public partial class GetVpcLinkRequest : AmazonAPIGatewayRequest
    {
        private string _vpcLinkId;

        /// <summary>
        /// Gets and sets the property VpcLinkId. 
        /// <para>
        /// [Required] The identifier of the <a>VpcLink</a>. It is used in an <a>Integration</a>
        /// to reference this <a>VpcLink</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string VpcLinkId
        {
            get { return this._vpcLinkId; }
            set { this._vpcLinkId = value; }
        }

        // Check to see if VpcLinkId property is set
        internal bool IsSetVpcLinkId()
        {
            return this._vpcLinkId != null;
        }

    }
}