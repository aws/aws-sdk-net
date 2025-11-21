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
 * Do not modify this file. This file is generated from the cloudformation-2010-05-15.normal.json service model.
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
namespace Amazon.CloudFormation.Model
{
    /// <summary>
    /// Structure that contains the results of the account gate function which CloudFormation
    /// invokes, if present, before proceeding with a StackSet operation in an account and
    /// Region.
    /// 
    ///  
    /// <para>
    /// For each account and Region, CloudFormation lets you specify a Lambda function that
    /// encapsulates any requirements that must be met before CloudFormation can proceed with
    /// a StackSet operation in that account and Region. CloudFormation invokes the function
    /// each time a StackSet operation is requested for that account and Region; if the function
    /// returns <c>FAILED</c>, CloudFormation cancels the operation in that account and Region,
    /// and sets the StackSet operation result status for that account and Region to <c>FAILED</c>.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/stacksets-account-gating.html">Prevent
    /// failed StackSets deployments using target account gates</a> in the <i>CloudFormation
    /// User Guide</i>.
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
        ///  <c>SUCCEEDED</c>: The account gate function has determined that the account and Region
        /// passes any requirements for a StackSet operation to occur. CloudFormation proceeds
        /// with the stack operation in that account and Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>FAILED</c>: The account gate function has determined that the account and Region
        /// doesn't meet the requirements for a StackSet operation to occur. CloudFormation cancels
        /// the StackSet operation in that account and Region, and sets the StackSet operation
        /// result status for that account and Region to <c>FAILED</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SKIPPED</c>: CloudFormation has skipped calling the account gate function for
        /// this account and Region, for one of the following reasons:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// An account gate function hasn't been specified for the account and Region. CloudFormation
        /// proceeds with the StackSet operation in this account and Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>AWSCloudFormationStackSetExecutionRole</c> of the administration account lacks
        /// permissions to invoke the function. CloudFormation proceeds with the StackSet operation
        /// in this account and Region.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Either no action is necessary, or no action is possible, on the stack. CloudFormation
        /// skips the StackSet operation in this account and Region.
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
        /// The reason for the account gate status assigned to this account and Region for the
        /// StackSet operation.
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