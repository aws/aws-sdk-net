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
 * Do not modify this file. This file is generated from the connectcases-2022-10-03.normal.json service model.
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
namespace Amazon.ConnectCases.Model
{
    /// <summary>
    /// This is the response object from the BatchGetCaseRule operation.
    /// </summary>
    public partial class BatchGetCaseRuleResponse : AmazonWebServiceResponse
    {
        private List<GetCaseRuleResponse> _caseRules = AWSConfigs.InitializeCollections ? new List<GetCaseRuleResponse>() : null;
        private List<CaseRuleError> _errors = AWSConfigs.InitializeCollections ? new List<CaseRuleError>() : null;
        private List<string> _unprocessedCaseRules = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property CaseRules. 
        /// <para>
        /// A list of detailed case rule information.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<GetCaseRuleResponse> CaseRules
        {
            get { return this._caseRules; }
            set { this._caseRules = value; }
        }

        // Check to see if CaseRules property is set
        internal bool IsSetCaseRules()
        {
            return this._caseRules != null && (this._caseRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of case rule errors.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public List<CaseRuleError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && (this._errors.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnprocessedCaseRules. 
        /// <para>
        /// A list of unprocessed case rule identifiers.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<string> UnprocessedCaseRules
        {
            get { return this._unprocessedCaseRules; }
            set { this._unprocessedCaseRules = value; }
        }

        // Check to see if UnprocessedCaseRules property is set
        internal bool IsSetUnprocessedCaseRules()
        {
            return this._unprocessedCaseRules != null && (this._unprocessedCaseRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}