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
 * Do not modify this file. This file is generated from the inspector2-2020-06-08.normal.json service model.
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
namespace Amazon.Inspector2.Model
{
    /// <summary>
    /// An object that contains details about a member account in your organization that failed
    /// to activate Amazon Inspector deep inspection.
    /// </summary>
    public partial class FailedMemberAccountEc2DeepInspectionStatusState
    {
        private string _accountId;
        private Status _ec2ScanStatus;
        private string _errorMessage;

        /// <summary>
        /// Gets and sets the property AccountId. 
        /// <para>
        /// The unique identifier for the Amazon Web Services account of the organization member
        /// that failed to activate Amazon Inspector deep inspection.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=12, Max=12)]
        public string AccountId
        {
            get { return this._accountId; }
            set { this._accountId = value; }
        }

        // Check to see if AccountId property is set
        internal bool IsSetAccountId()
        {
            return this._accountId != null;
        }

        /// <summary>
        /// Gets and sets the property Ec2ScanStatus. 
        /// <para>
        /// The status of EC2 scanning in the account that failed to activate Amazon Inspector
        /// deep inspection.
        /// </para>
        /// </summary>
        public Status Ec2ScanStatus
        {
            get { return this._ec2ScanStatus; }
            set { this._ec2ScanStatus = value; }
        }

        // Check to see if Ec2ScanStatus property is set
        internal bool IsSetEc2ScanStatus()
        {
            return this._ec2ScanStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// The error message explaining why the account failed to activate Amazon Inspector deep
        /// inspection.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

    }
}