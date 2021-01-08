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
    /// Container for the parameters to the BatchCreateDelegationByAssessment operation.
    /// Create a batch of delegations for a specified assessment in AWS Audit Manager.
    /// </summary>
    public partial class BatchCreateDelegationByAssessmentRequest : AmazonAuditManagerRequest
    {
        private string _assessmentId;
        private List<CreateDelegationRequest> _createDelegationRequests = new List<CreateDelegationRequest>();

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The identifier for the specified assessment. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=36, Max=36)]
        public string AssessmentId
        {
            get { return this._assessmentId; }
            set { this._assessmentId = value; }
        }

        // Check to see if AssessmentId property is set
        internal bool IsSetAssessmentId()
        {
            return this._assessmentId != null;
        }

        /// <summary>
        /// Gets and sets the property CreateDelegationRequests. 
        /// <para>
        ///  The API request to batch create delegations in AWS Audit Manager. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
        public List<CreateDelegationRequest> CreateDelegationRequests
        {
            get { return this._createDelegationRequests; }
            set { this._createDelegationRequests = value; }
        }

        // Check to see if CreateDelegationRequests property is set
        internal bool IsSetCreateDelegationRequests()
        {
            return this._createDelegationRequests != null && this._createDelegationRequests.Count > 0; 
        }

    }
}