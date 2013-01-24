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

namespace Amazon.StorageGateway.Model
{
    /// <summary>
    /// Returns information about the  ActivateGatewayResult response and response metadata.
    /// </summary>
    public class ActivateGatewayResponse : AmazonWebServiceResponse
    {
        private ActivateGatewayResult activateGatewayResult;

        /// <summary>
        /// Gets and sets the ActivateGatewayResult property.
        /// AWS Storage Gateway returns the Amazon Resource Name (ARN) of the activated gateway. It is a string made of information such as your
        /// account, gateway name, and region. This ARN is used to reference the gateway in other API operations as well as resource-based
        /// authorization.
        /// </summary>
        public ActivateGatewayResult ActivateGatewayResult
        {
            get 
            {
                if(this.activateGatewayResult == null)
                {
                    this.activateGatewayResult = new ActivateGatewayResult();
                }

                return this.activateGatewayResult; 
            }
            set { this.activateGatewayResult = value; }
        }
    }
}
    
