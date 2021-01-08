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
    /// This is the response object from the BatchDisassociateApprovalRuleTemplateFromRepositories operation.
    /// </summary>
    public partial class BatchDisassociateApprovalRuleTemplateFromRepositoriesResponse : AmazonWebServiceResponse
    {
        private List<string> _disassociatedRepositoryNames = new List<string>();
        private List<BatchDisassociateApprovalRuleTemplateFromRepositoriesError> _errors = new List<BatchDisassociateApprovalRuleTemplateFromRepositoriesError>();

        /// <summary>
        /// Gets and sets the property DisassociatedRepositoryNames. 
        /// <para>
        /// A list of repository names that have had their association with the template removed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> DisassociatedRepositoryNames
        {
            get { return this._disassociatedRepositoryNames; }
            set { this._disassociatedRepositoryNames = value; }
        }

        // Check to see if DisassociatedRepositoryNames property is set
        internal bool IsSetDisassociatedRepositoryNames()
        {
            return this._disassociatedRepositoryNames != null && this._disassociatedRepositoryNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of any errors that might have occurred while attempting to remove the association
        /// between the template and the repositories.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchDisassociateApprovalRuleTemplateFromRepositoriesError> Errors
        {
            get { return this._errors; }
            set { this._errors = value; }
        }

        // Check to see if Errors property is set
        internal bool IsSetErrors()
        {
            return this._errors != null && this._errors.Count > 0; 
        }

    }
}