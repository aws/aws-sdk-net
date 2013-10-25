/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Returns information about the  CreateInterconnectResult response and response metadata.
    /// </summary>
    public class CreateInterconnectResponse : AmazonWebServiceResponse
    {
        private CreateInterconnectResult createInterconnectResult;

        /// <summary>
        /// Gets and sets the CreateInterconnectResult property.
        /// An interconnect is a connection that can host other connections. Like a standard Direct Connect connection, an interconnect represents the
        /// physical connection between a Direct Connect partner's network and a specific Direct Connect location. A Direct Connect partner who owns an
        /// interconnect can provision hosted connections on the interconnect for their end customers, thereby providing the end customers with
        /// connectivity to AWS services. The resources of the interconnect, including bandwidth and VLAN numbers, are shared by all of the hosted
        /// connections on the interconnect, and the owner of the interconnect determines how these resources are assigned.
        /// </summary>
        public CreateInterconnectResult CreateInterconnectResult
        {
            get
            {
                if(this.createInterconnectResult == null)
                {
                    this.createInterconnectResult = new CreateInterconnectResult();
                }

                return this.createInterconnectResult;
            }
            set { this.createInterconnectResult = value; }
        }
    }
}
    
