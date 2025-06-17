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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Allows you to define the structure for modifying specific fields in security findings.
    /// </summary>
    public partial class AutomationRulesFindingFieldsUpdateV2
    {
        private string _comment;
        private int? _severityId;
        private int? _statusId;

        /// <summary>
        /// Gets and sets the property Comment. 
        /// <para>
        /// Notes or contextual information for findings that are modified by the automation rule.
        /// </para>
        /// </summary>
        public string Comment
        {
            get { return this._comment; }
            set { this._comment = value; }
        }

        // Check to see if Comment property is set
        internal bool IsSetComment()
        {
            return this._comment != null;
        }

        /// <summary>
        /// Gets and sets the property SeverityId. 
        /// <para>
        /// The severity level to be assigned to findings that match the automation rule criteria.
        /// </para>
        /// </summary>
        public int? SeverityId
        {
            get { return this._severityId; }
            set { this._severityId = value; }
        }

        // Check to see if SeverityId property is set
        internal bool IsSetSeverityId()
        {
            return this._severityId.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StatusId. 
        /// <para>
        /// The status to be applied to findings that match automation rule criteria.
        /// </para>
        /// </summary>
        public int? StatusId
        {
            get { return this._statusId; }
            set { this._statusId = value; }
        }

        // Check to see if StatusId property is set
        internal bool IsSetStatusId()
        {
            return this._statusId.HasValue; 
        }

    }
}