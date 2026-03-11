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
 * Do not modify this file. This file is generated from the arc-region-switch-2022-07-26.normal.json service model.
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
namespace Amazon.ARCRegionswitch.Model
{
    /// <summary>
    /// Configuration for approval steps in a Region switch plan execution. Approval steps
    /// require manual intervention before the execution can proceed.
    /// </summary>
    public partial class ExecutionApprovalConfiguration
    {
        private string _approvalRole;
        private int? _timeoutMinutes;

        /// <summary>
        /// Gets and sets the property ApprovalRole. 
        /// <para>
        /// The IAM approval role for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApprovalRole
        {
            get { return this._approvalRole; }
            set { this._approvalRole = value; }
        }

        // Check to see if ApprovalRole property is set
        internal bool IsSetApprovalRole()
        {
            return this._approvalRole != null;
        }

        /// <summary>
        /// Gets and sets the property TimeoutMinutes. 
        /// <para>
        /// The timeout value specified for the configuration.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public int? TimeoutMinutes
        {
            get { return this._timeoutMinutes; }
            set { this._timeoutMinutes = value; }
        }

        // Check to see if TimeoutMinutes property is set
        internal bool IsSetTimeoutMinutes()
        {
            return this._timeoutMinutes.HasValue; 
        }

    }
}