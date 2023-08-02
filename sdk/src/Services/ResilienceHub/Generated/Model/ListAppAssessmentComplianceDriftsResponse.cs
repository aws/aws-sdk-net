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
 * Do not modify this file. This file is generated from the resiliencehub-2020-04-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ResilienceHub.Model
{
    /// <summary>
    /// This is the response object from the ListAppAssessmentComplianceDrifts operation.
    /// </summary>
    public partial class ListAppAssessmentComplianceDriftsResponse : AmazonWebServiceResponse
    {
        private List<ComplianceDrift> _complianceDrifts = new List<ComplianceDrift>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ComplianceDrifts. 
        /// <para>
        /// Indicates compliance drifts (recovery time objective (RTO) and recovery point objective
        /// (RPO)) detected for an assessed entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<ComplianceDrift> ComplianceDrifts
        {
            get { return this._complianceDrifts; }
            set { this._complianceDrifts = value; }
        }

        // Check to see if ComplianceDrifts property is set
        internal bool IsSetComplianceDrifts()
        {
            return this._complianceDrifts != null && this._complianceDrifts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// Token number of the next application to be checked for compliance and regulatory requirements
        /// from the list of applications.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}