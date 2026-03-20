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
    /// Container for the parameters to the DeletePolicyTemplate operation.
    /// Deletes the specified policy template from the policy store.
    /// 
    ///  <important> 
    /// <para>
    /// This operation also deletes any policies that were created from the specified policy
    /// template. Those policies are immediately removed from all future API responses, and
    /// are asynchronously deleted from the policy store.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class DeletePolicyTemplateRequest : AmazonVerifiedPermissionsRequest
    {
        private string _policyStoreId;
        private string _policyTemplateId;

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the ID of the policy store that contains the policy template that you want
        /// to delete.
        /// </para>
        ///  
        /// <para>
        /// To specify a policy store, use its ID or alias name. When using an alias name, prefix
        /// it with <c>policy-store-alias/</c>. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ID: <c>PSEXAMPLEabcdefg111111</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Alias name: <c>policy-store-alias/example-policy-store</c> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// To view aliases, use <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_ListPolicyStoreAliases.html">ListPolicyStoreAliases</a>.
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
        /// Specifies the ID of the policy template that you want to delete.
        /// </para>
        ///  
        /// <para>
        /// You can use the policy template name in place of the policy template ID. When using
        /// a name, prefix it with <c>name/</c>. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ID: <c>PTEXAMPLEabcdefg111111</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Name: <c>name/example-policy-template</c> 
        /// </para>
        ///  </li> </ul>
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

    }
}