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
    /// Container for the parameters to the CreatePublicVirtualInterface operation.
    /// <para> Creates a new public virtual interface. A virtual interface is the VLAN that transports Direct Connect traffic. A public virtual
    /// interface supports sending traffic to public AWS services such as S3. </para>
    /// </summary>
    /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreatePublicVirtualInterface"/>
    public class CreatePublicVirtualInterfaceRequest : AmazonWebServiceRequest
    {
        private string connectionId;
        private NewPublicVirtualInterface newPublicVirtualInterface;

        /// <summary>
        /// ID of the connection. Example: dxcon-fg5678gh Default: None
        ///  
        /// </summary>
        public string ConnectionId
        {
            get { return this.connectionId; }
            set { this.connectionId = value; }
        }

        /// <summary>
        /// Sets the ConnectionId property
        /// </summary>
        /// <param name="connectionId">The value to set for the ConnectionId property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePublicVirtualInterfaceRequest WithConnectionId(string connectionId)
        {
            this.connectionId = connectionId;
            return this;
        }
            

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this.connectionId != null;       
        }

        /// <summary>
        /// Detailed information of the public virtual interface to be created. Default: None
        ///  
        /// </summary>
        public NewPublicVirtualInterface NewPublicVirtualInterface
        {
            get { return this.newPublicVirtualInterface; }
            set { this.newPublicVirtualInterface = value; }
        }

        /// <summary>
        /// Sets the NewPublicVirtualInterface property
        /// </summary>
        /// <param name="newPublicVirtualInterface">The value to set for the NewPublicVirtualInterface property </param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreatePublicVirtualInterfaceRequest WithNewPublicVirtualInterface(NewPublicVirtualInterface newPublicVirtualInterface)
        {
            this.newPublicVirtualInterface = newPublicVirtualInterface;
            return this;
        }
            

        // Check to see if NewPublicVirtualInterface property is set
        internal bool IsSetNewPublicVirtualInterface()
        {
            return this.newPublicVirtualInterface != null;       
        }
    }
}
    
