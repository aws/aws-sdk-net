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
    /// Container for the parameters to the GetConsoleOutput operation.
    /// <para>Gets the console output for the specified instance.</para> <para>Instances do not have a physical monitor through which you can view
    /// their console output. They also lack physical controls that allow you to power up, reboot, or shut them down. To allow these actions, we
    /// provide them through the Amazon EC2 API and command line interface.</para> <para>Instance console output is buffered and posted shortly
    /// after instance boot, reboot, and termination. Amazon EC2 preserves the most recent 64 KB output which is available for at least one hour
    /// after the most recent post.</para> <para>For Linux/Unix instances, the instance console output displays the exact console output that would
    /// normally be displayed on a physical monitor attached to a machine. This output is buffered because the instance produces it and then posts
    /// it to a store where the instance's owner can retrieve it.</para> <para>For Windows instances, the instance console output displays the last
    /// three system event log errors.</para>
    /// </summary>
    public partial class GetConsoleOutputRequest : AmazonEC2Request
    {
        private string instanceId;


        /// <summary>
        /// The ID of the instance.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

    }
}
    
