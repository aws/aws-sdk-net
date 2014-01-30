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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a state change.</para>
    /// </summary>
    public class StateReason
    {
        
        private string code;
        private string message;


        /// <summary>
        /// The reason code for the state change.
        ///  
        /// </summary>
        public string Code
        {
            get { return this.code; }
            set { this.code = value; }
        }

        // Check to see if Code property is set
        internal bool IsSetCode()
        {
            return this.code != null;
        }

        /// <summary>
        /// The message for the state change. <ul> <li><c>Server.SpotInstanceTermination</c>: A Spot Instance was terminated due to an increase in the
        /// market price.</li> <li><c>Server.InternalError</c>: An internal error occurred during instance launch, resulting in termination.</li>
        /// <li><c>Server.InsufficientInstanceCapacity</c>: There was insufficient instance capacity to satisfy the launch request.</li>
        /// <li><c>Client.InternalError</c>: A client error caused the instance to terminate on launch.</li>
        /// <li><c>Client.InstanceInitiatedShutdown</c>: The instance was shut down using the <c>shutdown -h</c> command from the instance.</li>
        /// <li><c>Client.UserInitiatedShutdown</c>: The instance was shut down using the Amazon EC2 API.</li> <li><c>Client.VolumeLimitExceeded</c>:
        /// The volume limit was exceeded.</li> <li><c>Client.InvalidSnapshot.NotFound</c>: The specified snapshot was not found.</li> </ul>
        ///  
        /// </summary>
        public string Message
        {
            get { return this.message; }
            set { this.message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this.message != null;
        }
    }
}
