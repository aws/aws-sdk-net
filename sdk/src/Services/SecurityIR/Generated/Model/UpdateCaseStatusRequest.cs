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
 * Do not modify this file. This file is generated from the security-ir-2018-05-10.normal.json service model.
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
namespace Amazon.SecurityIR.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCaseStatus operation.
    /// Updates the state transitions for a designated cases.
    /// 
    ///  
    /// <para>
    ///  <b>Self-managed</b>: the following states are available for self-managed cases. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Submitted → Detection and Analysis
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Detection and Analysis → Containment, Eradication, and Recovery
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Detection and Analysis → Post-incident Activities
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Containment, Eradication, and Recovery → Detection and Analysis
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Containment, Eradication, and Recovery → Post-incident Activities
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Post-incident Activities → Containment, Eradication, and Recovery
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Post-incident Activities → Detection and Analysis
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Any → Closed
    /// </para>
    ///  </li> </ul> 
    /// <para>
    ///  <b>AWS supported</b>: You must use the <c>CloseCase</c> API to close. 
    /// </para>
    /// </summary>
    public partial class UpdateCaseStatusRequest : AmazonSecurityIRRequest
    {
        private string _caseId;
        private SelfManagedCaseStatus _caseStatus;

        /// <summary>
        /// Gets and sets the property CaseId. 
        /// <para>
        /// Required element for UpdateCaseStatus to identify the case to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=32)]
        public string CaseId
        {
            get { return this._caseId; }
            set { this._caseId = value; }
        }

        // Check to see if CaseId property is set
        internal bool IsSetCaseId()
        {
            return this._caseId != null;
        }

        /// <summary>
        /// Gets and sets the property CaseStatus. 
        /// <para>
        /// Required element for UpdateCaseStatus to identify the status for a case. Options include
        /// <c>Submitted | Detection and Analysis | Containment, Eradication and Recovery | Post-incident
        /// Activities</c>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public SelfManagedCaseStatus CaseStatus
        {
            get { return this._caseStatus; }
            set { this._caseStatus = value; }
        }

        // Check to see if CaseStatus property is set
        internal bool IsSetCaseStatus()
        {
            return this._caseStatus != null;
        }

    }
}