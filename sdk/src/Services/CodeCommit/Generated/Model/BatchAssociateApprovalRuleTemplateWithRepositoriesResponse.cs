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
    /// This is the response object from the BatchAssociateApprovalRuleTemplateWithRepositories operation.
    /// </summary>
    public partial class BatchAssociateApprovalRuleTemplateWithRepositoriesResponse : AmazonWebServiceResponse
    {
        private List<string> _associatedRepositoryNames = new List<string>();
        private List<BatchAssociateApprovalRuleTemplateWithRepositoriesError> _errors = new List<BatchAssociateApprovalRuleTemplateWithRepositoriesError>();

        /// <summary>
        /// Gets and sets the property AssociatedRepositoryNames. 
        /// <para>
        /// A list of names of the repositories that have been associated with the template.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> AssociatedRepositoryNames
        {
            get { return this._associatedRepositoryNames; }
            set { this._associatedRepositoryNames = value; }
        }

        // Check to see if AssociatedRepositoryNames property is set
        internal bool IsSetAssociatedRepositoryNames()
        {
            return this._associatedRepositoryNames != null && this._associatedRepositoryNames.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Errors. 
        /// <para>
        /// A list of any errors that might have occurred while attempting to create the association
        /// between the template and the repositories.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public List<BatchAssociateApprovalRuleTemplateWithRepositoriesError> Errors
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