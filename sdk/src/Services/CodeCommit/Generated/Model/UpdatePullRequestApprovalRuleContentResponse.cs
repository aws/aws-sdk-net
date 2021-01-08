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
    /// This is the response object from the UpdatePullRequestApprovalRuleContent operation.
    /// </summary>
    public partial class UpdatePullRequestApprovalRuleContentResponse : AmazonWebServiceResponse
    {
        private ApprovalRule _approvalRule;

        /// <summary>
        /// Gets and sets the property ApprovalRule. 
        /// <para>
        /// Information about the updated approval rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ApprovalRule ApprovalRule
        {
            get { return this._approvalRule; }
            set { this._approvalRule = value; }
        }

        // Check to see if ApprovalRule property is set
        internal bool IsSetApprovalRule()
        {
            return this._approvalRule != null;
        }

    }
}