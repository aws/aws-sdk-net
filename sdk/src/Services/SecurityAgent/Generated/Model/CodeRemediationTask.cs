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
    /// Represents a code remediation task that was initiated to fix a security finding.
    /// </summary>
    public partial class CodeRemediationTask
    {
        private CodeRemediationTaskStatus _status;
        private string _statusReason;
        private List<CodeRemediationTaskDetails> _taskDetails = AWSConfigs.InitializeCollections ? new List<CodeRemediationTaskDetails>() : null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the code remediation task.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public CodeRemediationTaskStatus Status
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
        /// The reason for the current status of the code remediation task.
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

        /// <summary>
        /// Gets and sets the property TaskDetails. 
        /// <para>
        /// The list of details for the code remediation task, including repository name, code
        /// diff link, and pull request link.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<CodeRemediationTaskDetails> TaskDetails
        {
            get { return this._taskDetails; }
            set { this._taskDetails = value; }
        }

        // Check to see if TaskDetails property is set
        internal bool IsSetTaskDetails()
        {
            return this._taskDetails != null && (this._taskDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}