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
 * Do not modify this file. This file is generated from the sso-admin-2020-07-20.normal.json service model.
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
namespace Amazon.SSOAdmin.Model
{
    /// <summary>
    /// This is the response object from the GetInlinePolicyForPermissionSet operation.
    /// </summary>
    public partial class GetInlinePolicyForPermissionSetResponse : AmazonWebServiceResponse
    {
        private string _inlinePolicy;

        /// <summary>
        /// Gets and sets the property InlinePolicy. 
        /// <para>
        /// The inline policy that is attached to the permission set.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <c>Length Constraints</c>, if a valid ARN is provided for a permission set, it
        /// is possible for an empty inline policy to be returned.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min=1, Max=32768)]
        public string InlinePolicy
        {
            get { return this._inlinePolicy; }
            set { this._inlinePolicy = value; }
        }

        // Check to see if InlinePolicy property is set
        internal bool IsSetInlinePolicy()
        {
            return this._inlinePolicy != null;
        }

    }
}