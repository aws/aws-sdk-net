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
    /// <para> The GetConsoleOutput operation retrieves console output for the specified instance. </para> <para> Instance console output is
    /// buffered and posted shortly after instance boot, reboot, and termination. Amazon EC2 preserves the most recent 64 KB output which will be
    /// available for at least one hour after the most recent post. </para>
    /// </summary>
    public partial class GetConsoleOutputRequest : AmazonEC2Request
    {
        private string instanceId;


        /// <summary>
        /// The ID of the instance for which you want console output.
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
    
