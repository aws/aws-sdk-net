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
    /// This is the response object from the DeleteApprovalRuleTemplate operation.
    /// </summary>
    public partial class DeleteApprovalRuleTemplateResponse : AmazonWebServiceResponse
    {
        private string _approvalRuleTemplateId;

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateId. 
        /// <para>
        /// The system-generated ID of the deleted approval rule template. If the template has
        /// been previously deleted, the only response is a 200 OK.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ApprovalRuleTemplateId
        {
            get { return this._approvalRuleTemplateId; }
            set { this._approvalRuleTemplateId = value; }
        }

        // Check to see if ApprovalRuleTemplateId property is set
        internal bool IsSetApprovalRuleTemplateId()
        {
            return this._approvalRuleTemplateId != null;
        }

    }
}