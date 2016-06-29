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
    /// Container for the parameters to the DescribeStacks operation.
    /// Requests a description of one or more stacks.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack, or an attached policy that explicitly grants
    /// permissions. For more information on user permissions, see <a href="http://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    /// </summary>
    public partial class DescribeStacksRequest : AmazonOpsWorksRequest
    {
        private List<string> _stackIds = new List<string>();

        /// <summary>
        /// Gets and sets the property StackIds. 
        /// <para>
        /// An array of stack IDs that specify the stacks to be described. If you omit this parameter,
        /// <code>DescribeStacks</code> returns a description of every stack.
        /// </para>
        /// </summary>
        public List<string> StackIds
        {
            get { return this._stackIds; }
            set { this._stackIds = value; }
        }

        // Check to see if StackIds property is set
        internal bool IsSetStackIds()
        {
            return this._stackIds != null && this._stackIds.Count > 0; 
        }

    }
}