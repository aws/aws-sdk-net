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
    /// Container for the parameters to the GetPolicyVersion operation.
    /// Retrieves information about the specified version of the specified managed policy,
    /// including the policy document.
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
    /// To list the available versions for a policy, use <a>ListPolicyVersions</a>.
    /// </para>
    ///  
    /// <para>
    /// This API retrieves information about managed policies. To retrieve information about
    /// an inline policy that is embedded in a user, group, or role, use the <a>GetUserPolicy</a>,
    /// <a>GetGroupPolicy</a>, or <a>GetRolePolicy</a> API.
    /// </para>
    ///  
    /// <para>
    /// For more information about the types of policies, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// For more information about managed policy versions, see <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-versions.html">Versioning
    /// for Managed Policies</a> in the <i>IAM User Guide</i>.
    /// </para>
    /// </summary>
    public partial class GetPolicyVersionRequest : AmazonIdentityManagementServiceRequest
    {
        private string _policyArn;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property PolicyArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the managed policy that you want information about.
        /// </para>
        ///  
        /// <para>
        /// For more information about ARNs, see <a href="http://docs.aws.amazon.com/general/latest/gr/aws-arns-and-namespaces.html">Amazon
        /// Resource Names (ARNs) and AWS Service Namespaces</a> in the <i>AWS General Reference</i>.
        /// </para>
        /// </summary>
        public string PolicyArn
        {
            get { return this._policyArn; }
            set { this._policyArn = value; }
        }

        // Check to see if PolicyArn property is set
        internal bool IsSetPolicyArn()
        {
            return this._policyArn != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Identifies the policy version to retrieve.
        /// </para>
        ///  
        /// <para>
        /// The <a href="http://wikipedia.org/wiki/regex">regex pattern</a> for this parameter
        /// is a string of characters that consists of the lowercase letter 'v' followed by one
        /// or two digits, and optionally followed by a period '.' and a string of letters and
        /// digits.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}