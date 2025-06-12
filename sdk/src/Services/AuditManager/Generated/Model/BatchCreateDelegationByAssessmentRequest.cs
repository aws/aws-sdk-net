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
    /// Container for the parameters to the BatchCreateDelegationByAssessment operation.
    /// Creates a batch of delegations for an assessment in Audit Manager.
    /// </summary>
    public partial class BatchCreateDelegationByAssessmentRequest : AmazonAuditManagerRequest
    {
        private string _assessmentId;
        private List<CreateDelegationRequest> _createDelegationRequests = AWSConfigs.InitializeCollections ? new List<CreateDelegationRequest>() : null;

        /// <summary>
        /// Gets and sets the property AssessmentId. 
        /// <para>
        ///  The identifier for the assessment. 
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
        ///  The API request to batch create delegations in Audit Manager. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=50)]
        public List<CreateDelegationRequest> CreateDelegationRequests
        {
            get { return this._createDelegationRequests; }
            set { this._createDelegationRequests = value; }
        }

        // Check to see if CreateDelegationRequests property is set
        internal bool IsSetCreateDelegationRequests()
        {
            return this._createDelegationRequests != null && (this._createDelegationRequests.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}