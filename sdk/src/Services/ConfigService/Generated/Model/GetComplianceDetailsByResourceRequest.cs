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
 * Do not modify this file. This file is generated from the config-2014-11-12.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ConfigService.Model
{
    /// <summary>
    /// Container for the parameters to the GetComplianceDetailsByResource operation.
    /// Returns the evaluation results for the specified Amazon Web Services resource. The
    /// results indicate which Config rules were used to evaluate the resource, when each
    /// rule was last invoked, and whether the resource complies with each rule.
    /// </summary>
    public partial class GetComplianceDetailsByResourceRequest : AmazonConfigServiceRequest
    {
        private List<string> _complianceTypes = new List<string>();
        private string _nextToken;
        private string _resourceEvaluationId;
        private string _resourceId;
        private string _resourceType;

        /// <summary>
        /// Gets and sets the property ComplianceTypes. 
        /// <para>
        /// Filters the results by compliance.
        /// </para>
        ///  
        /// <para>
        ///  <code>INSUFFICIENT_DATA</code> is a valid <code>ComplianceType</code> that is returned
        /// when an Config rule cannot be evaluated. However, <code>INSUFFICIENT_DATA</code> cannot
        /// be used as a <code>ComplianceType</code> for filtering results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=3)]
        public List<string> ComplianceTypes
        {
            get { return this._complianceTypes; }
            set { this._complianceTypes = value; }
        }

        // Check to see if ComplianceTypes property is set
        internal bool IsSetComplianceTypes()
        {
            return this._complianceTypes != null && this._complianceTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// The <code>nextToken</code> string returned on a previous page that you use to get
        /// the next page of results in a paginated response.
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

        /// <summary>
        /// Gets and sets the property ResourceEvaluationId. 
        /// <para>
        /// The unique ID of Amazon Web Services resource execution for which you want to retrieve
        /// evaluation results. 
        /// </para>
        ///  <note> 
        /// <para>
        /// You need to only provide either a <code>ResourceEvaluationID</code> or a <code>ResourceID
        /// </code>and <code>ResourceType</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=128)]
        public string ResourceEvaluationId
        {
            get { return this._resourceEvaluationId; }
            set { this._resourceEvaluationId = value; }
        }

        // Check to see if ResourceEvaluationId property is set
        internal bool IsSetResourceEvaluationId()
        {
            return this._resourceEvaluationId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the Amazon Web Services resource for which you want compliance information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=768)]
        public string ResourceId
        {
            get { return this._resourceId; }
            set { this._resourceId = value; }
        }

        // Check to see if ResourceId property is set
        internal bool IsSetResourceId()
        {
            return this._resourceId != null;
        }

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of the Amazon Web Services resource for which you want compliance information.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ResourceType
        {
            get { return this._resourceType; }
            set { this._resourceType = value; }
        }

        // Check to see if ResourceType property is set
        internal bool IsSetResourceType()
        {
            return this._resourceType != null;
        }

    }
}