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
    /// Details of the evidence for a vulnerability identified in a finding.
    /// </summary>
    public partial class Evidence
    {
        private string _evidenceDetail;
        private string _evidenceRule;
        private string _severity;

        /// <summary>
        /// Gets and sets the property EvidenceDetail. 
        /// <para>
        /// The evidence details.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public string EvidenceDetail
        {
            get { return this._evidenceDetail; }
            set { this._evidenceDetail = value; }
        }

        // Check to see if EvidenceDetail property is set
        internal bool IsSetEvidenceDetail()
        {
            return this._evidenceDetail != null;
        }

        /// <summary>
        /// Gets and sets the property EvidenceRule. 
        /// <para>
        /// The evidence rule.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public string EvidenceRule
        {
            get { return this._evidenceRule; }
            set { this._evidenceRule = value; }
        }

        // Check to see if EvidenceRule property is set
        internal bool IsSetEvidenceRule()
        {
            return this._evidenceRule != null;
        }

        /// <summary>
        /// Gets and sets the property Severity. 
        /// <para>
        /// The evidence severity.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public string Severity
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