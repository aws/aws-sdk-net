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
    /// Container for the parameters to the DisassociateApprovalRuleTemplateFromRepository operation.
    /// Removes the association between a template and a repository so that approval rules
    /// based on the template are not automatically created when pull requests are created
    /// in the specified repository. This does not delete any approval rules previously created
    /// for pull requests through the template association.
    /// </summary>
    public partial class DisassociateApprovalRuleTemplateFromRepositoryRequest : AmazonCodeCommitRequest
    {
        private string _approvalRuleTemplateName;
        private string _repositoryName;

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateName. 
        /// <para>
        /// The name of the approval rule template to disassociate from a specified repository.
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
        /// The name of the repository you want to disassociate from the template.
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