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
    /// Container for the parameters to the DeleteConnection operation.
    /// <para>Deletes the Connection.</para> <para>Deleting a connection only stops the AWS Direct Connect Port and Data Transfer charges. You
    /// separately need to cancel any services or charges for cross-connects or network circuits that connect you to the AWS Direct Connect location
    /// with those providers.</para>
    /// </summary>
    /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteConnection"/>
    public class DeleteConnectionRequest : AmazonWebServiceRequest
    {
        private string connectionId;

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
        public DeleteConnectionRequest WithConnectionId(string connectionId)
        {
            this.connectionId = connectionId;
            return this;
        }
            

        // Check to see if ConnectionId property is set
        internal bool IsSetConnectionId()
        {
            return this.connectionId != null;       
        }
    }
}
    
