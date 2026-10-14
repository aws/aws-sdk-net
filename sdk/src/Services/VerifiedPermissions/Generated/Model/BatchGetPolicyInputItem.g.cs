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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Information about a policy that you include in a <c>BatchGetPolicy</c> API request.
    /// </summary>
    public partial class BatchGetPolicyInputItem
    {
        /// <summary>
        /// Gets and sets the property PolicyId. 
        /// <para>
        /// The identifier of the policy you want information about.
        /// </para>
        ///  
        /// <para>
        /// You can use the policy name in place of the policy ID. When using a name, prefix it
        /// with <c>name/</c>. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// ID: <c>SPEXAMPLEabcdefg111111</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Name: <c>name/example-policy</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyId property is set.
        /// </summary>
        internal bool IsSetPolicyId() => this.PolicyId != null;

        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// The identifier of the policy store where the policy you want information about is
        /// stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyStoreId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStoreId property is set.
        /// </summary>
        internal bool IsSetPolicyStoreId() => this.PolicyStoreId != null;
    }
}
