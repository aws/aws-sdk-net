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
    /// Structure that contains the results of the account gate function AWS CloudFormation
    /// StackSets invokes, if present, before proceeding with stack set operations in an account.
    /// 
    ///  
    /// <para>
    /// Account gating enables you to specify a Lamdba function for an account that encapsulates
    /// any requirements that must be met before AWS CloudFormation StackSets proceeds with
    /// stack set operations in that account. CloudFormation invokes the function each time
    /// stack set operations are initiated for that account, and only proceeds if the function
    /// returns a success code. 
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
        /// passes any requirements for stack set operations to occur. AWS CloudFormation proceeds
        /// with stack operations in the account. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code>: The account gate function has determined that the account does
        /// not meet the requirements for stack set operations to occur. AWS CloudFormation cancels
        /// the stack set operations in that account, and the stack set operation status is set
        /// to FAILED.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SKIPPED</code>: An account gate function has not been specified for the account,
        /// or the AWSCloudFormationStackSetExecutionRole of the stack set adminstration account
        /// lacks permissions to invoke the function. AWS CloudFormation proceeds with stack set
        /// operations in the account. 
        /// </para>
        ///  </li> </ul>
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
        /// The reason for the account gate status assigned to this account.
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