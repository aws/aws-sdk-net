/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the GetGroupPolicy operation.
    /// Retrieves the specified inline policy document that is embedded in the specified IAM
    /// group.
    /// 
    ///  <note> 
    /// <para>
    /// Policies returned by this API are URL-encoded compliant with <a href="https://tools.ietf.org/html/rfc3986">RFC
    /// 3986</a>. You can use a URL decoding method to convert the policy back to plain JSON
    /// text. For example, if you use Java, you can use the <code>decode</code> method of
    /// the <code>java.net.URLDecoder</code> utility class in the Java SDK. Other languages
    /// and SDKs provide similar functionality.
    /// </para>
    ///  </note> 
    /// <para>
    /// An IAM group can also have managed policies attached to it. To retrieve a managed
    /// policy document that is attached to a group, use <a>GetPolicy</a> to determine the
    /// policy's default version, then use <a>GetPolicyVersion</a> to retrieve the policy
    /// document.
    /// </para>
    ///  
    /// <para>
    /// For more information about policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetGroupPolicyRequest : AmazonIdentityManagementServiceRequest
    {
        private string _groupName;
        private string _policyName;

        /// <summary>
        /// Empty constructor used to set  properties independently even when a simple constructor is available
        /// </summary>
        public GetGroupPolicyRequest() { }

        /// <summary>
        /// Instantiates GetGroupPolicyRequest with the parameterized properties
        /// </summary>
        /// <param name="groupName">The name of the group the policy is associated with. This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        /// <param name="policyName">The name of the policy document to get. This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>) a string of characters consisting of upper and lowercase alphanumeric characters with no spaces. You can also include any of the following characters: _+=,.@-</param>
        public GetGroupPolicyRequest(string groupName, string policyName)
        {
            _groupName = groupName;
            _policyName = policyName;
        }

        /// <summary>
        /// Gets and sets the property GroupName. 
        /// <para>
        /// The name of the group the policy is associated with.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        public string GroupName
        {
            get { return this._groupName; }
            set { this._groupName = value; }
        }

        // Check to see if GroupName property is set
        internal bool IsSetGroupName()
        {
            return this._groupName != null;
        }

        /// <summary>
        /// Gets and sets the property PolicyName. 
        /// <para>
        /// The name of the policy document to get.
        /// </para>
        ///  
        /// <para>
        /// This parameter allows (per its <a href="http://wikipedia.org/wiki/regex">regex pattern</a>)
        /// a string of characters consisting of upper and lowercase alphanumeric characters with
        /// no spaces. You can also include any of the following characters: _+=,.@-
        /// </para>
        /// </summary>
        public string PolicyName
        {
            get { return this._policyName; }
            set { this._policyName = value; }
        }

        // Check to see if PolicyName property is set
        internal bool IsSetPolicyName()
        {
            return this._policyName != null;
        }

    }
}