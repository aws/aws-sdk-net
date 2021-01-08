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
 * Do not modify this file. This file is generated from the codecommit-2015-04-13.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// This is the response object from the ListApprovalRuleTemplates operation.
    /// </summary>
    public partial class ListApprovalRuleTemplatesResponse : AmazonWebServiceResponse
    {
        private List<string> _approvalRuleTemplateNames = new List<string>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateNames. 
        /// <para>
        /// The names of all the approval rule templates found in the AWS Region for your AWS
        /// account.
        /// </para>
        /// </summary>
        public List<string> ApprovalRuleTemplateNames
        {
            get { return this._approvalRuleTemplateNames; }
            set { this._approvalRuleTemplateNames = value; }
        }

        // Check to see if ApprovalRuleTemplateNames property is set
        internal bool IsSetApprovalRuleTemplateNames()
        {
            return this._approvalRuleTemplateNames != null && this._approvalRuleTemplateNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// An enumeration token that allows the operation to batch the next results of the operation.
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