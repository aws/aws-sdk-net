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
    /// Returns information about the  DisableGatewayResult response and response metadata.
    /// </summary>
    public class DisableGatewayResponse : AmazonWebServiceResponse
    {
        private DisableGatewayResult disableGatewayResult;

        /// <summary>
        /// Gets and sets the DisableGatewayResult property.
        /// DisableGatewayOutput
        /// </summary>
        public DisableGatewayResult DisableGatewayResult
        {
            get
            {
                if(this.disableGatewayResult == null)
                {
                    this.disableGatewayResult = new DisableGatewayResult();
                }

                return this.disableGatewayResult;
            }
            set { this.disableGatewayResult = value; }
        }
    }
}
    
