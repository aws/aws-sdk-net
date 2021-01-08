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

namespace Amazon.AuditManager.Model
{
    /// <summary>
    /// This is the response object from the BatchCreateDelegationByAssessment operation.
    /// </summary>
    public partial class BatchCreateDelegationByAssessmentResponse : AmazonWebServiceResponse
    {
        private List<Delegation> _delegations = new List<Delegation>();
        private List<BatchCreateDelegationByAssessmentError> _errors = new List<BatchCreateDelegationByAssessmentError>();

        /// <summary>
        /// Gets and sets the property Delegations. 
        /// <para>
        ///  The delegations associated with the assessment. 
        /// </para>
        /// </summary>
        public List<Delegation> Delegations
        {
            get { return this._delegations; }
            set { this._delegations = value; }
        }

        // Check to see if Delegations property is set
        internal bool IsSetDelegations()
        {
            return this._delegations != null && this._delegations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        ///  A list of errors returned by the <code>BatchCreateDelegationByAssessment</code> API.
        /// 
        /// </para>
        /// </summary>
        public List<BatchCreateDelegationByAssessmentError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

    }
}