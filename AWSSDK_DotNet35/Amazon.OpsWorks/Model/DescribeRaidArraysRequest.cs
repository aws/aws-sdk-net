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
 * Do not modify this file. This file is generated from the opsworks-2013-02-18.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRaidArrays operation.
    /// Describe an instance's RAID arrays.
    /// 
    ///  
    /// <para>
    /// <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack, or an attached policy that explicitly grants
    /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DescribeRaidArraysRequest : AmazonOpsWorksRequest
    {
        private string _instanceId;
        private List<string> _raidArrayIds = new List<string>();
        private string _stackId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID. If you use this parameter, <code>DescribeRaidArrays</code> returns
        /// descriptions of the RAID arrays associated with the specified instance. 
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

        /// <summary>
        /// Gets and sets the property RaidArrayIds. 
        /// <para>
        /// An array of RAID array IDs. If you use this parameter, <code>DescribeRaidArrays</code>
        /// returns descriptions of the specified arrays. Otherwise, it returns a description
        /// of every array.
        /// </para>
        /// </summary>
        public List<string> RaidArrayIds
        {
            get { return this._raidArrayIds; }
            set { this._raidArrayIds = value; }
        }

        // Check to see if RaidArrayIds property is set
        internal bool IsSetRaidArrayIds()
        {
            return this._raidArrayIds != null && this._raidArrayIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID.
        /// </para>
        /// </summary>
        public string StackId
        {
            get { return this._stackId; }
            set { this._stackId = value; }
        }

        // Check to see if StackId property is set
        internal bool IsSetStackId()
        {
            return this._stackId != null;
        }

    }
}