/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeRdsDbInstances operation.
    /// Describes Amazon RDS instances.
    /// 
    ///  
    /// <para>
    ///  <b>Required Permissions</b>: To use this action, an IAM user must have a Show, Deploy,
    /// or Manage permissions level for the stack, or an attached policy that explicitly grants
    /// permissions. For more information about user permissions, see <a href="https://docs.aws.amazon.com/opsworks/latest/userguide/opsworks-security-users.html">Managing
    /// User Permissions</a>.
    /// </para>
    ///  
    /// <para>
    /// This call accepts only one resource-identifying parameter.
    /// </para>
    /// </summary>
    public partial class DescribeRdsDbInstancesRequest : AmazonOpsWorksRequest
    {
        private List<string> _rdsDbInstanceArns = new List<string>();
        private string _stackId;

        /// <summary>
        /// Gets and sets the property RdsDbInstanceArns. 
        /// <para>
        /// An array containing the ARNs of the instances to be described.
        /// </para>
        /// </summary>
        public List<string> RdsDbInstanceArns
        {
            get { return this._rdsDbInstanceArns; }
            set { this._rdsDbInstanceArns = value; }
        }

        // Check to see if RdsDbInstanceArns property is set
        internal bool IsSetRdsDbInstanceArns()
        {
            return this._rdsDbInstanceArns != null && this._rdsDbInstanceArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property StackId. 
        /// <para>
        /// The ID of the stack with which the instances are registered. The operation returns
        /// descriptions of all registered Amazon RDS instances.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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