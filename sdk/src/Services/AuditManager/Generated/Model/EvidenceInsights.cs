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
 * Do not modify this file. This file is generated from the auditmanager-2017-07-25.normal.json service model.
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
namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// A breakdown of the latest compliance check status for the evidence in your Audit Manager
    /// assessments.
    /// </summary>
    public partial class EvidenceInsights
    {
        private int? _compliantEvidenceCount;
        private int? _inconclusiveEvidenceCount;
        private int? _noncompliantEvidenceCount;

        /// <summary>
        /// Gets and sets the property CompliantEvidenceCount. 
        /// <para>
        /// The number of compliance check evidence that Audit Manager classified as compliant.
        /// This includes evidence that was collected from Security Hub with a <i>Pass</i> ruling,
        /// or collected from Config with a <i>Compliant</i> ruling. 
        /// </para>
        /// </summary>
        public int? CompliantEvidenceCount
        {
            get { return this._compliantEvidenceCount; }
            set { this._compliantEvidenceCount = value; }
        }

        // Check to see if CompliantEvidenceCount property is set
        internal bool IsSetCompliantEvidenceCount()
        {
            return this._compliantEvidenceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InconclusiveEvidenceCount. 
        /// <para>
        /// The number of evidence that a compliance check ruling isn't available for. Evidence
        /// is inconclusive when the associated control uses Security Hub or Config as a data
        /// source but you didn't enable those services. This is also the case when a control
        /// uses a data source that doesn’t support compliance checks (for example, manual evidence,
        /// API calls, or CloudTrail). 
        /// </para>
        ///  <note> 
        /// <para>
        /// If evidence has a compliance check status of <i>not applicable</i> in the console,
        /// it's classified as <i>inconclusive</i> in <c>EvidenceInsights</c> data.
        /// </para>
        ///  </note>
        /// </summary>
        public int? InconclusiveEvidenceCount
        {
            get { return this._inconclusiveEvidenceCount; }
            set { this._inconclusiveEvidenceCount = value; }
        }

        // Check to see if InconclusiveEvidenceCount property is set
        internal bool IsSetInconclusiveEvidenceCount()
        {
            return this._inconclusiveEvidenceCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NoncompliantEvidenceCount. 
        /// <para>
        /// The number of compliance check evidence that Audit Manager classified as non-compliant.
        /// This includes evidence that was collected from Security Hub with a <i>Fail</i> ruling,
        /// or collected from Config with a <i>Non-compliant</i> ruling. 
        /// </para>
        /// </summary>
        public int? NoncompliantEvidenceCount
        {
            get { return this._noncompliantEvidenceCount; }
            set { this._noncompliantEvidenceCount = value; }
        }

        // Check to see if NoncompliantEvidenceCount property is set
        internal bool IsSetNoncompliantEvidenceCount()
        {
            return this._noncompliantEvidenceCount.HasValue; 
        }

    }
}