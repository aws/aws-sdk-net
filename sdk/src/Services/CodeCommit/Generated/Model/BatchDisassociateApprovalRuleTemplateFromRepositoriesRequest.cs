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
    /// Container for the parameters to the BatchDisassociateApprovalRuleTemplateFromRepositories operation.
    /// Removes the association between an approval rule template and one or more specified
    /// repositories.
    /// </summary>
    public partial class BatchDisassociateApprovalRuleTemplateFromRepositoriesRequest : AmazonCodeCommitRequest
    {
        private string _approvalRuleTemplateName;
        private List<string> _repositoryNames = new List<string>();

        /// <summary>
        /// Gets and sets the property ApprovalRuleTemplateName. 
        /// <para>
        /// The name of the template that you want to disassociate from one or more repositories.
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
        /// Gets and sets the property RepositoryNames. 
        /// <para>
        /// The repository names that you want to disassociate from the approval rule template.
        /// </para>
        ///  <note> 
        /// <para>
        /// The length constraint limit is for each string in the array. The array itself can
        /// be empty.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> RepositoryNames
        {
            get { return this._repositoryNames; }
            set { this._repositoryNames = value; }
        }

        // Check to see if RepositoryNames property is set
        internal bool IsSetRepositoryNames()
        {
            return this._repositoryNames != null && this._repositoryNames.Count > 0; 
        }

    }
}