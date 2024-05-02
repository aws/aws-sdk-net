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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeInstance operation.
    /// Returns the details of an instance of IAM Identity Center. The status can be one of
    /// the following:
    /// 
    ///  <ul> <li> 
    /// <para>
    ///  <c>CREATE_IN_PROGRESS</c> - The instance is in the process of being created. When
    /// the instance is ready for use, DescribeInstance returns the status of <c>ACTIVE</c>.
    /// While the instance is in the <c>CREATE_IN_PROGRESS</c> state, you can call only DescribeInstance
    /// and DeleteInstance operations.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>DELETE_IN_PROGRESS</c> - The instance is being deleted. Returns <c>AccessDeniedException</c>
    /// after the delete operation completes. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>ACTIVE</c> - The instance is active.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DescribeInstanceRequest : AmazonSSOAdminRequest
    {
        private string _instanceArn;

        /// <summary>
        /// Gets and sets the property InstanceArn. 
        /// <para>
        /// The ARN of the instance of IAM Identity Center under which the operation will run.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=1224)]
        public string InstanceArn
        {
            get { return this._instanceArn; }
            set { this._instanceArn = value; }
        }

        // Check to see if InstanceArn property is set
        internal bool IsSetInstanceArn()
        {
            return this._instanceArn != null;
        }

    }
}