/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the mediaconnect-2018-11-14.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.MediaConnect.Model
{
    /// <summary>
    /// This is the response object from the RemoveFlowVpcInterface operation.
    /// </summary>
    public partial class RemoveFlowVpcInterfaceResponse : AmazonWebServiceResponse
    {
        private string _flowArn;
        private List<string> _nonDeletedNetworkInterfaceIds = new List<string>();
        private string _vpcInterfaceName;

        /// <summary>
        /// Gets and sets the property FlowArn. The ARN of the flow that is associated with the
        /// VPC interface you removed.
        /// </summary>
        public string FlowArn
        {
            get { return this._flowArn; }
            set { this._flowArn = value; }
        }

        // Check to see if FlowArn property is set
        internal bool IsSetFlowArn()
        {
            return this._flowArn != null;
        }

        /// <summary>
        /// Gets and sets the property NonDeletedNetworkInterfaceIds. IDs of network interfaces
        /// associated with the removed VPC interface that Media Connect was unable to remove.
        /// </summary>
        public List<string> NonDeletedNetworkInterfaceIds
        {
            get { return this._nonDeletedNetworkInterfaceIds; }
            set { this._nonDeletedNetworkInterfaceIds = value; }
        }

        // Check to see if NonDeletedNetworkInterfaceIds property is set
        internal bool IsSetNonDeletedNetworkInterfaceIds()
        {
            return this._nonDeletedNetworkInterfaceIds != null && this._nonDeletedNetworkInterfaceIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcInterfaceName. The name of the VPC interface that was
        /// removed.
        /// </summary>
        public string VpcInterfaceName
        {
            get { return this._vpcInterfaceName; }
            set { this._vpcInterfaceName = value; }
        }

        // Check to see if VpcInterfaceName property is set
        internal bool IsSetVpcInterfaceName()
        {
            return this._vpcInterfaceName != null;
        }

    }
}