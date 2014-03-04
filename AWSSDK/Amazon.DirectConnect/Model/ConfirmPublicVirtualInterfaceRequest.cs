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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.DirectConnect.Model
{
    /// <summary>
    /// Container for the parameters to the ConfirmPublicVirtualInterface operation.
    /// <para>Accept ownership of a public virtual interface created by another customer.</para> <para>After the virtual interface owner calls this
    /// function, the specified virtual interface will be created and made available for handling traffic.</para>
    /// </summary>
    /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.ConfirmPublicVirtualInterface"/>
    public class ConfirmPublicVirtualInterfaceRequest : AmazonWebServiceRequest
    {
        private string virtualInterfaceId;

        /// <summary>
        /// ID of the virtual interface. Example: dxvif-123dfg56 Default: None
        ///  
        /// </summary>
        public string VirtualInterfaceId
        {
            get { return this.virtualInterfaceId; }
            set { this.virtualInterfaceId = value; }
        }

        /// <summary>
        /// Sets the VirtualInterfaceId property
        /// </summary>
        /// <param name="virtualInterfaceId">The value to set for the VirtualInterfaceId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public ConfirmPublicVirtualInterfaceRequest WithVirtualInterfaceId(string virtualInterfaceId)
        {
            this.virtualInterfaceId = virtualInterfaceId;
            return this;
        }
            

        // Check to see if VirtualInterfaceId property is set
        internal bool IsSetVirtualInterfaceId()
        {
            return this.virtualInterfaceId != null;
        }
    }
}
    
