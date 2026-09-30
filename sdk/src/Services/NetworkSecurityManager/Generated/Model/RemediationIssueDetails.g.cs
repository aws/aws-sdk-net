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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property CorrectiveAction. 
        /// <para>
        /// A recommended action for resolving the remediation issue.
        /// </para>
        /// </summary>
        public string CorrectiveAction { get; set; }

        /// <summary>
        /// Checks to see if the CorrectiveAction property is set.
        /// </summary>
        internal bool IsSetCorrectiveAction() => this.CorrectiveAction != null;

        /// <summary>
        /// Gets and sets the property IssueType. 
        /// <para>
        /// The type of remediation issue.
        /// </para>
        /// </summary>
        public string IssueType { get; set; }

        /// <summary>
        /// Checks to see if the IssueType property is set.
        /// </summary>
        internal bool IsSetIssueType() => this.IssueType != null;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// A human-readable description of the remediation issue.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;
    }
}
