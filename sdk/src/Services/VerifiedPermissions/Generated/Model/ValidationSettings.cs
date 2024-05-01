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
    /// A structure that contains Cedar policy validation settings for the policy store. The
    /// validation mode determines which validation failures that Cedar considers serious
    /// enough to block acceptance of a new or edited static policy or policy template. 
    /// 
    ///  
    /// <para>
    /// This data type is used as a request parameter in the <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_CreatePolicyStore.html">CreatePolicyStore</a>
    /// and <a href="https://docs.aws.amazon.com/verifiedpermissions/latest/apireference/API_UpdatePolicyStore.html">UpdatePolicyStore</a>
    /// operations.
    /// </para>
    /// </summary>
    public partial class ValidationSettings
    {
        private ValidationMode _mode;

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The validation mode currently configured for this policy store. The valid values are:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>OFF</b> – Neither Verified Permissions nor Cedar perform any validation on policies.
        /// No validation errors are reported by either service.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>STRICT</b> – Requires a schema to be present in the policy store. Cedar performs
        /// validation on all submitted new or updated static policies and policy templates. Any
        /// that fail validation are rejected and Cedar doesn't store them in the policy store.
        /// </para>
        ///  </li> </ul> <important> 
        /// <para>
        /// If <c>Mode=STRICT</c> and the policy store doesn't contain a schema, Verified Permissions
        /// rejects all static policies and policy templates because there is no schema to validate
        /// against. 
        /// </para>
        ///  
        /// <para>
        /// To submit a static policy or policy template without a schema, you must turn off validation.
        /// </para>
        ///  </important>
        /// </summary>
        [AWSProperty(Required=true)]
        public ValidationMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

    }
}