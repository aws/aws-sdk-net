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
 * Do not modify this file. This file is generated from the network-security-manager-2025-10-30.normal.json service model.
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
namespace Amazon.NetworkSecurityManager.Model
{
    /// <summary>
    /// Details about a remediation issue for a firewall type.
    /// </summary>
    public partial class RemediationIssueDetails
    {
        private string _correctiveAction;
        private string _issueType;
        private string _message;

        /// <summary>
        /// Gets and sets the property CorrectiveAction. 
        /// <para>
        /// A recommended action for resolving the remediation issue.
        /// </para>
        /// </summary>
        public string CorrectiveAction
        {
            get { return this._correctiveAction; }
            set { this._correctiveAction = value; }
        }

        // Check to see if CorrectiveAction property is set
        internal bool IsSetCorrectiveAction()
        {
            return this._correctiveAction != null;
        }

        /// <summary>
        /// Gets and sets the property IssueType. 
        /// <para>
        /// The type of remediation issue.
        /// </para>
        /// </summary>
        public string IssueType
        {
            get { return this._issueType; }
            set { this._issueType = value; }
        }

        // Check to see if IssueType property is set
        internal bool IsSetIssueType()
        {
            return this._issueType != null;
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable description of the remediation issue.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

    }
}