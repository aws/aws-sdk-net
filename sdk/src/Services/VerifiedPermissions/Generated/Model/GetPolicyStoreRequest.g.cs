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
    /// Container for the parameters to the GetPolicyStore operation. Retrieves details about
    /// a policy store.
    /// </summary>
    public partial class GetPolicyStoreRequest : AmazonVerifiedPermissionsRequest
    {
        /// <summary>
        /// Gets and sets the property PolicyStoreId. 
        /// <para>
        /// Specifies the policy store that you want information about.
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
        [AWSProperty(Required = true, Min = 1, Max = 200)]
        public string PolicyStoreId { get; set; }

        /// <summary>
        /// Checks to see if the PolicyStoreId property is set.
        /// </summary>
        internal bool IsSetPolicyStoreId() => this.PolicyStoreId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Specifies whether to return the tags that are attached to the policy store. If this
        /// parameter is included in the API call, the tags are returned, otherwise they are not
        /// returned.
        /// </para>
        ///  <note> 
        /// <para>
        /// If this parameter is included in the API call but there are no tags attached to the
        /// policy store, the <c>tags</c> response parameter is omitted from the response.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? Tags { get; set; }

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags.HasValue;
    }
}
