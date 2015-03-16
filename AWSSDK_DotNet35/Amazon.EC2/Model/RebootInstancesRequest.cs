/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Requests a reboot of one or more instances. This operation is asynchronous; it only
    /// queues a request to reboot the specified instances. The operation succeeds if the
    /// instances are valid and belong to you. Requests to reboot terminated instances are
    /// ignored.
    /// 
    ///  
    /// <para>
    /// If a Linux/Unix instance does not cleanly shut down within four minutes, Amazon EC2
    /// performs a hard reboot.
    /// </para>
    ///  
    /// <para>
    /// For more information about troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-console.html">Getting
    /// Console Output and Rebooting Instances</a> in the <i>Amazon Elastic Compute Cloud
    /// User Guide</i>.
    /// </para>
    /// </summary>
    public partial class RebootInstancesRequest : AmazonEC2Request
    {
        private List<string> _instanceIds = new List<string>();

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public RebootInstancesRequest() { }

        /// <summary>
        /// Instantiates RebootInstancesRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceIds">One or more instance IDs.</param>
        public RebootInstancesRequest(List<string> instanceIds)
        {
            _instanceIds = instanceIds;
        }

        /// <summary>
        /// Gets and sets the property InstanceIds. 
        /// <para>
        /// One or more instance IDs.
        /// </para>
        /// </summary>
        public List<string> InstanceIds
        {
            get { return this._instanceIds; }
            set { this._instanceIds = value; }
        }

        // Check to see if InstanceIds property is set
        internal bool IsSetInstanceIds()
        {
            return this._instanceIds != null && this._instanceIds.Count > 0; 
        }

    }
}