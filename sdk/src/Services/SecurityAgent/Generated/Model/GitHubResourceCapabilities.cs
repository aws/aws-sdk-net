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
 * Do not modify this file. This file is generated from the securityagent-2025-09-06.normal.json service model.
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
namespace Amazon.SecurityAgent.Model
{
    /// <summary>
    /// Capabilities for GitHub repositories
    /// </summary>
    public partial class GitHubResourceCapabilities
    {
        private bool? _leaveComments;
        private bool? _remediateCode;

        /// <summary>
        /// Gets and sets the property LeaveComments. 
        /// <para>
        /// Post code review comments on pull requests
        /// </para>
        /// </summary>
        public bool? LeaveComments
        {
            get { return this._leaveComments; }
            set { this._leaveComments = value; }
        }

        // Check to see if LeaveComments property is set
        internal bool IsSetLeaveComments()
        {
            return this._leaveComments.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RemediateCode. 
        /// <para>
        /// Create pull requests with automated fixes
        /// </para>
        /// </summary>
        public bool? RemediateCode
        {
            get { return this._remediateCode; }
            set { this._remediateCode = value; }
        }

        // Check to see if RemediateCode property is set
        internal bool IsSetRemediateCode()
        {
            return this._remediateCode.HasValue; 
        }

    }
}