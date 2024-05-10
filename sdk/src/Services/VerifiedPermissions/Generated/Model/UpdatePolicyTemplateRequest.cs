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
 * Do not modify this file. This file is generated from the verifiedpermissions-2021-12-01.normal.json service model.
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
namespace Amazon.VerifiedPermissions.Model
{
    /// <summary>
    /// Container for the parameters to the UpdatePolicyTemplate operation.
    /// Updates the specified policy template. You can update only the description and the
    /// some elements of the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyTemplate.html#amazonverifiedpermissions-UpdatePolicyTemplate-request-policyBody">policyBody</a>.
    /// 
    /// 
    ///  <important> 
    /// <para>
    /// Changes you make to the policy template content are immediately (within the constraints
    /// of eventual consistency) reflected in authorization decisions that involve all template-linked
    /// policies instantiated from this template.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// Verified Permissions is <i> <a href="https://wikipedia.org/wiki/Eventual_consistency">eventually
    /// consistent</a> </i>. It can take a few seconds for a new or changed element to propagate
    /// through the service and be visible in the results of other Verified Permissions operations.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class UpdatePolicyTemplateRequest : AmazonVerifiedPermissionsRequest
    {
        private string _description;
        private string _policyStoreId;
        private string _policyTemplateId;
        private string _statement;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// Specifies a new description to apply to the policy template.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=0, Max=150)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the ID of the policy store that contains the policy template that you want
        /// to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyStoreId
        {
            get { return this._policyStoreId; }
            set { this._policyStoreId = value; }
        }

        // Check to see if PolicyStoreId property is set
        internal bool IsSetPolicyStoreId()
        {
            return this._policyStoreId != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyTemplateId. 
        /// <para>
        /// Specifies the ID of the policy template that you want to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string PolicyTemplateId
        {
            get { return this._policyTemplateId; }
            set { this._policyTemplateId = value; }
        }

        // Check to see if PolicyTemplateId property is set
        internal bool IsSetPolicyTemplateId()
        {
            return this._policyTemplateId != null;
        }

        /// <summary>
        /// Gets and sets the property Statement. 
        /// <para>
        /// Specifies new statement content written in Cedar policy language to replace the current
        /// body of the policy template.
        /// </para>
        ///  
        /// <para>
        /// You can change only the following elements of the policy body:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The <c>action</c> referenced by the policy template.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Any conditional clauses, such as <c>when</c> or <c>unless</c> clauses.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You <b>can't</b> change the following elements:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The effect (<c>permit</c> or <c>forbid</c>) of the policy template.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>principal</c> referenced by the policy template.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The <c>resource</c> referenced by the policy template.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required=true, Sensitive=true, Min=1, Max=10000)]
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }

        // Check to see if Statement property is set
        internal bool IsSetStatement()
        {
            return this._statement != null;
        }

    }
}