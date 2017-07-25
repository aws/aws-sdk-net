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
    /// The structure that contains information about a specified operation's results for
    /// a given account in a given region.
    /// </summary>
    public partial class StackSetOperationResultSummary
    {
        private string _account;
        private AccountGateResult _accountGateResult;
        private string _region;
        private StackSetOperationResultStatus _status;
        private string _statusReason;

        /// <summary>
        /// Gets and sets the property Account. 
        /// <para>
        /// The name of the AWS account for this operation result.
        /// </para>
        /// </summary>
        public string Account
        {
            get { return this._account; }
            set { this._account = value; }
        }

        // Check to see if Account property is set
        internal bool IsSetAccount()
        {
            return this._account != null;
        }

        /// <summary>
        /// Gets and sets the property AccountGateResult. 
        /// <para>
        /// The results of the account gate function AWS CloudFormation invokes, if present, before
        /// proceeding with stack set operations in an account
        /// </para>
        /// </summary>
        public AccountGateResult AccountGateResult
        {
            get { return this._accountGateResult; }
            set { this._accountGateResult = value; }
        }

        // Check to see if AccountGateResult property is set
        internal bool IsSetAccountGateResult()
        {
            return this._accountGateResult != null;
        }

        /// <summary>
        /// Gets and sets the property Region. 
        /// <para>
        /// The name of the AWS region for this operation result.
        /// </para>
        /// </summary>
        public string Region
        {
            get { return this._region; }
            set { this._region = value; }
        }

        // Check to see if Region property is set
        internal bool IsSetRegion()
        {
            return this._region != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The result status of the stack set operation for the given account in the given region.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>CANCELLED</code>: The operation in the specified account and region has been
        /// cancelled. This is either because a user has stopped the stack set operation, or because
        /// the failure tolerance of the stack set operation has been exceeded.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>FAILED</code>: The operation in the specified account and region failed. 
        /// </para>
        ///  
        /// <para>
        /// If the stack set operation fails in enough accounts within a region, the failure tolerance
        /// for the stack set operation as a whole might be exceeded. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>RUNNING</code>: The operation in the specified account and region is currently
        /// in progress.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>PENDING</code>: The operation in the specified account and region has yet to
        /// start. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>SUCCEEDED</code>: The operation in the specified account and region completed
        /// successfully.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public StackSetOperationResultStatus Status
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
        /// The reason for the assigned result status.
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