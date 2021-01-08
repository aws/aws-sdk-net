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
 * Do not modify this file. This file is generated from the iot-2015-05-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IoT.Model
{
    /// <summary>
    /// Used in MitigationActionParams, this information identifies the target findings to
    /// which the mitigation actions are applied. Only one entry appears.
    /// </summary>
    public partial class AuditMitigationActionsTaskTarget
    {
        private Dictionary<string, List<string>> _auditCheckToReasonCodeFilter = new Dictionary<string, List<string>>();
        private string _auditTaskId;
        private List<string> _findingIds = new List<string>();

        /// <summary>
        /// Gets and sets the property AuditCheckToReasonCodeFilter. 
        /// <para>
        /// Specifies a filter in the form of an audit check and set of reason codes that identify
        /// the findings from the audit to which the audit mitigation actions task apply.
        /// </para>
        /// </summary>
        public Dictionary<string, List<string>> AuditCheckToReasonCodeFilter
        {
            get { return this._auditCheckToReasonCodeFilter; }
            set { this._auditCheckToReasonCodeFilter = value; }
        }

        // Check to see if AuditCheckToReasonCodeFilter property is set
        internal bool IsSetAuditCheckToReasonCodeFilter()
        {
            return this._auditCheckToReasonCodeFilter != null && this._auditCheckToReasonCodeFilter.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AuditTaskId. 
        /// <para>
        /// If the task will apply a mitigation action to findings from a specific audit, this
        /// value uniquely identifies the audit.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=40)]
        public string AuditTaskId
        {
            get { return this._auditTaskId; }
            set { this._auditTaskId = value; }
        }

        // Check to see if AuditTaskId property is set
        internal bool IsSetAuditTaskId()
        {
            return this._auditTaskId != null;
        }

        /// <summary>
        /// Gets and sets the property FindingIds. 
        /// <para>
        /// If the task will apply a mitigation action to one or more listed findings, this value
        /// uniquely identifies those findings.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=25)]
        public List<string> FindingIds
        {
            get { return this._findingIds; }
            set { this._findingIds = value; }
        }

        // Check to see if FindingIds property is set
        internal bool IsSetFindingIds()
        {
            return this._findingIds != null && this._findingIds.Count > 0; 
        }

    }
}