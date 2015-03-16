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
    /// Container for the parameters to the GetConsoleOutput operation.
    /// Gets the console output for the specified instance.
    /// 
    ///  
    /// <para>
    /// Instances do not have a physical monitor through which you can view their console
    /// output. They also lack physical controls that allow you to power up, reboot, or shut
    /// them down. To allow these actions, we provide them through the Amazon EC2 API and
    /// command line interface.
    /// </para>
    ///  
    /// <para>
    /// Instance console output is buffered and posted shortly after instance boot, reboot,
    /// and termination. Amazon EC2 preserves the most recent 64 KB output which is available
    /// for at least one hour after the most recent post.
    /// </para>
    ///  
    /// <para>
    /// For Linux instances, the instance console output displays the exact console output
    /// that would normally be displayed on a physical monitor attached to a computer. This
    /// output is buffered because the instance produces it and then posts it to a store where
    /// the instance's owner can retrieve it.
    /// </para>
    ///  
    /// <para>
    /// For Windows instances, the instance console output includes output from the EC2Config
    /// service.
    /// </para>
    /// </summary>
    public partial class GetConsoleOutputRequest : AmazonEC2Request
    {
        private string _instanceId;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetConsoleOutputRequest() { }

        /// <summary>
        /// Instantiates GetConsoleOutputRequest with the parameterized properties
        /// </summary>
        /// <param name="instanceId">The ID of the instance.</param>
        public GetConsoleOutputRequest(string instanceId)
        {
            _instanceId = instanceId;
        }

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The ID of the instance.
        /// </para>
        /// </summary>
        public string InstanceId
        {
            get { return this._instanceId; }
            set { this._instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this._instanceId != null;
        }

    }
}