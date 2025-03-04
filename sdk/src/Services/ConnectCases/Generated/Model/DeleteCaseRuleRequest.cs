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
    /// Container for the parameters to the DeleteCaseRule operation.
    /// Deletes a case rule. In the Amazon Connect admin website, case rules are known as
    /// <i>case field conditions</i>. For more information about case field conditions, see
    /// <a href="https://docs.aws.amazon.com/connect/latest/adminguide/case-field-conditions.html">Add
    /// case field conditions to a case template</a>.
    /// </summary>
    public partial class DeleteCaseRuleRequest : AmazonConnectCasesRequest
    {
        private string _caseRuleId;
        private string _domainId;

        /// <summary>
        /// Gets and sets the property CaseRuleId. 
        /// <para>
        /// Unique identifier of a case rule.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string CaseRuleId
        {
            get { return this._caseRuleId; }
            set { this._caseRuleId = value; }
        }

        // Check to see if CaseRuleId property is set
        internal bool IsSetCaseRuleId()
        {
            return this._caseRuleId != null;
        }

        /// <summary>
        /// Gets and sets the property DomainId. 
        /// <para>
        /// Unique identifier of a Cases domain.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=500)]
        public string DomainId
        {
            get { return this._domainId; }
            set { this._domainId = value; }
        }

        // Check to see if DomainId property is set
        internal bool IsSetDomainId()
        {
            return this._domainId != null;
        }

    }
}