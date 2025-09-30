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
 * Do not modify this file. This file is generated from the application-signals-2024-04-15.normal.json service model.
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
namespace Amazon.ApplicationSignals.Model
{
    /// <summary>
    /// A structure that contains the result of an automated audit analysis, including the
    /// auditor name, description of findings, and severity level.
    /// </summary>
    public partial class AuditorResult
    {
        private string _auditor;
        private string _description;
        private Severity _severity;

        /// <summary>
        /// Gets and sets the property Auditor. 
        /// <para>
        /// The name of the auditor algorithm that generated this result.
        /// </para>
        /// </summary>
        public string Auditor
        {
            get { return this._auditor; }
            set { this._auditor = value; }
        }

        // Check to see if Auditor property is set
        internal bool IsSetAuditor()
        {
            return this._auditor != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A detailed description of the audit finding, explaining what was observed and potential
        /// implications.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=10240)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The severity level of this audit finding, indicating the importance and potential
        /// impact of the issue.
        /// </para>
        /// </summary>
        public Severity Severity
        {
            get { return this._severity; }
            set { this._severity = value; }
        }

        // Check to see if Severity property is set
        internal bool IsSetSeverity()
        {
            return this._severity != null;
        }

    }
}