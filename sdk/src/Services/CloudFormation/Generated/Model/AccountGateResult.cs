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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Structure that contains the results of the account gate function which AWS CloudFormation
    /// invokes, if present, before proceeding with a stack set operation in an account and
    /// region.
    /// 
    ///  
    /// <para>
    /// For each account and region, AWS CloudFormation lets you specify a Lamdba function
    /// that encapsulates any requirements that must be met before CloudFormation can proceed
    /// with a stack set operation in that account and region. CloudFormation invokes the
    /// function each time a stack set operation is requested for that account and region;
    /// if the function returns <code>FAILED</code>, CloudFormation cancels the operation
    /// in that account and region, and sets the stack set operation result status for that
    /// account and region to <code>FAILED</code>. 
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="http://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-account-gating.html">Configuring
    /// a target account gate</a>.
    /// </para>
    /// </summary>
    public partial class AccountGateResult
    {
        private AccountGateStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the account gate function.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>SUCCEEDED</code>: The account gate function has determined that the account
        /// and region passes any requirements for a stack set operation to occur. AWS CloudFormation
        /// proceeds with the stack operation in that account and region. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code>: The account gate function has determined that the account and
        /// region does not meet the requirements for a stack set operation to occur. AWS CloudFormation
        /// cancels the stack set operation in that account and region, and sets the stack set
        /// operation result status for that account and region to <code>FAILED</code>. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SKIPPED</code>: AWS CloudFormation has skipped calling the account gate function
        /// for this account and region, for one of the following reasons:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An account gate function has not been specified for the account and region. AWS CloudFormation
        /// proceeds with the stack set operation in this account and region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <code>AWSCloudFormationStackSetExecutionRole</code> of the stack set adminstration
        /// account lacks permissions to invoke the function. AWS CloudFormation proceeds with
        /// the stack set operation in this account and region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Either no action is necessary, or no action is possible, on the stack. AWS CloudFormation
        /// skips the stack set operation in this account and region.
        /// </para>
        ///  </li> </ul> </li> </ul>
        /// </summary>
        public AccountGateStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property StatusReason. 
        /// <para>
        /// The reason for the account gate status assigned to this account and region for the
        /// stack set operation.
        /// </para>
        /// </summary>
        public string StatusReason
        {
            get { return this._statusReason; }
            set { this._statusReason = value; }
        }

        // Check to see if StatusReason property is set
        internal bool IsSetStatusReason()
        {
            return this._statusReason != null;
        }

    }
}