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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the RebootInstances operation.
    /// <para>Requests a reboot of one or more instances. This operation is asynchronous; it only queues a request to reboot the specified
    /// instances. The operation succeeds if the instances are valid and belong to you. Requests to reboot terminated instances are ignored.</para>
    /// <para>If a Linux/Unix instance does not cleanly shut down within four minutes, Amazon EC2 performs a hard reboot.</para>
    /// </summary>
    public partial class RebootInstancesRequest : AmazonEC2Request
    {
        private List<string> instanceIds = new List<string>();


        /// <summary>
        /// One or more instance IDs.
        ///  
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this.instanceIds; }
            set { this.instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this.instanceIds.Count > 0;
        }

    }
}
    
