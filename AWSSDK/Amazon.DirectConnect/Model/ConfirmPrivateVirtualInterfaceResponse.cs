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
    /// Returns information about the  ConfirmPrivateVirtualInterfaceResult response and response metadata.
    /// </summary>
    public class ConfirmPrivateVirtualInterfaceResponse : AmazonWebServiceResponse
    {
        private ConfirmPrivateVirtualInterfaceResult confirmPrivateVirtualInterfaceResult;

        /// <summary>
        /// Gets and sets the ConfirmPrivateVirtualInterfaceResult property.
        /// The response received when ConfirmPrivateVirtualInterface is called.
        /// </summary>
        public ConfirmPrivateVirtualInterfaceResult ConfirmPrivateVirtualInterfaceResult
        {
            get
            {
                if(this.confirmPrivateVirtualInterfaceResult == null)
                {
                    this.confirmPrivateVirtualInterfaceResult = new ConfirmPrivateVirtualInterfaceResult();
                }

                return this.confirmPrivateVirtualInterfaceResult;
            }
            set { this.confirmPrivateVirtualInterfaceResult = value; }
        }
    }
}
    
