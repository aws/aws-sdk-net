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
    /// Container for the parameters to the DescribeServiceErrors operation.
    /// Describes AWS OpsWorks Stacks service errors.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack, or an attached policy that explicitly grants
    /// permissions. For more information about user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    ///  
    /// <para>
    /// This call accepts only one resource-identifying parameter.
    /// </para>
    /// </summary>
    public partial class DescribeServiceErrorsRequest : AmazonOpsWorksRequest
    {
        private string _instanceId;
        private List<string> _serviceErrorIds = new List<string>();
        private string _stackId;

        /// <summary>
        /// Gets and sets the property InstanceId. 
        /// <para>
        /// The instance ID. If you use this parameter, <code>DescribeServiceErrors</code> returns
        /// descriptions of the errors associated with the specified instance.
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
        /// Gets and sets the property ServiceErrorIds. 
        /// <para>
        /// An array of service error IDs. If you use this parameter, <code>DescribeServiceErrors</code>
        /// returns descriptions of the specified errors. Otherwise, it returns a description
        /// of every error.
        /// </para>
        /// </summary>
        public List<string> ServiceErrorIds
        {
            get { return this._serviceErrorIds; }
            set { this._serviceErrorIds = value; }
        }

        // Check to see if ServiceErrorIds property is set
        internal bool IsSetServiceErrorIds()
        {
            return this._serviceErrorIds != null && this._serviceErrorIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The stack ID. If you use this parameter, <code>DescribeServiceErrors</code> returns
        /// descriptions of the errors associated with the specified stack.
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