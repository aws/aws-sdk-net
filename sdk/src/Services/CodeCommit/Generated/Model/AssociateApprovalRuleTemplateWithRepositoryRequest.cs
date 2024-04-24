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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.CodeCommit.Model
{
    /// <summary>
    /// Container for the parameters to the AssociateApprovalRuleTemplateWithRepository operation.
    /// Creates an association between an approval rule template and a specified repository.
    /// Then, the next time a pull request is created in the repository where the destination
    /// reference (if specified) matches the destination reference (branch) for the pull request,
    /// an approval rule that matches the template conditions is automatically created for
    /// that pull request. If no destination references are specified in the template, an
    /// approval rule that matches the template contents is created for all pull requests
    /// in that repository.
    /// </summary>
    public partial class AssociateApprovalRuleTemplateWithRepositoryRequest : AmazonCodeCommitRequest
    {
        private string _approvalRuleTemplateName;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateName. 
        /// <para>
        /// The name for the approval rule template. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string ApprovalRuleTemplateName
        {
            get { return this._approvalRuleTemplateName; }
            set { this._approvalRuleTemplateName = value; }
        }

        // Check to see if ApprovalRuleTemplateName property is set
        internal bool IsSetApprovalRuleTemplateName()
        {
            return this._approvalRuleTemplateName != null;
        }

        /// <summary>
        /// Gets and sets the property RepositoryName. 
        /// <para>
        /// The name of the repository that you want to associate with the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=100)]
        public string RepositoryName
        {
            get { return this._repositoryName; }
            set { this._repositoryName = value; }
        }

        // Check to see if RepositoryName property is set
        internal bool IsSetRepositoryName()
        {
            return this._repositoryName != null;
        }

    }
}